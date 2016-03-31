using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using NLog;
using System.Reflection;
using DevExpress.LookAndFeel;
using OmegaHKS.Properties;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;

namespace OmegaHKS.Views.Main
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        // private bool _Trial;
        public frmMain(bool IsTrial)
        {
            InitializeComponent();

            if (IsTrial == false)
            {
                bsiLisansBilgisi.Caption = "Full Sürüm";
            }
            Core.StaticDegiskenler.Trial = IsTrial;
            // _Trial = IsTrial;

            Text = Core.StaticDegiskenler.APP_NAME;

            InitSkins();
            AddDocumentManager();

            WebServiceTools();
        }
        private void AddDocumentManager()
        {
            DocumentManager manager = new DocumentManager();
            manager.MdiParent = this;
            manager.View = new TabbedView();
        }
        private void InitSkins()
        {
            UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
        }
        private void WebServiceTools()
        {
            logger.Info(string.Format("Program Çalıştırıldı  Pc Adi:{0}  Kullanıcı :{1}  Windows Ver:{2}  {3}", Environment.MachineName, Environment.UserName, Environment.OSVersion, MethodBase.GetCurrentMethod().DeclaringType));
            var conWebSer = new Controllers.WebServiceTool();
            var webUser = conWebSer.GetWebServiceUser();
            var sonuc = conWebSer.GetBildirimTanimlariniOku();
            if(!sonuc)
            {
                Helpers.MessageHelper.ShowInformation("Bildirim Yapılabilmesi İcin Bildirim Bildirimci ve Gidecek Yer Tanımları Yapılması Gerekir");
            }

            var anlikIslem = new Models.AnlikIslem();

            Core.StaticDegiskenler.HataListesi = new List<Models.ErrorLog>();
            Core.StaticDegiskenler.IslemHataListesi = new List<Models.ErrorLog>();
            Core.StaticDegiskenler.AnlikIslem = anlikIslem;
            if (webUser != null)
            {
                this.bsiPcName.Caption = Environment.MachineName;
                this.bsiPsUserName.Caption = Environment.UserName;
                this.bsiAppUserName.Caption = Environment.OSVersion.ToString();
                this.bsiOracleUser.Caption = Core.StaticDegiskenler.AktifOracleUser;

                Core.StaticDegiskenler.webServiceUser = webUser;
                logger.Info(string.Format("Program Çalıştırıldı  Pc Adi:{0}  Kullanıcı :{1}  Windows Ver:{2}  {3}", Environment.MachineName, Environment.UserName, Environment.OSVersion, MethodBase.GetCurrentMethod().DeclaringType));
            }
            else
            {
                Helpers.MessageHelper.ShowError("Web Service Bilgileri Sistemde Tanımlı Değil Bu Bilgiler Olmadan Sistemde İşlem Yapılamaz");
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Core.StaticDegiskenler.AnlikIslem.Islem != true)
            {
                logger.Info("Program Kapatıldı");
                e.Cancel = false;
            }
            else
            {
                Helpers.MessageHelper.ShowError("Devam eden işlem var işlemin bitmesini bekleyin lütfen ...!");
                e.Cancel = true;
            }
        }
        private void barBtnNihaiSorgula_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.Aktarimlar.NihaiBildirimler();
        }
        private void barBtnReferansSorgula_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.Aktarimlar.ReferansBildirimler();
        }
        private void barBtnLokasyonGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.HKSLocalUpdateIslemleri.LokasyonIslemleri();
        }
        private void barBtnUrunBilgileriGuncelle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.HKSLocalUpdateIslemleri.UrunIslemleri();
        }
        private void barBtnDepoEslestirme_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.EslestirmeIslemleri.DepoEslestirmeIslemleri();
        }
        private void barBtnSubeEslestirme_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.EslestirmeIslemleri.SubeEslestirmeIslemleri();
        }
        private void barBtnDMEslestirme_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.EslestirmeIslemleri.DMEslestirmeIslemleri();
        }
        private void barBtnUrunYardimciBilgileri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.HKSLocalUpdateIslemleri.UrunYardimciBilgileriIslemleri();
        }
        private void barBtnBildirimYardimciBilgieri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.HKSLocalUpdateIslemleri.BildirimYardimciSinifIslemleri();
        }
        private void barBtnUrunEslestirme_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.EslestirmeIslemleri.StokEslestirme();
        }
        private void barBtnBildirimYap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.Aktarimlar.BildirimYap();
        }
        private void btnEtiket_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.Aktarimlar.EtiketIslemleri();
        }
        private void barBtnHKSWebParametreleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.Ayarlar.WebServiceTanimlari();
        }
        private void barBtnPlakaTanimlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.Ayarlar.AracTanimlari();
        }
        private void barBtnHataDokumu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.HataBilgileri.HataGosterShow(Core.StaticDegiskenler.HataListesi);
        }
        private void bvBtnHataListesi_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Helpers.HataBilgileri.HataGosterShow(Core.StaticDegiskenler.HataListesi);
        }
        private void bvBtnHKSBildirimYAp_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Helpers.Aktarimlar.BildirimYap();
        }
        private void barBtnAlistanKunyeIsle_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.Aktarimlar.AlisIrsaliyesindenKunyeIsle();
        }
        private void bvBtnOlsanEtiketListesi_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Helpers.Aktarimlar.EtiketIslemleri();
        }
        private void barBtnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        private void bvBtnExit_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Views.LocalHKSUpdate.frmEtiketSorgu f = new LocalHKSUpdate.frmEtiketSorgu();
            //f.Show();
            Helpers.Aktarimlar.EtiketListesiSorgula();
        }

        private void barBtnBildirimAyarlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.Ayarlar.BildirimveGidecekYerAyarlari();
        }

        private void barBtnStokSifirla_ItemClick(object sender, ItemClickEventArgs e)
        {
            Helpers.Aktarimlar.StokSifirlama();
        }
    }
}
