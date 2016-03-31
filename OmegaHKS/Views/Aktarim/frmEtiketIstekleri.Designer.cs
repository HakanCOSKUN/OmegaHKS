namespace OmegaHKS.Views.Aktarim
{
    partial class frmEtiketIstekleri
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEtiketIstekleri));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnListeGetir = new DevExpress.XtraEditors.SimpleButton();
            this.txtDepoSube = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgcBelgeListesi = new DevExpress.XtraGrid.GridControl();
            this.dgvBelgeListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPOAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLAKANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colILID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colILCEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBELDEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsEtiket = new System.Windows.Forms.BindingSource(this.components);
            this.ucsBTNKayitIpal1 = new OmegaHKS.Views.UserControls.ucsBTNKayitIpal();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgcEtiketListesi = new DevExpress.XtraGrid.GridControl();
            this.dgvEtiketListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collDEPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collSTKKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collSTOKAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collKUNYENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collMALAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collMALCINSAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collURETIMTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collURETIMSEKLI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collURETIMYERI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collURETICI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStripEtiketYazdir = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.seciliEtiketleriYazdirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtDepoSube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcBelgeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBelgeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEtiket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEtiketListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtiketListesi)).BeginInit();
            this.contextMenuStripEtiketYazdir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnListeGetir);
            this.groupControl1.Controls.Add(this.txtDepoSube);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Location = new System.Drawing.Point(12, 30);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(793, 60);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Seçim Kriterleri";
            // 
            // btnListeGetir
            // 
            this.btnListeGetir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListeGetir.Image = global::OmegaHKS.Properties.Resources._1448145316_diagram_v2_32;
            this.btnListeGetir.Location = new System.Drawing.Point(668, 24);
            this.btnListeGetir.Name = "btnListeGetir";
            this.btnListeGetir.Size = new System.Drawing.Size(95, 33);
            this.btnListeGetir.TabIndex = 4;
            this.btnListeGetir.Text = "Listele";
            this.btnListeGetir.Click += new System.EventHandler(this.btnListeGetir_Click);
            // 
            // txtDepoSube
            // 
            this.txtDepoSube.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepoSube.Location = new System.Drawing.Point(292, 31);
            this.txtDepoSube.Name = "txtDepoSube";
            this.txtDepoSube.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F9), serializableAppearanceObject1, "", null, null, true)});
            this.txtDepoSube.Size = new System.Drawing.Size(359, 20);
            this.txtDepoSube.TabIndex = 3;
            this.txtDepoSube.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtDepoSube_ButtonClick);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(251, 35);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Şube";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(40, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tarih";
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(80, 32);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Size = new System.Drawing.Size(135, 20);
            this.txtTarih.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.dgcBelgeListesi);
            this.groupControl2.Location = new System.Drawing.Point(12, 96);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(794, 171);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Oluaşan Şube Depo Belge Listesi";
            // 
            // dgcBelgeListesi
            // 
            this.dgcBelgeListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcBelgeListesi.Location = new System.Drawing.Point(2, 20);
            this.dgcBelgeListesi.MainView = this.dgvBelgeListesi;
            this.dgcBelgeListesi.Name = "dgcBelgeListesi";
            this.dgcBelgeListesi.Size = new System.Drawing.Size(790, 149);
            this.dgcBelgeListesi.TabIndex = 0;
            this.dgcBelgeListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBelgeListesi});
            // 
            // dgvBelgeListesi
            // 
            this.dgvBelgeListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTARIH,
            this.colDEPNO,
            this.colDEPOAD,
            this.colPLAKANO,
            this.colBELGENO,
            this.colILID,
            this.colILCEID,
            this.colBELDEID});
            this.dgvBelgeListesi.GridControl = this.dgcBelgeListesi;
            this.dgvBelgeListesi.Name = "dgvBelgeListesi";
            this.dgvBelgeListesi.OptionsView.ShowGroupPanel = false;
            this.dgvBelgeListesi.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvEtiket_FocusedRowChanged);
            // 
            // colTARIH
            // 
            this.colTARIH.Caption = "Tarih";
            this.colTARIH.FieldName = "TARIH";
            this.colTARIH.Name = "colTARIH";
            this.colTARIH.OptionsColumn.AllowEdit = false;
            this.colTARIH.OptionsColumn.AllowFocus = false;
            this.colTARIH.OptionsColumn.ReadOnly = true;
            this.colTARIH.Visible = true;
            this.colTARIH.VisibleIndex = 0;
            // 
            // colDEPNO
            // 
            this.colDEPNO.Caption = "Dep.No";
            this.colDEPNO.FieldName = "DEPNO";
            this.colDEPNO.Name = "colDEPNO";
            this.colDEPNO.OptionsColumn.AllowEdit = false;
            this.colDEPNO.OptionsColumn.AllowFocus = false;
            this.colDEPNO.OptionsColumn.ReadOnly = true;
            this.colDEPNO.Visible = true;
            this.colDEPNO.VisibleIndex = 1;
            // 
            // colDEPOAD
            // 
            this.colDEPOAD.Caption = "Depo Açıklaması";
            this.colDEPOAD.FieldName = "DEPOAD";
            this.colDEPOAD.Name = "colDEPOAD";
            this.colDEPOAD.OptionsColumn.AllowEdit = false;
            this.colDEPOAD.OptionsColumn.AllowFocus = false;
            this.colDEPOAD.OptionsColumn.ReadOnly = true;
            this.colDEPOAD.Visible = true;
            this.colDEPOAD.VisibleIndex = 2;
            // 
            // colPLAKANO
            // 
            this.colPLAKANO.Caption = "Plaka";
            this.colPLAKANO.FieldName = "PLAKANO";
            this.colPLAKANO.Name = "colPLAKANO";
            this.colPLAKANO.OptionsColumn.AllowEdit = false;
            this.colPLAKANO.OptionsColumn.AllowFocus = false;
            this.colPLAKANO.OptionsColumn.ReadOnly = true;
            this.colPLAKANO.Visible = true;
            this.colPLAKANO.VisibleIndex = 3;
            // 
            // colBELGENO
            // 
            this.colBELGENO.Caption = "Belge No";
            this.colBELGENO.FieldName = "BELGENO";
            this.colBELGENO.Name = "colBELGENO";
            this.colBELGENO.OptionsColumn.AllowEdit = false;
            this.colBELGENO.OptionsColumn.AllowFocus = false;
            this.colBELGENO.OptionsColumn.ReadOnly = true;
            this.colBELGENO.Visible = true;
            this.colBELGENO.VisibleIndex = 4;
            // 
            // colILID
            // 
            this.colILID.Caption = "ILID";
            this.colILID.FieldName = "ILID";
            this.colILID.Name = "colILID";
            this.colILID.OptionsColumn.AllowEdit = false;
            this.colILID.OptionsColumn.AllowFocus = false;
            this.colILID.OptionsColumn.ReadOnly = true;
            // 
            // colILCEID
            // 
            this.colILCEID.Caption = "ILCEID";
            this.colILCEID.FieldName = "ILCEID";
            this.colILCEID.Name = "colILCEID";
            this.colILCEID.OptionsColumn.AllowEdit = false;
            this.colILCEID.OptionsColumn.AllowFocus = false;
            this.colILCEID.OptionsColumn.ReadOnly = true;
            // 
            // colBELDEID
            // 
            this.colBELDEID.Caption = "BELDEID";
            this.colBELDEID.FieldName = "BELDEID";
            this.colBELDEID.Name = "colBELDEID";
            this.colBELDEID.OptionsColumn.AllowEdit = false;
            this.colBELDEID.OptionsColumn.AllowFocus = false;
            this.colBELDEID.OptionsColumn.ReadOnly = true;
            // 
            // ucsBTNKayitIpal1
            // 
            this.ucsBTNKayitIpal1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucsBTNKayitIpal1.IptalEnabled = true;
            this.ucsBTNKayitIpal1.IptalImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.IptalImage")));
            this.ucsBTNKayitIpal1.IptalText = "&Kapat";
            this.ucsBTNKayitIpal1.IptalVisible = true;
            this.ucsBTNKayitIpal1.KaydetEnabled = true;
            this.ucsBTNKayitIpal1.KaydetImage = global::OmegaHKS.Properties.Resources.ThermalPrinterIcon32x32;
            this.ucsBTNKayitIpal1.KaydetText = "&Yazdir";
            this.ucsBTNKayitIpal1.KaydetVisible = true;
            this.ucsBTNKayitIpal1.Location = new System.Drawing.Point(0, 528);
            this.ucsBTNKayitIpal1.Name = "ucsBTNKayitIpal1";
            this.ucsBTNKayitIpal1.Size = new System.Drawing.Size(818, 52);
            this.ucsBTNKayitIpal1.TabIndex = 2;
            this.ucsBTNKayitIpal1.TemizleImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.TemizleImage")));
            this.ucsBTNKayitIpal1.TemizleText = "&Temizle";
            this.ucsBTNKayitIpal1.TemizleVisible = false;
            this.ucsBTNKayitIpal1.ClickKaydet += new System.EventHandler(this.ucsBTNKayitIpal1_ClickKaydet);
            this.ucsBTNKayitIpal1.ClickIptal += new System.EventHandler(this.ucsBTNKayitIpal1_ClickIptal);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.dgcEtiketListesi);
            this.groupControl3.Location = new System.Drawing.Point(12, 273);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(792, 249);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Oluşan Etiket Listesi";
            // 
            // dgcEtiketListesi
            // 
            this.dgcEtiketListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcEtiketListesi.Location = new System.Drawing.Point(2, 20);
            this.dgcEtiketListesi.MainView = this.dgvEtiketListesi;
            this.dgcEtiketListesi.Name = "dgcEtiketListesi";
            this.dgcEtiketListesi.Size = new System.Drawing.Size(788, 227);
            this.dgcEtiketListesi.TabIndex = 0;
            this.dgcEtiketListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvEtiketListesi});
            // 
            // dgvEtiketListesi
            // 
            this.dgvEtiketListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collTARIH,
            this.collDEPNO,
            this.collSTKKOD,
            this.collSTOKAD,
            this.collKUNYENO,
            this.collMALAD,
            this.collMALCINSAD,
            this.collURETIMTARIH,
            this.collURETIMSEKLI,
            this.collURETIMYERI,
            this.collURETICI});
            this.dgvEtiketListesi.GridControl = this.dgcEtiketListesi;
            this.dgvEtiketListesi.Name = "dgvEtiketListesi";
            this.dgvEtiketListesi.OptionsView.ShowGroupPanel = false;
            this.dgvEtiketListesi.DataSourceChanged += new System.EventHandler(this.dgvEtiketListesi_DataSourceChanged);
            // 
            // collTARIH
            // 
            this.collTARIH.Caption = "Tarih";
            this.collTARIH.FieldName = "TARIH";
            this.collTARIH.Name = "collTARIH";
            this.collTARIH.OptionsColumn.AllowEdit = false;
            this.collTARIH.OptionsColumn.AllowFocus = false;
            this.collTARIH.OptionsColumn.ReadOnly = true;
            // 
            // collDEPNO
            // 
            this.collDEPNO.Caption = "Dep No";
            this.collDEPNO.FieldName = "DEPNO";
            this.collDEPNO.Name = "collDEPNO";
            this.collDEPNO.OptionsColumn.AllowEdit = false;
            this.collDEPNO.OptionsColumn.AllowFocus = false;
            this.collDEPNO.OptionsColumn.ReadOnly = true;
            // 
            // collSTKKOD
            // 
            this.collSTKKOD.Caption = "Stok Kodu";
            this.collSTKKOD.FieldName = "STKKOD";
            this.collSTKKOD.Name = "collSTKKOD";
            this.collSTKKOD.OptionsColumn.AllowEdit = false;
            this.collSTKKOD.OptionsColumn.AllowFocus = false;
            this.collSTKKOD.OptionsColumn.ReadOnly = true;
            this.collSTKKOD.Visible = true;
            this.collSTKKOD.VisibleIndex = 0;
            // 
            // collSTOKAD
            // 
            this.collSTOKAD.Caption = "Stok Açıklama";
            this.collSTOKAD.FieldName = "STOKAD";
            this.collSTOKAD.Name = "collSTOKAD";
            this.collSTOKAD.OptionsColumn.AllowEdit = false;
            this.collSTOKAD.OptionsColumn.AllowFocus = false;
            this.collSTOKAD.OptionsColumn.ReadOnly = true;
            this.collSTOKAD.Visible = true;
            this.collSTOKAD.VisibleIndex = 1;
            // 
            // collKUNYENO
            // 
            this.collKUNYENO.Caption = "Künye";
            this.collKUNYENO.FieldName = "KUNYENO";
            this.collKUNYENO.Name = "collKUNYENO";
            this.collKUNYENO.OptionsColumn.AllowEdit = false;
            this.collKUNYENO.OptionsColumn.AllowFocus = false;
            this.collKUNYENO.OptionsColumn.ReadOnly = true;
            this.collKUNYENO.Visible = true;
            this.collKUNYENO.VisibleIndex = 2;
            // 
            // collMALAD
            // 
            this.collMALAD.Caption = "Mal Adı";
            this.collMALAD.FieldName = "MALAD";
            this.collMALAD.Name = "collMALAD";
            this.collMALAD.OptionsColumn.AllowEdit = false;
            this.collMALAD.OptionsColumn.AllowFocus = false;
            this.collMALAD.OptionsColumn.ReadOnly = true;
            this.collMALAD.Visible = true;
            this.collMALAD.VisibleIndex = 3;
            // 
            // collMALCINSAD
            // 
            this.collMALCINSAD.Caption = "Mal Cins Adı";
            this.collMALCINSAD.FieldName = "MALCINSAD";
            this.collMALCINSAD.Name = "collMALCINSAD";
            this.collMALCINSAD.OptionsColumn.AllowEdit = false;
            this.collMALCINSAD.OptionsColumn.AllowFocus = false;
            this.collMALCINSAD.OptionsColumn.ReadOnly = true;
            this.collMALCINSAD.Visible = true;
            this.collMALCINSAD.VisibleIndex = 4;
            // 
            // collURETIMTARIH
            // 
            this.collURETIMTARIH.Caption = "Ürt.Tarihi";
            this.collURETIMTARIH.FieldName = "URETIMTARIH";
            this.collURETIMTARIH.Name = "collURETIMTARIH";
            this.collURETIMTARIH.OptionsColumn.AllowEdit = false;
            this.collURETIMTARIH.OptionsColumn.AllowFocus = false;
            this.collURETIMTARIH.OptionsColumn.ReadOnly = true;
            this.collURETIMTARIH.Visible = true;
            this.collURETIMTARIH.VisibleIndex = 5;
            // 
            // collURETIMSEKLI
            // 
            this.collURETIMSEKLI.Caption = "Ürt. Şekli";
            this.collURETIMSEKLI.FieldName = "URETIMSEKLI";
            this.collURETIMSEKLI.Name = "collURETIMSEKLI";
            this.collURETIMSEKLI.OptionsColumn.AllowEdit = false;
            this.collURETIMSEKLI.OptionsColumn.AllowFocus = false;
            this.collURETIMSEKLI.OptionsColumn.ReadOnly = true;
            this.collURETIMSEKLI.Visible = true;
            this.collURETIMSEKLI.VisibleIndex = 6;
            // 
            // collURETIMYERI
            // 
            this.collURETIMYERI.Caption = "Ürt. Yeri";
            this.collURETIMYERI.FieldName = "URETIMYERI";
            this.collURETIMYERI.Name = "collURETIMYERI";
            this.collURETIMYERI.OptionsColumn.AllowEdit = false;
            this.collURETIMYERI.OptionsColumn.AllowFocus = false;
            this.collURETIMYERI.OptionsColumn.ReadOnly = true;
            this.collURETIMYERI.Visible = true;
            this.collURETIMYERI.VisibleIndex = 7;
            // 
            // collURETICI
            // 
            this.collURETICI.Caption = "Üretici";
            this.collURETICI.FieldName = "URETICI";
            this.collURETICI.Name = "collURETICI";
            this.collURETICI.OptionsColumn.AllowEdit = false;
            this.collURETICI.OptionsColumn.AllowFocus = false;
            this.collURETICI.OptionsColumn.ReadOnly = true;
            this.collURETICI.Visible = true;
            this.collURETICI.VisibleIndex = 8;
            // 
            // contextMenuStripEtiketYazdir
            // 
            this.contextMenuStripEtiketYazdir.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seciliEtiketleriYazdirToolStripMenuItem});
            this.contextMenuStripEtiketYazdir.Name = "contextMenuStripEtiketYazdir";
            this.contextMenuStripEtiketYazdir.Size = new System.Drawing.Size(184, 26);
            // 
            // seciliEtiketleriYazdirToolStripMenuItem
            // 
            this.seciliEtiketleriYazdirToolStripMenuItem.Name = "seciliEtiketleriYazdirToolStripMenuItem";
            this.seciliEtiketleriYazdirToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.seciliEtiketleriYazdirToolStripMenuItem.Text = "Secili Etiketleri Yazdır";
            this.seciliEtiketleriYazdirToolStripMenuItem.Click += new System.EventHandler(this.seciliEtiketleriYazdirToolStripMenuItem_Click);
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
            this.barDockControlTop.Size = new System.Drawing.Size(818, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 580);
            this.barDockControlBottom.Size = new System.Drawing.Size(818, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 556);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(818, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 556);
            // 
            // frmEtiketIstekleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 580);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.ucsBTNKayitIpal1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEtiketIstekleri";
            this.Text = "Oluşan Belge ve Etiket Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepoSube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcBelgeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBelgeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEtiket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcEtiketListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtiketListesi)).EndInit();
            this.contextMenuStripEtiketYazdir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgcBelgeListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBelgeListesi;
        private System.Windows.Forms.BindingSource bsEtiket;
        private DevExpress.XtraEditors.SimpleButton btnListeGetir;
        private DevExpress.XtraEditors.ButtonEdit txtDepoSube;
        private UserControls.ucsBTNKayitIpal ucsBTNKayitIpal1;
        private DevExpress.XtraGrid.Columns.GridColumn colTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPOAD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLAKANO;
        private DevExpress.XtraGrid.Columns.GridColumn colBELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn colILID;
        private DevExpress.XtraGrid.Columns.GridColumn colILCEID;
        private DevExpress.XtraGrid.Columns.GridColumn colBELDEID;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl dgcEtiketListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvEtiketListesi;
        private DevExpress.XtraGrid.Columns.GridColumn collTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn collDEPNO;
        private DevExpress.XtraGrid.Columns.GridColumn collSTKKOD;
        private DevExpress.XtraGrid.Columns.GridColumn collSTOKAD;
        private DevExpress.XtraGrid.Columns.GridColumn collKUNYENO;
        private DevExpress.XtraGrid.Columns.GridColumn collMALAD;
        private DevExpress.XtraGrid.Columns.GridColumn collMALCINSAD;
        private DevExpress.XtraGrid.Columns.GridColumn collURETIMTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn collURETIMSEKLI;
        private DevExpress.XtraGrid.Columns.GridColumn collURETIMYERI;
        private DevExpress.XtraGrid.Columns.GridColumn collURETICI;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripEtiketYazdir;
        private System.Windows.Forms.ToolStripMenuItem seciliEtiketleriYazdirToolStripMenuItem;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barBtnExportToFile;
        private DevExpress.XtraBars.BarButtonItem barBtnPrintPrivew;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnPrint;
    }
}