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
    public class WebServiceTool
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        public Models.ServiceUser GetWebServiceUser()
        {
            IList<Models.OmegaGENTM03> resultGentm03 = new List<Models.OmegaGENTM03>();

            var result = new Models.ServiceUser();
            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT ID, ");
            sqlString.AppendLine("       KOD, ");
            sqlString.AppendLine("       KOD2, ");
            sqlString.AppendLine("       DEGER ");
            sqlString.AppendLine("  FROM GENTM03 ");
            sqlString.AppendLine(" WHERE ID = 240 AND KOD = 1 ");
            var con = Controllers.OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var GenTm03List = con.Query<Models.OmegaGENTM03>(sqlString.ToString());
                if(GenTm03List !=null)
                    resultGentm03 = (IList<Models.OmegaGENTM03>)GenTm03List;
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

            if (resultGentm03.Count <= 0)
                return result;

            foreach (var item in resultGentm03)
            {
                if (item.ID == 240 && item.KOD == 1 && item.KOD2 == 1)
                {
                    result.UserName = item.DEGER;
                }
                else
                {
                    if (item.ID == 240 && item.KOD == 1 && item.KOD2 == 2)
                    {
                        result.Password = item.DEGER;
                    }
                    else
                    {
                        if (item.ID == 240 && item.KOD == 1 && item.KOD2 == 3)
                        {
                            result.ServicePasssword = item.DEGER;
                        }
                        else
                        {
                            result = null;
                        }
                    }
                }
            }
            return result;
        }
        public bool GetBildirimTanimlariniOku()
        {
            bool result = false;

            IList<Models.OmegaGENTM03> sonuc = new List<Models.OmegaGENTM03>();

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT ID, ");
            sqlString.AppendLine("       KOD, ");
            sqlString.AppendLine("       KOD2, ");
            sqlString.AppendLine("       DEGER ");
            sqlString.AppendLine("  FROM GENTM03 ");
            sqlString.AppendLine(" WHERE ID = 240 AND KOD >= 10 ");
            var con = Controllers.OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var GenTm03List = con.Query<Models.OmegaGENTM03>(sqlString.ToString());
                if (GenTm03List != null)
                    sonuc = (IList<Models.OmegaGENTM03>)GenTm03List;
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

            if (sonuc.Count <= 0)
                return result;

            foreach (var item in sonuc)
            {
                if (item.ID == 240 && item.KOD == 10)
                {
                    Core.StaticDegiskenler.BildirimciSifatId = item.KOD2;
                }
                else if(item.ID == 240 && item.KOD == 11)
                {
                    Core.StaticDegiskenler.GidecekYerSifatId = item.KOD2;
                }
                else if (item.ID == 240 && item.KOD == 12)
                {
                    Core.StaticDegiskenler.GidecekYerIsletmeTuruId = item.KOD2;
                }
                else if (item.ID == 240 && item.KOD == 13)
                {
                    Core.StaticDegiskenler.BidirimTuruId = item.KOD2;
                }
                else if (item.ID == 240 && item.KOD == 14)
                {
                    Core.StaticDegiskenler.BildirimBelgeTipiId = item.KOD2;
                }
                else if (item.ID == 240 && item.KOD == 15)
                {
                    Core.StaticDegiskenler.BildirimciIsletmeTuruId = item.KOD2;
                }
            }
            result = true;
            return result;
        }
    }
}
