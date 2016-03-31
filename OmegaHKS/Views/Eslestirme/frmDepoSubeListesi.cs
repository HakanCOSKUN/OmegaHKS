using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OmegaHKS.Views.Eslestirme
{
    public partial class frmDepoSubeListesi : BaseForm
    {
        private bool SecimIcin = false;
        private Models.DepoSubeAramaTipi Tip;
        private int LocalNo = -1;
        public frmDepoSubeListesi(bool secimIcin, int localNo, Models.DepoSubeAramaTipi tip)
        {
            InitializeComponent();

            Tip = tip;
            SecimIcin = secimIcin;
            LocalNo = localNo;

            InitSecreen();
            InitDTGDoldur();
        }

        private void InitSecreen()
        {
            if (Tip == Models.DepoSubeAramaTipi.Depo)
            {
                Text = "Omega Depo Arama İşlemi";
                groupControl1.Text = "Omega Depo Listesi";
            }
            else
            {
                if (Tip == Models.DepoSubeAramaTipi.Sube)
                {
                    Text = "Omega Şube Arama İşlemi";
                    groupControl1.Text = "Omega Şube Listesi";
                }
                else
                {
                    Text = "Omega Şube Depo Arama İşlemi";
                    groupControl1.Text = "Omega Şube Depo Listesi";
                }
            }
        }

        private void InitDTGDoldur()
        {
            var localDepoController = new Controllers.LocalDepoDTOController();
            var localList = localDepoController.GetLocalDepoList(Tip);
            bsLocalDepoSube.DataSource = localList;
            dgcDepoSubeListesi.DataSource = bsLocalDepoSube;
        }

        private void dgvDepoSubeListesi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Core.StaticDegiskenler.tmpLocalDepo = dgvDepoSubeListesi.GetFocusedItem<Models.LocalDepo>();
                Core.StaticDegiskenler.FormInt = dgvDepoSubeListesi.GetFocusedItem<Models.LocalDepo>().DMBNO;
                Close();
            }
        }

        private void dgvDepoSubeListesi_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDepoSubeListesi.RowCount > 0)
            {
                Core.StaticDegiskenler.tmpLocalDepo = dgvDepoSubeListesi.GetFocusedItem<Models.LocalDepo>();
                Core.StaticDegiskenler.FormInt = dgvDepoSubeListesi.GetFocusedItem<Models.LocalDepo>().DMBNO;
                Close();
            }
        }

        private void ucsBTNKayitIpal1_ClickIptal(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
