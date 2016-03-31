using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OmegaHKS.Views.Eslestirme
{
    public partial class frmCariFirmaAra : BaseForm
    {
        private string CariUnvan = string.Empty;
        //private bool SecimIcin = false;
        public frmCariFirmaAra(string firmaUnvan)
        {
            InitializeComponent();
            this.CariUnvan = firmaUnvan;
            InitDTGDoldur();
        }

        private void InitDTGDoldur()
        {
            var irsController = new Controllers.IrsaliyeController();
            bsCariList.DataSource= irsController.GetFirmaListesi(this.CariUnvan);
            dgcCariListe.DataSource = bsCariList;
        }

        private void dgvCariListe_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCariListe.RowCount > 0)
            {
                Core.StaticDegiskenler.tmpCari = dgvCariListe.GetFocusedItem<Models.Cari>();
                Core.StaticDegiskenler.CariKod = dgvCariListe.GetFocusedItem<Models.Cari>().CARKOD;
                Close();
            }
        }

        private void dgvCariListe_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Core.StaticDegiskenler.tmpCari = dgvCariListe.GetFocusedItem<Models.Cari>();
                Core.StaticDegiskenler.CariKod = dgvCariListe.GetFocusedItem<Models.Cari>().CARKOD;
                Close();
            }
        }

        private void ucsBTNKayitIpal1_ClickIptal(object sender, EventArgs e)
        {
            Core.StaticDegiskenler.CariKod = null;
            Core.StaticDegiskenler.tmpCari = null;
            this.Close();
        }
    }
}