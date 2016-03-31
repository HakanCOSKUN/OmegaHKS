namespace OmegaHKS.Views.Aktarim
{
    partial class frmEtiketViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEtiketViewer));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.beCozunurluk = new DevExpress.XtraBars.BarEditItem();
            this.ricbCozunurluk = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.bbtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnExportToPdf = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bbPNG = new DevExpress.XtraBars.BarButtonItem();
            this.bbJPEG = new DevExpress.XtraBars.BarButtonItem();
            this.bbTIFF = new DevExpress.XtraBars.BarButtonItem();
            this.bbGIF = new DevExpress.XtraBars.BarButtonItem();
            this.bbBMP = new DevExpress.XtraBars.BarButtonItem();
            this.bbXmlTemplate = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.brcLang = new DevExpress.XtraBars.BarEditItem();
            this.rcbLang = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.gcEtiket = new DevExpress.XtraEditors.GroupControl();
            this.uscImageViewer1 = new OmegaHKS.Views.UserControls.uscImageViewer();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbCozunurluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEtiket)).BeginInit();
            this.gcEtiket.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barHeaderItem1,
            this.beCozunurluk,
            this.bbtnPrint,
            this.bbtnExportToPdf,
            this.barSubItem1,
            this.bbPNG,
            this.bbJPEG,
            this.bbTIFF,
            this.bbGIF,
            this.bbBMP,
            this.bbXmlTemplate,
            this.barStaticItem1,
            this.brcLang,
            this.barStaticItem2,
            this.barStaticItem3});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 21;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ricbCozunurluk,
            this.rcbLang});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.beCozunurluk),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnExportToPdf, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbXmlTemplate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = " Çıktı Ön İzleme Çözünürlüğü ";
            this.barStaticItem1.Id = 17;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // beCozunurluk
            // 
            this.beCozunurluk.Caption = "Çözünürlük";
            this.beCozunurluk.Edit = this.ricbCozunurluk;
            this.beCozunurluk.EditWidth = 100;
            this.beCozunurluk.Id = 6;
            this.beCozunurluk.Name = "beCozunurluk";
            this.beCozunurluk.EditValueChanged += new System.EventHandler(this.beCozunurluk_EditValueChanged);
            // 
            // ricbCozunurluk
            // 
            this.ricbCozunurluk.AutoHeight = false;
            this.ricbCozunurluk.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ricbCozunurluk.DropDownRows = 4;
            this.ricbCozunurluk.Items.AddRange(new object[] {
            "Ekran",
            "203",
            "300",
            "600"});
            this.ricbCozunurluk.Name = "ricbCozunurluk";
            // 
            // bbtnPrint
            // 
            this.bbtnPrint.Caption = "Yazdır";
            this.bbtnPrint.Glyph = global::OmegaHKS.Properties.Resources.ThermalPrinterIcon32x32;
            this.bbtnPrint.Id = 7;
            this.bbtnPrint.Name = "bbtnPrint";
            this.bbtnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnPrint_ItemClick);
            // 
            // bbtnExportToPdf
            // 
            this.bbtnExportToPdf.Caption = "PDF Kaydet";
            this.bbtnExportToPdf.Glyph = global::OmegaHKS.Properties.Resources.PDF;
            this.bbtnExportToPdf.Id = 8;
            this.bbtnExportToPdf.Name = "bbtnExportToPdf";
            this.bbtnExportToPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnExportToPdf_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Resim Olarak Kaydet";
            this.barSubItem1.Glyph = global::OmegaHKS.Properties.Resources.ImageFile;
            this.barSubItem1.Id = 10;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbPNG),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbJPEG),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbTIFF),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbGIF),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbBMP)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // bbPNG
            // 
            this.bbPNG.Caption = "PNG";
            this.bbPNG.Id = 11;
            this.bbPNG.Name = "bbPNG";
            this.bbPNG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbPNG_ItemClick);
            // 
            // bbJPEG
            // 
            this.bbJPEG.Caption = "JPEG";
            this.bbJPEG.Id = 12;
            this.bbJPEG.Name = "bbJPEG";
            this.bbJPEG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbJPEG_ItemClick);
            // 
            // bbTIFF
            // 
            this.bbTIFF.Caption = "TIFF";
            this.bbTIFF.Id = 13;
            this.bbTIFF.Name = "bbTIFF";
            this.bbTIFF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbTIFF_ItemClick);
            // 
            // bbGIF
            // 
            this.bbGIF.Caption = "GIF";
            this.bbGIF.Id = 14;
            this.bbGIF.Name = "bbGIF";
            this.bbGIF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbGIF_ItemClick);
            // 
            // bbBMP
            // 
            this.bbBMP.Caption = "BMP";
            this.bbBMP.Id = 15;
            this.bbBMP.Name = "bbBMP";
            this.bbBMP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbBMP_ItemClick);
            // 
            // bbXmlTemplate
            // 
            this.bbXmlTemplate.Caption = "XML Kaydet";
            this.bbXmlTemplate.Glyph = global::OmegaHKS.Properties.Resources.TOXML;
            this.bbXmlTemplate.Id = 16;
            this.bbXmlTemplate.Name = "bbXmlTemplate";
            this.bbXmlTemplate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbXmlTemplate_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(797, 60);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 518);
            this.barDockControlBottom.Size = new System.Drawing.Size(797, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 60);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 458);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(797, 60);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 458);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = " Çıktı Ön İzleme Çözünürlüğü ";
            this.barHeaderItem1.Id = 0;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // brcLang
            // 
            this.brcLang.Caption = "Çıktı Dili";
            this.brcLang.Edit = this.rcbLang;
            this.brcLang.Id = 18;
            this.brcLang.Name = "brcLang";
            // 
            // rcbLang
            // 
            this.rcbLang.AutoHeight = false;
            this.rcbLang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rcbLang.Items.AddRange(new object[] {
            "TR",
            "RU"});
            this.rcbLang.Name = "rcbLang";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Baski Dili";
            this.barStaticItem2.Id = 19;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "|";
            this.barStaticItem3.Id = 20;
            this.barStaticItem3.Name = "barStaticItem3";
            this.barStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // gcEtiket
            // 
            this.gcEtiket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcEtiket.Controls.Add(this.uscImageViewer1);
            this.gcEtiket.Location = new System.Drawing.Point(12, 46);
            this.gcEtiket.Name = "gcEtiket";
            this.gcEtiket.Size = new System.Drawing.Size(773, 440);
            this.gcEtiket.TabIndex = 3;
            this.gcEtiket.Text = "Etiket Çıktısı";
            // 
            // uscImageViewer1
            // 
            this.uscImageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscImageViewer1.Location = new System.Drawing.Point(2, 21);
            this.uscImageViewer1.Name = "uscImageViewer1";
            this.uscImageViewer1.Size = new System.Drawing.Size(769, 417);
            this.uscImageViewer1.TabIndex = 0;
            // 
            // frmEtiketViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 541);
            this.Controls.Add(this.gcEtiket);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEtiketViewer";
            this.Text = "Etiket Çıktı İzleme";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ricbCozunurluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbLang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEtiket)).EndInit();
            this.gcEtiket.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.GroupControl gcEtiket;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem beCozunurluk;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox ricbCozunurluk;
        private DevExpress.XtraBars.BarButtonItem bbtnPrint;
        private DevExpress.XtraBars.BarButtonItem bbtnExportToPdf;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem bbPNG;
        private DevExpress.XtraBars.BarButtonItem bbJPEG;
        private DevExpress.XtraBars.BarButtonItem bbTIFF;
        private DevExpress.XtraBars.BarButtonItem bbGIF;
        private DevExpress.XtraBars.BarButtonItem bbBMP;
        private DevExpress.XtraBars.BarButtonItem bbXmlTemplate;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem brcLang;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rcbLang;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private UserControls.uscImageViewer uscImageViewer1;
    }
}