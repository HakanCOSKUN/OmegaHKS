using DevExpress.XtraEditors;
using System;

namespace OmegaHKS.Views.Aktarim
{
    public partial class frmEtiketIstekleri : BaseForm
    {
        private bool islem;
        public frmEtiketIstekleri()
        {
            InitializeComponent();

            IntiDgcDoldur();
            islem = true;
            dgvEtiketListesi.SecimColumnGoster();
        }

        private void IntiDgcDoldur()
        {
            txtTarih.EditValue = DateTime.Now;
            txtTarih.Refresh();
        }

        private void txtDepoSube_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var btnEdit = sender as ButtonEdit;

            Core.StaticDegiskenler.tmpSubeDepo = null;
            Helpers.DepoSubeIslemleri.DepoSubeSecim(true, -1, Models.DepoSubeAramaTipi.Sube);
            if (Core.StaticDegiskenler.tmpLocalDepo != null)
            {
                btnEdit.Tag = Core.StaticDegiskenler.tmpLocalDepo.DMBNO;
                btnEdit.Text = Core.StaticDegiskenler.tmpLocalDepo.AD;
            }
        }

        private void btnListeGetir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDepoSube.Text) && !string.IsNullOrEmpty(txtTarih.Text))
            {
                var bildirimController = new Controllers.BildirimController();
                var liste = bildirimController.GetEtiketBelgeListesiDepoBazli((int)txtDepoSube.Tag, Convert.ToDateTime(txtTarih.Text));
                if (liste.Count > 0)
                {
                    dgcBelgeListesi.DataSource = liste;
                }
            }
            else
            {
                Helpers.MessageHelper.ShowError("Tarih ve Depo veya Şube Alanı Mecburi Bilgidir Girilmesi Gerekir...");
            }
        }

        private void dgvEtiket_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (dgvBelgeListesi.FocusedRowHandle >= 0 && islem)
            {
                var bildirimController = new Controllers.BildirimController();

                var secilen = dgvBelgeListesi.GetFocusedItem<Models.EtiketBelgeDepoListe>();
                if (secilen.DEPNO == 0)
                {
                    bsEtiket.DataSource = null;
                }
                else
                {
                    bsEtiket.DataSource = bildirimController.GetEtiketListesiDepoBazli(secilen.DEPNO, secilen.TARIH, secilen.BELGENO);
                }
                dgcEtiketListesi.DataSource = bsEtiket;
            }
        }

        private void ucsBTNKayitIpal1_ClickIptal(object sender, EventArgs e)
        {
            Close();
        }

        private void seciliEtiketleriYazdirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var etkList = dgvEtiketListesi.GetSelectedItems<Models.EtiketEkranListe>();
            if (etkList.Count > 0)
            {
                Helpers.Aktarimlar.EtiketYazdir(etkList);
            }
            else
            {
                Helpers.MessageHelper.ShowInformation("Etiketleri Yazdırmak icin Öncelikle Yazdırmak istediğiniz Etiketi Seçin...");
            }
        }

        private void dgvEtiketListesi_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvEtiketListesi.RowCount > 0)
            {
                dgcEtiketListesi.ContextMenuStrip = contextMenuStripEtiketYazdir;
            }
        }

        private void ucsBTNKayitIpal1_ClickKaydet(object sender, EventArgs e)
        {
            var etkList = dgvEtiketListesi.GetSelectedItems<Models.EtiketEkranListe>();
            if (etkList.Count > 0)
            {
                Helpers.Aktarimlar.EtiketYazdir(etkList);
            }
            else
            {
                Helpers.MessageHelper.ShowInformation("Etiketleri Yazdırmak icin Öncelikle Yazdırmak istediğiniz Etiketi Seçin...");
            }
        }

        private void barBtnExportToFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(dgvEtiketListesi.RowCount>0)
            {
                dgvEtiketListesi.ExcellAktar();
            }
        }

        private void barBtnPrintPrivew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dgvEtiketListesi.RowCount > 0)
            {
                dgvEtiketListesi.ShowPrintPreview();
            }
        }

        private void barBtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dgvEtiketListesi.RowCount > 0)
            {
                dgvEtiketListesi.PrintDialog();
            }
        }
    }
}
