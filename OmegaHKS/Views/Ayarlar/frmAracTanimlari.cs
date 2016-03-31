using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OmegaHKS.Views.Ayarlar
{
    public partial class frmAracTanimlari : BaseForm
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public frmAracTanimlari()
        {
            InitializeComponent();

            IntiDgcDoldur();
        }

        private void IntiDgcDoldur()
        {
            var plkController = new Controllers.LocalHKSUpdateController();
            var list = plkController.GetAracPlakaList();
            bsAracPlaka.DataSource = list;
            dgcAracPlaka.DataSource = bsAracPlaka;
        }

        private void ucsBTNKayitIpal1_ClickIptal(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ucsBTNKayitIpal1_ClickKaydet(object sender, EventArgs e)
        {
            var plkList = bsAracPlaka.List as List<Models.AracPlaka>;
            var plkController = new Controllers.LocalHKSUpdateController();
            var sonuc = plkController.LocalAracPlakaGuncelleEkle(plkList);
            
            
            if(!sonuc)
            {
                var islemLog = string.Format("Araç Plaka Bilgileri Güncellendi", MethodBase.GetCurrentMethod().DeclaringType);
                logger.Info(islemLog);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = islemLog });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Info", HataBilgisi = islemLog });
                Helpers.MessageHelper.ShowInformation("İşlem Başarılı Bir Şekilde Gerçekleşti");

                var listDb = plkController.GetAracPlakaList();
                bsAracPlaka.DataSource = listDb;
                dgcAracPlaka.DataSource = bsAracPlaka;
            }
            else
            {
                var islemLog = string.Format("Araç Plaka Bilgileri Günceleme İşleminde Hata Oluştu Güncelleme Yapılamadı", MethodBase.GetCurrentMethod().DeclaringType);
                logger.Error(islemLog);
                Core.StaticDegiskenler.HataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = islemLog });
                Core.StaticDegiskenler.IslemHataListesi.Add(new Models.ErrorLog { Tarih = DateTime.Now, HataTipi = "Error", HataBilgisi = islemLog });
                Helpers.MessageHelper.ShowError("İşlem Bir Hata Aldı Kayıt Yapılamadı");
            }
        }
    }
}
