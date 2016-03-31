using System;
using System.Collections.Generic;
using System.Linq;

namespace OmegaHKS.Views.Aktarim
{
    public partial class frmIrsaliyeDetay : BaseForm
    {
        private int irsNo = 0;
        public frmIrsaliyeDetay(int IrsNo)
        {
            InitializeComponent();
            irsNo = IrsNo;

            IntGridView();
        }

        private void IntGridView()
        {
            var controllerIrsaliyeDetay = new Controllers.IrsaliyeController();
            var controllerDepoSube = new Controllers.LocalDepoDTOController();

            //var AsilIrsaliye = controllerIrsaliyeDetay.GetIrsaliyeDetayListesiAsilIRsaliye(irsNo);
            var EslesenIrsaliye = controllerIrsaliyeDetay.GetIrsaliyeDetayListesi(irsNo);
            var result = EslesenIrsaliye.GroupBy(test => test.STKKOD)
                           .Select(grp => grp.First())
                           .ToList();

            gcIrsaliyeDetay.DataSource = result;


            txtSevDeposu.Text = controllerDepoSube.GetLocalDepo(Core.StaticDegiskenler.tmpIrsaliye.DEPNO).AD;
            txtKarsiDeposu.Text = controllerDepoSube.GetLocalDepo(Core.StaticDegiskenler.tmpIrsaliye.ALDEP).AD;

            txtBelgeNo.Text = Core.StaticDegiskenler.tmpIrsaliye.BELGENO;
            txtBelgeTarihi.Text = Core.StaticDegiskenler.tmpIrsaliye.TARIH.ToShortDateString();
            txtIrsaliyeNo.Text = Core.StaticDegiskenler.tmpIrsaliye.IRSNO.ToString();
        }

        private void ucsBTNKayitIpal1_ClickIptal(object sender, EventArgs e)
        {
            Close();
        }
    }
}
