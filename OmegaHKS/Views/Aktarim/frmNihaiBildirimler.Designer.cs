namespace OmegaHKS.Views.Aktarim
{
    partial class frmNihaiBildirimler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNihaiBildirimler));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnNihaiBildirimSorgula = new DevExpress.XtraEditors.SimpleButton();
            this.chkKalanMiktariSifirdanBuyukOlanlar = new DevExpress.XtraEditors.CheckEdit();
            this.txtKunyeNo = new DevExpress.XtraEditors.TextEdit();
            this.dtBitisTarihi = new DevExpress.XtraEditors.DateEdit();
            this.dtBaslangicTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgcKunyeListeleri = new DevExpress.XtraGrid.GridControl();
            this.bildirimSorguDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvKunyeListeleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAnalizStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rsiBelgeTipi = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.belgeTipiDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colBildirimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBildirimTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rsiBildirimTuru = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bildirimTuruDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colBildirimciTcKimlikVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGidecekIsyeriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rsiGidecekSube = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsSubeler = new System.Windows.Forms.BindingSource(this.components);
            this.colGidecekYerTuruId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rsiGidecekYerTuru = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.isletmeTuruDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colKalanMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKunyeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinCinsKodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinCinsi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinKodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinSahibiTcKimlikVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinSatisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinTuruKodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktarBirimId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktarBirimiAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRusumMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUniqueId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUreticiTcKimlikVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsBidirimler = new System.Windows.Forms.BindingSource(this.components);
            this.ucsBTNKayitIpal1 = new OmegaHKS.Views.UserControls.ucsBTNKayitIpal();
            this.contextMenuStripExcell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barBtnExportToFile = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrintPrivew = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkKalanMiktariSifirdanBuyukOlanlar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKunyeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcKunyeListeleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildirimSorguDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunyeListeleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiBelgeTipi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.belgeTipiDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiBildirimTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildirimTuruDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiGidecekSube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubeler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiGidecekYerTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmeTuruDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBidirimler)).BeginInit();
            this.contextMenuStripExcell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnNihaiBildirimSorgula);
            this.groupControl1.Controls.Add(this.chkKalanMiktariSifirdanBuyukOlanlar);
            this.groupControl1.Controls.Add(this.txtKunyeNo);
            this.groupControl1.Controls.Add(this.dtBitisTarihi);
            this.groupControl1.Controls.Add(this.dtBaslangicTarihi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 32);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1183, 100);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Sorgulama Kriterleri";
            // 
            // btnNihaiBildirimSorgula
            // 
            this.btnNihaiBildirimSorgula.Image = global::OmegaHKS.Properties.Resources._1447276817_notification_done_32;
            this.btnNihaiBildirimSorgula.Location = new System.Drawing.Point(658, 30);
            this.btnNihaiBildirimSorgula.Name = "btnNihaiBildirimSorgula";
            this.btnNihaiBildirimSorgula.Size = new System.Drawing.Size(134, 51);
            this.btnNihaiBildirimSorgula.TabIndex = 4;
            this.btnNihaiBildirimSorgula.Text = "Bildirimleri Sorgula";
            this.btnNihaiBildirimSorgula.Click += new System.EventHandler(this.btnNihaiBildirimSorgula_Click);
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
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.dgcKunyeListeleri);
            this.groupControl2.Location = new System.Drawing.Point(12, 138);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1183, 382);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Bildirim Listeleri";
            // 
            // dgcKunyeListeleri
            // 
            this.dgcKunyeListeleri.DataSource = this.bildirimSorguDTOBindingSource;
            this.dgcKunyeListeleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcKunyeListeleri.Location = new System.Drawing.Point(2, 20);
            this.dgcKunyeListeleri.MainView = this.dgvKunyeListeleri;
            this.dgcKunyeListeleri.Name = "dgcKunyeListeleri";
            this.dgcKunyeListeleri.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rsiGidecekSube,
            this.rsiBelgeTipi,
            this.rsiGidecekYerTuru,
            this.rsiBildirimTuru});
            this.dgcKunyeListeleri.Size = new System.Drawing.Size(1179, 360);
            this.dgcKunyeListeleri.TabIndex = 0;
            this.dgcKunyeListeleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvKunyeListeleri});
            // 
            // bildirimSorguDTOBindingSource
            // 
            this.bildirimSorguDTOBindingSource.DataSource = typeof(OmegaHKS.BildirimServiceReference.BildirimSorguDTO);
            // 
            // dgvKunyeListeleri
            // 
            this.dgvKunyeListeleri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAnalizStatus,
            this.colBelgeNo,
            this.colBelgeTipi,
            this.colBildirimTarihi,
            this.colBildirimTuru,
            this.colBildirimciTcKimlikVergiNo,
            this.colGidecekIsyeriId,
            this.colGidecekYerTuruId,
            this.colKalanMiktar,
            this.colKunyeNo,
            this.colMalinAdi,
            this.colMalinCinsKodNo,
            this.colMalinCinsi,
            this.colMalinKodNo,
            this.colMalinMiktari,
            this.colMalinSahibiTcKimlikVergiNo,
            this.colMalinSatisFiyati,
            this.colMalinTuru,
            this.colMalinTuruKodNo,
            this.colMiktarBirimId,
            this.colMiktarBirimiAd,
            this.colRusumMiktari,
            this.colUniqueId,
            this.colUreticiTcKimlikVergiNo});
            this.dgvKunyeListeleri.GridControl = this.dgcKunyeListeleri;
            this.dgvKunyeListeleri.GroupPanelText = "Gruplamak istediğiniz kolonu sürükleyip buruya bırakın";
            this.dgvKunyeListeleri.Name = "dgvKunyeListeleri";
            this.dgvKunyeListeleri.OptionsView.ShowAutoFilterRow = true;
            this.dgvKunyeListeleri.DataSourceChanged += new System.EventHandler(this.dgvKunyeListeleri_DataSourceChanged);
            // 
            // colAnalizStatus
            // 
            this.colAnalizStatus.FieldName = "AnalizStatus";
            this.colAnalizStatus.Name = "colAnalizStatus";
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.VisibleIndex = 0;
            // 
            // colBelgeTipi
            // 
            this.colBelgeTipi.ColumnEdit = this.rsiBelgeTipi;
            this.colBelgeTipi.FieldName = "BelgeTipi";
            this.colBelgeTipi.Name = "colBelgeTipi";
            this.colBelgeTipi.Visible = true;
            this.colBelgeTipi.VisibleIndex = 1;
            // 
            // rsiBelgeTipi
            // 
            this.rsiBelgeTipi.AutoHeight = false;
            this.rsiBelgeTipi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rsiBelgeTipi.DataSource = this.belgeTipiDTOBindingSource;
            this.rsiBelgeTipi.DisplayMember = "BelgeTipiAdi";
            this.rsiBelgeTipi.Name = "rsiBelgeTipi";
            this.rsiBelgeTipi.ValueMember = "Id";
            // 
            // belgeTipiDTOBindingSource
            // 
            this.belgeTipiDTOBindingSource.DataSource = typeof(OmegaHKS.BildirimServiceReference.BelgeTipiDTO);
            // 
            // colBildirimTarihi
            // 
            this.colBildirimTarihi.FieldName = "BildirimTarihi";
            this.colBildirimTarihi.Name = "colBildirimTarihi";
            this.colBildirimTarihi.Visible = true;
            this.colBildirimTarihi.VisibleIndex = 2;
            // 
            // colBildirimTuru
            // 
            this.colBildirimTuru.ColumnEdit = this.rsiBildirimTuru;
            this.colBildirimTuru.FieldName = "BildirimTuru";
            this.colBildirimTuru.Name = "colBildirimTuru";
            this.colBildirimTuru.Visible = true;
            this.colBildirimTuru.VisibleIndex = 3;
            // 
            // rsiBildirimTuru
            // 
            this.rsiBildirimTuru.AutoHeight = false;
            this.rsiBildirimTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rsiBildirimTuru.DataSource = this.bildirimTuruDTOBindingSource;
            this.rsiBildirimTuru.DisplayMember = "BildirimTuruAdi";
            this.rsiBildirimTuru.Name = "rsiBildirimTuru";
            this.rsiBildirimTuru.ValueMember = "Id";
            // 
            // bildirimTuruDTOBindingSource
            // 
            this.bildirimTuruDTOBindingSource.DataSource = typeof(OmegaHKS.BildirimServiceReference.BildirimTuruDTO);
            // 
            // colBildirimciTcKimlikVergiNo
            // 
            this.colBildirimciTcKimlikVergiNo.FieldName = "BildirimciTcKimlikVergiNo";
            this.colBildirimciTcKimlikVergiNo.Name = "colBildirimciTcKimlikVergiNo";
            this.colBildirimciTcKimlikVergiNo.Visible = true;
            this.colBildirimciTcKimlikVergiNo.VisibleIndex = 4;
            // 
            // colGidecekIsyeriId
            // 
            this.colGidecekIsyeriId.ColumnEdit = this.rsiGidecekSube;
            this.colGidecekIsyeriId.FieldName = "GidecekIsyeriId";
            this.colGidecekIsyeriId.Name = "colGidecekIsyeriId";
            this.colGidecekIsyeriId.Visible = true;
            this.colGidecekIsyeriId.VisibleIndex = 5;
            // 
            // rsiGidecekSube
            // 
            this.rsiGidecekSube.AutoHeight = false;
            this.rsiGidecekSube.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rsiGidecekSube.DataSource = this.bsSubeler;
            this.rsiGidecekSube.DisplayMember = "SubeAdi";
            this.rsiGidecekSube.Name = "rsiGidecekSube";
            this.rsiGidecekSube.ValueMember = "Id";
            // 
            // bsSubeler
            // 
            this.bsSubeler.DataSource = typeof(OmegaHKS.GenelServiceReference.SubeDTO);
            // 
            // colGidecekYerTuruId
            // 
            this.colGidecekYerTuruId.ColumnEdit = this.rsiGidecekYerTuru;
            this.colGidecekYerTuruId.FieldName = "GidecekYerTuruId";
            this.colGidecekYerTuruId.Name = "colGidecekYerTuruId";
            this.colGidecekYerTuruId.Visible = true;
            this.colGidecekYerTuruId.VisibleIndex = 6;
            // 
            // rsiGidecekYerTuru
            // 
            this.rsiGidecekYerTuru.AutoHeight = false;
            this.rsiGidecekYerTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rsiGidecekYerTuru.DataSource = this.isletmeTuruDTOBindingSource;
            this.rsiGidecekYerTuru.DisplayMember = "IsletmeTuruAdi";
            this.rsiGidecekYerTuru.Name = "rsiGidecekYerTuru";
            this.rsiGidecekYerTuru.ValueMember = "Id";
            // 
            // isletmeTuruDTOBindingSource
            // 
            this.isletmeTuruDTOBindingSource.DataSource = typeof(OmegaHKS.GenelServiceReference.IsletmeTuruDTO);
            // 
            // colKalanMiktar
            // 
            this.colKalanMiktar.FieldName = "KalanMiktar";
            this.colKalanMiktar.Name = "colKalanMiktar";
            this.colKalanMiktar.Visible = true;
            this.colKalanMiktar.VisibleIndex = 13;
            // 
            // colKunyeNo
            // 
            this.colKunyeNo.FieldName = "KunyeNo";
            this.colKunyeNo.Name = "colKunyeNo";
            this.colKunyeNo.Visible = true;
            this.colKunyeNo.VisibleIndex = 7;
            // 
            // colMalinAdi
            // 
            this.colMalinAdi.FieldName = "MalinAdi";
            this.colMalinAdi.Name = "colMalinAdi";
            this.colMalinAdi.Visible = true;
            this.colMalinAdi.VisibleIndex = 9;
            // 
            // colMalinCinsKodNo
            // 
            this.colMalinCinsKodNo.FieldName = "MalinCinsKodNo";
            this.colMalinCinsKodNo.Name = "colMalinCinsKodNo";
            this.colMalinCinsKodNo.Visible = true;
            this.colMalinCinsKodNo.VisibleIndex = 10;
            // 
            // colMalinCinsi
            // 
            this.colMalinCinsi.FieldName = "MalinCinsi";
            this.colMalinCinsi.Name = "colMalinCinsi";
            this.colMalinCinsi.Visible = true;
            this.colMalinCinsi.VisibleIndex = 11;
            // 
            // colMalinKodNo
            // 
            this.colMalinKodNo.FieldName = "MalinKodNo";
            this.colMalinKodNo.Name = "colMalinKodNo";
            this.colMalinKodNo.Visible = true;
            this.colMalinKodNo.VisibleIndex = 8;
            // 
            // colMalinMiktari
            // 
            this.colMalinMiktari.FieldName = "MalinMiktari";
            this.colMalinMiktari.Name = "colMalinMiktari";
            this.colMalinMiktari.Visible = true;
            this.colMalinMiktari.VisibleIndex = 12;
            // 
            // colMalinSahibiTcKimlikVergiNo
            // 
            this.colMalinSahibiTcKimlikVergiNo.FieldName = "MalinSahibiTcKimlikVergiNo";
            this.colMalinSahibiTcKimlikVergiNo.Name = "colMalinSahibiTcKimlikVergiNo";
            this.colMalinSahibiTcKimlikVergiNo.Visible = true;
            this.colMalinSahibiTcKimlikVergiNo.VisibleIndex = 14;
            // 
            // colMalinSatisFiyati
            // 
            this.colMalinSatisFiyati.FieldName = "MalinSatisFiyati";
            this.colMalinSatisFiyati.Name = "colMalinSatisFiyati";
            this.colMalinSatisFiyati.Visible = true;
            this.colMalinSatisFiyati.VisibleIndex = 15;
            // 
            // colMalinTuru
            // 
            this.colMalinTuru.FieldName = "MalinTuru";
            this.colMalinTuru.Name = "colMalinTuru";
            this.colMalinTuru.Visible = true;
            this.colMalinTuru.VisibleIndex = 16;
            // 
            // colMalinTuruKodNo
            // 
            this.colMalinTuruKodNo.FieldName = "MalinTuruKodNo";
            this.colMalinTuruKodNo.Name = "colMalinTuruKodNo";
            this.colMalinTuruKodNo.Visible = true;
            this.colMalinTuruKodNo.VisibleIndex = 17;
            // 
            // colMiktarBirimId
            // 
            this.colMiktarBirimId.FieldName = "MiktarBirimId";
            this.colMiktarBirimId.Name = "colMiktarBirimId";
            // 
            // colMiktarBirimiAd
            // 
            this.colMiktarBirimiAd.FieldName = "MiktarBirimiAd";
            this.colMiktarBirimiAd.Name = "colMiktarBirimiAd";
            this.colMiktarBirimiAd.Visible = true;
            this.colMiktarBirimiAd.VisibleIndex = 18;
            // 
            // colRusumMiktari
            // 
            this.colRusumMiktari.FieldName = "RusumMiktari";
            this.colRusumMiktari.Name = "colRusumMiktari";
            this.colRusumMiktari.Visible = true;
            this.colRusumMiktari.VisibleIndex = 19;
            // 
            // colUniqueId
            // 
            this.colUniqueId.FieldName = "UniqueId";
            this.colUniqueId.Name = "colUniqueId";
            this.colUniqueId.Visible = true;
            this.colUniqueId.VisibleIndex = 21;
            // 
            // colUreticiTcKimlikVergiNo
            // 
            this.colUreticiTcKimlikVergiNo.FieldName = "UreticiTcKimlikVergiNo";
            this.colUreticiTcKimlikVergiNo.Name = "colUreticiTcKimlikVergiNo";
            this.colUreticiTcKimlikVergiNo.Visible = true;
            this.colUreticiTcKimlikVergiNo.VisibleIndex = 20;
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
            this.ucsBTNKayitIpal1.Location = new System.Drawing.Point(0, 526);
            this.ucsBTNKayitIpal1.Name = "ucsBTNKayitIpal1";
            this.ucsBTNKayitIpal1.Size = new System.Drawing.Size(1207, 52);
            this.ucsBTNKayitIpal1.TabIndex = 1;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1207, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 578);
            this.barDockControlBottom.Size = new System.Drawing.Size(1207, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 554);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1207, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 554);
            // 
            // frmNihaiBildirimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 578);
            this.Controls.Add(this.ucsBTNKayitIpal1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNihaiBildirimler";
            this.Text = "Nihai Bildirim Sorgulama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNihaiBildirimler_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkKalanMiktariSifirdanBuyukOlanlar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKunyeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBitisTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBaslangicTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcKunyeListeleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildirimSorguDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKunyeListeleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiBelgeTipi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.belgeTipiDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiBildirimTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildirimTuruDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiGidecekSube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSubeler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiGidecekYerTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isletmeTuruDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBidirimler)).EndInit();
            this.contextMenuStripExcell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnNihaiBildirimSorgula;
        private DevExpress.XtraEditors.CheckEdit chkKalanMiktariSifirdanBuyukOlanlar;
        private DevExpress.XtraEditors.TextEdit txtKunyeNo;
        private DevExpress.XtraEditors.DateEdit dtBitisTarihi;
        private DevExpress.XtraEditors.DateEdit dtBaslangicTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dgcKunyeListeleri;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvKunyeListeleri;
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
        private System.Windows.Forms.BindingSource bildirimSorguDTOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colAnalizStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colBildirimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colBildirimTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBildirimciTcKimlikVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colGidecekIsyeriId;
        private DevExpress.XtraGrid.Columns.GridColumn colGidecekYerTuruId;
        private DevExpress.XtraGrid.Columns.GridColumn colKalanMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKunyeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinCinsKodNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinCinsi;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinKodNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinSahibiTcKimlikVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinSatisFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinTuruKodNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktarBirimId;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktarBirimiAd;
        private DevExpress.XtraGrid.Columns.GridColumn colRusumMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colUniqueId;
        private DevExpress.XtraGrid.Columns.GridColumn colUreticiTcKimlikVergiNo;
        private System.Windows.Forms.BindingSource bsSubeler;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rsiBelgeTipi;
        private System.Windows.Forms.BindingSource belgeTipiDTOBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rsiGidecekSube;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rsiGidecekYerTuru;
        private System.Windows.Forms.BindingSource isletmeTuruDTOBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rsiBildirimTuru;
        private System.Windows.Forms.BindingSource bildirimTuruDTOBindingSource;
    }
}