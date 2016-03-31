using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OmegaHKS.UrunServiceReference;
using System.Threading;
using System.Text;
using NLog;

namespace OmegaHKS.Views.LocalHKSUpdate
{
    public partial class frmUrunBilgileri : BaseForm
    {
        private bool islem = false;
        private Guid PidID;
        Logger logger = LogManager.GetCurrentClassLogger();
        public frmUrunBilgileri()
        {
            InitializeComponent();

            InitWebService();
            InitDTGDoldur();

            islem = true;
            PidID = Guid.NewGuid();
        }

        private void InitWebService()
        {
            if (!Helpers.GenerelHelper.IsConnected())
            {
                Helpers.MessageHelper.ShowInformation("İşlemleri Tamamlayabilmek İçin İnternet Erişimi Olması Gerekir İşlemler İptal Ediliyor..!");
                return;
            }
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Views.Main.WaitForm));
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption("Lütfen bekleyiniz..");
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("HKS Sisteminden Veriler Okunuyor...");
            try
            {
                bsUrunDTO.DataSource = GetUrunDTOList();
                bsUrunCinsiDTO.DataSource = GetDefaultUrunCinsiDTO();
            }
            finally
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            }
        }
        private void InitDTGDoldur()
        {
            dgcUrunDTO.DataSource = bsUrunDTO;
            dgcUrunCinsiDTO.DataSource = bsUrunCinsiDTO;
        }
        private List<UrunDTO> GetUrunDTOList()
        {
            var result = new List<UrunDTO>();

            using (var proxy = new UrunServiceReference.UrunServiceClient())
            {
                var istek = new UrunServiceReference.BaseRequestMessageOf_UrunlerIstek()
                { UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                    Password = Core.StaticDegiskenler.webServiceUser.Password,
                    ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                    Istek = new UrunServiceReference.UrunlerIstek() { } };
                var cevap = proxy.UrunServiceUrunler(istek);
                // result = cevap.Sonuc.Urunler;

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
                    result = cevap.Sonuc.Urunler;
                }

            }
            return result;
        }
        private List<UrunCinsiDTO> GetDefaultUrunCinsiDTO()
        {
            return new List<UrunCinsiDTO>() { new UrunCinsiDTO() { Id = 0, UrunCinsiAdi = "Seçiniz" } };
        }
        private List<UrunCinsiDTO> GetUrunCinsiDTOList(int urunId)
        {
            var result = new List<UrunCinsiDTO>();
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (var proxy = new UrunServiceReference.UrunServiceClient())
                {
                    var istek = new UrunServiceReference.BaseRequestMessageOf_UrunCinsleriIstek()
                    { UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                        Password = Core.StaticDegiskenler.webServiceUser.Password,
                        ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                        Istek = new UrunServiceReference.UrunCinsleriIstek() { UrunId = urunId } };
                    var cevap = proxy.UrunServiceUrunCinsleri(istek);
                    //result = cevap.Sonuc.UrunCinsleri;


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
                        result = cevap.Sonuc.UrunCinsleri;
                    }



                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            return result;
        }
        private void dgvUrunDTO_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (dgvUrunDTO.FocusedRowHandle >= 0 && islem)
            {
                var secilen = dgvUrunDTO.GetFocusedItem<UrunDTO>();
                if (secilen.Id == 0)
                {
                    bsUrunCinsiDTO.DataSource = GetDefaultUrunCinsiDTO();
                }
                else
                {
                    bsUrunCinsiDTO.DataSource = GetUrunCinsiDTOList(secilen.Id);
                }
                dgcUrunCinsiDTO.DataSource = bsUrunCinsiDTO;
            }
        }
        private void ScreenActivity(Models.IslemSayac islem)
        {
            ucsBTNGuncelle1.ProgressValue = islem.Sayac;
            ucsBTNGuncelle1.ProgressTextYazi = islem.Text;
        }
        private void OracleDbKayitGuncele()
        {
            var urunler = bsUrunDTO.List as List<UrunDTO>;

            var i = -1;
            if (urunler.Count > 0)
            {
                ucsBTNGuncelle1.ProgressBarControlMaxValue = urunler.Count;
                ucsBTNGuncelle1.ProgressBarControlStep = 1;

                var stokController1 = new Controllers.LocalHKSUpdateController();
                var thread1 = new Thread(() => stokController1.LocalUrunDTOEkleGuncelle(urunler));
                thread1.Start();

                foreach (var u in urunler)
                {
                    ScreenActivity(new Models.IslemSayac() { Sayac = i++, Text = u.UrunAdi });

                    List<UrunCinsiDTO> urunCinsleri = null;
                    urunCinsleri = GetUrunCinsiDTOList(u.Id);

                    if (urunCinsleri.Count > 0)
                    {
                        var stokController2 = new Controllers.LocalHKSUpdateController();
                        var thread2 = new Thread(() => stokController2.LocalUrunCinsiDTOEkleGuncelle(urunCinsleri));
                        thread2.Start();
                    }
                }
            }
            Core.StaticDegiskenler.AnlikIslem.Islem = false;
            Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();

            Helpers.MessageHelper.ShowInformation("İşlem Başarı İle Tamamlandı !!!");

        }
        private void frmUrunBilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Core.StaticDegiskenler.AnlikIslem.IslemPidId != PidID)
            {
                e.Cancel = false;
            }
            else
            {
                Helpers.MessageHelper.ShowError("Devam eden işlem var işlemin bitmesini bekleyin lütfen ...!");
                e.Cancel = true;
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
        private void ucsBTNGuncelle1_ClickGuncelle(object sender, EventArgs e)
        {
            if (!Core.StaticDegiskenler.AnlikIslem.Islem)
            {
                PidID = Guid.NewGuid();
                Core.StaticDegiskenler.AnlikIslem.IslemPidId = PidID;
                Core.StaticDegiskenler.AnlikIslem.Islem = true;
                ucsBTNGuncelle1.ProgressBarControllVisible = true;
                ucsBTNGuncelle1.ProgressTextVisible = true;
                ucsBTNGuncelle1.ProgressTextYazi = null;
                ucsBTNGuncelle1.ProgressBarControlStep = 0;
                ucsBTNGuncelle1.ProgressValue = 0;
                ucsBTNGuncelle1.ProgressBarControlPosition = 0;

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
