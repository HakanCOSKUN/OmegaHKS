using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using OmegaHKS.UrunServiceReference;
using Oracle.ManagedDataAccess.Client;
using NLog;
using System.Reflection;

namespace OmegaHKS.Controllers
{
    internal class UrunControllers
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        public IList<UrunDTO> GetUrunDTOList()
        {
            IList<UrunDTO> result = null;
            var sqlString = "SELECT MALID AS Id, MALAD AS UrunAdi FROM STKTH01";
            var con = Controllers.OracleDb.GetOrclConn();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                var urunList = con.Query<UrunDTO>(sqlString.ToString());
                result = (IList<UrunDTO>)urunList;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);

                logger.Error(errorMessage);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public IList<Models.LocalUrunCinsiDTO> GetLocalUrunCinsiDTOList(int urunId)
        {
            IList<Models.LocalUrunCinsiDTO> result = null;

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT STKTH02.MALID AS UrunId, ");
            sqlString.AppendLine("       STKTH02.MALCINSID AS Id, ");
            sqlString.AppendLine("       STKTH02.MALCINSAD AS UrunCinsiAdi, ");
            sqlString.AppendLine("       STKTH02.URUNKOD AS UrunKodu, ");
            sqlString.AppendLine("       STKTH02.ITHAL AS Ithalmi, ");
            sqlString.AppendLine("       STKTH02.URETIMSEKLIID AS UretimSekilId, ");
            sqlString.AppendLine("       GENTM03.DEGER AS UretimSekiliAdi ");
            sqlString.AppendLine("  FROM STKTH02, GENTM03 ");
            sqlString.AppendLine(string.Format(" WHERE STKTH02.MALID ={0}", urunId));
            sqlString.AppendLine("       AND STKTH02.URETIMSEKLIID = GENTM03.KOD2");
            sqlString.AppendLine("       AND GENTM03.ID = 240 ");
            sqlString.AppendLine("       AND GENTM03.KOD = 8");

            var con = Controllers.OracleDb.GetOrclConn();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                var urunCinsiListesi = con.Query<Models.LocalUrunCinsiDTO>(sqlString.ToString());
                result = (IList<Models.LocalUrunCinsiDTO>)urunCinsiListesi;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);

                logger.Error(errorMessage);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public bool DelLocalUrunDTO_Eslesenler(List<Models.LocalUrunDTO> model)
        {
            var result = false;
            if (model.Count > 0)
            {
                var con = Controllers.OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var item in model)
                {
                    var cmd = new OracleCommand("STKTH011_Pkg.DEL_STOK", con) { CommandType = CommandType.StoredProcedure };


                    cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmd.Parameters.Add(new OracleParameter("WSTKKOD", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = item.STKKOD;
                    cmd.Parameters.Add(new OracleParameter("WMALID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = item.UrunId;
                    cmd.Parameters.Add(new OracleParameter("WMCINSID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = item.UrunCinsiId;
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
                }
                con.Close();
            }
            return result;
        }

        public IList<Models.LocalUrunDTO> GetOmegaStokArama(int? stokKodu, string stokAdi)
        {
            IList<Models.LocalUrunDTO> result = null;
            var StokKodu = stokKodu == -1 ? null : stokKodu;
            var StokAdi = stokAdi;

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT STKKOD, ");
            sqlString.AppendLine("       STOKAD, ");
            sqlString.AppendLine("       REYON, ");
            sqlString.AppendLine("       GENTM010203_PKG.ONDEGER1 (3, REYON) REYONAD, ");
            sqlString.AppendLine("       STKTM011_PKG.GET_MBARKOD (STKKOD) BARKOD ");
            sqlString.AppendLine("  FROM STKTM010 ");
            if (StokKodu != null && StokAdi != null)
            {
                sqlString.AppendLine(string.Format(" WHERE STKKOD LIKE {0}||'%'  ", StokKodu));
                sqlString.AppendLine(string.Format("     AND STOKAD LIKE {0}||'%' ", StokAdi.ToUpper()));
            }
            else
            {
                if (StokKodu != null && StokAdi == null)
                {
                    sqlString.AppendLine(string.Format(" WHERE STKKOD LIKE {0}||'%'  ", StokKodu));
                }
                else
                {
                    if (StokKodu == null && StokAdi != null)
                    {
                        sqlString.AppendLine(string.Format("     WHERE STOKAD LIKE '{0}%' ", StokAdi.ToUpper()));
                    }
                }
            }
            sqlString.AppendLine("     ORDER BY STOKAD");

            var con = Controllers.OracleDb.GetOrclConn();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                var StokList = con.Query<Models.LocalUrunDTO>(sqlString.ToString());
                result = (IList<Models.LocalUrunDTO>)StokList;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);

                logger.Error(errorMessage);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public IList<Models.LocalUrunDTO> GetUrunDTOEslesnler(int? urunId, int? urunCinsId)
        {
            IList<Models.LocalUrunDTO> result = null;

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT STKTH011.MALID AS URUNID, ");
            sqlString.AppendLine("       STKTH011.MALCINSID AS URUNCINSIID, ");
            sqlString.AppendLine("       STKTH011.URUNKOD AS URUNKODU, ");
            sqlString.AppendLine("       STKTH011.STKKOD AS STKKOD, ");
            sqlString.AppendLine("       STKTM010.STOKAD, ");
            sqlString.AppendLine("       STKTM010.REYON, ");
            sqlString.AppendLine("       GENTM010203_PKG.ONDEGER1 (3, REYON) REYONAD, ");
            sqlString.AppendLine("       STKTM011_PKG.GET_MBARKOD (STKTM010.STKKOD) BARKOD ");
            sqlString.AppendLine("  FROM STKTH011, STKTM010  ");
            sqlString.AppendLine(" WHERE     STKTH011.STKKOD = STKTM010.STKKOD ");
            sqlString.AppendLine(string.Format("       AND MALID = {0}", urunId));
            sqlString.AppendLine(string.Format("       AND MALCINSID  ={0}", urunCinsId));

            var con = Controllers.OracleDb.GetOrclConn();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                var StokList = con.Query<Models.LocalUrunDTO>(sqlString.ToString());
                result = (IList<Models.LocalUrunDTO>)StokList;
            }

            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);

                logger.Error(errorMessage);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public bool StokUrunCinsEsleme(List<Models.LocalUrunDTO> model)
        {
            var result = false;

            var con = Controllers.OracleDb.GetOrclConn();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            if (model.Count > 0)
            {
                foreach (var item in model)
                {
                    var cmdUrunler = new OracleCommand("STKTH011_Pkg.SET_STOK", con) { CommandType = CommandType.StoredProcedure };

                    cmdUrunler.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmdUrunler.Parameters.Add(new OracleParameter("WSTKKOD", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = item.STKKOD;
                    cmdUrunler.Parameters.Add(new OracleParameter("WMALID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = item.UrunId;
                    cmdUrunler.Parameters.Add(new OracleParameter("WMCINSID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = item.UrunCinsiId;
                    cmdUrunler.Parameters.Add(new OracleParameter("WMALTUR", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = item.UretimSekilId;
                    cmdUrunler.Parameters.Add(new OracleParameter("WURUNKOD", OracleDbType.Varchar2,20, System.Data.ParameterDirection.Input)).Value = item.UrunKodu;
                    cmdUrunler.Parameters.Add(new OracleParameter("WITHAL", OracleDbType.Varchar2,1, System.Data.ParameterDirection.Input)).Value = item.Ithalmi;

                    try
                    {
                        cmdUrunler.ExecuteReader();
                        result = true;
                    }

                    catch (OracleException e)
                    {
                        var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);

                        logger.Error(errorMessage);
                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    }
                }
                con.Close();
            }

            return result;
        }
    }
}
