using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OmegaHKS.BildirimServiceReference;
using OmegaHKS.GenelServiceReference;
using System.Threading;
using NLog;
using System.Text;

namespace OmegaHKS.Views.LocalHKSUpdate
{
    public partial class frmBildirimYardimciBilgileri : BaseForm
    {
        //private bool islem = false;
        private Guid PidID;
        Logger logger = LogManager.GetCurrentClassLogger();

        public frmBildirimYardimciBilgileri()
        {
            InitializeComponent();


            InitWebService();
            InitDTGDoldur();

            //islem = true;
            PidID = Guid.NewGuid();
        }

        private void InitWebService()
        {
            if (!Helpers.GenerelHelper.IsConnected())
            {
                Helpers.MessageHelper.ShowInformation("İşlemleri Tamamlayabilmek İçin İnternet Erişimi Olması Gerekir İşlemler İptal Ediliyor..!");
                return;
            }
            try
            {
                var isSucc = false;
                var sifatListesi = new List<SifatDTO>();
                sifatListesi = GetSifatDTOListesi(out isSucc);
                if (!isSucc)
                {
                    return;
                }
                bsSifatDTO.DataSource = sifatListesi;
                bsBelgeTipiDTO.DataSource = GetBelgeTipiDTOList();
                bsBildirimTuruDTO.DataSource = GetBildirimTuruDTOList();
                bsIsletmeTuruDTO.DataSource = GetIsletmeTuruDTOList();
            }
            finally
            {
                /// Cursor.Current = Cursors.Default;
            }
        }


        private void InitDTGDoldur()
        {
            dgcBelgeTipiDTO.DataSource = bsBelgeTipiDTO;
            dgcBildirimTuruDTO.DataSource = bsBildirimTuruDTO;
            dgcIsletmeTuruDTO.DataSource = bsIsletmeTuruDTO;
            dgcSifatDTO.DataSource = bsSifatDTO;
        }

        private List<SifatDTO> GetSifatDTOListesi(out bool isSuccess)
        {
            var result = new List<SifatDTO>();
            isSuccess = false;
            using (var proxy = new BildirimServiceReference.BildirimServiceClient())
            {
                var istek = new BildirimServiceReference.BaseRequestMessageOf_SifatIstek()
                { UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                    Password = Core.StaticDegiskenler.webServiceUser.Password,
                    ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                    Istek = new BildirimServiceReference.SifatIstek() { } };
                var cevap = proxy.BildirimServisSifatListesi(istek);

                if (cevap.IslemKodu == ServiceConstants.Global.ServisIslemBasarili)
                {
                    result = cevap.Sonuc.Sifatlar;
                    isSuccess = true;
                }
                else
                {
                    if (cevap.Sonuc != null)
                    {
                        if (cevap.Sonuc.HataKodu != 0)
                        {
                            // MessageBox.Show(string.Format("Hata Kodu : {0}, Hata Mesajı : {1}\r\n", cevap.Sonuc.HataKodu, cevap.Sonuc.Mesaj));
                            Helpers.MessageHelper.ShowError(string.Format("Hata Kodu : {0}, Hata Mesajı : {1}\r\n", cevap.Sonuc.HataKodu, cevap.Sonuc.Mesaj));

                            Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = string.Format("Hata Kodu : {0}, Hata Mesajı : {1}\r\n", cevap.Sonuc.HataKodu, cevap.Sonuc.Mesaj) });
                            Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = string.Format("Hata Kodu : {0}, Hata Mesajı : {1}\r\n", cevap.Sonuc.HataKodu, cevap.Sonuc.Mesaj) });
                            logger.Error(string.Format("Hata Kodu : {0}, Hata Mesajı : {1}\r\n", cevap.Sonuc.HataKodu, cevap.Sonuc.Mesaj));

                        }
                    }

                    else if(cevap.HataKodlari != null && cevap.HataKodlari.Count > 0)
                    {
                        var sb = new StringBuilder();
                        foreach (var item in cevap.HataKodlari)
                        {
                            sb.AppendLine(string.Format("Hata Kodu :{0} Hata Mesajı :{1}", item.HataKodu, item.Mesaj));
                        }

                        Helpers.MessageHelper.ShowError(sb.ToString());

                        Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                        Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                        logger.Error(sb.ToString());
                    }
                }
            }
            return result;
        }

        private List<BildirimTuruDTO> GetBildirimTuruDTOList()
        {
            var result = new List<BildirimTuruDTO>();

            using (var proxy = new BildirimServiceReference.BildirimServiceClient())
            {
                var istek = new BildirimServiceReference.BaseRequestMessageOf_BildirimTurleriIstek()
                { UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                    Password = Core.StaticDegiskenler.webServiceUser.Password,
                    ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                    Istek = new BildirimServiceReference.BildirimTurleriIstek() { } };
                var cevap = proxy.BildirimServisBildirimTurleri(istek);

                if (cevap.HataKodlari != null && cevap.HataKodlari.Count > 0)
                {
                    var sb = new StringBuilder();
                    foreach (var item in cevap.HataKodlari)
                    {
                        sb.AppendLine(string.Format("Hata Kodu :{0} Hata Mesajı :{1}", item.HataKodu, item.Mesaj));
                    }

                    Helpers.MessageHelper.ShowError(sb.ToString());

                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                    logger.Error(sb.ToString());
                }
                else
                {
                    logger.Info("HKS Web Service Okuma İşlemi Bitti");
                    result = cevap.Sonuc.BildirimTurleri;
                }
            }
            return result;
        }

        private List<BelgeTipiDTO> GetBelgeTipiDTOList()
        {
            var result = new List<BelgeTipiDTO>();

            using (var proxy = new BildirimServiceReference.BildirimServiceClient())
            {
                var istek = new BildirimServiceReference.BaseRequestMessageOf_BelgeTipleriIstek()
                { UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                    Password = Core.StaticDegiskenler.webServiceUser.Password,
                    ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                    Istek = new BildirimServiceReference.BelgeTipleriIstek() { } };
                var cevap = proxy.BildirimServisBelgeTipleriListesi(istek);

                if (cevap.HataKodlari != null && cevap.HataKodlari.Count > 0)
                {
                    var sb = new StringBuilder();
                    foreach (var item in cevap.HataKodlari)
                    {
                        sb.AppendLine(string.Format("Hata Kodu :{0} Hata Mesajı :{1}", item.HataKodu, item.Mesaj));
                    }

                    Helpers.MessageHelper.ShowError(sb.ToString());

                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                    logger.Error(sb.ToString());
                }
                else
                {
                    logger.Info("HKS Web Service Okuma İşlemi Bitti");
                    result = cevap.Sonuc.BelgeTipleri;
                }
            }
            return result;
        }

        private List<IsletmeTuruDTO> GetIsletmeTuruDTOList()
        {
            var result = new List<IsletmeTuruDTO>();

            using (var proxy = new GenelServiceReference.GenelServiceClient())
            {
                var  istek = new GenelServiceReference.BaseRequestMessageOf_IsletmeTurleriIstek()
                { UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                    Password = Core.StaticDegiskenler.webServiceUser.Password,
                    ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                    Istek = new GenelServiceReference.IsletmeTurleriIstek() { } };
                var cevap = proxy.GenelServisIsletmeTurleri(istek);

                if (cevap.HataKodlari != null && cevap.HataKodlari.Count > 0)
                {
                    var sb = new StringBuilder();
                    foreach (var item in cevap.HataKodlari)
                    {
                        sb.AppendLine(string.Format("Hata Kodu :{0} Hata Mesajı :{1}", item.HataKodu, item.Mesaj));
                    }

                    Helpers.MessageHelper.ShowError(sb.ToString());

                    Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                    Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = sb.ToString() });
                    logger.Error(sb.ToString());
                }
                else
                {
                    logger.Info("HKS Web Service Okuma İşlemi Bitti");
                    result = cevap.Sonuc.IsletmeTurleri;
                }
            }
            return result;
        }

        private void OracleDbKayitGuncele()
        {
            var SifatDTOList = bsSifatDTO.List as List<SifatDTO>;
            var BildirimTuruDTOList = bsBildirimTuruDTO.List as List<BildirimTuruDTO>;
            var BelgeTipiDTOList = bsBelgeTipiDTO.List as List<BelgeTipiDTO>;
            var IsletmeTuruDTOList = bsIsletmeTuruDTO.List as List<IsletmeTuruDTO>;

            var localUpdateController = new Controllers.LocalHKSUpdateController();

            var sonucSifat = localUpdateController.LocalSifatDTOEkleGuncelle(SifatDTOList);
            var sonucBildirimTuru = localUpdateController.LocalBildirimTuruDTOEkleGuncelle(BildirimTuruDTOList);
            var sonucBelgeTipi = localUpdateController.LocalBelgeTipiDTOEkleGuncelle(BelgeTipiDTOList);
            var sonucIsletmeTuru = localUpdateController.LocalIsletmeTuruDTOEkleGuncelle(IsletmeTuruDTOList);

            if (sonucSifat && sonucBildirimTuru && sonucBelgeTipi && sonucIsletmeTuru)
            {
                Helpers.MessageHelper.ShowInformation("Yardimci Tanımlar Güncellendi veya Eklendi ..!");

                Core.StaticDegiskenler.AnlikIslem.Islem = false;
                Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();
            }
            else
            {
                Helpers.MessageHelper.ShowError("İşelem Başarısız Oldu");
            }
        }

        private void ucsBTNGuncelle1_ClickGuncelle(object sender, EventArgs e)
        {
            if (!Core.StaticDegiskenler.AnlikIslem.Islem)
            {
                PidID = Guid.NewGuid();
                Core.StaticDegiskenler.AnlikIslem.IslemPidId = PidID;
                Core.StaticDegiskenler.AnlikIslem.Islem = true;

                var thread = new Thread(() => OracleDbKayitGuncele());
                thread.Start();
            }
            else
            {
                Helpers.MessageHelper.ShowError("Devam eden işlem var işlemin bitmesini bekleyin lütfen ...!");
            }
        }

        private void ucsBTNGuncelle1_ClickKapat(object sender, EventArgs e)
        {
            if (Core.StaticDegiskenler.AnlikIslem.IslemPidId != PidID)
            {
                Close();
            }
            else
            {
                Helpers.MessageHelper.ShowError("Devam eden işlem var işlemin bitmesini bekleyin lütfen ...!");
            }
        }
    }
}
