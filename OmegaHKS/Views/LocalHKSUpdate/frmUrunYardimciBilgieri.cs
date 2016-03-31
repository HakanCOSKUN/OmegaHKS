using System;
using System.Collections.Generic;
using System.Linq;
using OmegaHKS.UrunServiceReference;
using System.Threading;
using NLog;
using System.Text;

namespace OmegaHKS.Views.LocalHKSUpdate
{
    public partial class frmUrunYardimciBilgieri : BaseForm
    {
        //private bool islem = false;
        private Guid PidID;
        Logger logger = LogManager.GetCurrentClassLogger();
        public frmUrunYardimciBilgieri()
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
                bsUrunBirimiDTO.DataSource = GetUrunBirimiDTOList();
                bsUretimSekliDTO.DataSource = GetUretimSekliDTOList();
                bsMalinNiteligiDTO.DataSource = GetMalinNiteligiDTOList();
            }
            finally
            {
                /// Cursor.Current = Cursors.Default;
            }
        }


        private void InitDTGDoldur()
        {
            dgcUrunBirimiDTO.DataSource = bsUrunBirimiDTO;
            dgcUretimSekliDTO.DataSource = bsUretimSekliDTO;
            dgcMalinNiteligiDTO.DataSource = bsMalinNiteligiDTO;
        }

        private List<UrunBirimiDTO> GetUrunBirimiDTOList()
        {
            var result = new List<UrunBirimiDTO>();

            using (var proxy = new UrunServiceReference.UrunServiceClient())
            {
                var istek = new UrunServiceReference.BaseRequestMessageOf_UrunBirimleriIstek()
                { UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                    Password = Core.StaticDegiskenler.webServiceUser.Password,
                    ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                    Istek = new UrunServiceReference.UrunBirimleriIstek() { } };
                var cevap = proxy.UrunServiceUrunBirimleri(istek);
                // result = cevap.Sonuc.UrunBirimleri;


                logger.Info("HKS Web Service Okuma İşlemi Başlatıldı");

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
                    result = cevap.Sonuc.UrunBirimleri;
                }


            }
            return result;
        }

        private List<UretimSekliDTO> GetUretimSekliDTOList()
        {
            var result = new List<UretimSekliDTO>();

            using (var proxy = new UrunServiceReference.UrunServiceClient())
            {
                var istek = new UrunServiceReference.BaseRequestMessageOf_UretimSekilleriIstek()
                { UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                    Password = Core.StaticDegiskenler.webServiceUser.Password,
                    ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                    Istek = new UrunServiceReference.UretimSekilleriIstek() { } };
                var cevap = proxy.UrunServiceUretimSekilleri(istek);
                // result = cevap.Sonuc.UretimSekilleri;

                logger.Info("HKS Web Service Okuma İşlemi Başlatıldı");

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
                    result = cevap.Sonuc.UretimSekilleri;
                }
            }
            return result;
        }

        private List<MalinNiteligiDTO> GetMalinNiteligiDTOList()
        {
            var result = new List<MalinNiteligiDTO>();

            using (var proxy = new UrunServiceReference.UrunServiceClient())
            {
                var istek = new UrunServiceReference.BaseRequestMessageOf_MalinNiteligiIstek()
                { UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                    Password = Core.StaticDegiskenler.webServiceUser.Password,
                    ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                    Istek = new UrunServiceReference.MalinNiteligiIstek() { } };
                var cevap = proxy.UrunServiceMalinNiteligi(istek);
                // result = cevap.Sonuc.MalinNitelikleri;

                logger.Info("HKS Web Service Okuma İşlemi Başlatıldı");

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
                    result = cevap.Sonuc.MalinNitelikleri;
                }
            }
            return result;
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

        private void OracleDbKayitGuncele()
        {
            var UrunBirimiDTOList = bsUrunBirimiDTO.List as List<UrunBirimiDTO>;
            var MalinNiteligiDTOList = bsMalinNiteligiDTO.List as List<MalinNiteligiDTO>;
            var UretimSekliDTOList = bsUretimSekliDTO.List as List<UretimSekliDTO>;

            var localUpdateController = new Controllers.LocalHKSUpdateController();

            var sonucUrunBirimi = localUpdateController.LocalUrunBirimiDTOEkleGuncelle(UrunBirimiDTOList);
            var sonucUretimSekli = localUpdateController.LocalUretimSekliDTOEkleGuncelle(UretimSekliDTOList);
            var sonucMalNiteligi = localUpdateController.LocalMalinNiteligiDTOEkleGuncelle(MalinNiteligiDTOList);

            if (sonucMalNiteligi && sonucUrunBirimi && sonucUretimSekli)
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
    }
}
