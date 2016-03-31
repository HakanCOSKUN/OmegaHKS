using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OmegaHKS.GenelServiceReference;
using System.Threading;
using NLog;
using System.Text;

namespace OmegaHKS.Views.LocalHKSUpdate
{
    public partial class frmLokasyon : BaseForm
    {
        private bool islem = false;
        private Guid PidID;
        private Logger logger = LogManager.GetCurrentClassLogger();
        public frmLokasyon()
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
                var ulkeDTOList = GetUlkeDTOList();
                var ilDTOList = GetIlDTOList();
                bsUlkeDTO.DataSource = ulkeDTOList;
                bsIlDTO.DataSource = ilDTOList;
            }
            finally
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
            }
        }

        private void InitDTGDoldur()
        {
            dgcUlkeDTO.DataSource = bsUlkeDTO;
            dgcIlDTO.DataSource = bsIlDTO;
        }

        private List<UlkeDTO> GetUlkeDTOList()
        {
            var result = new List<UlkeDTO>();

            using (var proxy = new GenelServiceReference.GenelServiceClient())
            {
                var istek = new GenelServiceReference.BaseRequestMessageOf_UlkelerIstek()
                { UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                    Password = Core.StaticDegiskenler.webServiceUser.Password,
                    ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                    Istek = new GenelServiceReference.UlkelerIstek() { } };
                var cevap = proxy.GenelServisUlkeler(istek);
                // result = cevap.Sonuc.Ulkeler;



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
                    result = cevap.Sonuc.Ulkeler;
                }

            }
            return result;
        }

        private List<IlDTO> GetIlDTOList()
        {
            var result = new List<IlDTO>();
            using (var proxy = new GenelServiceReference.GenelServiceClient())
            {
                var istek = new GenelServiceReference.BaseRequestMessageOf_IllerIstek()
                { UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                    Password = Core.StaticDegiskenler.webServiceUser.Password,
                    ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                    Istek = new GenelServiceReference.IllerIstek() { } };
                var cevap = proxy.GenelServisIller(istek);
                //result = cevap.Sonuc.Iller;



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
                    result = cevap.Sonuc.Iller;
                }
            }
            return result;
        }

        private List<IlceDTO> GetIlceDTOList(int ilId)
        {
            var result = new List<IlceDTO>();
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                using (var proxy = new GenelServiceReference.GenelServiceClient())
                {
                    var istek = new GenelServiceReference.BaseRequestMessageOf_IlcelerIstek()
                    { UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                        Password = Core.StaticDegiskenler.webServiceUser.Password,
                        ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                        Istek = new GenelServiceReference.IlcelerIstek() { IlId = ilId } };
                    var cevap = proxy.GenelServisIlceler(istek);
                    result = cevap.Sonuc.Ilceler;
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            return result;
        }

        private List<BeldeDTO> GetBeldeDTOList(int ilceId)
        {
            var result = new List<BeldeDTO>();
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                using (var proxy = new GenelServiceReference.GenelServiceClient())
                {
                    var istek = new GenelServiceReference.BaseRequestMessageOf_BeldelerIstek()
                    { UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                        Password = Core.StaticDegiskenler.webServiceUser.Password,
                        ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                        Istek = new GenelServiceReference.BeldelerIstek() { IlceId = ilceId } };
                    var cevap = proxy.GenelServisBeldeler(istek);

                    result = cevap.Sonuc.Beldeler;
                }
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            return result;
        }

        private void ScreenActivity(Models.IslemSayac islemSayac)
        {
            ucsBTNGuncelle1.ProgressValue = islemSayac.Sayac;
            ucsBTNGuncelle1.ProgressTextYazi = islemSayac.Text;
        }

        private void OracleDbKayitGuncele()
        {
            var ulkelerList = bsUlkeDTO.List as List<UlkeDTO>;
            var sehirlerList = bsIlDTO.List as List<IlDTO>;

            if (ulkelerList.Count > 0)
            {
                var usibController1 = new Controllers.LocalHKSUpdateController();

                var thread1 = new Thread(() => usibController1.LocalUlkeDTOEkleGuncelle(ulkelerList));
                thread1.Start();
            }

            if (sehirlerList.Count > 0)
            {
                var i = 0;
                ucsBTNGuncelle1.ProgressBarControlMaxValue = sehirlerList.Count;
                ucsBTNGuncelle1.ProgressBarControlStep = 1;

                var usibController2 = new Controllers.LocalHKSUpdateController();
                var thread2 = new Thread(() => usibController2.LocalIlDTOEkleGuncelle(sehirlerList));
                thread2.Start();

                foreach (var s in sehirlerList)
                {
                    ScreenActivity(new Models.IslemSayac() { Sayac = i++, Text = s.IlAdi });

                    List<IlceDTO> ilcelerList = null;
                    ilcelerList = GetIlceDTOList(s.Id);

                    List<Models.LocalIlceDTO> localIlcelerList = new List<Models.LocalIlceDTO>();
                    foreach (var ii in ilcelerList)
                    {
                        localIlcelerList.Add( new Models.LocalIlceDTO { IlId = s.Id, Id = ii.Id , IlceAdi = ii.IlceAdi});
                    }

                    if (localIlcelerList.Count > 0)
                    {
                        var thread3 = new Thread(() => usibController2.LocalIlceDTOEkleGuncelle(localIlcelerList));
                        thread3.Start();
                        ScreenActivity(new Models.IslemSayac() { Sayac = i, Text = s.IlAdi });

                        foreach (var iii in localIlcelerList)
                        {
                            ScreenActivity(new Models.IslemSayac() { Sayac = i, Text = string.Format("{0} {1}", s.IlAdi, iii.IlceAdi) });


                            List<BeldeDTO> beldeList = null;
                            beldeList = GetBeldeDTOList(iii.Id);

                            if (beldeList.Count > 0)
                            {
                                List<Models.LocalBeldeDTO> lolcalBeldeListesi = new List<Models.LocalBeldeDTO>();
                                foreach (var bl in beldeList)
                                {
                                    lolcalBeldeListesi.Add(new Models.LocalBeldeDTO { IlId = s.Id, IlceId = iii.Id, Id = bl.Id, BeldeAdi = bl.BeldeAdi });
                                }

                                var usibController4 = new Controllers.LocalHKSUpdateController();
                                var thread4 = new Thread(() => usibController4.LocalBeldeDTOEkleGuncelle(lolcalBeldeListesi));
                                thread4.Start();
                            }
                            ScreenActivity(new Models.IslemSayac() { Sayac = i, Text = string.Format("{0} {1}", s.IlAdi, iii.IlceAdi) });
                        }
                    }
                }
            }

            Core.StaticDegiskenler.AnlikIslem.Islem = false;
            Core.StaticDegiskenler.AnlikIslem.IslemPidId = Guid.NewGuid();
            Helpers.MessageHelper.ShowInformation("İşlem Başarı İle Tamamlandı !!!");
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

        private void frmLokasyon_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgvIlDTO_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (dgvIlDTO.FocusedRowHandle >= 0 && islem)
            {
                var secilen = dgvIlDTO.GetFocusedItem<IlDTO>();
                if (secilen.Id == 0)
                {
                    bsIlceDTO.DataSource = GetIlceDTOList(secilen.Id);
                }
                else
                {
                    bsIlceDTO.DataSource = GetIlceDTOList(secilen.Id);
                }
                dgcIlceDTO.DataSource = bsIlceDTO;

                bsBeldeDTO.DataSource = null;
                dgcBeldeDTO.DataSource = bsBeldeDTO;
            }
        }

        private void dgvIlceDTO_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (dgvIlceDTO.FocusedRowHandle >= 0 && islem)
            {
                var secilen = dgvIlceDTO.GetFocusedItem<IlceDTO>();
                if (secilen.Id == 0)
                {
                    bsBeldeDTO.DataSource = GetBeldeDTOList(secilen.Id);
                }
                else
                {
                    bsBeldeDTO.DataSource = GetBeldeDTOList(secilen.Id);
                }
                dgcBeldeDTO.DataSource = bsBeldeDTO;
            }
        }
    }
}
