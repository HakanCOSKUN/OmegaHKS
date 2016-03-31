using System;
using System.Collections.Generic;
using System.Linq;

namespace OmegaHKS.Views.Eslestirme
{
    public partial class frmStokArama : BaseForm
    {
        private bool SecimIcin = false;
        private string StokAdi = string.Empty;
        private int? StokKodu = -1;
        public frmStokArama(bool secimIcin, int? stokKodu, string stokAdi)
        {
            SecimIcin = secimIcin;
            StokKodu = stokKodu;
            StokAdi = stokAdi;

            InitializeComponent();

            IntGridView();
            gvLocalStokListesi.SecimColumnGoster();
        }

        private void IntGridView()
        {
            var stokController = new Controllers.UrunControllers();
            bsLocalStoklar.DataSource = stokController.GetOmegaStokArama(StokKodu, StokAdi);
            gcLocalStokListesi.DataSource = bsLocalStoklar;
        }

        private void ucsBTNKayitIpal1_ClickKaydet(object sender, EventArgs e)
        {
            Core.StaticDegiskenler.tmpLocalUrunDTOList = gvLocalStokListesi.GetSelectedItems<Models.LocalUrunDTO>();
            if (Core.StaticDegiskenler.tmpLocalUrunDTOList.Count > 0)
            {
                Core.StaticDegiskenler.FormInt = 1;
            }
            Close();
        }

        private void ucsBTNKayitIpal1_ClickIptal(object sender, EventArgs e)
        {
            Close();
        }
    }
}
