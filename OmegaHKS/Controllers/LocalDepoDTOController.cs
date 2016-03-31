using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using OmegaHKS.BildirimServiceReference;
using OmegaHKS.GenelServiceReference;
using NLog;
using System.Reflection;
using OmegaHKS.Properties;

namespace OmegaHKS.Controllers
{
    internal class LocalDepoDTOController
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        public bool LocalDepoDTOEkleGuncelle(List<Models.LocalDepoDTO> model)
        {
            var result = false;
            if (model.Count > 0)
            {
                var con = Controllers.OracleDb.GetOrclConn();

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var dp in model)
                {
                    if (dp.DMBNO != null)
                    {
                        var cmdIslem = new OracleCommand("STKTH011_Pkg.SET_HALSUBEID", con) { CommandType = CommandType.StoredProcedure };
                        cmdIslem.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                        cmdIslem.Parameters.Add(new OracleParameter("WDEPNO", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = dp.DMBNO;
                        cmdIslem.Parameters.Add(new OracleParameter("WSBID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = dp.Id;
                        cmdIslem.Parameters.Add(new OracleParameter("WHKSISYERITURU", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 6;
                        cmdIslem.Parameters.Add(new OracleParameter("WHKSILID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = dp.IlId;
                        cmdIslem.Parameters.Add(new OracleParameter("WHKSILCEID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = dp.IlceId;
                        cmdIslem.Parameters.Add(new OracleParameter("WHKSBELDEID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = dp.BeldeId;
                        try
                        {
                            Settings.Default["GelenReferansID"] = dp.Id.ToString();
                            Settings.Default.Save();

                            cmdIslem.ExecuteReader();
                            result = true;
                        }
                        catch (OracleException e)
                        {
                            var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                            Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                            Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                            logger.Error(errorMessage);
                        }
                    }
                }
            }
            return result;
        }
        public bool LocalSubeDTOEkleGuncelle(List<Models.LocalSubeDTO> model)
        {
            var result = false;
            if (model.Count > 0)
            {
                var depoSil = LocalSubeDTOSil(model);
                //if (!depoSil)
                //{
                //    var errorMessage = "Depo Şube Eşleştirme İşlemleri Sırasında HKS Id silerken Hata Oluştu";
                //    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                //    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                //    logger.Error(errorMessage);
                //    return false;
                //}

                var con = Controllers.OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var dp in model)
                {
                    if (dp.DMBNO != null)
                    {
                        var cmdIslem = new OracleCommand("STKTH011_Pkg.SET_HALSUBEID", con) { CommandType = CommandType.StoredProcedure };
                        cmdIslem.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                        cmdIslem.Parameters.Add(new OracleParameter("WDEPNO", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = dp.DMBNO;
                        cmdIslem.Parameters.Add(new OracleParameter("WSBID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = dp.Id;
                        cmdIslem.Parameters.Add(new OracleParameter("WHKSISYERITURU", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = dp.IsyeriTuruId;
                        cmdIslem.Parameters.Add(new OracleParameter("WHKSILID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = dp.IlId;
                        cmdIslem.Parameters.Add(new OracleParameter("WHKSILCEID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = dp.IlceId;
                        cmdIslem.Parameters.Add(new OracleParameter("WHKSBELDEID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = dp.BeldeId;

                        try
                        {
                            Settings.Default["GelenReferansID"] = dp.Id.ToString();
                            Settings.Default.Save();

                            cmdIslem.ExecuteReader();
                            result = true;
                        }
                        catch (OracleException e)
                        {
                            var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                            Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                            Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                            logger.Error(errorMessage);
                        }
                    }
                }
                con.Clone();
            }
            return result;
        }

        public bool LocalSubeDTOSil(List<Models.LocalSubeDTO> model)
        {
            var result = false;
            if (model.Count > 0)
            {
                var con = Controllers.OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var dp in model)
                {
                    if (dp.DMBNOKONTROL > 0)
                    {
                        var cmdIslem = new OracleCommand("STKTH011_Pkg.DEL_HALSUBEID", con) { CommandType = CommandType.StoredProcedure };
                        cmdIslem.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                        cmdIslem.Parameters.Add(new OracleParameter("WDEPNO", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = dp.DMBNOKONTROL;
                        try
                        {
                            cmdIslem.ExecuteReader();
                            result = true;
                        }
                        catch (OracleException e)
                        {
                            var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2} {3}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message , dp.DMBNOKONTROL);
                            Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                            Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                            logger.Error(errorMessage);
                        }
                    }
                }
                con.Clone();
            }
            return result;
        }
        public IsletmeTuruDTO GetLocalIsletmeTuru(int? id)
        {
            IsletmeTuruDTO result = new IsletmeTuruDTO();

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT KOD2 AS ID, DEGER AS ISLETMETURUADI ");
            sqlString.AppendLine("  FROM GENTM03 ");
            sqlString.AppendLine(" WHERE ID = 240  ");
            sqlString.AppendLine("    AND KOD = 6 ");
            sqlString.AppendLine(string.Format("    AND KOD2 ={0}", id));

            var con = Controllers.OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<IsletmeTuruDTO>(sqlString.ToString()).SingleOrDefault();
                if (sonuc != null)
                {
                    result = sonuc;
                }
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }

            return result;
        }
        public Models.LocalDepo GetLocalDepo(int? depNo)
        {
            Models.LocalDepo result = new Models.LocalDepo();

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT GENTM05.DMBNO,  ");
            sqlString.AppendLine("       GENTM05.DMBNO AS DMBNOKONTROL, ");
            sqlString.AppendLine("       GENTM05.AD,  ");
            sqlString.AppendLine("       GENTD09.ADRES,  ");
            sqlString.AppendLine("       GENTD09.ILCE,  ");
            sqlString.AppendLine("       GENTD09.IL,  ");
            sqlString.AppendLine("       GENTD09.HKSID,  ");
            sqlString.AppendLine("       GENTD09.HKSISYERITURU,  ");
            sqlString.AppendLine("       GENTD09.HKSBELDEID,  ");
            sqlString.AppendLine("       GENTD09.HKSILCEID,  ");
            sqlString.AppendLine("       GENTD09.HKSILID,  ");
            sqlString.AppendLine("       GENTM13.PLAKANO, ");
            sqlString.AppendLine("       GENTM13.PLAKANO AS Plaka ");
            sqlString.AppendLine("  FROM GENTM05, GENTD09, GENTM13 ");
            sqlString.AppendLine(" WHERE     GENTM05.DMBNO = GENTD09.DMBNO(+) ");
            sqlString.AppendLine("       AND GENTM05.DMBNO = GENTM13.DEPNO(+) ");
            sqlString.AppendLine(string.Format("       AND GENTM05.DMBNO = {0}", depNo));

            var con = Controllers.OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<Models.LocalDepo>(sqlString.ToString()).SingleOrDefault();
                if (sonuc != null)
                {
                    result = sonuc;
                }
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }

            return result;
        }
        public Models.LocalDepo GetHKSDepo(int? depNo)
        {
            Models.LocalDepo result = new Models.LocalDepo();
            if (depNo <= 0)
                return null;

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT GENTM05.DMBNO,   ");
            sqlString.AppendLine("       GENTM05.DMBNO AS DMBNOKONTROL, ");
            sqlString.AppendLine("       GENTM05.AD,   ");
            sqlString.AppendLine("       GENTD09.ADRES,   ");
            sqlString.AppendLine("       GENTD09.ILCE,   ");
            sqlString.AppendLine("       GENTD09.IL,   ");
            sqlString.AppendLine("       GENTD09.HKSID,   ");
            sqlString.AppendLine("       GENTD09.HKSISYERITURU,   ");
            sqlString.AppendLine("       GENTD09.HKSBELDEID,   ");
            sqlString.AppendLine("       GENTD09.HKSILCEID,   ");
            sqlString.AppendLine("       GENTD09.HKSILID   ");
            sqlString.AppendLine("  FROM GENTM05, GENTD09  ");
            sqlString.AppendLine("  WHERE GENTD09.DMBNO = GENTM05.DMBNO  ");
            sqlString.AppendLine(string.Format("       AND GENTD09.HKSID = {0}", depNo));

            var con = Controllers.OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<Models.LocalDepo>(sqlString.ToString()).SingleOrDefault();
                if (sonuc != null)
                    result = sonuc;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public IlDTO GetLocall(int? Id)
        {
            IlDTO result = new IlDTO();

            if (Id > 0)
            {
                var sqlString = new StringBuilder();
                sqlString.AppendLine("SELECT ILID AS Id, ILAD AS IlAdi ");
                sqlString.AppendLine("  FROM GENTM152 ");
                sqlString.AppendLine(string.Format(" WHERE ILID ={0}", Id));

                var con = Controllers.OracleDb.GetOrclConn();
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    var sonuc = con.Query<IlDTO>(sqlString.ToString()).SingleOrDefault();
                    if (sonuc != null)
                        result = sonuc;
                }
                catch (OracleException e)
                {
                    var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                    logger.Error(errorMessage);
                }
                finally
                {
                    con.Close();
                }
            }
            return result;
        }
        public IlceDTO GetLocalIce(int? ilId, int? ilceId)
        {
            IlceDTO result = new IlceDTO();
            if (ilId > 0 && ilceId > 0)
            {
                var sqlString = new StringBuilder();
                sqlString.AppendLine("SELECT ILCEID AS Id, ILCEAD AS IlceAdi ");
                sqlString.AppendLine("  FROM GENTM153 ");
                sqlString.AppendLine(string.Format(" WHERE ILID = {0} AND ILCEID = {1} ", ilId, ilceId));

                var con = Controllers.OracleDb.GetOrclConn();
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    var sonuc = con.Query<IlceDTO>(sqlString.ToString()).SingleOrDefault();
                    if (sonuc != null)
                        result = sonuc;
                }
                catch (OracleException e)
                {
                    var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                    logger.Error(errorMessage);
                }
                finally
                {
                    con.Close();
                }
            }

            return result;
        }
        public BeldeDTO GetLocalBelde(int? ilId, int? ilceId, int? beldeId)
        {
            BeldeDTO result = new BeldeDTO();

            if (ilId > 0 && ilceId > 0 && beldeId > 0)
            {
                var sqlString = new StringBuilder();
                sqlString.AppendLine("SELECT BELDEID AS Id, BELDEAD AS BeldeAdi ");
                sqlString.AppendLine("  FROM GENTM154 ");
                sqlString.AppendLine(string.Format(" WHERE ILID = {0} AND ILCEID = {1} AND BELDEID = {2} ", ilId, ilceId, beldeId));

                var con = Controllers.OracleDb.GetOrclConn();
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    var sonuc = con.Query<BeldeDTO>(sqlString.ToString()).SingleOrDefault();
                    if (sonuc != null)
                        result = sonuc;
                }
                catch (OracleException e)
                {
                    var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                    logger.Error(errorMessage);
                }
                finally
                {
                    con.Close();
                }
            }
            return result;
        }
        public UlkeDTO GetLocalUlke(int ulkeId)
        {
            UlkeDTO result = new UlkeDTO();
            if (ulkeId <= 0)
                return result;

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT ULKID AS Id, ULKEAD AS UlkeAdi");
            sqlString.AppendLine("   FROM GENTM151");
            sqlString.AppendLine(string.Format("  WHERE ULKID={0}", ulkeId));

            var con = Controllers.OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<UlkeDTO>(sqlString.ToString()).SingleOrDefault();
                if (sonuc != null)
                    result = sonuc;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public SifatDTO GetLocalSifat(int id)
        {
            SifatDTO result = new SifatDTO();
            if (id <= 0)
                return result;

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT KOD2 AS Id, DEGER AS SifatAdi FROM GENTM03 WHERE ID=240 AND KOD=2 AND KOD2=" + id);

            var con = Controllers.OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<SifatDTO>(sqlString.ToString()).SingleOrDefault();
                if (sonuc != null)
                    result = sonuc;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public BildirimTuruDTO GetLocalBildirimTuru(int id)
        {
            BildirimTuruDTO result = new BildirimTuruDTO();

            if (id <= 0)
                return result;

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT KOD2 AS Id, DEGER AS BildirimTuruAdi FROM GENTM03 WHERE ID=240 AND KOD=3 AND KOD2=" + id);
            var con = Controllers.OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<BildirimTuruDTO>(sqlString.ToString()).SingleOrDefault();
                if (sonuc != null)
                    result = sonuc;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public BelgeTipiDTO GetLocalBelgeTipi(int id)
        {
            BelgeTipiDTO result = new BelgeTipiDTO();
            if (id <= 0)
                return result;

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT KOD2 AS Id, DEGER AS BelgeTipiAdi FROM GENTM03 WHERE ID=240 AND KOD=4 AND KOD2=" + id);
            var con = Controllers.OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<BelgeTipiDTO>(sqlString.ToString()).SingleOrDefault();
                if (sonuc != null)
                    result = sonuc;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public IsletmeTuruDTO GetLocalIsletmeTuru(int id)
        {
            IsletmeTuruDTO result = new IsletmeTuruDTO();
            if (id <= 0)
                return result;

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT KOD2 AS Id, DEGER AS IsletmeTuruAdi FROM GENTM03 WHERE ID=240 AND KOD=6 AND KOD2=" + id);
            var con = Controllers.OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<IsletmeTuruDTO>(sqlString.ToString()).SingleOrDefault();
                if (sonuc != null)
                    result = sonuc;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public IList<Models.LocalDepo> GetLocalDepoList(Models.DepoSubeAramaTipi tip)
        {
            IList<Models.LocalDepo> result = new List<Models.LocalDepo>();

            var sqlString = new StringBuilder();
            var listeTipi = tip == Models.DepoSubeAramaTipi.Depo ? "D" : "M";
            sqlString.AppendLine("SELECT GENTM05.DMBNO, ");
            sqlString.AppendLine("       GENTM05.DMBNO AS DMBNOKONTROL, ");
            sqlString.AppendLine("       GENTM05.AD, ");
            sqlString.AppendLine("       GENTM13.PLAKANO, ");
            sqlString.AppendLine("       GENTD09.ADRES, ");
            sqlString.AppendLine("       GENTD09.ILCE, ");
            sqlString.AppendLine("       GENTD09.IL, ");
            sqlString.AppendLine("       GENTD09.HKSID, ");
            sqlString.AppendLine("       GENTD09.HKSISYERITURU, ");
            sqlString.AppendLine("       GENTD09.HKSBELDEID, ");
            sqlString.AppendLine("       GENTD09.HKSILCEID, ");
            sqlString.AppendLine("       GENTD09.HKSILID ");
            sqlString.AppendLine("  FROM GENTM05, GENTD09, GENTM13 ");
            sqlString.AppendLine(" WHERE     GENTM05.DMBNO = GENTD09.DMBNO(+) AND GENTM05.DMBNO = GENTM13.DEPNO(+)");
            if (Models.DepoSubeAramaTipi.Genel != tip)
            {
                sqlString.AppendLine(string.Format("       AND GENTM05.TIP = '{0}' ", listeTipi));
            }
            sqlString.AppendLine("       AND GENTM05.DMBNO > 0 ");

            var con = Controllers.OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<Models.LocalDepo>(sqlString.ToString());
                if (sonuc != null)
                    result = (IList<Models.LocalDepo>)sonuc;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public IList<Models.LocalSube> GetLocalSubeList(Models.DepoSubeAramaTipi tip)
        {
            IList<Models.LocalSube> result = new List<Models.LocalSube>();

            var sqlString = new StringBuilder();
            var listeTipi = "";
            if (tip == Models.DepoSubeAramaTipi.Depo)
            {
                listeTipi = "D";
            }
            else if(tip == Models.DepoSubeAramaTipi.Sube)
            {
                listeTipi = "M";
            }
            else
            {
                listeTipi = "G";
            }

            sqlString.AppendLine("SELECT GENTM05.DMBNO, ");
            sqlString.AppendLine("       GENTM05.DMBNO AS DMBNOKONTROL, ");
            sqlString.AppendLine("       GENTM05.AD, ");
            sqlString.AppendLine("       GENTD09.ADRES, ");
            sqlString.AppendLine("       GENTD09.ILCE, ");
            sqlString.AppendLine("       GENTD09.IL, ");
            sqlString.AppendLine("       GENTD09.HKSID, ");
            sqlString.AppendLine("       GENTD09.HKSISYERITURU, ");
            sqlString.AppendLine("       GENTD09.HKSBELDEID, ");
            sqlString.AppendLine("       GENTD09.HKSILCEID, ");
            sqlString.AppendLine("       GENTD09.HKSILID ");
            sqlString.AppendLine("  FROM GENTM05, GENTD09 ");
            sqlString.AppendLine(" WHERE     GENTM05.DMBNO = GENTD09.DMBNO(+) ");
            if(tip != Models.DepoSubeAramaTipi.Genel)
            {
                sqlString.AppendLine(string.Format("       AND GENTM05.TIP = '{0}' ", listeTipi));
            }
            sqlString.AppendLine("       AND GENTM05.DMBNO > 0 ");

            var con = Controllers.OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<Models.LocalSube>(sqlString.ToString());
                if (sonuc != null)
                    result = (IList<Models.LocalSube>)sonuc;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    }
}
