using OmegaHKS.BildirimServiceReference;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using NLog;
using System.Reflection;
using Dapper;


namespace OmegaHKS.Controllers
{
    internal class BildirimController
    {
        Logger logger = LogManager.GetCurrentClassLogger();

        public IList<Models.EtiketBelgeListesi> EtiketBelgeListesi(DateTime islemTarihi)
        {

            IList<Models.EtiketBelgeListesi> result = new List<Models.EtiketBelgeListesi>();
            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT DISTINCT TRUNC (TARIH) TARIH,");
            sqlString.AppendLine("                PLAKANO,");
            sqlString.AppendLine("                BELGENO,");
            sqlString.AppendLine("                ILID,");
            sqlString.AppendLine("                ILCEID,");
            sqlString.AppendLine("                BELDEID");
            sqlString.AppendLine("                UNIQUEID");
            sqlString.AppendLine("  FROM ETKTMH02");
            sqlString.AppendLine(string.Format(" WHERE TRUNC (TARIH) =  TO_DATE('{0}', 'DD/MM/YYYY')", islemTarihi.ToShortDateString()));

            var con = OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<Models.EtiketBelgeListesi>(sqlString.ToString());
                if (sonuc != null)
                {
                    result = (IList<Models.EtiketBelgeListesi>)sonuc;
                }
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası  EtiketBelgeListesi :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public bool SaveRefaransBildirim(IList<BildirimSorguDTO> model)
        {
            var result = false;
            if (model.Count <= 0)
            {
                return result;
            }
            var con = OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            foreach (var m in model)
            {
                var cmd = new OracleCommand() { Connection = con, CommandText = "STKTH011_Pkg.INS_KUNYE1", CommandType = CommandType.StoredProcedure };

                cmd.Parameters.Add("WSONUC", OracleDbType.Varchar2, 999999);
                cmd.Parameters["WSONUC"].Direction = ParameterDirection.ReturnValue;

                // cmd.Parameters.Add(new OracleParameter("WKUNYENO", OracleDbType.Varchar2, 20, System.Data.ParameterDirection.Input)).Value = m.KunyeNo;
                cmd.Parameters.Add("P_WKUNYENO", OracleDbType.Varchar2);
                cmd.Parameters["P_WKUNYENO"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WKUNYENO"].Value = m.KunyeNo;

                // cmd.Parameters.Add(new OracleParameter("WMALID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.MalinKodNo;
                cmd.Parameters.Add("P_WMALID", OracleDbType.Int16);
                cmd.Parameters["P_WMALID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WMALID"].Value = m.MalinKodNo;

                // cmd.Parameters.Add(new OracleParameter("WMALCINSID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.MalinCinsKodNo;
                cmd.Parameters.Add("P_WMALCINSID", OracleDbType.Int16);
                cmd.Parameters["P_WMALCINSID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WMALCINSID"].Value = m.MalinCinsKodNo;

                // cmd.Parameters.Add(new OracleParameter("WBILDIRIMTAR", OracleDbType.Date, System.Data.ParameterDirection.Input)).Value = m.BildirimTarihi;
                cmd.Parameters.Add("P_WBILDIRIMTAR", OracleDbType.Date);
                cmd.Parameters["P_WBILDIRIMTAR"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WBILDIRIMTAR"].Value = m.BildirimTarihi;

                // cmd.Parameters.Add(new OracleParameter("WBELGETIP", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.BelgeTipi;
                cmd.Parameters.Add("P_WBELGETIP", OracleDbType.Int16);
                cmd.Parameters["P_WBELGETIP"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WBELGETIP"].Value = m.BelgeTipi;

                //cmd.Parameters.Add(new OracleParameter("WBILDIRIMTUR", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.BildirimTuru;
                cmd.Parameters.Add("P_WBILDIRIMTUR", OracleDbType.Int16);
                cmd.Parameters["P_WBILDIRIMTUR"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WBILDIRIMTUR"].Value = m.BildirimTuru;

                //cmd.Parameters.Add(new OracleParameter("WMALTUR", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.MalinTuruKodNo;
                cmd.Parameters.Add("P_WMALTUR", OracleDbType.Int16);
                cmd.Parameters["P_WMALTUR"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WMALTUR"].Value = m.MalinTuruKodNo; 

                // cmd.Parameters.Add(new OracleParameter("WBELGENO", OracleDbType.Varchar2, 15, System.Data.ParameterDirection.Input)).Value = String.IsNullOrEmpty(m.BelgeNo) ? string.Empty : m.BelgeNo;
                cmd.Parameters.Add("P_WBELGENO", OracleDbType.Varchar2);
                cmd.Parameters["P_WBELGENO"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WBELGENO"].Value = string.IsNullOrEmpty(m.BelgeNo) ? string.Empty : m.BelgeNo;

                // cmd.Parameters.Add(new OracleParameter("WIRSNO", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WIRSNO", OracleDbType.Int32);
                cmd.Parameters["P_WIRSNO"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WIRSNO"].Value = 0;

                //cmd.Parameters.Add(new OracleParameter("WHKSID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.GidecekIsyeriId;
                cmd.Parameters.Add("P_WHKSID", OracleDbType.Int16);
                cmd.Parameters["P_WHKSID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WHKSID"].Value = m.GidecekIsyeriId;

                // cmd.Parameters.Add(new OracleParameter("WREFKUNYE", OracleDbType.Varchar2, 20, System.Data.ParameterDirection.Input)).Value = m.KunyeNo;
                cmd.Parameters.Add("P_WREFKUNYE", OracleDbType.Varchar2);
                cmd.Parameters["P_WREFKUNYE"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WREFKUNYE"].Value = m.KunyeNo;

                // cmd.Parameters.Add(new OracleParameter("WMIKTAR", OracleDbType.Decimal, System.Data.ParameterDirection.Input)).Value = Convert.ToDecimal(m.MalinMiktari);
                cmd.Parameters.Add("P_WMIKTAR", OracleDbType.Decimal);
                cmd.Parameters["P_WMIKTAR"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WMIKTAR"].Value = Convert.ToDecimal(m.MalinMiktari);

                //cmd.Parameters.Add(new OracleParameter("WKALANMIK", OracleDbType.Decimal, System.Data.ParameterDirection.Input)).Value = Convert.ToDecimal(m.KalanMiktar);
                cmd.Parameters.Add("P_WKALANMIK", OracleDbType.Decimal);
                cmd.Parameters["P_WKALANMIK"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WKALANMIK"].Value = Convert.ToDecimal(m.KalanMiktar);

                // cmd.Parameters.Add(new OracleParameter("WURETICI", OracleDbType.Varchar2, 100, System.Data.ParameterDirection.Input)).Value = string.Empty;
                cmd.Parameters.Add("P_WURETICI", OracleDbType.Varchar2);
                cmd.Parameters["P_WURETICI"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WURETICI"].Value = string.Empty;

                // cmd.Parameters.Add(new OracleParameter("WILID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WILID", OracleDbType.Int16);
                cmd.Parameters["P_WILID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WILID"].Value = 0;

                // cmd.Parameters.Add(new OracleParameter("WILCEID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WILCEID", OracleDbType.Int16);
                cmd.Parameters["P_WILCEID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WILCEID"].Value = 0;

                // cmd.Parameters.Add(new OracleParameter("WBELDEID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WBELDEID", OracleDbType.Int16);
                cmd.Parameters["P_WBELDEID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WBELDEID"].Value = 0;

                // cmd.Parameters.Add(new OracleParameter("WUNIQEID", OracleDbType.Varchar2, 60, System.Data.ParameterDirection.Input)).Value = String.IsNullOrEmpty(m.UniqueId) ? null : m.UniqueId.ToString().Length > 60 ? m.UniqueId.ToString().Substring(0, 59) : m.UniqueId.ToString();
                cmd.Parameters.Add("P_WUNIQEID", OracleDbType.Varchar2);
                cmd.Parameters["P_WUNIQEID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WUNIQEID"].Value = string.IsNullOrEmpty(m.UniqueId) ? null : m.UniqueId.ToString().Length > 60 ? m.UniqueId.ToString().Substring(0, 59) : m.UniqueId.ToString();

                // cmd.Parameters.Add(new OracleParameter("WBILDIRIMCITCVERGINO", OracleDbType.Varchar2, 11, System.Data.ParameterDirection.Input)).Value = m.BildirimciTcKimlikVergiNo;
                cmd.Parameters.Add("P_WBILDIRIMCITCVERGINO", OracleDbType.Varchar2);
                cmd.Parameters["P_WBILDIRIMCITCVERGINO"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WBILDIRIMCITCVERGINO"].Value = m.BildirimciTcKimlikVergiNo;


                // cmd.Parameters.Add(new OracleParameter("WMALSAHIPTCVERGINO", OracleDbType.Varchar2, 11, System.Data.ParameterDirection.Input)).Value = m.MalinSahibiTcKimlikVergiNo;
                cmd.Parameters.Add("P_WMALSAHIPTCVERGINO", OracleDbType.Varchar2);
                cmd.Parameters["P_WMALSAHIPTCVERGINO"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WMALSAHIPTCVERGINO"].Value = m.MalinSahibiTcKimlikVergiNo;

                // cmd.Parameters.Add(new OracleParameter("WTMIKTAR", OracleDbType.Decimal, System.Data.ParameterDirection.Input)).Value = Convert.ToDecimal(m.KalanMiktar);
                cmd.Parameters.Add("P_WTMIKTAR", OracleDbType.Decimal);
                cmd.Parameters["P_WTMIKTAR"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WTMIKTAR"].Value = Convert.ToDecimal(m.KalanMiktar);

                // cmd.Parameters.Add(new OracleParameter("WMIKTARBIRIMID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.MiktarBirimId;
                cmd.Parameters.Add("P_WTMIKTAR", OracleDbType.Int16);
                cmd.Parameters["P_WTMIKTAR"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WTMIKTAR"].Value = m.MiktarBirimId;

                //*****************************

                string stringdata = "";
                try
                {
                    cmd.ExecuteNonQuery();
                    stringdata = (string)(((Oracle.ManagedDataAccess.Types.OracleString)cmd.Parameters["WSONUC"].Value).Value);
                    if (stringdata != "0")
                    {
                        result = true;

                        var errorMessage = string.Format("Hata Noktası STKTH011_Pkg.INS_KUNYE1 :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, 00, stringdata);
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
                    var errorMessage = string.Format("Hata Noktası SaveRefaransBildirim :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    logger.Error(errorMessage);
                }
            }

            con.Close();
            return result;
        }
        public List<BildirimSorguDTO> GetReferansBildirim(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            var result = new List<BildirimSorguDTO>();

            BaseResponseMessageOf_BildirimSorguCevap cevap = null;

            var istek = new BaseRequestMessageOf_BildirimSorguIstek()
            {
                UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                Password = Core.StaticDegiskenler.webServiceUser.Password,
                ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                Istek = new BildirimSorguIstek()
                {
                    KunyeTuru = 1,
                    KunyeNo = 0,
                    BaslangicTarihi = baslangicTarihi,
                    BitisTarihi = bitisTarihi,
                    KalanMiktariSifirdanBuyukOlanlar = true,
                }
            };

            try
            {
                if (!Helpers.GenerelHelper.IsConnected())
                {
                    Helpers.MessageHelper.ShowInformation("İşlemleri Tamamlayabilmek İçin İnternet Erişimi Olması Gerekir İşlemler İptal Ediliyor..!");

                    var errorMessage = string.Format("İşlemleri Tamamlayabilmek İçin İnternet Erişimi Olması Gerekir İşlemler İptal Ediliyor..!  {0}", MethodBase.GetCurrentMethod().DeclaringType);
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    logger.Error(errorMessage);
                    return null;
                }

                using (var proxy = new BildirimServiceClient())
                {
                    cevap = proxy.BildirimServisBildirimSorgu(istek);
                }
            }
            finally
            {
            }
            if (cevap.Sonuc != null)
            {
                if ((cevap.Sonuc.HataKodu == 0))
                {
                    result = cevap.Sonuc.Bildirimler;
                }
                else
                {
                    var errorMessage = string.Format("Hata Noktası GetReferansBildirim :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, cevap.Sonuc.HataKodu, cevap.Sonuc.Mesaj);
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    logger.Error(errorMessage);
                }
            }
            else
            {
                if (cevap.HataKodlari != null)
                {
                    var errorMessage = string.Format("Hata Kodu : {0}, Hata Mesajı : {1}", cevap.HataKodlari[0].HataKodu, cevap.HataKodlari[0].Mesaj);
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    logger.Error(errorMessage);
                }
                else
                {
                    logger.Error(cevap.IslemKodu);
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = cevap.IslemKodu });
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = cevap.IslemKodu });
                }
            }
            return result;
        }
        public bool BildirimEtiketKayit(List<Models.LocalBildirimEtiketDTO> model)
        {
            var result = false;
            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                foreach (var m in model)
                {

                    var cmd = new OracleCommand() { Connection = con, CommandText = "STKTH011_Pkg.INS_ETIKET2", CommandType = CommandType.StoredProcedure };


                    cmd.Parameters.Add("WSONUC", OracleDbType.Varchar2, 999999);
                    cmd.Parameters["WSONUC"].Direction = ParameterDirection.ReturnValue;

                    // 1 //cmd.Parameters.Add(new OracleParameter("WSTKKOD", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.STKKOD; /// Stok Kodu
                    cmd.Parameters.Add("P_WSTKKOD", OracleDbType.Int16);
                    cmd.Parameters["P_WSTKKOD"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WSTKKOD"].Value = m.STKKOD;

                    // 2 //cmd.Parameters.Add(new OracleParameter("WTARIH", OracleDbType.Date, System.Data.ParameterDirection.Input)).Value = m.KayitTarihi;
                    cmd.Parameters.Add("P_WTARIH", OracleDbType.Date);
                    cmd.Parameters["P_WTARIH"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WTARIH"].Value = m.KayitTarihi;

                    // 3 cmd.Parameters.Add(new OracleParameter("WDEPNO", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.DEPNO; /// Depo No
                    cmd.Parameters.Add("P_WDEPNO", OracleDbType.Int16);
                    cmd.Parameters["P_WDEPNO"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WDEPNO"].Value = m.DEPNO;
                    //WMALCINSID NUMBER,

                    // 4 cmd.Parameters.Add(new OracleParameter("WMALAD", OracleDbType.Varchar2, 100, System.Data.ParameterDirection.Input)).Value = m.MalinAdi;
                    cmd.Parameters.Add("P_WMALAD", OracleDbType.Varchar2);
                    cmd.Parameters["P_WMALAD"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WMALAD"].Value = m.MalinAdi; //.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                    // 5 cmd.Parameters.Add(new OracleParameter("WMALCINSAD", OracleDbType.Varchar2, 100, System.Data.ParameterDirection.Input)).Value = m.MalinCinsAdi;
                    cmd.Parameters.Add("P_WMALCINSAD", OracleDbType.Varchar2);
                    cmd.Parameters["P_WMALCINSAD"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WMALCINSAD"].Value = m.MalinCinsAdi;


                    // 6 cmd.Parameters.Add(new OracleParameter("WKUNYENO", OracleDbType.Varchar2, 20, System.Data.ParameterDirection.Input)).Value = m.MalinKunyeNo;
                    cmd.Parameters.Add("P_WKUNYENO", OracleDbType.Varchar2);
                    cmd.Parameters["P_WKUNYENO"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WKUNYENO"].Value = m.MalinKunyeNo;


                    // 7 cmd.Parameters.Add(new OracleParameter("WURETICI", OracleDbType.Varchar2, 200, System.Data.ParameterDirection.Input)).Value = m.UreticisininAdUnvani;
                    cmd.Parameters.Add("P_WURETICI", OracleDbType.Varchar2);
                    cmd.Parameters["P_WURETICI"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WURETICI"].Value = string.IsNullOrEmpty(m.UreticisininAdUnvani) ? null : m.UreticisininAdUnvani.ToUpper();

                    // 8 cmd.Parameters.Add(new OracleParameter("WURETIMSEKLI", OracleDbType.Varchar2, 75, System.Data.ParameterDirection.Input)).Value = m.UretimSekliAdi;
                    cmd.Parameters.Add("P_WURETIMSEKLI", OracleDbType.Varchar2);
                    cmd.Parameters["P_WURETIMSEKLI"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WURETIMSEKLI"].Value = m.UretimSekliAdi; // string.IsNullOrEmpty(m.UretimSekliAdi) ? null : m.UretimSekliAdi.ToUpper();

                    // 9 cmd.Parameters.Add(new OracleParameter("WURETIMTARIH", OracleDbType.Date, System.Data.ParameterDirection.Input)).Value = m.UretimTarihi;
                    cmd.Parameters.Add("P_WURETIMTARIH", OracleDbType.Date);
                    cmd.Parameters["P_WURETIMTARIH"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WURETIMTARIH"].Value = m.UretimTarihi;

                    // 10 cmd.Parameters.Add(new OracleParameter("WURETIMYERI", OracleDbType.Varchar2, 200, System.Data.ParameterDirection.Input)).Value = m.UretimYeri;
                    cmd.Parameters.Add("P_WURETIMYERI", OracleDbType.Varchar2);
                    cmd.Parameters["P_WURETIMYERI"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WURETIMYERI"].Value = m.UretimYeri;

                    // 11 cmd.Parameters.Add(new OracleParameter("WPLAKANO", OracleDbType.Varchar2, 15, System.Data.ParameterDirection.Input)).Value = m.PlakaNo;
                    cmd.Parameters.Add("P_WPLAKANO", OracleDbType.Varchar2);
                    cmd.Parameters["P_WPLAKANO"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WPLAKANO"].Value = m.PlakaNo;

                    // 12 cmd.Parameters.Add(new OracleParameter("WBELGENO", OracleDbType.Varchar2, 15, System.Data.ParameterDirection.Input)).Value = m.BelgeNo;
                    cmd.Parameters.Add("P_WBELGENO", OracleDbType.Varchar2);
                    cmd.Parameters["P_WBELGENO"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WBELGENO"].Value = m.BelgeNo;

                    // 13 cmd.Parameters.Add(new OracleParameter("WILID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.IlId;
                    cmd.Parameters.Add("P_WILID", OracleDbType.Int16);
                    cmd.Parameters["P_WILID"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WILID"].Value = m.IlId;

                    // 14 cmd.Parameters.Add(new OracleParameter("WILCEID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.IlceId;
                    cmd.Parameters.Add("P_WILCEID", OracleDbType.Int16);
                    cmd.Parameters["P_WILCEID"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WILCEID"].Value = m.IlceId;

                    // 15 cmd.Parameters.Add(new OracleParameter("WBELDEID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.BeldeId;
                    cmd.Parameters.Add("P_WBELDEID", OracleDbType.Int16);
                    cmd.Parameters["P_WBELDEID"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WBELDEID"].Value = m.BeldeId;

                    //// 16 cmd.Parameters.Add(new OracleParameter("WUNIQEID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.UniqueId;
                    //cmd.Parameters.Add("P_WUNIQEID", OracleDbType.Varchar2);
                    //cmd.Parameters["P_WUNIQEID"].Direction = ParameterDirection.Input;
                    //cmd.Parameters["P_WUNIQEID"].Value = m.UniqueId;


                    string stringdata = "";
                    try
                    {
                        cmd.ExecuteNonQuery();
                        stringdata = (string)(((Oracle.ManagedDataAccess.Types.OracleString)cmd.Parameters["WSONUC"].Value).Value);
                        if (stringdata != "0")
                        {
                            result = true;

                            var errorMessage = string.Format("Hata Noktası STKTH011_Pkg.INS_ETIKET :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, 00, stringdata);
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
                        var errorMessage = string.Format("Hata Noktası STKTH011_Pkg.INS_ETIKET :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                        logger.Error(errorMessage);
                    }
                }

                con.Close();
            }
            return result;
        }


        public bool BildirimEtiketGuncelle(List<BildirimEtiketDTO> model)
        {
            var result = false;
            if (model.Count > 0)
            {
                var con = OracleDb.GetOrclConn();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                foreach (var m in model)
                {
                    var cmd = new OracleCommand() { Connection = con, CommandText = "STKTH011_Pkg.UPD_ETIKET2", CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.Add("WSONUC", OracleDbType.Varchar2, 999999);
                    cmd.Parameters["WSONUC"].Direction = ParameterDirection.ReturnValue;

                    cmd.Parameters.Add("P_WTARIH", OracleDbType.Date);
                    cmd.Parameters["P_WTARIH"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WTARIH"].Value = m.KayitTarihi;

                    cmd.Parameters.Add("P_WMALAD", OracleDbType.Varchar2);
                    cmd.Parameters["P_WMALAD"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WMALAD"].Value = string.IsNullOrEmpty(m.MalinAdi) ? null : m.MalinAdi.ToUpper();

                    cmd.Parameters.Add("P_WMALCINSAD", OracleDbType.Varchar2);
                    cmd.Parameters["P_WMALCINSAD"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WMALCINSAD"].Value = string.IsNullOrEmpty(m.MalinCinsAdi) ? null : m.MalinCinsAdi.ToUpper();

                    cmd.Parameters.Add("P_WKUNYENO", OracleDbType.Varchar2);
                    cmd.Parameters["P_WKUNYENO"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WKUNYENO"].Value = m.MalinKunyeNo;

                    cmd.Parameters.Add("P_WURETICI", OracleDbType.Varchar2);
                    cmd.Parameters["P_WURETICI"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WURETICI"].Value = string.IsNullOrEmpty(m.UreticisininAdUnvani) ? null : m.UreticisininAdUnvani.ToUpper();

                    cmd.Parameters.Add("P_WURETIMSEKLI", OracleDbType.Varchar2);
                    cmd.Parameters["P_WURETIMSEKLI"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WURETIMSEKLI"].Value = string.IsNullOrEmpty(m.UretimSekliAdi) ? null : m.UretimSekliAdi.ToUpper();

                    cmd.Parameters.Add("P_WURETIMTARIH", OracleDbType.Date);
                    cmd.Parameters["P_WURETIMTARIH"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WURETIMTARIH"].Value = m.UretimTarihi;

                    cmd.Parameters.Add("P_WURETIMYERI", OracleDbType.Varchar2);
                    cmd.Parameters["P_WURETIMYERI"].Direction = ParameterDirection.Input;
                    cmd.Parameters["P_WURETIMYERI"].Value = string.IsNullOrEmpty(m.UretimYeri) ? null : m.UretimYeri.ToUpper();

                    ////cmd.Parameters.Add(new OracleParameter("WUNIQUEID", OracleDbType.Varchar2, 200, System.Data.ParameterDirection.Input)).Value = "";
                    //cmd.Parameters.Add("P_WUNIQUEID", OracleDbType.Varchar2);
                    //cmd.Parameters["P_WUNIQUEID"].Direction = ParameterDirection.Input;
                    //cmd.Parameters["P_WUNIQUEID"].Value = "";

                    string stringdata = "";
                    try
                    {
                        cmd.ExecuteNonQuery();
                        stringdata = (string)(((Oracle.ManagedDataAccess.Types.OracleString)cmd.Parameters["WSONUC"].Value).Value);
                        if (stringdata != "0")
                        {
                            result = true;

                            var errorMessage = string.Format("Hata Noktası STKTH011_Pkg.INS_ETIKET :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, 00, stringdata);
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
                        var errorMessage = string.Format("Hata Noktası STKTH011_Pkg.INS_ETIKET :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                        logger.Error(errorMessage);
                        result = true;
                    }
                }
                con.Close();
            }
            return result;
        }


        private MalinGidecekYerBilgileriDTO GetMalinGidecekYerBilgileri(int karsiDepo, string belgeNo)
        {
            var localControllers = new LocalDepoDTOController();

            var result = new MalinGidecekYerBilgileriDTO();
            var localDepo = new Models.LocalDepo();

            if(string.IsNullOrEmpty(belgeNo))
            {
                const string belgeNoEksik = "Belge No Bilgisi Eksik Bildirim Yapılamaz";
                logger.Error(belgeNoEksik);
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = belgeNoEksik });
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = belgeNoEksik });


            }
            else
            {
                localDepo = localControllers.GetLocalDepo(karsiDepo);
                if (string.IsNullOrEmpty(localDepo.Plaka))
                {
                    string plakaEkisk = string.Format("Plaka Tanımı Eksik Plaka Tanımlamanız Gerekir Depo No :{0} Depo / Şube :{1}", localDepo.DMBNO, localDepo.AD);
                    logger.Error(plakaEkisk);
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = plakaEkisk });
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = plakaEkisk });

                }
                else
                {
                    result.AracPlakaNo = localDepo.Plaka;
                    result.GidecekIsyeriId = localDepo.HKSID;
                    result.BelgeNo = belgeNo;
                    result.GidecekYerIsletmeTuruId = Core.StaticDegiskenler.GidecekYerIsletmeTuruId;  //19; // Databseden Alınıcak
                    result.BelgeTipi = Core.StaticDegiskenler.BildirimBelgeTipiId; // 207;   // Databseden Alınıcak
                }
            }

            return result;
        }

        private long GetReferansKunyeNo(long refKunye)
        {
            return Convert.ToInt64(refKunye);
        }
        public BildirimKayitIstek WebBuildSingleIstek(long refKunye, int depo, Models.IrsaliyeDetay urun, string belgeNo)
        {
            return new BildirimKayitIstek()
            {
                BildirimciBilgileri = new BildirimciBilgileriDTO { KisiSifat = Core.StaticDegiskenler.BildirimciSifatId }, 
                BildirimTuru = Core.StaticDegiskenler.BidirimTuruId,
                IkinciKisiBilgileri = new IkinciKisiBilgileriDTO { TcKimlikVergiNo = Core.StaticDegiskenler.webServiceUser.UserName, KisiSifat = Core.StaticDegiskenler.GidecekYerSifatId }, 
                ReferansBildirimKunyeNo = GetReferansKunyeNo(refKunye),
                BildirimMalBilgileri = new BildirimMalBilgileriDTO { MalinSatisFiyat = 0, MalinMiktari = urun.TBIRIMMIK, MalinNiteligi = 1 },
                MalinGidecekYerBilgileri = GetMalinGidecekYerBilgileri(depo, belgeNo),
                UniqueId = urun.UniqueId.ToString()
            };
        }
        public bool WebBildirimKayit(IList<BildirimKayitIstek> bildirim, IList<Models.IrsaliyeDetay> irsDetray)
        {
            BaseResponseMessageOf_ListOf_BildirimKayitCevap cevap = null;

            var donus = false;

            logger.Info("Web Servis İslemleri Başlatıldı");

            var bildirimController = new BildirimController();
            var localControllers = new LocalDepoDTOController();
            var etkList = new List<Models.LocalBildirimEtiketDTO>();
            var istekList = new BaseRequestMessageOf_ListOf_BildirimKayitIstek()
            {
                UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                Password = Core.StaticDegiskenler.webServiceUser.Password,
                ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                Istek = new List<BildirimKayitIstek>()
            };

            if(bildirim.Count <= 0)
            {
                var xxx = "Bildirim İstek İşlemi Gerçekleştirilemedi Beklenmeyen Sorun Oluştu";
                logger.Info(xxx);
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = xxx });
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = xxx });
                return false;
            }

            for (var i = 0; i < bildirim.Count; i++)
            {
                var singleIstek = bildirim[i];
                singleIstek.UniqueId = bildirim[i].UniqueId.ToString();
                istekList.Istek.Add(singleIstek);

                var info = string.Format("Bildirim Hazırlanıyor {0} {1} {2} {3} {4} {5}", bildirim[i].MalinGidecekYerBilgileri.AracPlakaNo.ToString().PadRight(6),
                                                                                          bildirim[i].MalinGidecekYerBilgileri.BelgeNo.ToString().PadRight(12),
                                                                                          bildirim[i].BildirimMalBilgileri.MalinCinsiId.ToString().PadRight(6),
                                                                                          bildirim[i].BildirimMalBilgileri.MalinKodNo.ToString().PadRight(6),
                                                                                          bildirim[i].ReferansBildirimKunyeNo.ToString().PadRight(22),
                                                                                          bildirim[i].UniqueId.ToString().PadRight(40));
                logger.Info(info);
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Bilgi", HataBilgisi = info });
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Bilgi", HataBilgisi = info });

            }

            try
            {
                logger.Info("proxy Oluşturuluyor");
                using (var proxy = new BildirimServiceClient())
                {
                    logger.Info("İstek Bildirimi Başlıyor");

                    cevap = proxy.BildirimServisBildirimKaydet(istekList);

                    logger.Info("İstek işlemi Sona Erdi Sorun Yok");
                }
            }
            catch (Exception e)
            {
                logger.Info("Hata Oluştu :" + e.Message);
            }
            finally
            {
            }

            var sb = new StringBuilder();
            if (cevap.Sonuc != null)
            {

                var info = string.Format("Bildirim Sonucu Alınan Künye Sayısı :{0} ", cevap.Sonuc.Count);
                logger.Info(info);
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Bilgi", HataBilgisi = info });
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Bilgi", HataBilgisi = info });

                List<Models.LocalKunyeKayitBildirimSorguDTO> KunyeKayitList = new List<Models.LocalKunyeKayitBildirimSorguDTO>();

                foreach (var item in cevap.Sonuc)
                {
                    if ((item == null) || (item.HataKodu == 0))
                    {
                        foreach (var i in Core.StaticDegiskenler.IslemYapilanIrsaliye)
                        {
                            info = string.Empty;

                            if (item.MalinKodNo == i.MALID && item.MalinCinsiId == i.MALCINSID && item.UniqueId == i.UniqueId.ToString())
                            {
                                var localDepo = new Models.LocalDepo();
                                localDepo = localControllers.GetLocalDepo(i.ALDEP);

                                etkList.Add(new Models.LocalBildirimEtiketDTO
                                {
                                    STKKOD = i.STKKOD,
                                    DEPNO = i.ALDEP,
                                    KayitTarihi = item.KayitTarihi,
                                    UreticisininAdUnvani = item.UreticisininAdUnvani,
                                    MalinKunyeNo = item.YeniKunyeNo,
                                    MalinAdi = i.MALAD,
                                    BelgeNo = item.BelgeNo,
                                    PlakaNo = item.AracPlakaNo,
                                    IlId = (int)localDepo.HKSILID,
                                    IlceId = (int)localDepo.HKSILCEID,
                                    BeldeId = (int)localDepo.HKSBELDEID,
                                    UretimSekliAdi = item.UretimSekli.ToString(),
                                    UniqueId = item.UniqueId
                                });

                                //************************
                                KunyeKayitList.Add(new Models.LocalKunyeKayitBildirimSorguDTO
                                {
                                    IRSTARIHI = i.TARIH,
                                    BildirimTarihi = item.KayitTarihi,
                                    DEPNO = i.ALDEP,
                                    IRSNO = i.IRSNO,
                                    STKKOD = i.STKKOD,
                                    YeniKunye = item.YeniKunyeNo,
                                    KunyeNo = i.KUNYE,
                                    MalinCinsKodNo = i.MALCINSID,
                                    MalinKodNo = i.MALID,
                                    BelgeNo = i.BELGENO,
                                    MalinMiktari = i.BIRIMMIK,
                                    BelgeTipi = item.BelgeTipi,
                                    UniqueId = item.UniqueId
                                });
                                //**************************

                                info = string.Format("Yeni Künye Alındı :{0} Depo No:{1} Yeni Künye :{2}  Belge No :{3}  Plaka No :{4}  :Il Id :{5}  Ilce Id :{6}  Belde Id :{7} Tekil ID {8}",
                                            i.STKKOD.ToString().PadRight(11), 
                                            i.ALDEP.ToString().PadRight(5), 
                                            item.YeniKunyeNo.ToString().PadRight(21), 
                                            item.BelgeNo.PadRight(10), 
                                            item.AracPlakaNo.PadRight(12), 
                                            ((int)localDepo.HKSILID).ToString().PadRight(6), 
                                            ((int)localDepo.HKSILCEID).ToString().PadRight(6), 
                                            ((int)localDepo.HKSBELDEID).ToString().PadRight(6),
                                            i.UniqueId.ToString().PadRight(40));
                                logger.Info(info);
                                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Bilgi", HataBilgisi = info });
                                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Bilgi", HataBilgisi = info });
                            }
                        }

                        var kunyeKayit = bildirimController.SaveKunyeBildirim(KunyeKayitList);
                        var etkKayit = bildirimController.BildirimEtiketKayit(etkList);
                        if (etkKayit)
                        {
                            donus = true;
                        }
                        else
                        {
                            donus = false;
                        }
                    }
                    else
                    {
                        sb.AppendFormat("{0} unique id'li bildirimin hata Kodu : {1}, Hata Mesajı : {2}\r\n",
                            item.UniqueId, item.HataKodu, item.Mesaj);
                        Helpers.MessageHelper.ShowInformation(sb.ToString());

                        logger.Info(sb.ToString());
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });

                        donus = false;
                    }
                }

                if (cevap.IslemKodu == ServiceConstants.Global.ServisIslemBasarili)
                {
                    donus = false;
                    // Helpers.MessageHelper.ShowInformation(sb.ToString());
                    logger.Info(sb.ToString());
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Bilgi", HataBilgisi = sb.ToString() });
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Bilgi", HataBilgisi = sb.ToString() });
                }
                else
                {
                    Helpers.MessageHelper.ShowError(sb.ToString());
                    logger.Info(sb.ToString());
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                    donus = true;
                }
               // donus = false;
            }
            else
            {
                if (cevap.IslemKodu.Length > 0)
                {
                    Helpers.MessageHelper.ShowInformation(cevap.IslemKodu);
                    logger.Info(cevap.IslemKodu);
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                }

                donus = true;
            }
            return donus;
        }
        public bool SaveKunyeBildirim(List<Models.LocalKunyeKayitBildirimSorguDTO> model)
        {
            var result = false;
            if (model.Count <= 0)
            {
                return result;
            }
            var con = OracleDb.GetOrclConn();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            foreach (var m in model)
            {

                //if(!m.YazYazma)
                //{
                var cmd = new OracleCommand() { Connection = con, CommandText = "STKTH011_Pkg.INS_KUNYE2", CommandType = CommandType.StoredProcedure };


                cmd.Parameters.Add("WSONUC", OracleDbType.Varchar2, 999999);
                cmd.Parameters["WSONUC"].Direction = ParameterDirection.ReturnValue;

                // 1 cmd.Parameters.Add(new OracleParameter("WKUNYENO", OracleDbType.Varchar2, 20, System.Data.ParameterDirection.Input)).Value = m.YeniKunye;
                cmd.Parameters.Add("P_WKUNYENO", OracleDbType.Varchar2);
                cmd.Parameters["P_WKUNYENO"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WKUNYENO"].Value = m.YeniKunye;
                //WKUNYENO VARCHAR2,

                // 2 cmd.Parameters.Add(new OracleParameter("WMALID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WMALID", OracleDbType.Int16);
                cmd.Parameters["P_WMALID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WMALID"].Value = m.MalinKodNo;
                // WMALID NUMBER,

                // 3 cmd.Parameters.Add(new OracleParameter("WMALCINSID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WMALCINSID", OracleDbType.Int16);
                cmd.Parameters["P_WMALCINSID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WMALCINSID"].Value = m.MalinCinsKodNo;
                //WMALCINSID NUMBER,

                // 4 cmd.Parameters.Add(new OracleParameter("WBILDIRIMTAR", OracleDbType.Date, System.Data.ParameterDirection.Input)).Value = m.BildirimTarihi;
                cmd.Parameters.Add("P_WBILDIRIMTAR", OracleDbType.Date);
                cmd.Parameters["P_WBILDIRIMTAR"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WBILDIRIMTAR"].Value = m.BildirimTarihi; //.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                //WBILDIRIMTAR DATE,

                // 5 cmd.Parameters.Add(new OracleParameter("WBELGETIP", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WBELGETIP", OracleDbType.Int16);
                cmd.Parameters["P_WBELGETIP"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WBELGETIP"].Value = m.BelgeTipi;
                //WBELGETIP NUMBER,


                // 6 cmd.Parameters.Add(new OracleParameter("WBILDIRIMTUR", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WBILDIRIMTUR", OracleDbType.Int16);
                cmd.Parameters["P_WBILDIRIMTUR"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WBILDIRIMTUR"].Value = m.BildirimTuru;
                //WBILDIRIMTUR NUMBER,


                // 7 cmd.Parameters.Add(new OracleParameter("WMALTUR", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WMALTUR", OracleDbType.Int16);
                cmd.Parameters["P_WMALTUR"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WMALTUR"].Value = m.MalinTuru;
                //WMALTUR NUMBER,


                // 8 cmd.Parameters.Add(new OracleParameter("WBELGENO", OracleDbType.Varchar2, 15, System.Data.ParameterDirection.Input)).Value = String.IsNullOrEmpty(m.BelgeNo) ? string.Empty : m.BelgeNo;
                cmd.Parameters.Add("P_WBELGENO", OracleDbType.Varchar2);
                cmd.Parameters["P_WBELGENO"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WBELGENO"].Value = String.IsNullOrEmpty(m.BelgeNo) ? string.Empty : m.BelgeNo;
                //WBELGENO VARCHAR2,

                // 9 cmd.Parameters.Add(new OracleParameter("WIRSNO", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = m.IRSNO;
                cmd.Parameters.Add("P_WIRSNO", OracleDbType.Int16);
                cmd.Parameters["P_WIRSNO"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WIRSNO"].Value = m.IRSNO;
                //WIRSNO NUMBER,

                // 10 cmd.Parameters.Add(new OracleParameter("WHKSID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WHKSID", OracleDbType.Int16);
                cmd.Parameters["P_WHKSID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WHKSID"].Value = m.GidecekIsyeriId;
                //WHKSID NUMBER,

                // 11 cmd.Parameters.Add(new OracleParameter("WREFKUNYE", OracleDbType.Varchar2, 20, System.Data.ParameterDirection.Input)).Value = m.KunyeNo;
                cmd.Parameters.Add("P_WREFKUNYE", OracleDbType.Varchar2);
                cmd.Parameters["P_WREFKUNYE"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WREFKUNYE"].Value = m.KunyeNo;
                //WREFKUNYE VARCHAR2,

                // 12 cmd.Parameters.Add(new OracleParameter("WMIKTAR", OracleDbType.Decimal, System.Data.ParameterDirection.Input)).Value = Convert.ToDecimal(m.MalinMiktari);
                cmd.Parameters.Add("P_WMIKTAR", OracleDbType.Decimal);
                cmd.Parameters["P_WMIKTAR"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WMIKTAR"].Value = Convert.ToDecimal(m.MalinMiktari);
                //WMIKTAR NUMBER,

                // 13 cmd.Parameters.Add(new OracleParameter("WKALANMIK", OracleDbType.Decimal, System.Data.ParameterDirection.Input)).Value = Convert.ToDecimal(m.KalanMiktar);
                cmd.Parameters.Add("P_WKALANMIK", OracleDbType.Decimal);
                cmd.Parameters["P_WKALANMIK"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WKALANMIK"].Value = Convert.ToDecimal(m.KalanMiktar);
                //WKALANMIK NUMBER,

                // 14 cmd.Parameters.Add(new OracleParameter("WURETICI", OracleDbType.Varchar2, 100, System.Data.ParameterDirection.Input)).Value = string.Empty;
                cmd.Parameters.Add("P_WURETICI", OracleDbType.Varchar2);
                cmd.Parameters["P_WURETICI"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WURETICI"].Value = m.UreticiTcKimlikVergiNo;
                //WURETICI VARCHAR2,

                // 15 cmd.Parameters.Add(new OracleParameter("WILID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WILID", OracleDbType.Int16);
                cmd.Parameters["P_WILID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WILID"].Value = 0;
                //WILID NUMBER,

                // 16 cmd.Parameters.Add(new OracleParameter("WILCEID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WILCEID", OracleDbType.Int16);
                cmd.Parameters["P_WILCEID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WILCEID"].Value = 0;
                //WILCEID NUMBER,

                // 17 cmd.Parameters.Add(new OracleParameter("WBELDEID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WBELDEID", OracleDbType.Int16);
                cmd.Parameters["P_WBELDEID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WBELDEID"].Value = 0;

                // 18 cmd.Parameters.Add(new OracleParameter("WUNIQEID", OracleDbType.Varchar2, 60, System.Data.ParameterDirection.Input)).Value = String.IsNullOrEmpty(m.UniqueId) ? null : m.UniqueId.ToString().Length > 60 ? m.UniqueId.ToString().Substring(0, 59) : m.UniqueId.ToString();
                cmd.Parameters.Add("P_WUNIQEID", OracleDbType.Varchar2);
                cmd.Parameters["P_WUNIQEID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WUNIQEID"].Value = String.IsNullOrEmpty(m.UniqueId) ? null : m.UniqueId.ToString().Length > 100 ? m.UniqueId.ToString().Substring(0, 99) : m.UniqueId.ToString();
                //WBELDEID NUMBER,

                // 19 cmd.Parameters.Add(new OracleParameter("WBILDIRIMCITCVERGINO", OracleDbType.Varchar2, 11, System.Data.ParameterDirection.Input)).Value = "";
                cmd.Parameters.Add("P_WBILDIRIMCITCVERGINO", OracleDbType.Varchar2);
                cmd.Parameters["P_WBILDIRIMCITCVERGINO"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WBILDIRIMCITCVERGINO"].Value = m.BildirimciTcKimlikVergiNo;
                //WBILDIRIMCITCVERGINO VARCHAR2,

                // 20 cmd.Parameters.Add(new OracleParameter("WMALSAHIPTCVERGINO", OracleDbType.Varchar2, 11, System.Data.ParameterDirection.Input)).Value = "";
                cmd.Parameters.Add("P_WMALSAHIPTCVERGINO", OracleDbType.Varchar2);
                cmd.Parameters["P_WMALSAHIPTCVERGINO"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WMALSAHIPTCVERGINO"].Value = m.MalinSahibiTcKimlikVergiNo;
                //WMALSAHIPTCVERGINO VARCHAR2,

                // 21 cmd.Parameters.Add(new OracleParameter("WTMIKTAR", OracleDbType.Decimal, System.Data.ParameterDirection.Input)).Value = Convert.ToDecimal(0);
                cmd.Parameters.Add("P_WTMIKTAR", OracleDbType.Decimal);
                cmd.Parameters["P_WTMIKTAR"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WTMIKTAR"].Value = m.MalinMiktari;
                //WTMIKTAR NUMBER,

                // 22 cmd.Parameters.Add(new OracleParameter("WMIKTARBIRIMID", OracleDbType.Int16, System.Data.ParameterDirection.Input)).Value = 0;
                cmd.Parameters.Add("P_WMIKTARBIRIMID", OracleDbType.Int16);
                cmd.Parameters["P_WMIKTARBIRIMID"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WMIKTARBIRIMID"].Value = m.MiktarBirimId;
                //WMIKTARBIRIMID IN NUMBER,

                // 23 cmd.Parameters.Add(new OracleParameter("WIRSTARIH", OracleDbType.Date, System.Data.ParameterDirection.Input)).Value = m.IRSTARIHI;
                cmd.Parameters.Add("P_WIRSTARIH", OracleDbType.Date);
                cmd.Parameters["P_WIRSTARIH"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WIRSTARIH"].Value = m.IRSTARIHI;// .ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                // WIRSTARIH DATE,

                // 24 cmd.Parameters.Add(new OracleParameter("WSTKKOD", OracleDbType.Int32, System.Data.ParameterDirection.Input)).Value = Convert.ToInt32(m.STKKOD);
                cmd.Parameters.Add("P_WSTKKOD", OracleDbType.Int32);
                cmd.Parameters["P_WSTKKOD"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WSTKKOD"].Value = Convert.ToInt32(m.STKKOD);
                // WSTKKOD IN NUMBER,

                // 25 cmd.Parameters.Add(new OracleParameter("WDEPNO", OracleDbType.Int32, System.Data.ParameterDirection.Input)).Value = m.DEPNO;
                cmd.Parameters.Add("P_WDEPNO", OracleDbType.Int16);
                cmd.Parameters["P_WDEPNO"].Direction = ParameterDirection.Input;
                cmd.Parameters["P_WDEPNO"].Value = m.DEPNO;
                // WDEPNO IN NUMBER

                string stringdata = "";
                try
                {
                    cmd.ExecuteNonQuery();
                    stringdata = (string)(((Oracle.ManagedDataAccess.Types.OracleString)cmd.Parameters["WSONUC"].Value).Value);
                    if (stringdata != "0")
                    {
                        result = true;

                        var errorMessage = string.Format("Hata Noktası STKTH011_Pkg.INS_KUNYE2 -232 Tablosu :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, 00, stringdata);
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
                    var errorMessage = string.Format("Hata Noktası STKTH011_Pkg.INS_KUNYE2 -232 Tablosu :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                    logger.Error(errorMessage);
                }
            }

            con.Close();
            return result;
        }
        public IList<Models.EtiketBelgeDepoListe> GetEtiketBelgeListesiDepoBazli(int depno, DateTime tarih)
        {
            IList<Models.EtiketBelgeDepoListe> result = new List<Models.EtiketBelgeDepoListe>();

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT DISTINCT TRUNC (ETKTMH02.TARIH) TARIH,");
            sqlString.AppendLine("                ETKTMH02.DEPNO,");
            sqlString.AppendLine("                GENTM05.AD AS DEPOAD,");
            sqlString.AppendLine("                ETKTMH02.PLAKANO,");
            sqlString.AppendLine("                ETKTMH02.BELGENO,");
            sqlString.AppendLine("                ETKTMH02.ILID,");
            sqlString.AppendLine("                ETKTMH02.ILCEID,");
            sqlString.AppendLine("                ETKTMH02.BELDEID");
            //sqlString.AppendLine("                ETKTMH02.UNIQUEID");
            sqlString.AppendLine("  FROM ETKTMH02,GENTM05");
            sqlString.AppendLine(" WHERE ETKTMH02.DEPNO = GENTM05.DMBNO");
            sqlString.AppendLine("    AND GENTM05.TIP IN ('M','D')");
            sqlString.AppendLine("    AND ETKTMH02.PLAKANO IS NOT NULL ");
            sqlString.AppendLine(string.Format("    AND TRUNC (ETKTMH02.TARIH) = TO_DATE('{0}', 'DD/MM/YYYY')", tarih.ToShortDateString()));
            sqlString.AppendLine(string.Format("    AND ETKTMH02.DEPNO ={0}", depno));

            var con = OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<Models.EtiketBelgeDepoListe>(sqlString.ToString());
                if (sonuc != null)
                {
                    result = (IList<Models.EtiketBelgeDepoListe>)sonuc;
                }
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası GetEtiketBelgeListesiDepoBazli :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public IList<Models.EtiketEkranListe> GetEtiketListesiDepoBazli(int depno, DateTime tarih, string belgeNo)
        {
            IList<Models.EtiketEkranListe> result = new List<Models.EtiketEkranListe>();

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT ETKTMH02.TARIH,");
            sqlString.AppendLine("       ETKTMH02.DEPNO,");
            sqlString.AppendLine("       ETKTMH02.STKKOD,");
            sqlString.AppendLine("       STKTM010.STOKAD,");
            sqlString.AppendLine("       ETKTMH02.KUNYENO,");
            sqlString.AppendLine("       ETKTMH02.MALAD,");
            sqlString.AppendLine("       ETKTMH02.MALCINSAD,");
            sqlString.AppendLine("       ETKTMH02.URETIMTARIH,");
            sqlString.AppendLine("       ETKTMH02.URETIMSEKLI,");
            sqlString.AppendLine("       ETKTMH02.URETIMYERI,");
            sqlString.AppendLine("       SUBSTR( ETKTMH02.URETICI,0,65) AS URETICI,");
            sqlString.AppendLine("       GET_FIYATM3(ETKTMH02.STKKOD,ETKTMH02.DEPNO) SFIYAT,");
            sqlString.AppendLine("       STKTM011_PKG.GET_MBARKOD(ETKTMH02.STKKOD) BARKOD");
            sqlString.AppendLine("  FROM ETKTMH02, STKTM010");
            sqlString.AppendLine(" WHERE     ETKTMH02.STKKOD = STKTM010.STKKOD");
            sqlString.AppendLine("       AND ETKTMH02.PLAKANO IS NOT NULL");
            sqlString.AppendLine("       AND ETKTMH02.BELGENO IS NOT NULL");
            sqlString.AppendLine(string.Format("    AND TRUNC (ETKTMH02.TARIH) = TO_DATE('{0}', 'DD/MM/YYYY')", tarih.ToShortDateString()));
            sqlString.AppendLine(string.Format("    AND ETKTMH02.DEPNO ={0}", depno));
            sqlString.AppendLine(string.Format("AND ETKTMH02.BELGENO = '{0}'", belgeNo));


            var con = OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<Models.EtiketEkranListe>(sqlString.ToString());
                if (sonuc != null)
                {
                    result = (IList<Models.EtiketEkranListe>)sonuc;
                }
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası GetEtiketListesiDepoBazli :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }
            if (result != null)
            {
                return result;
            }

            return result;
        }
        public IList<Models.EtiketEkranListe> GetEkitekKontrolListesi(DateTime tarih,int DepNo)
        {
            IList<Models.EtiketEkranListe> result = new List<Models.EtiketEkranListe>();

            var sqlString = new StringBuilder();
            sqlString.AppendLine("SELECT ETKTMH02.TARIH,");
            sqlString.AppendLine("       ETKTMH02.DEPNO,");
            sqlString.AppendLine("       ETKTMH02.STKKOD,");
            sqlString.AppendLine("       STKTM010.STOKAD,");
            sqlString.AppendLine("       ETKTMH02.KUNYENO,");
            sqlString.AppendLine("       ETKTMH02.MALAD,");
            sqlString.AppendLine("       ETKTMH02.MALCINSAD,");
            sqlString.AppendLine("       ETKTMH02.URETIMTARIH,");
            sqlString.AppendLine("       ETKTMH02.URETIMSEKLI,");
            sqlString.AppendLine("       ETKTMH02.URETIMYERI,");
            sqlString.AppendLine("       SUBSTR( ETKTMH02.URETICI,0,65) AS URETICI,");
            sqlString.AppendLine("       GET_FIYATM3(ETKTMH02.STKKOD,ETKTMH02.DEPNO) SFIYAT,");
            sqlString.AppendLine("       STKTM011_PKG.GET_MBARKOD(ETKTMH02.STKKOD) BARKOD");
            sqlString.AppendLine("  FROM ETKTMH02, STKTM010");
            sqlString.AppendLine(" WHERE     ETKTMH02.STKKOD = STKTM010.STKKOD");
            sqlString.AppendLine("       AND ETKTMH02.PLAKANO IS NOT NULL");
            sqlString.AppendLine("       AND ETKTMH02.BELGENO IS NOT NULL");
            sqlString.AppendLine(string.Format("    AND TRUNC (ETKTMH02.TARIH) = TO_DATE('{0}', 'DD/MM/YYYY')", tarih.ToShortDateString()));
            sqlString.AppendLine(string.Format("    AND ETKTMH02.DEPNO ={0}", DepNo));


            var con = OracleDb.GetOrclConn();
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                var sonuc = con.Query<Models.EtiketEkranListe>(sqlString.ToString());
                if (sonuc != null)
                {
                    result = (IList<Models.EtiketEkranListe>)sonuc;
                }
            }
            catch (OracleException e)
            {
                var errorMessage = string.Format("Hata Noktası GetEtiketListesiDepoBazli :{0} Hata Kodu : {1} Hata Bilgisi: {2}", MethodBase.GetCurrentMethod().DeclaringType, e.ErrorCode, e.Message);
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                logger.Error(errorMessage);
            }
            finally
            {
                con.Close();
            }
            if (result != null)
            {
                return result;
            }

            return result;
        }
    }
}
