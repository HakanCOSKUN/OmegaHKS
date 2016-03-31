using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace OmegaHKS.Views.Aktarim
{
    public partial class frmReferansBildirimler : BaseForm
    {
        private bool islem = false;
        public frmReferansBildirimler()
        {
            InitializeComponent();

            InitScreen();
        }

        private void InitScreen()
        {
            dtBaslangicTarihi.EditValue = DateTime.Now;
            dtBitisTarihi.EditValue = DateTime.Now;
        }


        private void btnReferansBildirimSorgula_Click(object sender, EventArgs e)
        {
            BildirimServiceReference.BaseResponseMessageOf_BildirimSorguCevap cevap = null;

            var istek = new BildirimServiceReference.BaseRequestMessageOf_BildirimSorguIstek()
            {
                UserName = Core.StaticDegiskenler.webServiceUser.UserName,
                Password = Core.StaticDegiskenler.webServiceUser.Password,
                ServicePassword = Core.StaticDegiskenler.webServiceUser.ServicePasssword,
                Istek = new BildirimServiceReference.BildirimSorguIstek()
                {
                    KunyeTuru = 1,
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
                    var bildirimList = new List<BildirimServiceReference.BildirimSorguDTO>();

                    bildirimList = cevap.Sonuc.Bildirimler;
                    if (bildirimList.Count <= 0)
                    {
                        return;
                    }

                    bsBidirimler.DataSource = bildirimList;
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

        private void frmReferansBildirimler_FormClosing(object sender, FormClosingEventArgs e)
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

        private void exportToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvKunyeListeleri.RowCount > 0)
            {
                dgvKunyeListeleri.ExcellAktar();
            }
        }

        private void printViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvKunyeListeleri.RowCount > 0)
            {
                dgvKunyeListeleri.ShowPrintPreview();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvKunyeListeleri.RowCount > 0)
            {
                dgvKunyeListeleri.PrintDialog();
            }
        }

        private void dgvKunyeListeleri_DataSourceChanged(object sender, EventArgs e)
        {
            if(dgvKunyeListeleri.RowCount>0)
            {
                dgcKunyeListeleri.ContextMenuStrip = contextMenuStripExcell;
            }
        }

        private void barBtnExportToFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(dgvKunyeListeleri.RowCount>0)
            {
                dgvKunyeListeleri.ExcellAktar();
            }
        }

        private void barBtnPrintPrivew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dgvKunyeListeleri.RowCount > 0)
            {
                dgvKunyeListeleri.ShowPrintPreview();
            }
        }

        private void barBtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dgvKunyeListeleri.RowCount > 0)
            {
                dgvKunyeListeleri.PrintDialog();
            }
        }
    }
}
