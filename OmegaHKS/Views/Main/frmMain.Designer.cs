namespace OmegaHKS.Views.Main
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.bvBtnHKSBildirimYAp = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.bvBtnOlsanEtiketListesi = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.bvBtnHataListesi = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.bvBtnExit = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.barBtnNihaiSorgula = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnReferansSorgula = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBildirimYap = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPlakaTanimlari = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnHKSWebParametreleri = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEvrakBildirimParametreleri = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnLokasyonGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUrunBilgileriGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDepoEslestirme = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSubeEslestirme = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUrunYardimciBilgileri = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBildirimYardimciBilgieri = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnUrunEslestirme = new DevExpress.XtraBars.BarButtonItem();
            this.btnEtiketListesi = new DevExpress.XtraBars.BarButtonItem();
            this.bsiPcName = new DevExpress.XtraBars.BarStaticItem();
            this.bsiPsUserName = new DevExpress.XtraBars.BarStaticItem();
            this.bsiAppUserName = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barBtnHataDokumu = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bsiLisansBilgisi = new DevExpress.XtraBars.BarStaticItem();
            this.bsiOracleUser = new DevExpress.XtraBars.BarStaticItem();
            this.barBtnAlistanKunyeIsle = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDMEslestirme = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnKunyeSorgula = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBildirimAyarlari = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnStokSifirla = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.rpAyarlar = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgTanimlar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgBildirimParametreleri = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpAktarimlar = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSorgulamalar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgIslemler = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpEslestirmeler = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgDepoSube = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgUrunEslestirme = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpGuncellemeler = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgLokasyon = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgUrunBilgieri = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgGenelTanimGuncellemeleri = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpProgram = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgHata = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.OmegaHKSSistemi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnNihaiSorgula,
            this.barBtnReferansSorgula,
            this.barBtnBildirimYap,
            this.barBtnPlakaTanimlari,
            this.barBtnHKSWebParametreleri,
            this.barBtnEvrakBildirimParametreleri,
            this.barBtnLokasyonGuncelle,
            this.barBtnUrunBilgileriGuncelle,
            this.barBtnDepoEslestirme,
            this.barBtnSubeEslestirme,
            this.barBtnUrunYardimciBilgileri,
            this.barBtnBildirimYardimciBilgieri,
            this.barBtnUrunEslestirme,
            this.btnEtiketListesi,
            this.bsiPcName,
            this.bsiPsUserName,
            this.bsiAppUserName,
            this.barStaticItem4,
            this.barBtnHataDokumu,
            this.barBtnExit,
            this.bsiLisansBilgisi,
            this.bsiOracleUser,
            this.barBtnAlistanKunyeIsle,
            this.barBtnDMEslestirme,
            this.barBtnKunyeSorgula,
            this.barBtnBildirimAyarlari,
            this.barBtnStokSifirla});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barBtnHataDokumu);
            this.ribbon.PageHeaderItemLinks.Add(this.barBtnExit);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpAyarlar,
            this.rpAktarimlar,
            this.rpEslestirmeler,
            this.rpGuncellemeler,
            this.rpProgram});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(1138, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ItemLinks.Add(this.barBtnHataDokumu);
            this.ribbon.Toolbar.ItemLinks.Add(this.barBtnExit);
            this.ribbon.Toolbar.ItemLinks.Add(this.bsiLisansBilgisi);
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.backstageViewControl1.Items.Add(this.bvBtnHKSBildirimYAp);
            this.backstageViewControl1.Items.Add(this.bvBtnOlsanEtiketListesi);
            this.backstageViewControl1.Items.Add(this.bvBtnHataListesi);
            this.backstageViewControl1.Items.Add(this.bvBtnExit);
            this.backstageViewControl1.Location = new System.Drawing.Point(0, 153);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.Ribbon = this.ribbon;
            this.backstageViewControl1.SelectedTab = null;
            this.backstageViewControl1.Size = new System.Drawing.Size(275, 358);
            this.backstageViewControl1.TabIndex = 2;
            // 
            // bvBtnHKSBildirimYAp
            // 
            this.bvBtnHKSBildirimYAp.Caption = "HKS Sistemine Bildirim Yap";
            this.bvBtnHKSBildirimYAp.Glyph = global::OmegaHKS.Properties.Resources._1447276761_load_upload_32;
            this.bvBtnHKSBildirimYAp.Name = "bvBtnHKSBildirimYAp";
            this.bvBtnHKSBildirimYAp.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvBtnHKSBildirimYAp_ItemClick);
            // 
            // bvBtnOlsanEtiketListesi
            // 
            this.bvBtnOlsanEtiketListesi.Caption = "Oluşan Etiket Listesi";
            this.bvBtnOlsanEtiketListesi.Glyph = global::OmegaHKS.Properties.Resources._1448145316_diagram_v2_32;
            this.bvBtnOlsanEtiketListesi.Name = "bvBtnOlsanEtiketListesi";
            this.bvBtnOlsanEtiketListesi.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvBtnOlsanEtiketListesi_ItemClick);
            // 
            // bvBtnHataListesi
            // 
            this.bvBtnHataListesi.Caption = "Oluşan Hatalar";
            this.bvBtnHataListesi.Glyph = global::OmegaHKS.Properties.Resources._1448176516_Error_32;
            this.bvBtnHataListesi.Name = "bvBtnHataListesi";
            this.bvBtnHataListesi.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvBtnHataListesi_ItemClick);
            // 
            // bvBtnExit
            // 
            this.bvBtnExit.Caption = "Program Sonu";
            this.bvBtnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("bvBtnExit.Glyph")));
            this.bvBtnExit.Name = "bvBtnExit";
            this.bvBtnExit.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvBtnExit_ItemClick);
            // 
            // barBtnNihaiSorgula
            // 
            this.barBtnNihaiSorgula.Caption = "Nihai Bildirim Sorgulama";
            this.barBtnNihaiSorgula.Glyph = global::OmegaHKS.Properties.Resources._1447277082_file_search_32;
            this.barBtnNihaiSorgula.Id = 1;
            this.barBtnNihaiSorgula.LargeGlyph = global::OmegaHKS.Properties.Resources._1447277082_file_search_32;
            this.barBtnNihaiSorgula.Name = "barBtnNihaiSorgula";
            this.barBtnNihaiSorgula.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnNihaiSorgula_ItemClick);
            // 
            // barBtnReferansSorgula
            // 
            this.barBtnReferansSorgula.Caption = "Referans Bildirim Sorgulama";
            this.barBtnReferansSorgula.Glyph = global::OmegaHKS.Properties.Resources._1447276842_document_search_32;
            this.barBtnReferansSorgula.Id = 2;
            this.barBtnReferansSorgula.LargeGlyph = global::OmegaHKS.Properties.Resources._1447276842_document_search_32;
            this.barBtnReferansSorgula.Name = "barBtnReferansSorgula";
            this.barBtnReferansSorgula.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnReferansSorgula_ItemClick);
            // 
            // barBtnBildirimYap
            // 
            this.barBtnBildirimYap.Caption = "HKS Sistemine Bildirim Yap";
            this.barBtnBildirimYap.Glyph = global::OmegaHKS.Properties.Resources._1447276761_load_upload_32;
            this.barBtnBildirimYap.Id = 3;
            this.barBtnBildirimYap.LargeGlyph = global::OmegaHKS.Properties.Resources._1447276761_load_upload_32;
            this.barBtnBildirimYap.Name = "barBtnBildirimYap";
            this.barBtnBildirimYap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBildirimYap_ItemClick);
            // 
            // barBtnPlakaTanimlari
            // 
            this.barBtnPlakaTanimlari.Caption = "Plaka Tanimlari";
            this.barBtnPlakaTanimlari.Glyph = global::OmegaHKS.Properties.Resources.Sevkiyat_48;
            this.barBtnPlakaTanimlari.Id = 4;
            this.barBtnPlakaTanimlari.LargeGlyph = global::OmegaHKS.Properties.Resources.Sevkiyat_48;
            this.barBtnPlakaTanimlari.Name = "barBtnPlakaTanimlari";
            this.barBtnPlakaTanimlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPlakaTanimlari_ItemClick);
            // 
            // barBtnHKSWebParametreleri
            // 
            this.barBtnHKSWebParametreleri.Caption = "H K S Web Parametreleri";
            this.barBtnHKSWebParametreleri.Glyph = global::OmegaHKS.Properties.Resources._1444400131_internet_earth_48;
            this.barBtnHKSWebParametreleri.Id = 5;
            this.barBtnHKSWebParametreleri.LargeGlyph = global::OmegaHKS.Properties.Resources._1444400131_internet_earth_48;
            this.barBtnHKSWebParametreleri.Name = "barBtnHKSWebParametreleri";
            this.barBtnHKSWebParametreleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnHKSWebParametreleri_ItemClick);
            // 
            // barBtnEvrakBildirimParametreleri
            // 
            this.barBtnEvrakBildirimParametreleri.Caption = "Evrak Bildirim Parametreleri";
            this.barBtnEvrakBildirimParametreleri.Glyph = global::OmegaHKS.Properties.Resources._32_1445813876_todo_list;
            this.barBtnEvrakBildirimParametreleri.Id = 6;
            this.barBtnEvrakBildirimParametreleri.LargeGlyph = global::OmegaHKS.Properties.Resources._32_1445813876_todo_list;
            this.barBtnEvrakBildirimParametreleri.Name = "barBtnEvrakBildirimParametreleri";
            // 
            // barBtnLokasyonGuncelle
            // 
            this.barBtnLokasyonGuncelle.Caption = "Lokasyon Bilgieri Güncelle";
            this.barBtnLokasyonGuncelle.Glyph = global::OmegaHKS.Properties.Resources._1444400094_map;
            this.barBtnLokasyonGuncelle.Id = 8;
            this.barBtnLokasyonGuncelle.LargeGlyph = global::OmegaHKS.Properties.Resources._1444400094_map;
            this.barBtnLokasyonGuncelle.Name = "barBtnLokasyonGuncelle";
            this.barBtnLokasyonGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLokasyonGuncelle_ItemClick);
            // 
            // barBtnUrunBilgileriGuncelle
            // 
            this.barBtnUrunBilgileriGuncelle.Caption = "Ürün Bilgileri Güncelle";
            this.barBtnUrunBilgileriGuncelle.Glyph = global::OmegaHKS.Properties.Resources._1445541680_Tomato;
            this.barBtnUrunBilgileriGuncelle.Id = 9;
            this.barBtnUrunBilgileriGuncelle.LargeGlyph = global::OmegaHKS.Properties.Resources._1445541680_Tomato;
            this.barBtnUrunBilgileriGuncelle.Name = "barBtnUrunBilgileriGuncelle";
            this.barBtnUrunBilgileriGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUrunBilgileriGuncelle_ItemClick);
            // 
            // barBtnDepoEslestirme
            // 
            this.barBtnDepoEslestirme.Caption = "Depo Eşleştirme";
            this.barBtnDepoEslestirme.Glyph = global::OmegaHKS.Properties.Resources.palet02_63;
            this.barBtnDepoEslestirme.Id = 10;
            this.barBtnDepoEslestirme.LargeGlyph = global::OmegaHKS.Properties.Resources.palet02_63;
            this.barBtnDepoEslestirme.Name = "barBtnDepoEslestirme";
            this.barBtnDepoEslestirme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDepoEslestirme_ItemClick);
            // 
            // barBtnSubeEslestirme
            // 
            this.barBtnSubeEslestirme.Caption = "Şube Eşleştirme";
            this.barBtnSubeEslestirme.Glyph = global::OmegaHKS.Properties.Resources._48_48_1445525494_Department;
            this.barBtnSubeEslestirme.Id = 11;
            this.barBtnSubeEslestirme.LargeGlyph = global::OmegaHKS.Properties.Resources._48_48_1445525494_Department;
            this.barBtnSubeEslestirme.Name = "barBtnSubeEslestirme";
            this.barBtnSubeEslestirme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSubeEslestirme_ItemClick);
            // 
            // barBtnUrunYardimciBilgileri
            // 
            this.barBtnUrunYardimciBilgileri.Caption = "Ürün Yardımcı Bilgileri";
            this.barBtnUrunYardimciBilgileri.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnUrunYardimciBilgileri.Glyph")));
            this.barBtnUrunYardimciBilgileri.Id = 12;
            this.barBtnUrunYardimciBilgileri.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnUrunYardimciBilgileri.LargeGlyph")));
            this.barBtnUrunYardimciBilgileri.Name = "barBtnUrunYardimciBilgileri";
            this.barBtnUrunYardimciBilgileri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUrunYardimciBilgileri_ItemClick);
            // 
            // barBtnBildirimYardimciBilgieri
            // 
            this.barBtnBildirimYardimciBilgieri.Caption = "Bildirim Yardimci Bilgileri";
            this.barBtnBildirimYardimciBilgieri.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnBildirimYardimciBilgieri.Glyph")));
            this.barBtnBildirimYardimciBilgieri.Id = 13;
            this.barBtnBildirimYardimciBilgieri.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnBildirimYardimciBilgieri.LargeGlyph")));
            this.barBtnBildirimYardimciBilgieri.Name = "barBtnBildirimYardimciBilgieri";
            this.barBtnBildirimYardimciBilgieri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBildirimYardimciBilgieri_ItemClick);
            // 
            // barBtnUrunEslestirme
            // 
            this.barBtnUrunEslestirme.Caption = "Ürün Eşletirme";
            this.barBtnUrunEslestirme.Glyph = global::OmegaHKS.Properties.Resources._1445541680_Tomato;
            this.barBtnUrunEslestirme.Id = 15;
            this.barBtnUrunEslestirme.LargeGlyph = global::OmegaHKS.Properties.Resources._1445541680_Tomato;
            this.barBtnUrunEslestirme.Name = "barBtnUrunEslestirme";
            this.barBtnUrunEslestirme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnUrunEslestirme_ItemClick);
            // 
            // btnEtiketListesi
            // 
            this.btnEtiketListesi.Caption = "Oluşan Belge Etiket Listesi";
            this.btnEtiketListesi.Glyph = global::OmegaHKS.Properties.Resources._1448145316_diagram_v2_32;
            this.btnEtiketListesi.Id = 16;
            this.btnEtiketListesi.LargeGlyph = global::OmegaHKS.Properties.Resources._1448145316_diagram_v2_32;
            this.btnEtiketListesi.Name = "btnEtiketListesi";
            this.btnEtiketListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEtiket_ItemClick);
            // 
            // bsiPcName
            // 
            this.bsiPcName.Caption = "PcName";
            this.bsiPcName.Glyph = global::OmegaHKS.Properties.Resources.pc_2_16;
            this.bsiPcName.Id = 17;
            this.bsiPcName.LargeGlyph = global::OmegaHKS.Properties.Resources.pc_2_32;
            this.bsiPcName.Name = "bsiPcName";
            this.bsiPcName.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bsiPsUserName
            // 
            this.bsiPsUserName.Caption = "PcUserName";
            this.bsiPsUserName.Glyph = global::OmegaHKS.Properties.Resources.pcUser_1_16;
            this.bsiPsUserName.Id = 18;
            this.bsiPsUserName.LargeGlyph = global::OmegaHKS.Properties.Resources.pcUser_1_32;
            this.bsiPsUserName.Name = "bsiPsUserName";
            this.bsiPsUserName.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bsiAppUserName
            // 
            this.bsiAppUserName.Caption = "WinVer";
            this.bsiAppUserName.Glyph = global::OmegaHKS.Properties.Resources.program_1_16;
            this.bsiAppUserName.Id = 19;
            this.bsiAppUserName.LargeGlyph = global::OmegaHKS.Properties.Resources.program_1_32;
            this.bsiAppUserName.Name = "bsiAppUserName";
            this.bsiAppUserName.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem4.Caption = "Program By: Hakan COŞKUN && Metin AKAR";
            this.barStaticItem4.Glyph = global::OmegaHKS.Properties.Resources._24_1445814681_vector_65_01;
            this.barStaticItem4.Id = 20;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barBtnHataDokumu
            // 
            this.barBtnHataDokumu.Caption = "Hata Listesi";
            this.barBtnHataDokumu.Glyph = global::OmegaHKS.Properties.Resources._1448176516_Error_32;
            this.barBtnHataDokumu.Id = 21;
            this.barBtnHataDokumu.LargeGlyph = global::OmegaHKS.Properties.Resources._1448176516_Error_32;
            this.barBtnHataDokumu.Name = "barBtnHataDokumu";
            this.barBtnHataDokumu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnHataDokumu_ItemClick);
            // 
            // barBtnExit
            // 
            this.barBtnExit.Caption = "Çıkış";
            this.barBtnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExit.Glyph")));
            this.barBtnExit.Id = 22;
            this.barBtnExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnExit.LargeGlyph")));
            this.barBtnExit.Name = "barBtnExit";
            this.barBtnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExit_ItemClick);
            // 
            // bsiLisansBilgisi
            // 
            this.bsiLisansBilgisi.Caption = "Deneme Sürümü";
            this.bsiLisansBilgisi.Glyph = global::OmegaHKS.Properties.Resources._32_32_1445525269_application_pgp_signature;
            this.bsiLisansBilgisi.Id = 2;
            this.bsiLisansBilgisi.ItemAppearance.Normal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bsiLisansBilgisi.ItemAppearance.Normal.Options.UseForeColor = true;
            this.bsiLisansBilgisi.Name = "bsiLisansBilgisi";
            this.bsiLisansBilgisi.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bsiOracleUser
            // 
            this.bsiOracleUser.Caption = "Aktif DB";
            this.bsiOracleUser.Glyph = ((System.Drawing.Image)(resources.GetObject("bsiOracleUser.Glyph")));
            this.bsiOracleUser.Id = 3;
            this.bsiOracleUser.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bsiOracleUser.LargeGlyph")));
            this.bsiOracleUser.Name = "bsiOracleUser";
            this.bsiOracleUser.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barBtnAlistanKunyeIsle
            // 
            this.barBtnAlistanKunyeIsle.Caption = "Alis Irsaliyesinden Künye İşle";
            this.barBtnAlistanKunyeIsle.Id = 1;
            this.barBtnAlistanKunyeIsle.LargeGlyph = global::OmegaHKS.Properties.Resources._1447276725_load_download_32;
            this.barBtnAlistanKunyeIsle.Name = "barBtnAlistanKunyeIsle";
            this.barBtnAlistanKunyeIsle.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barBtnAlistanKunyeIsle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAlistanKunyeIsle_ItemClick);
            // 
            // barBtnDMEslestirme
            // 
            this.barBtnDMEslestirme.Caption = "Dağıtım Merkezi Eşleştirme";
            this.barBtnDMEslestirme.Glyph = global::OmegaHKS.Properties.Resources.palet02_63;
            this.barBtnDMEslestirme.Id = 2;
            this.barBtnDMEslestirme.LargeGlyph = global::OmegaHKS.Properties.Resources.palet02_63;
            this.barBtnDMEslestirme.Name = "barBtnDMEslestirme";
            this.barBtnDMEslestirme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDMEslestirme_ItemClick);
            // 
            // barBtnKunyeSorgula
            // 
            this.barBtnKunyeSorgula.Caption = "Künye Bilgisi Sorgula";
            this.barBtnKunyeSorgula.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnKunyeSorgula.Glyph")));
            this.barBtnKunyeSorgula.Id = 3;
            this.barBtnKunyeSorgula.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnKunyeSorgula.LargeGlyph")));
            this.barBtnKunyeSorgula.Name = "barBtnKunyeSorgula";
            this.barBtnKunyeSorgula.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barBtnBildirimAyarlari
            // 
            this.barBtnBildirimAyarlari.Caption = "Bildirimci ve Gidecek Yer Tanımları";
            this.barBtnBildirimAyarlari.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnBildirimAyarlari.Glyph")));
            this.barBtnBildirimAyarlari.Id = 4;
            this.barBtnBildirimAyarlari.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnBildirimAyarlari.LargeGlyph")));
            this.barBtnBildirimAyarlari.Name = "barBtnBildirimAyarlari";
            this.barBtnBildirimAyarlari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBildirimAyarlari_ItemClick);
            // 
            // barBtnStokSifirla
            // 
            this.barBtnStokSifirla.Caption = "HKS Sistemi Stok Sıfırlama";
            this.barBtnStokSifirla.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnStokSifirla.Glyph")));
            this.barBtnStokSifirla.Id = 5;
            this.barBtnStokSifirla.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnStokSifirla.LargeGlyph")));
            this.barBtnStokSifirla.Name = "barBtnStokSifirla";
            this.barBtnStokSifirla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokSifirla_ItemClick);
            // 
            // ribbonMiniToolbar1
            // 
            this.ribbonMiniToolbar1.ItemLinks.Add(this.barBtnHataDokumu);
            this.ribbonMiniToolbar1.ItemLinks.Add(this.barBtnExit);
            this.ribbonMiniToolbar1.ItemLinks.Add(this.bsiLisansBilgisi);
            // 
            // rpAyarlar
            // 
            this.rpAyarlar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgTanimlar,
            this.rpgBildirimParametreleri});
            this.rpAyarlar.Name = "rpAyarlar";
            this.rpAyarlar.Text = "Ayarlar";
            // 
            // rpgTanimlar
            // 
            this.rpgTanimlar.ItemLinks.Add(this.barBtnPlakaTanimlari);
            this.rpgTanimlar.ItemLinks.Add(this.barBtnHKSWebParametreleri);
            this.rpgTanimlar.ItemLinks.Add(this.barBtnBildirimAyarlari);
            this.rpgTanimlar.Name = "rpgTanimlar";
            this.rpgTanimlar.Text = "Tanimlar";
            // 
            // rpgBildirimParametreleri
            // 
            this.rpgBildirimParametreleri.ItemLinks.Add(this.barBtnEvrakBildirimParametreleri);
            this.rpgBildirimParametreleri.Name = "rpgBildirimParametreleri";
            this.rpgBildirimParametreleri.Text = "Evrak Bildirim Parametreleri";
            this.rpgBildirimParametreleri.Visible = false;
            // 
            // rpAktarimlar
            // 
            this.rpAktarimlar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSorgulamalar,
            this.rpgIslemler});
            this.rpAktarimlar.Name = "rpAktarimlar";
            this.rpAktarimlar.Text = "Aktarimlar";
            // 
            // rpgSorgulamalar
            // 
            this.rpgSorgulamalar.ItemLinks.Add(this.barBtnNihaiSorgula);
            this.rpgSorgulamalar.ItemLinks.Add(this.barBtnReferansSorgula);
            this.rpgSorgulamalar.Name = "rpgSorgulamalar";
            this.rpgSorgulamalar.Text = "Bildirim Sorgulama";
            // 
            // rpgIslemler
            // 
            this.rpgIslemler.ItemLinks.Add(this.barBtnStokSifirla);
            this.rpgIslemler.ItemLinks.Add(this.barBtnBildirimYap);
            this.rpgIslemler.ItemLinks.Add(this.btnEtiketListesi);
            this.rpgIslemler.ItemLinks.Add(this.barBtnAlistanKunyeIsle);
            this.rpgIslemler.ItemLinks.Add(this.barBtnKunyeSorgula);
            this.rpgIslemler.Name = "rpgIslemler";
            this.rpgIslemler.Text = "İşlemler";
            // 
            // rpEslestirmeler
            // 
            this.rpEslestirmeler.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgDepoSube,
            this.rpgUrunEslestirme});
            this.rpEslestirmeler.Name = "rpEslestirmeler";
            this.rpEslestirmeler.Text = "Eşleştirmeler";
            // 
            // rpgDepoSube
            // 
            this.rpgDepoSube.ItemLinks.Add(this.barBtnDepoEslestirme);
            this.rpgDepoSube.ItemLinks.Add(this.barBtnDMEslestirme);
            this.rpgDepoSube.ItemLinks.Add(this.barBtnSubeEslestirme);
            this.rpgDepoSube.Name = "rpgDepoSube";
            this.rpgDepoSube.Text = "Depo Şube Eşleştirme";
            // 
            // rpgUrunEslestirme
            // 
            this.rpgUrunEslestirme.ItemLinks.Add(this.barBtnUrunEslestirme);
            this.rpgUrunEslestirme.Name = "rpgUrunEslestirme";
            this.rpgUrunEslestirme.Text = "Ürün Eşleştirmeleri";
            // 
            // rpGuncellemeler
            // 
            this.rpGuncellemeler.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgLokasyon,
            this.rpgUrunBilgieri,
            this.rpgGenelTanimGuncellemeleri});
            this.rpGuncellemeler.Name = "rpGuncellemeler";
            this.rpGuncellemeler.Text = "Güncellemeler";
            // 
            // rpgLokasyon
            // 
            this.rpgLokasyon.ItemLinks.Add(this.barBtnLokasyonGuncelle);
            this.rpgLokasyon.Name = "rpgLokasyon";
            this.rpgLokasyon.Text = "Lokasyon Güncellemeleri";
            // 
            // rpgUrunBilgieri
            // 
            this.rpgUrunBilgieri.ItemLinks.Add(this.barBtnUrunBilgileriGuncelle);
            this.rpgUrunBilgieri.Name = "rpgUrunBilgieri";
            this.rpgUrunBilgieri.Text = "Ürün Bilgileri Güncelleme";
            // 
            // rpgGenelTanimGuncellemeleri
            // 
            this.rpgGenelTanimGuncellemeleri.ItemLinks.Add(this.barBtnUrunYardimciBilgileri);
            this.rpgGenelTanimGuncellemeleri.ItemLinks.Add(this.barBtnBildirimYardimciBilgieri);
            this.rpgGenelTanimGuncellemeleri.Name = "rpgGenelTanimGuncellemeleri";
            this.rpgGenelTanimGuncellemeleri.Text = "Genel Tanmimlar";
            // 
            // rpProgram
            // 
            this.rpProgram.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgHata,
            this.OmegaHKSSistemi});
            this.rpProgram.Name = "rpProgram";
            this.rpProgram.Text = "Program";
            // 
            // rpgHata
            // 
            this.rpgHata.ItemLinks.Add(this.barBtnHataDokumu);
            this.rpgHata.Name = "rpgHata";
            this.rpgHata.Text = "Oluşan Hatalar";
            // 
            // OmegaHKSSistemi
            // 
            this.OmegaHKSSistemi.ItemLinks.Add(this.barBtnExit);
            this.OmegaHKSSistemi.Name = "OmegaHKSSistemi";
            this.OmegaHKSSistemi.Text = "Omega HSK Sistemi";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiPcName);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiPsUserName);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiOracleUser);
            this.ribbonStatusBar.ItemLinks.Add(this.bsiAppUserName);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem4);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 559);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1138, 23);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 582);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAktarimlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSorgulamalar;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barBtnNihaiSorgula;
        private DevExpress.XtraBars.BarButtonItem barBtnReferansSorgula;
        private DevExpress.XtraBars.BarButtonItem barBtnBildirimYap;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgIslemler;
        private DevExpress.XtraBars.BarButtonItem barBtnPlakaTanimlari;
        private DevExpress.XtraBars.BarButtonItem barBtnHKSWebParametreleri;
        private DevExpress.XtraBars.BarButtonItem barBtnEvrakBildirimParametreleri;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAyarlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTanimlar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBildirimParametreleri;
        private DevExpress.XtraBars.BarButtonItem barBtnLokasyonGuncelle;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpGuncellemeler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgLokasyon;
        private DevExpress.XtraBars.BarButtonItem barBtnUrunBilgileriGuncelle;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgUrunBilgieri;
        private DevExpress.XtraBars.BarButtonItem barBtnDepoEslestirme;
        private DevExpress.XtraBars.BarButtonItem barBtnSubeEslestirme;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpEslestirmeler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgDepoSube;
        private DevExpress.XtraBars.BarButtonItem barBtnUrunYardimciBilgileri;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGenelTanimGuncellemeleri;
        private DevExpress.XtraBars.BarButtonItem barBtnBildirimYardimciBilgieri;
        private DevExpress.XtraBars.BarButtonItem barBtnUrunEslestirme;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgUrunEslestirme;
        private DevExpress.XtraBars.BarButtonItem btnEtiketListesi;
        private DevExpress.XtraBars.BarStaticItem bsiPcName;
        private DevExpress.XtraBars.BarStaticItem bsiPsUserName;
        private DevExpress.XtraBars.BarStaticItem bsiAppUserName;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarButtonItem barBtnHataDokumu;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpProgram;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgHata;
        private DevExpress.XtraBars.BarButtonItem barBtnExit;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup OmegaHKSSistemi;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvBtnHKSBildirimYAp;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvBtnOlsanEtiketListesi;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvBtnHataListesi;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvBtnExit;
        private DevExpress.XtraBars.BarStaticItem bsiLisansBilgisi;
        private DevExpress.XtraBars.BarStaticItem bsiOracleUser;
        private DevExpress.XtraBars.BarButtonItem barBtnAlistanKunyeIsle;
        private DevExpress.XtraBars.BarButtonItem barBtnDMEslestirme;
        private DevExpress.XtraBars.BarButtonItem barBtnKunyeSorgula;
        private DevExpress.XtraBars.BarButtonItem barBtnBildirimAyarlari;
        private DevExpress.XtraBars.BarButtonItem barBtnStokSifirla;
    }
}