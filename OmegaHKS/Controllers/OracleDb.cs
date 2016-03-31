using NLog;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace OmegaHKS.Controllers
{
    internal static class OracleDb
    {
        private static string _orclConnStr;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public static OracleConnection GetOrclConn()
        {
            try
            {
                if (_orclConnStr == null)
                {
                    var orclUserPass = string.Empty;
                    var orclUserName = string.Empty;
                    var tmpConnStr = "data source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)" +
                                              "(HOST=" + Properties.Settings.Default.OracleDbIP + ")(PORT=1521))(CONNECT_DATA=" +
                                              "(SERVICE_NAME=" + Properties.Settings.Default.OracleDbSID + ")));" +
                                              "user id=" + Properties.Settings.Default.TempUserID + ";password=" + Properties.Settings.Default.TempPassword + ";Pooling=false";
                    using (var conn = new OracleConnection(tmpConnStr))
                    {
                        conn.Open();

                        using (var command = new OracleCommand("SELECT UNAME,USIF FROM GESTC010 WHERE AKTIF = 'E'", conn))
                        {
                            using (var dr = command.ExecuteReader())
                            {
                                if (dr != null && dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        orclUserPass = dr["USIF"].ToString();
                                        orclUserName = dr["UNAME"].ToString();
                                        Core.StaticDegiskenler.AktifOracleUser = dr["UNAME"].ToString();
                                    }
                                }
                                else
                                {
                                }
                            }
                        }
                    }
                    _orclConnStr = "data source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)" +
                                           "(HOST=" + Properties.Settings.Default.OracleDbIP + ")(PORT=1521))(CONNECT_DATA=" +
                                           "(SERVICE_NAME=" + Properties.Settings.Default.OracleDbSID + ")));" +
                                           "user id=" + orclUserName + ";password=" + orclUserPass + ";enlist=true;";
                }
                var orclConn = new OracleConnection(_orclConnStr);
                orclConn.Open();
                return orclConn;
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Kodu : {0}\nHata Bilgisi: {1}", e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                logger.Error(errorMessage);
                return null;
            }
        }

        public static DataTable GetSQLOrclTableData(string pSql)
        {
            var dt = new DataTable();
            using (var conn = GetOrclConn())
            {
                using (var adpt = new OracleDataAdapter(pSql, conn))
                {
                    try
                    {
                        adpt.Fill(dt);
                        return dt;
                    }
                    catch (OracleException e)
                    {
                        var errorMessage = string.Format("Hata Noktası :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                        logger.Error(errorMessage);
                        return null;
                        // throw new SystemException(errorMessage);
                    }
                }
            }
        }

        public static DataTable GetCMDOrclTableData(OracleCommand pCmd)
        {
            var dt = new DataTable();
            using (var conn = GetOrclConn())
            {
                using (var adpt = new OracleDataAdapter(pCmd))
                {
                    try
                    {
                        adpt.Fill(dt);
                        return dt;
                    }
                    catch (OracleException e)
                    {
                        var errorMessage = string.Format("Hata Kodu : {0}\nHata Bilgisi: {1}", e.ErrorCode, e.Message);
                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                        logger.Error(errorMessage);
                        return null;
                    }
                }
            }
        }

        public static string GetOrclScalar(string pSql)
        {
            try
            {
                using (var conn = GetOrclConn())
                {
                    using (var command = new OracleCommand(pSql, conn))
                    {
                        var result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return Convert.ToString(result);
                        }
                        return null;
                    }
                }
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Kodu : {0}\nHata Bilgisi: {1}", e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
                return null;
            }
        }

        public static int GetOrclScalarInt(string pSql)
        {
            try
            {
                using (var conn = GetOrclConn())
                {
                    using (var command = new OracleCommand(pSql, conn))
                    {
                        var result = (Int32)command.ExecuteScalar();
                        return result;
                    }
                }
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Kodu : {0}\nHata Bilgisi: {1}", e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
                return -1;
            }
        }

        public static bool ExcOrclNonQuery(string pSql)
        {
            try
            {
                using (var conn = GetOrclConn())
                {
                    using (var command = new OracleCommand(pSql, conn))
                    {
                        if (command.ExecuteNonQuery() >= 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Kodu : {0}\nHata Bilgisi: {1}", e.ErrorCode, e.Message);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                logger.Error(errorMessage);
                return false;
            }
        }

        public static bool ExcOrclCommand(OracleCommand pCmd)
        {
            using (var conn = GetOrclConn())
            {
                using (var cmd = pCmd)
                {
                    cmd.Connection = conn;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (OracleException e)
                    {
                        var errorMessage = string.Format("Hata Kodu : {0}\nHata Bilgisi: {1}", e.ErrorCode, e.Message);
                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });

                        logger.Error(errorMessage);
                        return false;
                    }
                }
            }
        }
    }
}
