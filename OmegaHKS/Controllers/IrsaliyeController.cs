using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using Oracle.ManagedDataAccess.Client;
using NLog;
using System.Reflection;

namespace OmegaHKS.Controllers
{
    internal class IrsaliyeController
    {
        private Logger logger = LogManager.GetCurrentClassLogger();


        public IList<Models.Cari> GetFirmaListesi(string cariUnvan)
        {
            IList<Models.Cari> result = new List<Models.Cari>();

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT CARTM001.CARKOD,");
            sqlString.AppendLine("       CARTM001.UNVAN,");
            sqlString.AppendLine("       CARTM001.VERGIDAIRE,");
            sqlString.AppendLine("       CARTM001.VERGINO");
            sqlString.AppendLine("  FROM CARTM001");
            if(!string.IsNullOrEmpty(cariUnvan))
            {
                sqlString.AppendLine(string.Format(" WHERE STKKOD LIKE {0}||'%'  ", cariUnvan));
            }

            var con = Controllers.OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                var sonuc = con.Query<Models.Cari>(sqlString.ToString());
                if (sonuc != null)
                    result = (IList<Models.Cari>)sonuc;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);

                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
            }

            con.Close();
            return result;
        }
        public IList<Models.AlisIrsaliye> GetAlisIrsaliyeListesi(DateTime tarihb, DateTime tarihs, int depno, string cariKod, bool kunyeDahil)
        {
            IList<Models.AlisIrsaliye> result = new List<Models.AlisIrsaliye>();

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT STKTM022.TARIH,");
            sqlString.AppendLine("       STKTM022.DEPNO,");
            sqlString.AppendLine("       GENTM05_PKG.GET_AD (DEPNO) DEPOAD,");
            sqlString.AppendLine("       STKTM022.TIP,");
            sqlString.AppendLine("       STKTM022.IRSNO,");
            sqlString.AppendLine("       STKTM022.BELGENO,");
            sqlString.AppendLine("       STKTM022.TUTAR,");
            sqlString.AppendLine("       STKTM022.KDVTUTAR,");
            sqlString.AppendLine("       STKTM022.CARKOD,");
            sqlString.AppendLine("       STKTM022.KUNYETARIH,");
            sqlString.AppendLine("       CASE WHEN STKTM022.KUNYETARIH IS NULL THEN 0 ELSE 1 END AS KONTROL,");
            sqlString.AppendLine("       GENTD09.HKSID,");
            sqlString.AppendLine("       GENTD09.HKSILID,");
            sqlString.AppendLine("       GENTD09.HKSILCEID,");
            sqlString.AppendLine("       GENTD09.HKSBELDEID,");
            sqlString.AppendLine("       CARTT001_PKG.GET_CARAD (STKTM022.CARKOD) CARIUNVAN,");
            sqlString.AppendLine("       CARTM001.VERGINO");
            sqlString.AppendLine("  FROM STKTM022, GENTD09, CARTM001");
            sqlString.AppendLine(" WHERE     STKTM022.DEPNO = GENTD09.DMBNO(+)");
            sqlString.AppendLine("       AND STKTM022.CARKOD = CARTM001.CARKOD(+)");
            sqlString.AppendLine("       AND STKTM022.TIP = 2 ");
            sqlString.AppendLine(string.Format("       AND STKTM022.TARIH BETWEEN TO_DATE('{0}', 'DD/MM/YYYY')", tarihb.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)));
            sqlString.AppendLine(string.Format("       AND TO_DATE('{0}', 'DD/MM/YYYY')", tarihs.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)));
            sqlString.AppendLine(string.Format("       AND STKTM022.DEPNO ={0} ", depno));
            sqlString.AppendLine(string.Format("       AND STKTM022.CARKOD = '{0}'", cariKod));
            if (kunyeDahil)
            {
                sqlString.AppendLine("       AND STKTM022.KUNYETARIH IS NULL");
            }

            var con = Controllers.OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                var sonuc = con.Query<Models.AlisIrsaliye>(sqlString.ToString());
                if (sonuc != null)
                    result = (IList<Models.AlisIrsaliye>)sonuc;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);

                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
            }

            con.Close();
            return result;
        }

        public IList<Models.Irsaliye> GetSevkIrsaliyeListesi(DateTime tarihb, DateTime tarihs, int sevDepoNo, int karsiDepoNo, bool kunyeDahil)
        {
            IList<Models.Irsaliye> result = new List<Models.Irsaliye>();

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT STKTM022.TARIH, ");
            sqlString.AppendLine("       STKTM022.DEPNO,");
            sqlString.AppendLine("       GENTM05_PKG.GET_AD (DEPNO) SEVKDEPOAD,");
            sqlString.AppendLine("       STKTM022.ALDEP,");
            sqlString.AppendLine("       GENTM05_PKG.GET_AD (ALDEP) KARSIDEPOAD,");
            sqlString.AppendLine("       STKTM022.TIP,");
            sqlString.AppendLine("       STKTM022.IRSNO,");
            sqlString.AppendLine("       STKTM022.BELGENO,");
            sqlString.AppendLine("       STKTM022.TUTAR,");
            sqlString.AppendLine("       STKTM022.KDVTUTAR,");
            sqlString.AppendLine("       STKTM022.CARKOD,");
            sqlString.AppendLine("       STKTM022.KUNYETARIH,");
            sqlString.AppendLine("       CASE WHEN STKTM022.KUNYETARIH IS NULL THEN 0 ELSE 1 END AS KONTROL,");
            sqlString.AppendLine("       STKTH011_PKG.GET_HALSUBEID (DEPNO) AS DEPOID,");
            sqlString.AppendLine("       STKTH011_PKG.GET_HALSUBEID (ALDEP) AS SUBEID,");
            sqlString.AppendLine("       GENTD09.HKSID,");
            sqlString.AppendLine("       GENTD09.HKSILID,");
            sqlString.AppendLine("       GENTD09.HKSILCEID,");
            sqlString.AppendLine("       GENTD09.HKSBELDEID");
            sqlString.AppendLine("  FROM STKTM022, GENTD09");
            sqlString.AppendLine(" WHERE     STKTM022.ALDEP = GENTD09.DMBNO");
            //sqlString.AppendLine("       AND GENTD09.HKSID > 0");
            sqlString.AppendLine(string.Format("       AND STKTM022.TARIH BETWEEN TO_DATE('{0}', 'DD/MM/YYYY')", tarihb.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)));
            sqlString.AppendLine(string.Format("       AND TO_DATE('{0}', 'DD/MM/YYYY')", tarihs.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)));
            sqlString.AppendLine(string.Format("       AND STKTM022.DEPNO ={0} ", sevDepoNo));
            if (karsiDepoNo > 0)
            {
                sqlString.AppendLine(string.Format("       AND ALDEP ={0} ", karsiDepoNo));
            }
            sqlString.AppendLine("       AND STKTM022.TIP = 8 ");
            if (kunyeDahil)
            {
                sqlString.AppendLine("       AND STKTM022.KUNYETARIH IS NULL");
            }


            var con = Controllers.OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                var sonuc = con.Query<Models.Irsaliye>(sqlString.ToString());
                if(sonuc!=null)
                    result = (IList<Models.Irsaliye>)sonuc;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);

                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
            }

            con.Close();
            return result;
        }

        public IList<Models.IrsaliyeDetay> GetIrsaliyeDetayListesiAsilIRsaliye(int irsNo)
        {
            IList<Models.IrsaliyeDetay> result = new List<Models.IrsaliyeDetay>();

            //var sqlString = new StringBuilder();
            //sqlString.AppendLine("SELECT A.IRSNO, ");
            //sqlString.AppendLine("       A.BELGENO, ");
            //sqlString.AppendLine("       A.TARIH, ");
            //sqlString.AppendLine("       A.DEPNO, ");
            //sqlString.AppendLine("       A.ALDEP, ");
            //sqlString.AppendLine("       B.SIPNO, ");
            //sqlString.AppendLine("       B.SIRANO, ");
            //sqlString.AppendLine("       B.STKKOD, ");
            //sqlString.AppendLine("       B.BARKOD, ");
            //sqlString.AppendLine("       C.STOKAD, ");
            //sqlString.AppendLine("       B.TBIRIMMIK, ");
            //sqlString.AppendLine("       C.CEVDEG1 AS CEVRIMDEGER, ");
            //sqlString.AppendLine("       B.BIRIMMIK, ");
            //sqlString.AppendLine("       B.BIRIMTIP, ");
            //sqlString.AppendLine("       B.BRTFIAT, ");
            //sqlString.AppendLine("       B.NETTUTAR, ");
            //sqlString.AppendLine("       B.TUTAR, ");
            //sqlString.AppendLine("       D.MALID, ");
            //sqlString.AppendLine("       D.MALAD, ");
            //sqlString.AppendLine("       D.MALCINSID, ");
            //sqlString.AppendLine("       D.MALCINSAD, ");
            //sqlString.AppendLine("       D.MALTUR, ");
            //sqlString.AppendLine("       D.URUNKOD, ");
            //sqlString.AppendLine("       DECODE(D.ITHAL,'H',0,'E',1) AS MALINNITELIGI");
            //sqlString.AppendLine("  FROM STKTM022 A, ");
            //sqlString.AppendLine("       STKTD023 B, ");
            //sqlString.AppendLine("       STKTM010 C, ");
            //sqlString.AppendLine("       STKTH011 D ");
            //sqlString.AppendLine(" WHERE     A.TARIH = B.TARIH ");
            //sqlString.AppendLine("       AND A.DEPNO = B.DEPNO ");
            //sqlString.AppendLine("       AND A.TIP = B.TIP ");
            //sqlString.AppendLine("       AND A.IRSNO = B.IRSNO ");
            //sqlString.AppendLine("       AND B.STKKOD = C.STKKOD ");
            //sqlString.AppendLine("       AND B.STKKOD = D.STKKOD(+) ");
            //sqlString.AppendLine(string.Format("       AND A.IRSNO = {0}", irsNo));


            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT A.IRSNO, ");
            sqlString.AppendLine("       A.BELGENO, ");
            sqlString.AppendLine("       A.TARIH, ");
            sqlString.AppendLine("       A.DEPNO, ");
            sqlString.AppendLine("       A.ALDEP, ");
            sqlString.AppendLine("       B.SIPNO, ");
            sqlString.AppendLine("       B.SIRANO, ");
            sqlString.AppendLine("       B.STKKOD, ");
            sqlString.AppendLine("       B.BARKOD, ");
            sqlString.AppendLine("       C.STOKAD, ");
            sqlString.AppendLine("       B.TBIRIMMIK, ");
            sqlString.AppendLine("       C.CEVDEG1 AS CEVRIMDEGER, ");
            sqlString.AppendLine("       B.BIRIMMIK, ");
            sqlString.AppendLine("       B.BIRIMTIP, ");
            sqlString.AppendLine("       B.BRTFIAT, ");
            sqlString.AppendLine("       B.NETTUTAR, ");
            sqlString.AppendLine("       B.TUTAR");
            sqlString.AppendLine("  FROM STKTM022 A, ");
            sqlString.AppendLine("       STKTD023 B, ");
            sqlString.AppendLine("       STKTM010 C");
            sqlString.AppendLine(" WHERE     A.TARIH = B.TARIH ");
            sqlString.AppendLine("       AND A.DEPNO = B.DEPNO ");
            sqlString.AppendLine("       AND A.TIP = B.TIP ");
            sqlString.AppendLine("       AND A.IRSNO = B.IRSNO ");
            sqlString.AppendLine("       AND B.STKKOD = C.STKKOD ");
            sqlString.AppendLine(string.Format("       AND A.IRSNO = {0}", irsNo));


            var con = Controllers.OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                var sonuc = con.Query<Models.IrsaliyeDetay>(sqlString.ToString());
                if (sonuc != null)
                    result = (IList<Models.IrsaliyeDetay>)sonuc;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                logger.Error(errorMessage);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
            }

            con.Close();
            return result;
        }

        public IList<Models.IrsaliyeDetay> GetIrsaliyeDetayListesi(int irsNo)
        {
            IList<Models.IrsaliyeDetay> result = new List<Models.IrsaliyeDetay>();

            //var sqlString = new StringBuilder();
            //sqlString.AppendLine("SELECT A.IRSNO, ");
            //sqlString.AppendLine("       A.BELGENO, ");
            //sqlString.AppendLine("       A.TARIH, ");
            //sqlString.AppendLine("       A.DEPNO, ");
            //sqlString.AppendLine("       A.ALDEP, ");
            //sqlString.AppendLine("       B.SIPNO, ");
            //sqlString.AppendLine("       B.SIRANO, ");
            //sqlString.AppendLine("       B.STKKOD, ");
            //sqlString.AppendLine("       B.BARKOD, ");
            //sqlString.AppendLine("       C.STOKAD, ");
            //sqlString.AppendLine("       B.TBIRIMMIK, ");
            //sqlString.AppendLine("       C.CEVDEG1 AS CEVRIMDEGER, ");
            //sqlString.AppendLine("       B.BIRIMMIK, ");
            //sqlString.AppendLine("       B.BIRIMTIP, ");
            //sqlString.AppendLine("       B.BRTFIAT, ");
            //sqlString.AppendLine("       B.NETTUTAR, ");
            //sqlString.AppendLine("       B.TUTAR, ");
            //sqlString.AppendLine("       D.MALID, ");
            //sqlString.AppendLine("       D.MALAD, ");
            //sqlString.AppendLine("       D.MALCINSID, ");
            //sqlString.AppendLine("       D.MALCINSAD, ");
            //sqlString.AppendLine("       D.MALTUR, ");
            //sqlString.AppendLine("       D.URUNKOD, ");
            //sqlString.AppendLine("       DECODE(D.ITHAL,'H',0,'E',1) AS MALINNITELIGI");
            //sqlString.AppendLine("  FROM STKTM022 A, ");
            //sqlString.AppendLine("       STKTD023 B, ");
            //sqlString.AppendLine("       STKTM010 C, ");
            //sqlString.AppendLine("       STKTH011 D ");
            //sqlString.AppendLine(" WHERE     A.TARIH = B.TARIH ");
            //sqlString.AppendLine("       AND A.DEPNO = B.DEPNO ");
            //sqlString.AppendLine("       AND A.TIP = B.TIP ");
            //sqlString.AppendLine("       AND A.IRSNO = B.IRSNO ");
            //sqlString.AppendLine("       AND B.STKKOD = C.STKKOD ");
            //sqlString.AppendLine("       AND B.STKKOD = D.STKKOD(+) ");
            //sqlString.AppendLine(string.Format("       AND A.IRSNO = {0}", irsNo));


            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT A.IRSNO,");
            sqlString.AppendLine("       A.BELGENO,");
            sqlString.AppendLine("       A.TARIH,");
            sqlString.AppendLine("       A.DEPNO,");
            sqlString.AppendLine("       A.ALDEP,");
            sqlString.AppendLine("       B.SIPNO,");
            sqlString.AppendLine("       B.SIRANO,");
            sqlString.AppendLine("       B.STKKOD,");
            sqlString.AppendLine("       B.BARKOD,");
            sqlString.AppendLine("       C.STOKAD,");
            sqlString.AppendLine("       B.TBIRIMMIK,");
            sqlString.AppendLine("       C.USTBIRIM1 AS CEVBIRIMTIP,");
            sqlString.AppendLine("       C.CEVDEG1 AS CEVRIMDEGER,");
            sqlString.AppendLine("       B.BIRIMMIK,");
            sqlString.AppendLine("       B.BIRIMTIP,");
            sqlString.AppendLine("       B.BRTFIAT,");
            sqlString.AppendLine("       B.NETTUTAR,");
            sqlString.AppendLine("       B.TUTAR,");
            sqlString.AppendLine("       D.MALID,");
            sqlString.AppendLine("       D.MALAD,");
            sqlString.AppendLine("       D.MALCINSID,");
            sqlString.AppendLine("       D.MALCINSAD,");
            sqlString.AppendLine("       D.MALTUR,");
            sqlString.AppendLine("       D.URUNKOD,");
            sqlString.AppendLine("       E.KUNYENO AS KUNYE,");
            sqlString.AppendLine("       E.REFKUNYE,");
            sqlString.AppendLine("       DECODE (D.ITHAL,  'H', 0,  'E', 1) AS MALINNITELIGI");
            sqlString.AppendLine("  FROM STKTM022 A,");
            sqlString.AppendLine("       STKTD023 B,");
            sqlString.AppendLine("       STKTM010 C,");
            sqlString.AppendLine("       STKTH011 D,");
            sqlString.AppendLine("       STKTH0232 E");
            sqlString.AppendLine(" WHERE     A.TARIH = B.TARIH");
            sqlString.AppendLine("       AND A.DEPNO = B.DEPNO");
            sqlString.AppendLine("       AND A.TIP = B.TIP");
            sqlString.AppendLine("       AND A.IRSNO = B.IRSNO");
            sqlString.AppendLine("       AND B.STKKOD = C.STKKOD");
            sqlString.AppendLine("       AND B.STKKOD = D.STKKOD(+)");
            sqlString.AppendLine(string.Format("       AND A.IRSNO = {0}", irsNo));
            sqlString.AppendLine("       AND B.TARIH = E.IRSTARIH(+)");
            sqlString.AppendLine("       AND B.ALDEP = E.DEPNO(+)");
            sqlString.AppendLine("       AND B.IRSNO = E.IRSNO(+)");
            sqlString.AppendLine("       AND B.STKKOD = E.STKKOD(+)");

            var con = Controllers.OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                var sonuc  = con.Query<Models.IrsaliyeDetay>(sqlString.ToString());
                if(sonuc!= null)
                    result = (IList<Models.IrsaliyeDetay>)sonuc;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                logger.Error(errorMessage);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
            }

            con.Close();
            return result;
        }

        public bool UpdateIrsaliyeTarih(int irsaliyeNo, DateTime tarih)
        {
            var result = false;

            var con = Controllers.OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            var cmd = new OracleCommand("STKTH011_Pkg.SET_IRSTARIH", con) { CommandType = CommandType.StoredProcedure };

            cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
            cmd.Parameters.Add(new OracleParameter("WIRSNO", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = irsaliyeNo;
            cmd.Parameters.Add(new OracleParameter("WTARIH", OracleDbType.Date, System.Data.ParameterDirection.Input)).Value = tarih;
            try
            {
                cmd.ExecuteReader();
                result = true;
            }

            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                logger.Error(errorMessage);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
            }
            con.Close();

            return result;
        }

        public IList<Models.IRSALIYEURUNDETAYI> GetUrunEslestirmeListesi(IList<Models.IrsaliyeDetay> stokListesi)
        {
            IList<Models.IRSALIYEURUNDETAYI> result = new List<Models.IRSALIYEURUNDETAYI>();

            var con = Controllers.OracleDb.GetOrclConn();

            var sqlString = new StringBuilder();
            foreach (var item in stokListesi)
            {
                sqlString.AppendLine("SELECT STKTH011.STKKOD,");
                sqlString.AppendLine("       STKTH011.MALID,");
                sqlString.AppendLine("       STKTH011.MALCINSID,");
                sqlString.AppendLine("       STKTH011.MALTUR,");
                sqlString.AppendLine("       STKTH011.URUNKOD");
                sqlString.AppendLine("  FROM STKTH011");
                sqlString.AppendLine(" WHERE STKTH011.STKKOD = " + item.STKKOD);

                var irsDtUrList = new Models.IRSALIYEURUNDETAYI() {
                    ALDEP = item.ALDEP,
                    BARKOD = item.BARKOD,
                    BELGENO = item.BELGENO,
                    BIRIMMIK = item.BIRIMMIK,
                    BIRIMTIP = item.BIRIMTIP,
                    BRTFIAT = item.BRTFIAT,
                    CEVRIMDEGER = item.CEVRIMDEGER,
                    DEPNO = item.DEPNO,
                    IRSNO = item.IRSNO,
                    KUNYE = item.KUNYE,
                    MALAD = item.MALAD,
                    MALCINSAD = item.MALCINSAD,
                    MALCINSID = item.MALCINSID,
                    MALID = item.MALID,
                    MALINNITELIGI = item.MALINNITELIGI,
                    MALTUR = item.MALTUR,
                    NETTUTAR = item.NETTUTAR,
                    REFKUNYE = item.REFKUNYE,
                    SifatId = item.SifatId,
                    SIPNO = item.SIPNO,
                    SIRANO = item.SIRANO,
                    STKKOD = item.STKKOD,
                    STOKAD = item.STOKAD,
                    TARIH = item.TARIH,
                    TBIRIMMIK = item.TBIRIMMIK,
                    TUTAR = item.TUTAR,
                    UniqueId = item.UniqueId,
                    URUNKOD = item.URUNKOD,
                    EslesmeDurumu = false
                };

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    var sonuc = con.Query<Models.STKTH011>(sqlString.ToString());
                    if (sonuc != null)
                    {
                        var liste = (IList<Models.STKTH011>)sonuc;

                        foreach (var i in liste)
                        {
                            irsDtUrList.URUNESLESTIRMETABLOSU.Add(new Models.STKTH011
                            {
                                STKKOD = i.STKKOD,
                                MALID = i.MALID,
                                MALCINSID = i.MALCINSID,
                                MALTUR = i.MALTUR,
                                ITHAL = i.ITHAL,
                                URUNKOD = i.URUNKOD
                            });
                        }
                        irsDtUrList.EslesmeDurumu = true;
                    }

                }
                catch (OracleException e)
                {
                    var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);

                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                    logger.Error(errorMessage);
                }
                sqlString.Clear();
                result.Add(irsDtUrList);
            }
            con.Close();
            return result;
        }
    }
}
