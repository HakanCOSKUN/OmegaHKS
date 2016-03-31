using OmegaHKS.GenelServiceReference;
using OmegaHKS.UrunServiceReference;
using OmegaHKS.BildirimServiceReference;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using NLog;
using System.Reflection;
using System.Text;
using Dapper;

namespace OmegaHKS.Controllers
{
    internal class LocalHKSUpdateController
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        public bool LocalUlkeDTOEkleGuncelle(List<UlkeDTO> model)
        {
            var result = false;

            if (model.Count > 0)
            {
                var con = Controllers.OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var u in model)
                {
                    var cmdUlkeler = new OracleCommand("GENTM15_Pkg.SET_ULKE", con) { CommandType = CommandType.StoredProcedure };

                    cmdUlkeler.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmdUlkeler.Parameters.Add(new OracleParameter("WULKID", OracleDbType.Int16, ParameterDirection.Input)).Value = u.Id;
                    cmdUlkeler.Parameters.Add(new OracleParameter("WULKAD", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = u.UlkeAdi;
                    try
                    {
                        cmdUlkeler.ExecuteReader();
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
        public bool LocalIlDTOEkleGuncelle(List<IlDTO> model)
        {
            var result = false;

            if (model.Count > 0)
            {
                var con = Controllers.OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var s in model)
                {
                    var cmdSehirler = new OracleCommand("GENTM15_Pkg.SET_IL", con) { CommandType = CommandType.StoredProcedure };

                    cmdSehirler.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmdSehirler.Parameters.Add(new OracleParameter("WILID", OracleDbType.Int16, ParameterDirection.Input)).Value = s.Id;
                    cmdSehirler.Parameters.Add(new OracleParameter("WILAD", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = s.IlAdi;
                    try
                    {
                        cmdSehirler.ExecuteReader();
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
        public bool LocalIlceDTOEkleGuncelle(List<Models.LocalIlceDTO> model)
        {
            var result = false;

            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var i in model)
                {
                    var cmdIlce = new OracleCommand("GENTM15_Pkg.SET_ILCE", con) { CommandType = CommandType.StoredProcedure };

                    cmdIlce.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmdIlce.Parameters.Add(new OracleParameter("WILID", OracleDbType.Int16, ParameterDirection.Input)).Value = i.IlId;
                    cmdIlce.Parameters.Add(new OracleParameter("WILCEID", OracleDbType.Int16, ParameterDirection.Input)).Value = i.Id;
                    cmdIlce.Parameters.Add(new OracleParameter("WILCEAD", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = i.IlceAdi;

                    try
                    {
                        cmdIlce.ExecuteReader();
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
        public bool LocalBeldeDTOEkleGuncelle(List<Models.LocalBeldeDTO> model)
        {
            var result = false;

            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var b in model)
                {
                    var cmdBelde = new OracleCommand("GENTM15_Pkg.SET_BELDE", con) { CommandType = CommandType.StoredProcedure };

                    cmdBelde.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmdBelde.Parameters.Add(new OracleParameter("WILID", OracleDbType.Int16, ParameterDirection.Input)).Value = b.IlId;
                    cmdBelde.Parameters.Add(new OracleParameter("WILCEID", OracleDbType.Int16, ParameterDirection.Input)).Value = b.IlceId;
                    cmdBelde.Parameters.Add(new OracleParameter("WBELDEID", OracleDbType.Int16, ParameterDirection.Input)).Value = b.Id;
                    cmdBelde.Parameters.Add(new OracleParameter("WBELDEAD", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = b.BeldeAdi;
                    try
                    {
                        cmdBelde.ExecuteReader();
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
        public bool LocalUrunDTOEkleGuncelle(List<UrunDTO> model)
        {
            var result = false;

            var con = OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            foreach (var item in model)
            {
                var cmdUrunler = new OracleCommand("STKTH011_Pkg.SET_MAL", con) { CommandType = CommandType.StoredProcedure };

                cmdUrunler.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                cmdUrunler.Parameters.Add(new OracleParameter("WMALID", OracleDbType.Int16, ParameterDirection.Input)).Value = item.Id;
                cmdUrunler.Parameters.Add(new OracleParameter("WMALAD", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = item.UrunAdi;
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
            return result;
        }
        public bool LocalUrunCinsiDTOEkleGuncelle(List<UrunCinsiDTO> model)
        {
            var result = false;

            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var uCins in model)
                {
                    var cmdUrunCins = new OracleCommand("STKTH011_Pkg.SET_MALCINS", con) { CommandType = CommandType.StoredProcedure };

                    cmdUrunCins.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmdUrunCins.Parameters.Add(new OracleParameter("WMALID", OracleDbType.Int16, ParameterDirection.Input)).Value = uCins.UrunId;
                    cmdUrunCins.Parameters.Add(new OracleParameter("WMCINSID", OracleDbType.Int16, ParameterDirection.Input)).Value = uCins.Id;
                    cmdUrunCins.Parameters.Add(new OracleParameter("WMALCINSAD", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = uCins.UrunCinsiAdi;
                    cmdUrunCins.Parameters.Add(new OracleParameter("WURUNKOD", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = uCins.UrunKodu;
                    cmdUrunCins.Parameters.Add(new OracleParameter("WITHAL", OracleDbType.Varchar2, 20, ParameterDirection.Input)).Value = uCins.Ithalmi ? "E" : "H";
                    cmdUrunCins.Parameters.Add(new OracleParameter("WURETIMSEKLIID", OracleDbType.Int16, ParameterDirection.Input)).Value = uCins.UretimSekliId;

                    try
                    {
                        cmdUrunCins.ExecuteReader();
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
        public bool LocalUretimSekliDTOEkleGuncelle(List<UretimSekliDTO> model)
        {
            var result = false;

            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var u in model)
                {
                    var cmd = new OracleCommand("STKTH011_Pkg.SET_HALTANIM", con) { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmd.Parameters.Add(new OracleParameter("WID", OracleDbType.Int16, ParameterDirection.Input)).Value = 240;
                    cmd.Parameters.Add(new OracleParameter("WKOD", OracleDbType.Int16, ParameterDirection.Input)).Value = 8;
                    cmd.Parameters.Add(new OracleParameter("WKOD2", OracleDbType.Int16, ParameterDirection.Input)).Value = u.Id;
                    cmd.Parameters.Add(new OracleParameter("WDEGER", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = u.UretimSekliAdi;

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
        public bool LocalUrunBirimiDTOEkleGuncelle(List<UrunBirimiDTO> model)
        {
            var result = false;

            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var u in model)
                {
                    var cmd = new OracleCommand("STKTH011_Pkg.SET_HALTANIM", con) { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmd.Parameters.Add(new OracleParameter("WID", OracleDbType.Int16, ParameterDirection.Input)).Value = 240;
                    cmd.Parameters.Add(new OracleParameter("WKOD", OracleDbType.Int16, ParameterDirection.Input)).Value = 5;
                    cmd.Parameters.Add(new OracleParameter("WKOD2", OracleDbType.Int16, ParameterDirection.Input)).Value = u.Id;
                    cmd.Parameters.Add(new OracleParameter("WDEGER", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = u.UrunBirimAdi;

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
        public bool LocalMalinNiteligiDTOEkleGuncelle(List<MalinNiteligiDTO> model)
        {
            var result = false;

            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var u in model)
                {
                    var cmd = new OracleCommand("STKTH011_Pkg.SET_HALTANIM", con) { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmd.Parameters.Add(new OracleParameter("WID", OracleDbType.Int16, ParameterDirection.Input)).Value = 240;
                    cmd.Parameters.Add(new OracleParameter("WKOD", OracleDbType.Int16, ParameterDirection.Input)).Value = 7;
                    cmd.Parameters.Add(new OracleParameter("WKOD2", OracleDbType.Int16, ParameterDirection.Input)).Value = u.Id;
                    cmd.Parameters.Add(new OracleParameter("WDEGER", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = u.MalinNiteligiAdi;

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
        public bool LocalSifatDTOEkleGuncelle(List<SifatDTO> model)
        {
            var result = false;


            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var u in model)
                {
                    var cmd = new OracleCommand("STKTH011_Pkg.SET_HALTANIM", con) { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmd.Parameters.Add(new OracleParameter("WID", OracleDbType.Int16, ParameterDirection.Input)).Value = 240;
                    cmd.Parameters.Add(new OracleParameter("WKOD", OracleDbType.Int16, ParameterDirection.Input)).Value = 2;
                    cmd.Parameters.Add(new OracleParameter("WKOD2", OracleDbType.Int16, ParameterDirection.Input)).Value = u.Id;
                    cmd.Parameters.Add(new OracleParameter("WDEGER", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = u.SifatAdi;

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
        public bool LocalBildirimTuruDTOEkleGuncelle(List<BildirimTuruDTO> model)
        {
            var result = false;
            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var u in model)
                {
                    var cmd = new OracleCommand("STKTH011_Pkg.SET_HALTANIM", con) { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmd.Parameters.Add(new OracleParameter("WID", OracleDbType.Int16, ParameterDirection.Input)).Value = 240;
                    cmd.Parameters.Add(new OracleParameter("WKOD", OracleDbType.Int16, ParameterDirection.Input)).Value = 3;
                    cmd.Parameters.Add(new OracleParameter("WKOD2", OracleDbType.Int16, ParameterDirection.Input)).Value = u.Id;
                    cmd.Parameters.Add(new OracleParameter("WDEGER", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = u.BildirimTuruAdi;

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
        public bool LocalBelgeTipiDTOEkleGuncelle(List<BelgeTipiDTO> model)
        {
            var result = false;
            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var u in model)
                {
                    var cmd = new OracleCommand("STKTH011_Pkg.SET_HALTANIM", con) { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmd.Parameters.Add(new OracleParameter("WID", OracleDbType.Int16, ParameterDirection.Input)).Value = 240;
                    cmd.Parameters.Add(new OracleParameter("WKOD", OracleDbType.Int16, ParameterDirection.Input)).Value = 4;
                    cmd.Parameters.Add(new OracleParameter("WKOD2", OracleDbType.Int16, ParameterDirection.Input)).Value = u.Id;
                    cmd.Parameters.Add(new OracleParameter("WDEGER", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = u.BelgeTipiAdi;

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
        public bool LocalIsletmeTuruDTOEkleGuncelle(List<IsletmeTuruDTO> model)
        {
            var result = false;
            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var u in model)
                {
                    var cmd = new OracleCommand("STKTH011_Pkg.SET_HALTANIM", con) { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmd.Parameters.Add(new OracleParameter("WID", OracleDbType.Int16, ParameterDirection.Input)).Value = 240;
                    cmd.Parameters.Add(new OracleParameter("WKOD", OracleDbType.Int16, ParameterDirection.Input)).Value = 6;
                    cmd.Parameters.Add(new OracleParameter("WKOD2", OracleDbType.Int16, ParameterDirection.Input)).Value = u.Id;
                    cmd.Parameters.Add(new OracleParameter("WDEGER", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = u.IsletmeTuruAdi;

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
        public bool WebServiceUserUpdate(Models.ServiceUser model)
        {
            var result = false;
            if (model != null)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var cmd = new OracleCommand("STKTH011_Pkg.SET_HALTANIM", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                cmd.Parameters.Add(new OracleParameter("WID", OracleDbType.Int16, ParameterDirection.Input)).Value = 240;
                cmd.Parameters.Add(new OracleParameter("WKOD", OracleDbType.Int16, ParameterDirection.Input)).Value = 1;
                cmd.Parameters.Add(new OracleParameter("WKOD2", OracleDbType.Int16, ParameterDirection.Input)).Value = 1;
                cmd.Parameters.Add(new OracleParameter("WDEGER", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = model.UserName;

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

                cmd = null;
                cmd = new OracleCommand("STKTH011_Pkg.SET_HALTANIM", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                cmd.Parameters.Add(new OracleParameter("WID", OracleDbType.Int16, ParameterDirection.Input)).Value = 240;
                cmd.Parameters.Add(new OracleParameter("WKOD", OracleDbType.Int16, ParameterDirection.Input)).Value = 1;
                cmd.Parameters.Add(new OracleParameter("WKOD2", OracleDbType.Int16, ParameterDirection.Input)).Value = 2;
                cmd.Parameters.Add(new OracleParameter("WDEGER", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = model.Password;

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

                cmd = null;
                cmd = new OracleCommand("STKTH011_Pkg.SET_HALTANIM", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                cmd.Parameters.Add(new OracleParameter("WID", OracleDbType.Int16, ParameterDirection.Input)).Value = 240;
                cmd.Parameters.Add(new OracleParameter("WKOD", OracleDbType.Int16, ParameterDirection.Input)).Value = 1;
                cmd.Parameters.Add(new OracleParameter("WKOD2", OracleDbType.Int16, ParameterDirection.Input)).Value = 3;
                cmd.Parameters.Add(new OracleParameter("WDEGER", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = model.ServicePasssword;

                try
                {
                    cmd.ExecuteReader();
                    result = true;
                }
                catch (OracleException e)
                {
                    var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    logger.Error(errorMessage);
                }

                con.Close();
            }

            return result;
        }
        public bool LocalAracPlakaGuncelleEkle(List<Models.AracPlaka> model)
        {
            var result = false;
            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                foreach (var item in model)
                {

                    var cmd = new OracleCommand() { Connection = con, CommandText = "STKTH011_Pkg.SET_PLAKANO", CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.Add("WSONUC", OracleDbType.Varchar2, 999999);
                    cmd.Parameters["WSONUC"].Direction = ParameterDirection.ReturnValue;

                    cmd.Parameters.Add("P_WPLAKANO", OracleDbType.Varchar2);
                    cmd.Parameters["P_WPLAKANO"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WPLAKANO"].Value = string.IsNullOrEmpty(item.PLAKANO) ? "" : item.PLAKANO = item.PLAKANO.Length > 15 ? item.PLAKANO.Substring(0, 14).ToUpper() : item.PLAKANO.ToUpper();

                    cmd.Parameters.Add("P_WDEPNO", OracleDbType.Varchar2);
                    cmd.Parameters["P_WDEPNO"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WDEPNO"].Value = item.DMBNO;

                    string stringdata = "";
                    try
                    {
                        cmd.ExecuteNonQuery();
                        stringdata = (string)(((Oracle.ManagedDataAccess.Types.OracleString)cmd.Parameters["WSONUC"].Value).Value);
                        if (stringdata != "0")
                        {
                            result = true;

                            var errorMessage = string.Format("Hata Noktası STKTH011_Pkg.SET_PLAKANO :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, 00, stringdata);
                            Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                            Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                            logger.Error(errorMessage);
                        }
                        else
                        {
                            result = false;
                        }

                    }
                    catch (OracleException e)
                    {
                        var errorMessage = string.Format("Hata Noktası STKTH011_Pkg.SET_PLAKANO :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                        logger.Error(errorMessage);
                    }
                }

                con.Close();
            }


            return result;
        }
        public IList<Models.AracPlaka> GetAracPlakaList ()
        {
            IList<Models.AracPlaka> result = new  List<Models.AracPlaka>();

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT GENTM05.DMBNO, GENTM05.AD AS ACIKLAMA, GENTM13.PLAKANO");
            sqlString.AppendLine("  FROM GENTM05, GENTM13");
            sqlString.AppendLine(" WHERE GENTM05.DMBNO = GENTM13.DEPNO(+) AND GENTM05.TIP IN ('M', 'D')");

            var con = Controllers.OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                var sonuc = con.Query<Models.AracPlaka>(sqlString.ToString());
                if(sonuc!=null)
                    result = (IList<Models.AracPlaka>)sonuc;
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


        /// <summary>
        /// Bildirim icin Gerekli Sıfat ve Benzeri Bilgilerin Listeleri
        /// </summary>
        /// <returns></returns>
        public IList<Models.LocalIsletmeTuruDTO> GetIsletmeTuruDTO()
        {
            IList<Models.LocalIsletmeTuruDTO> result = new List<Models.LocalIsletmeTuruDTO>();

            var sqlString = new StringBuilder();
            sqlString.AppendLine("   -- IsletmeTuruAdi Türü Bilgieri");
            sqlString.AppendLine("SELECT KOD2 AS ID, DEGER AS ISLETMETURUADI");
            sqlString.AppendLine("  FROM GENTM03");
            sqlString.AppendLine(" WHERE ID = 240 AND KOD = 6");

            var con = Controllers.OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                var sonuc = con.Query<Models.LocalIsletmeTuruDTO>(sqlString.ToString());
                if (sonuc != null)
                    result = (IList<Models.LocalIsletmeTuruDTO>)sonuc;
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
        public IList<Models.LocalSifatDTO> GetSifatlarDTO()
        {
            IList<Models.LocalSifatDTO> result = new List<Models.LocalSifatDTO>();
            var sqlString = new StringBuilder();
            sqlString.AppendLine("-- Sıfat Bilgieri");
            sqlString.AppendLine("SELECT KOD2 AS ID, DEGER AS SIFATADI");
            sqlString.AppendLine("  FROM GENTM03");
            sqlString.AppendLine(" WHERE ID = 240 AND KOD = 2");



            var con = Controllers.OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                var sonuc = con.Query<Models.LocalSifatDTO>(sqlString.ToString());
                if (sonuc != null)
                    result = (IList<Models.LocalSifatDTO>)sonuc;
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
        public IList<Models.LocalBildirimTuruDTO> GetBildirimTuruDTO()
        {
            IList<Models.LocalBildirimTuruDTO> result = new List<Models.LocalBildirimTuruDTO>();
            var sqlString = new StringBuilder();
            sqlString.AppendLine(" -- BildirimTuruAdi Türü Bilgieri");
            sqlString.AppendLine("SELECT KOD2 AS ID, DEGER AS BILDIRIMTURUADI");
            sqlString.AppendLine("  FROM GENTM03");
            sqlString.AppendLine(" WHERE ID = 240 AND KOD = 3");



            var con = Controllers.OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                var sonuc = con.Query<Models.LocalBildirimTuruDTO>(sqlString.ToString());
                if (sonuc != null)
                    result = (IList<Models.LocalBildirimTuruDTO>)sonuc;
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
        public IList<Models.LocalBelgeTipiDTO> GetBelgeTipiDTO()
        {
            IList<Models.LocalBelgeTipiDTO> result = new List<Models.LocalBelgeTipiDTO>();
            var sqlString = new StringBuilder();
            sqlString.AppendLine("  -- BelgeTipiAdi Türü Bilgieri");
            sqlString.AppendLine("SELECT KOD2 AS ID, DEGER AS BELGETIPIADI");
            sqlString.AppendLine("  FROM GENTM03");
            sqlString.AppendLine(" WHERE ID = 240 AND KOD = 4");



            var con = Controllers.OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            try
            {
                var sonuc = con.Query<Models.LocalBelgeTipiDTO>(sqlString.ToString());
                if (sonuc != null)
                    result = (IList<Models.LocalBelgeTipiDTO>)sonuc;
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

        /// <summary>
        /// Bildirim icin Gerekli Sıfat ve Benzeri Bilgilerin Listeleri
        /// </summary>
        /// <returns></returns>
        /// 


        public bool BildirimTainlamalariGuncelle(List<Models.SifatTanimlari> model)
        {
            var result = false;
            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                foreach (var u in model)
                {
                    var cmd = new OracleCommand("STKTH011_Pkg.SET_HALTANIM", con) { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.Add("Return_Value", OracleDbType.Int16, ParameterDirection.ReturnValue);
                    cmd.Parameters.Add(new OracleParameter("WID", OracleDbType.Int16, ParameterDirection.Input)).Value = 240;
                    cmd.Parameters.Add(new OracleParameter("WKOD", OracleDbType.Int16, ParameterDirection.Input)).Value = u.TANIMKODU;
                    cmd.Parameters.Add(new OracleParameter("WKOD2", OracleDbType.Int16, ParameterDirection.Input)).Value = u.ID;
                    cmd.Parameters.Add(new OracleParameter("WDEGER", OracleDbType.Varchar2, 100, ParameterDirection.Input)).Value = u.TANIMBILGISI;

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

        public bool BildirimTainlamalariSil()
        {
            var result = false;

            var con = OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            const string sql = @"delete from GENTM03 where ID =240 AND KOD >=10";
            var cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;

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
    }
}
