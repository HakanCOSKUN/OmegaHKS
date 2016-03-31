namespace OmegaHKS.Views.Aktarim
{
    partial class frmReferansBildirimler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReferansBildirimler));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgcKunyeListeleri = new DevExpress.XtraGrid.GridControl();
            this.dgvKunyeListeleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnReferansBildirimSorgula = new DevExpress.XtraEditors.SimpleButton();
            this.chkKalanMiktariSifirdanBuyukOlanlar = new DevExpress.XtraEditors.CheckEdit();
            this.txtKunyeNo = new DevExpress.XtraEditors.TextEdit();
            this.dtBitisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dtBaslangicTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bsBidirimler = new System.Windows.Forms.BindingSource();
            this.ucsBTNKayitIpal1 = new OmegaHKS.Views.UserControls.ucsBTNKayitIpal();
            this.contextMenuStripExcell = new System.Windows.Forms.ContextMenuStrip();
            this.exportToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnExportToFile = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrintPrivew = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcKunyeListeleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunyeListeleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkKalanMiktariSifirdanBuyukOlanlar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKunyeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBidirimler)).BeginInit();
            this.contextMenuStripExcell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.dgcKunyeListeleri);
            this.groupControl2.Location = new System.Drawing.Point(12, 126);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(882, 399);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Bildirim Listeleri";
            // 
            // dgcKunyeListeleri
            // 
            this.dgcKunyeListeleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcKunyeListeleri.Location = new System.Drawing.Point(2, 21);
            this.dgcKunyeListeleri.MainView = this.dgvKunyeListeleri;
            this.dgcKunyeListeleri.Name = "dgcKunyeListeleri";
            this.dgcKunyeListeleri.Size = new System.Drawing.Size(878, 376);
            this.dgcKunyeListeleri.TabIndex = 0;
            this.dgcKunyeListeleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvKunyeListeleri});
            // 
            // dgvKunyeListeleri
            // 
            this.dgvKunyeListeleri.GridControl = this.dgcKunyeListeleri;
            this.dgvKunyeListeleri.GroupPanelText = "Gruplamak istediğiniz kolonu sürükleyip buruya bırakın";
            this.dgvKunyeListeleri.Name = "dgvKunyeListeleri";
            this.dgvKunyeListeleri.OptionsView.ShowAutoFilterRow = true;
            this.dgvKunyeListeleri.DataSourceChanged += new System.EventHandler(this.dgvKunyeListeleri_DataSourceChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnReferansBildirimSorgula);
            this.groupControl1.Controls.Add(this.chkKalanMiktariSifirdanBuyukOlanlar);
            this.groupControl1.Controls.Add(this.txtKunyeNo);
            this.groupControl1.Controls.Add(this.dtBitisTarihi);
            this.groupControl1.Controls.Add(this.dtBaslangicTarihi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 32);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(882, 88);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Sorgulama Kriterleri";
            // 
            // btnReferansBildirimSorgula
            // 
            this.btnReferansBildirimSorgula.Image = global::OmegaHKS.Properties.Resources._1447276817_notification_done_32;
            this.btnReferansBildirimSorgula.Location = new System.Drawing.Point(658, 30);
            this.btnReferansBildirimSorgula.Name = "btnReferansBildirimSorgula";
            this.btnReferansBildirimSorgula.Size = new System.Drawing.Size(134, 51);
            this.btnReferansBildirimSorgula.TabIndex = 4;
            this.btnReferansBildirimSorgula.Text = "Bildirimleri Sorgula";
            this.btnReferansBildirimSorgula.Click += new System.EventHandler(this.btnReferansBildirimSorgula_Click);
            // 
            // chkKalanMiktariSifirdanBuyukOlanlar
            // 
            this.chkKalanMiktariSifirdanBuyukOlanlar.Location = new System.Drawing.Point(430, 62);
            this.chkKalanMiktariSifirdanBuyukOlanlar.Name = "chkKalanMiktariSifirdanBuyukOlanlar";
            this.chkKalanMiktariSifirdanBuyukOlanlar.Properties.Caption = "Kalan Miktarı 0\'dan Büyük Olanlar";
            this.chkKalanMiktariSifirdanBuyukOlanlar.Size = new System.Drawing.Size(194, 19);
            this.chkKalanMiktariSifirdanBuyukOlanlar.TabIndex = 3;
            // 
            // txtKunyeNo
            // 
            this.txtKunyeNo.EditValue = "0";
            this.txtKunyeNo.Location = new System.Drawing.Point(430, 33);
            this.txtKunyeNo.Name = "txtKunyeNo";
            this.txtKunyeNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtKunyeNo.Size = new System.Drawing.Size(196, 20);
            this.txtKunyeNo.TabIndex = 2;
            // 
            // dtBitisTarihi
            // 
            this.dtBitisTarihi.EditValue = null;
            this.dtBitisTarihi.Location = new System.Drawing.Point(124, 62);
            this.dtBitisTarihi.Name = "dtBitisTarihi";
            this.dtBitisTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBitisTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBitisTarihi.Size = new System.Drawing.Size(161, 20);
            this.dtBitisTarihi.TabIndex = 1;
            // 
            // dtBaslangicTarihi
            // 
            this.dtBaslangicTarihi.EditValue = null;
            this.dtBaslangicTarihi.Location = new System.Drawing.Point(124, 33);
            this.dtBaslangicTarihi.Name = "dtBaslangicTarihi";
            this.dtBaslangicTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBaslangicTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBaslangicTarihi.Size = new System.Drawing.Size(161, 20);
            this.dtBaslangicTarihi.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Bitiş Tarihi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Başlangıç Tarihi";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(368, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Künye No";
            // 
            // ucsBTNKayitIpal1
            // 
            this.ucsBTNKayitIpal1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucsBTNKayitIpal1.IptalEnabled = true;
            this.ucsBTNKayitIpal1.IptalImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.IptalImage")));
            this.ucsBTNKayitIpal1.IptalText = "İ&ptal";
            this.ucsBTNKayitIpal1.IptalVisible = true;
            this.ucsBTNKayitIpal1.KaydetEnabled = true;
            this.ucsBTNKayitIpal1.KaydetImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.KaydetImage")));
            this.ucsBTNKayitIpal1.KaydetText = "&Kaydet";
            this.ucsBTNKayitIpal1.KaydetVisible = false;
            this.ucsBTNKayitIpal1.Location = new System.Drawing.Point(0, 531);
            this.ucsBTNKayitIpal1.Name = "ucsBTNKayitIpal1";
            this.ucsBTNKayitIpal1.Size = new System.Drawing.Size(906, 52);
            this.ucsBTNKayitIpal1.TabIndex = 3;
            this.ucsBTNKayitIpal1.TemizleImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.TemizleImage")));
            this.ucsBTNKayitIpal1.TemizleText = "&Temizle";
            this.ucsBTNKayitIpal1.TemizleVisible = false;
            this.ucsBTNKayitIpal1.ClickIptal += new System.EventHandler(this.ucsBTNKayitIpal1_ClickIptal);
            // 
            // contextMenuStripExcell
            // 
            this.contextMenuStripExcell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToFileToolStripMenuItem,
            this.printViewToolStripMenuItem,
            this.printToolStripMenuItem});
            this.contextMenuStripExcell.Name = "contextMenuStripExcell";
            this.contextMenuStripExcell.Size = new System.Drawing.Size(160, 70);
            // 
            // exportToFileToolStripMenuItem
            // 
            this.exportToFileToolStripMenuItem.Name = "exportToFileToolStripMenuItem";
            this.exportToFileToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exportToFileToolStripMenuItem.Text = "Excell\'e Aktar";
            this.exportToFileToolStripMenuItem.Click += new System.EventHandler(this.exportToFileToolStripMenuItem_Click);
            // 
            // printViewToolStripMenuItem
            // 
            this.printViewToolStripMenuItem.Name = "printViewToolStripMenuItem";
            this.printViewToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.printViewToolStripMenuItem.Text = "Yazici Ön İzleme";
            this.printViewToolStripMenuItem.Click += new System.EventHandler(this.printViewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.printToolStripMenuItem.Text = "Yazdir";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtnExportToFile,
            this.barBtnPrintPrivew,
            this.barBtnPrint});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnExportToFile, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnPrintPrivew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnPrint, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barBtnExportToFile
            // 
            this.barBtnExportToFile.Caption = "Dışarı Aktar";
            this.barBtnExportToFile.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExportToFile.Glyph")));
            this.barBtnExportToFile.Id = 0;
            this.barBtnExportToFile.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnExportToFile.LargeGlyph")));
            this.barBtnExportToFile.Name = "barBtnExportToFile";
            this.barBtnExportToFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExportToFile_ItemClick);
            // 
            // barBtnPrintPrivew
            // 
            this.barBtnPrintPrivew.Caption = "Çıktı Ön İzleme";
            this.barBtnPrintPrivew.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnPrintPrivew.Glyph")));
            this.barBtnPrintPrivew.Id = 1;
            this.barBtnPrintPrivew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnPrintPrivew.LargeGlyph")));
            this.barBtnPrintPrivew.Name = "barBtnPrintPrivew";
            this.barBtnPrintPrivew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPrintPrivew_ItemClick);
            // 
            // barBtnPrint
            // 
            this.barBtnPrint.Caption = "Yazdır";
            this.barBtnPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnPrint.Glyph")));
            this.barBtnPrint.Id = 2;
            this.barBtnPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnPrint.LargeGlyph")));
            this.barBtnPrint.Name = "barBtnPrint";
            this.barBtnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPrint_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(906, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 583);
            this.barDockControlBottom.Size = new System.Drawing.Size(906, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 559);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(906, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 559);
            // 
            // frmReferansBildirimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 583);
            this.Controls.Add(this.ucsBTNKayitIpal1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReferansBildirimler";
            this.Text = "Referans Bildirim Sorgulama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReferansBildirimler_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcKunyeListeleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunyeListeleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkKalanMiktariSifirdanBuyukOlanlar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKunyeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBidirimler)).EndInit();
            this.contextMenuStripExcell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgcKunyeListeleri;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvKunyeListeleri;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnReferansBildirimSorgula;
        private DevExpress.XtraEditors.CheckEdit chkKalanMiktariSifirdanBuyukOlanlar;
        private DevExpress.XtraEditors.TextEdit txtKunyeNo;
        private DevExpress.XtraEditors.DateEdit dtBitisTarihi;
        private DevExpress.XtraEditors.DateEdit dtBaslangicTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bsBidirimler;
        private UserControls.ucsBTNKayitIpal ucsBTNKayitIpal1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripExcell;
        private System.Windows.Forms.ToolStripMenuItem exportToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barBtnExportToFile;
        private DevExpress.XtraBars.BarButtonItem barBtnPrintPrivew;
        private DevExpress.XtraBars.BarButtonItem barBtnPrint;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}