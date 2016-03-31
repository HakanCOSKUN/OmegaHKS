using NLog;
using OmegaHKS.BildirimServiceReference;
using OmegaHKS.GenelServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace OmegaHKS.Views.Aktarim
{
    public partial class frmNihaiBildirimler : BaseForm
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        private bool islem = false;
        private Guid PidID;
        public frmNihaiBildirimler()
        {
            InitializeComponent();

            InitScreen();


            PidID = Guid.NewGuid();
        }

        private void InitScreen()
        {
            dtBaslangicTarihi.EditValue = DateTime.Now;
            dtBitisTarihi.EditValue = DateTime.Now;

            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Views.Main.WaitForm));
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption("Lütfen bekleyiniz..");
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("HKS Sisteminden Veriler Okunuyor...");

            bsSubeler.DataSource = GetSubeDTO();
            belgeTipiDTOBindingSource.DataSource = GetBelgeTipiDTOList();
            isletmeTuruDTOBindingSource.DataSource = GetIsletmeTuruDTOList();
            bildirimTuruDTOBindingSource.DataSource = GetBildirimTuruDTOList();

            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }

        private IList<SubeDTO> GetSubeDTO()
        {
            logger.Error("HKS Web Service Okumaya İstek Hazırla");
            if (!Helpers.GenerelHelper.IsConnected())
            {
                Helpers.MessageHelper.ShowInformation("İşlemleri Tamamlayabilmek İçin İnternet Erişimi Olması Gerekir İşlemler İptal Ediliyor..!");
                return null;
            }
            var result = new List<SubeDTO>();
            try
            {
                using (var proxy = new GenelServiceReference.GenelServiceClient())
                {
                    var istek = new GenelServiceReference.BaseRequestMessageOf_SubelerIstek()
                    {
                        UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                        Password = Core.StaticDegiskenler.webServiceUser.Password,
                        ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                        Istek = new GenelServiceReference.SubelerIstek() { TcKimlikVergiNo = Core.StaticDegiskenler.webServiceUser.UserName }
                    };
                    logger.Info("HKS Web Service Okumaya Başladı");
                    var cevap = proxy.GenelServisSubeler(istek);

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
                        result = cevap.Sonuc.Subeler;
                    }
                }
            }
            catch (Exception e)
            {
                var errorMessage = string.Format("Hata Yeri : {0}\nHata Bilgisi: {1} {2}", e.StackTrace, e.Message, MethodBase.GetCurrentMethod().DeclaringType);
                logger.Error(errorMessage);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = errorMessage });
            }
            return result;
        }

        private List<BildirimTuruDTO> GetBildirimTuruDTOList()
        {
            var result = new List<BildirimTuruDTO>();

            using (var proxy = new BildirimServiceReference.BildirimServiceClient())
            {
                var istek = new BildirimServiceReference.BaseRequestMessageOf_BildirimTurleriIstek()
                {
                    UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                    Password = Core.StaticDegiskenler.webServiceUser.Password,
                    ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                    Istek = new BildirimServiceReference.BildirimTurleriIstek() { }
                };
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
                {
                    UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                    Password = Core.StaticDegiskenler.webServiceUser.Password,
                    ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                    Istek = new BildirimServiceReference.BelgeTipleriIstek() { }
                };
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
                var istek = new GenelServiceReference.BaseRequestMessageOf_IsletmeTurleriIstek()
                {
                    UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                    Password = Core.StaticDegiskenler.webServiceUser.Password,
                    ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                    Istek = new GenelServiceReference.IsletmeTurleriIstek() { }
                };
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

        private void btnNihaiBildirimSorgula_Click(object sender, EventArgs e)
        {
            BildirimServiceReference.BaseResponseMessageOf_BildirimSorguCevap cevap = null;

            var istek = new BildirimServiceReference.BaseRequestMessageOf_BildirimSorguIstek()
            {
                UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                Password = Core.StaticDegiskenler.webServiceUser.Password,
                ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                Istek = new BildirimServiceReference.BildirimSorguIstek()
                {
                    KunyeTuru = 2,
                    KunyeNo = Convert.ToInt64(txtKunyeNo.Text),
                    BaslangicTarihi = Convert.ToDateTime(dtBaslangicTarihi.Text),
                    BitisTarihi = Convert.ToDateTime(dtBitisTarihi.Text),
                    KalanMiktariSifirdanBuyukOlanlar = chkKalanMiktariSifirdanBuyukOlanlar.Checked,
                }
            };


            try
            {
                islem = true;
                DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(Views.Main.WaitForm));
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption("Lütfen bekleyiniz..");
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("HKS Sisteminden Veriler Okunuyor...");

                if (!Helpers.GenerelHelper.IsConnected())
                {
                    Helpers.MessageHelper.ShowInformation("İşlemleri Tamamlayabilmek İçin İnternet Erişimi Olması Gerekir İşlemler İptal Ediliyor..!");
                    return;
                }

                using (var proxy = new BildirimServiceReference.BildirimServiceClient())
                {
                    cevap = proxy.BildirimServisBildirimSorgu(istek);
                }
            }
            finally
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
                islem = false;
            }
            if (cevap.Sonuc != null)
            {
                if ((cevap.Sonuc.HataKodu == 0))
                {
                    bsBidirimler.DataSource = cevap.Sonuc.Bildirimler;
                    dgcKunyeListeleri.DataSource = bsBidirimler;
                }
                else
                {
                    Helpers.MessageHelper.ShowError(string.Format("Hata Kodu : {0}, Hata Mesajı : {1}", cevap.Sonuc.HataKodu, cevap.Sonuc.Mesaj));
                }
            }
            else
            {
                if (cevap.HataKodlari != null)
                {
                    Helpers.MessageHelper.ShowError(string.Format("Hata Kodu : {0}, Hata Mesajı : {1}", cevap.HataKodlari[0].HataKodu, cevap.HataKodlari[0].Mesaj));
                }
                else
                {
                    Helpers.MessageHelper.ShowError(cevap.IslemKodu);
                }
            }
        }

        private void frmNihaiBildirimler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!islem)
            {
                e.Cancel = false;
            }
            else
            {
                Helpers.MessageHelper.ShowError("Devam eden işlem var işlemin bitmesini bekleyin lütfen ...!");
                e.Cancel = true;
            }
        }

        private void ucsBTNKayitIpal1_ClickIptal(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvKunyeListeleri_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvKunyeListeleri.RowCount > 0)
            {
                dgcKunyeListeleri.ContextMenuStrip = contextMenuStripExcell;
            }
        }

        private void exportToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvKunyeListeleri.RowCount > 0)
                dgvKunyeListeleri.ExcellAktar();
        }

        private void printViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvKunyeListeleri.ShowPrintPreview();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvKunyeListeleri.RowCount > 0)
                dgvKunyeListeleri.PrintDialog();
        }

        private void barBtnExportToFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dgvKunyeListeleri.RowCount > 0)
                dgvKunyeListeleri.ExcellAktar();
        }

        private void barBtnPrintPrivew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dgvKunyeListeleri.RowCount > 0)
                dgvKunyeListeleri.ShowPrintPreview();
        }

        private void barBtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dgvKunyeListeleri.RowCount > 0)
                dgvKunyeListeleri.PrintDialog();
        }
    }
}
