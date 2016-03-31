namespace OmegaHKS.Views.Eslestirme
{
    partial class frmUrunEslestirmeleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunEslestirmeleri));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgcUrunDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvUrunDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgcLocalUrunCinsiDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvLocalUrunCinsiDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collUrunId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collUrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collIthalmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collUretimSekilId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collUrunCinsiAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collUretimSekiliAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collOmegaStokSec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rsiBtnOmegaStokAra = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dgcLocalUrunDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvLocalUrunDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colllUrunId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colllUrunCinsiId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colllUretimSekilId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colllUrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colllSTKKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colllSTOKAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colllREYON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colllREYONAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colllBARKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colllAKTIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsUrunDTO = new System.Windows.Forms.BindingSource();
            this.bsLocalUrunCinsiDTO = new System.Windows.Forms.BindingSource();
            this.bsLocalUrunDTO = new System.Windows.Forms.BindingSource();
            this.contextMenuStripdgcLocalUrunDTO = new System.Windows.Forms.ContextMenuStrip();
            this.seciliUrunleriEslestirmedenKaldırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucsBTNKayitIpal1 = new OmegaHKS.Views.UserControls.ucsBTNKayitIpal();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcUrunDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcLocalUrunCinsiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalUrunCinsiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiBtnOmegaStokAra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcLocalUrunDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalUrunDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUrunDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalUrunCinsiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalUrunDTO)).BeginInit();
            this.contextMenuStripdgcLocalUrunDTO.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.splitContainer1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(998, 508);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ürün Eşleşrime";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 21);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgcUrunDTO);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(994, 485);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgcUrunDTO
            // 
            this.dgcUrunDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcUrunDTO.Location = new System.Drawing.Point(0, 0);
            this.dgcUrunDTO.MainView = this.dgvUrunDTO;
            this.dgcUrunDTO.Name = "dgcUrunDTO";
            this.dgcUrunDTO.Size = new System.Drawing.Size(312, 485);
            this.dgcUrunDTO.TabIndex = 0;
            this.dgcUrunDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvUrunDTO});
            // 
            // dgvUrunDTO
            // 
            this.dgvUrunDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colUrunAdi});
            this.dgvUrunDTO.GridControl = this.dgcUrunDTO;
            this.dgvUrunDTO.Name = "dgvUrunDTO";
            this.dgvUrunDTO.OptionsView.ShowAutoFilterRow = true;
            this.dgvUrunDTO.OptionsView.ShowGroupPanel = false;
            this.dgvUrunDTO.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvUrunDTO_FocusedRowChanged);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.OptionsColumn.AllowSize = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 51;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.OptionsColumn.AllowFocus = false;
            this.colUrunAdi.OptionsColumn.ReadOnly = true;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            this.colUrunAdi.Width = 243;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgcLocalUrunCinsiDTO);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgcLocalUrunDTO);
            this.splitContainer2.Size = new System.Drawing.Size(678, 485);
            this.splitContainer2.SplitterDistance = 321;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgcLocalUrunCinsiDTO
            // 
            this.dgcLocalUrunCinsiDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcLocalUrunCinsiDTO.Location = new System.Drawing.Point(0, 0);
            this.dgcLocalUrunCinsiDTO.MainView = this.dgvLocalUrunCinsiDTO;
            this.dgcLocalUrunCinsiDTO.Name = "dgcLocalUrunCinsiDTO";
            this.dgcLocalUrunCinsiDTO.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rsiBtnOmegaStokAra});
            this.dgcLocalUrunCinsiDTO.Size = new System.Drawing.Size(321, 485);
            this.dgcLocalUrunCinsiDTO.TabIndex = 0;
            this.dgcLocalUrunCinsiDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvLocalUrunCinsiDTO});
            // 
            // dgvLocalUrunCinsiDTO
            // 
            this.dgvLocalUrunCinsiDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collId,
            this.collUrunId,
            this.collUrunKodu,
            this.collIthalmi,
            this.collUretimSekilId,
            this.collUrunCinsiAdi,
            this.collUretimSekiliAdi,
            this.collOmegaStokSec});
            this.dgvLocalUrunCinsiDTO.GridControl = this.dgcLocalUrunCinsiDTO;
            this.dgvLocalUrunCinsiDTO.Name = "dgvLocalUrunCinsiDTO";
            this.dgvLocalUrunCinsiDTO.OptionsView.ShowAutoFilterRow = true;
            this.dgvLocalUrunCinsiDTO.OptionsView.ShowGroupPanel = false;
            this.dgvLocalUrunCinsiDTO.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvLocalUrunCinsiDTO_FocusedRowChanged);
            this.dgvLocalUrunCinsiDTO.DataSourceChanged += new System.EventHandler(this.dgvLocalUrunCinsiDTO_DataSourceChanged);
            // 
            // collId
            // 
            this.collId.Caption = "Id";
            this.collId.FieldName = "Id";
            this.collId.MaxWidth = 75;
            this.collId.Name = "collId";
            this.collId.OptionsColumn.AllowEdit = false;
            this.collId.OptionsColumn.AllowFocus = false;
            this.collId.OptionsColumn.AllowSize = false;
            this.collId.OptionsColumn.ReadOnly = true;
            this.collId.Visible = true;
            this.collId.VisibleIndex = 0;
            this.collId.Width = 56;
            // 
            // collUrunId
            // 
            this.collUrunId.Caption = "UrunId";
            this.collUrunId.FieldName = "UrunId";
            this.collUrunId.Name = "collUrunId";
            this.collUrunId.OptionsColumn.AllowEdit = false;
            this.collUrunId.OptionsColumn.AllowFocus = false;
            this.collUrunId.OptionsColumn.AllowSize = false;
            this.collUrunId.OptionsColumn.ReadOnly = true;
            // 
            // collUrunKodu
            // 
            this.collUrunKodu.Caption = "Ürün Kodu";
            this.collUrunKodu.FieldName = "UrunKodu";
            this.collUrunKodu.Name = "collUrunKodu";
            this.collUrunKodu.OptionsColumn.AllowEdit = false;
            this.collUrunKodu.OptionsColumn.AllowFocus = false;
            this.collUrunKodu.OptionsColumn.AllowSize = false;
            this.collUrunKodu.OptionsColumn.ReadOnly = true;
            this.collUrunKodu.Visible = true;
            this.collUrunKodu.VisibleIndex = 1;
            this.collUrunKodu.Width = 72;
            // 
            // collIthalmi
            // 
            this.collIthalmi.Caption = "Ithalmi";
            this.collIthalmi.FieldName = "Ithalmi";
            this.collIthalmi.MaxWidth = 65;
            this.collIthalmi.Name = "collIthalmi";
            this.collIthalmi.OptionsColumn.AllowEdit = false;
            this.collIthalmi.OptionsColumn.AllowFocus = false;
            this.collIthalmi.OptionsColumn.AllowSize = false;
            this.collIthalmi.OptionsColumn.ReadOnly = true;
            this.collIthalmi.Visible = true;
            this.collIthalmi.VisibleIndex = 2;
            this.collIthalmi.Width = 47;
            // 
            // collUretimSekilId
            // 
            this.collUretimSekilId.Caption = "UretimSekilId";
            this.collUretimSekilId.FieldName = "UretimSekilId";
            this.collUretimSekilId.Name = "collUretimSekilId";
            this.collUretimSekilId.OptionsColumn.AllowEdit = false;
            this.collUretimSekilId.OptionsColumn.AllowFocus = false;
            this.collUretimSekilId.OptionsColumn.AllowSize = false;
            this.collUretimSekilId.OptionsColumn.ReadOnly = true;
            // 
            // collUrunCinsiAdi
            // 
            this.collUrunCinsiAdi.Caption = "Ürün Cinsi";
            this.collUrunCinsiAdi.FieldName = "UrunCinsiAdi";
            this.collUrunCinsiAdi.Name = "collUrunCinsiAdi";
            this.collUrunCinsiAdi.OptionsColumn.AllowEdit = false;
            this.collUrunCinsiAdi.OptionsColumn.AllowFocus = false;
            this.collUrunCinsiAdi.OptionsColumn.AllowSize = false;
            this.collUrunCinsiAdi.OptionsColumn.ReadOnly = true;
            this.collUrunCinsiAdi.Visible = true;
            this.collUrunCinsiAdi.VisibleIndex = 3;
            this.collUrunCinsiAdi.Width = 285;
            // 
            // collUretimSekiliAdi
            // 
            this.collUretimSekiliAdi.Caption = "Üretim Şekili";
            this.collUretimSekiliAdi.FieldName = "UretimSekiliAdi";
            this.collUretimSekiliAdi.Name = "collUretimSekiliAdi";
            this.collUretimSekiliAdi.OptionsColumn.AllowEdit = false;
            this.collUretimSekiliAdi.OptionsColumn.AllowFocus = false;
            this.collUretimSekiliAdi.OptionsColumn.AllowSize = false;
            this.collUretimSekiliAdi.OptionsColumn.ReadOnly = true;
            this.collUretimSekiliAdi.Visible = true;
            this.collUretimSekiliAdi.VisibleIndex = 4;
            this.collUretimSekiliAdi.Width = 227;
            // 
            // collOmegaStokSec
            // 
            this.collOmegaStokSec.Caption = "Stok Seç";
            this.collOmegaStokSec.ColumnEdit = this.rsiBtnOmegaStokAra;
            this.collOmegaStokSec.MinWidth = 65;
            this.collOmegaStokSec.Name = "collOmegaStokSec";
            this.collOmegaStokSec.OptionsColumn.AllowSize = false;
            this.collOmegaStokSec.Visible = true;
            this.collOmegaStokSec.VisibleIndex = 5;
            this.collOmegaStokSec.Width = 95;
            // 
            // rsiBtnOmegaStokAra
            // 
            this.rsiBtnOmegaStokAra.AutoHeight = false;
            this.rsiBtnOmegaStokAra.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("rsiBtnOmegaStokAra.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F9), serializableAppearanceObject1, "Stok Arama ( F9 )", null, null, true)});
            this.rsiBtnOmegaStokAra.Name = "rsiBtnOmegaStokAra";
            this.rsiBtnOmegaStokAra.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.rsiBtnOmegaStokAra_ButtonClick);
            // 
            // dgcLocalUrunDTO
            // 
            this.dgcLocalUrunDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcLocalUrunDTO.Location = new System.Drawing.Point(0, 0);
            this.dgcLocalUrunDTO.MainView = this.dgvLocalUrunDTO;
            this.dgcLocalUrunDTO.Name = "dgcLocalUrunDTO";
            this.dgcLocalUrunDTO.Size = new System.Drawing.Size(353, 485);
            this.dgcLocalUrunDTO.TabIndex = 0;
            this.dgcLocalUrunDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvLocalUrunDTO});
            // 
            // dgvLocalUrunDTO
            // 
            this.dgvLocalUrunDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colllUrunId,
            this.colllUrunCinsiId,
            this.colllUretimSekilId,
            this.colllUrunKodu,
            this.colllSTKKOD,
            this.colllSTOKAD,
            this.colllREYON,
            this.colllREYONAD,
            this.colllBARKOD,
            this.colllAKTIF});
            this.dgvLocalUrunDTO.GridControl = this.dgcLocalUrunDTO;
            this.dgvLocalUrunDTO.Name = "dgvLocalUrunDTO";
            this.dgvLocalUrunDTO.OptionsView.ShowAutoFilterRow = true;
            this.dgvLocalUrunDTO.OptionsView.ShowGroupPanel = false;
            this.dgvLocalUrunDTO.DataSourceChanged += new System.EventHandler(this.dgvLocalUrunDTO_DataSourceChanged);
            // 
            // colllUrunId
            // 
            this.colllUrunId.Caption = "UrunId";
            this.colllUrunId.FieldName = "UrunId";
            this.colllUrunId.Name = "colllUrunId";
            this.colllUrunId.OptionsColumn.AllowEdit = false;
            this.colllUrunId.OptionsColumn.AllowFocus = false;
            this.colllUrunId.OptionsColumn.ReadOnly = true;
            // 
            // colllUrunCinsiId
            // 
            this.colllUrunCinsiId.Caption = "UrunCinsiId";
            this.colllUrunCinsiId.FieldName = "UrunCinsiId";
            this.colllUrunCinsiId.Name = "colllUrunCinsiId";
            this.colllUrunCinsiId.OptionsColumn.AllowEdit = false;
            this.colllUrunCinsiId.OptionsColumn.AllowFocus = false;
            this.colllUrunCinsiId.OptionsColumn.ReadOnly = true;
            // 
            // colllUretimSekilId
            // 
            this.colllUretimSekilId.Caption = "UretimSekilId";
            this.colllUretimSekilId.FieldName = "UretimSekilId";
            this.colllUretimSekilId.Name = "colllUretimSekilId";
            this.colllUretimSekilId.OptionsColumn.AllowEdit = false;
            this.colllUretimSekilId.OptionsColumn.AllowFocus = false;
            this.colllUretimSekilId.OptionsColumn.ReadOnly = true;
            // 
            // colllUrunKodu
            // 
            this.colllUrunKodu.Caption = "UrunKodu";
            this.colllUrunKodu.FieldName = "UrunKodu";
            this.colllUrunKodu.Name = "colllUrunKodu";
            this.colllUrunKodu.OptionsColumn.AllowEdit = false;
            this.colllUrunKodu.OptionsColumn.AllowFocus = false;
            this.colllUrunKodu.OptionsColumn.ReadOnly = true;
            // 
            // colllSTKKOD
            // 
            this.colllSTKKOD.Caption = "Stk. Kod";
            this.colllSTKKOD.FieldName = "STKKOD";
            this.colllSTKKOD.Name = "colllSTKKOD";
            this.colllSTKKOD.OptionsColumn.AllowEdit = false;
            this.colllSTKKOD.OptionsColumn.AllowFocus = false;
            this.colllSTKKOD.OptionsColumn.AllowSize = false;
            this.colllSTKKOD.OptionsColumn.ReadOnly = true;
            this.colllSTKKOD.Visible = true;
            this.colllSTKKOD.VisibleIndex = 0;
            this.colllSTKKOD.Width = 71;
            // 
            // colllSTOKAD
            // 
            this.colllSTOKAD.Caption = "Stok Açıklama";
            this.colllSTOKAD.FieldName = "STOKAD";
            this.colllSTOKAD.Name = "colllSTOKAD";
            this.colllSTOKAD.OptionsColumn.AllowEdit = false;
            this.colllSTOKAD.OptionsColumn.AllowFocus = false;
            this.colllSTOKAD.OptionsColumn.ReadOnly = true;
            this.colllSTOKAD.Visible = true;
            this.colllSTOKAD.VisibleIndex = 1;
            this.colllSTOKAD.Width = 394;
            // 
            // colllREYON
            // 
            this.colllREYON.Caption = "REYON";
            this.colllREYON.FieldName = "REYON";
            this.colllREYON.Name = "colllREYON";
            this.colllREYON.OptionsColumn.AllowEdit = false;
            this.colllREYON.OptionsColumn.AllowFocus = false;
            this.colllREYON.OptionsColumn.ReadOnly = true;
            // 
            // colllREYONAD
            // 
            this.colllREYONAD.Caption = "Reyon Açıklama";
            this.colllREYONAD.FieldName = "REYONAD";
            this.colllREYONAD.Name = "colllREYONAD";
            this.colllREYONAD.OptionsColumn.AllowEdit = false;
            this.colllREYONAD.OptionsColumn.AllowFocus = false;
            this.colllREYONAD.OptionsColumn.ReadOnly = true;
            this.colllREYONAD.Visible = true;
            this.colllREYONAD.VisibleIndex = 2;
            this.colllREYONAD.Width = 218;
            // 
            // colllBARKOD
            // 
            this.colllBARKOD.Caption = "Barkod";
            this.colllBARKOD.FieldName = "BARKOD";
            this.colllBARKOD.Name = "colllBARKOD";
            this.colllBARKOD.OptionsColumn.AllowEdit = false;
            this.colllBARKOD.OptionsColumn.AllowFocus = false;
            this.colllBARKOD.OptionsColumn.AllowSize = false;
            this.colllBARKOD.OptionsColumn.ReadOnly = true;
            this.colllBARKOD.Visible = true;
            this.colllBARKOD.VisibleIndex = 3;
            // 
            // colllAKTIF
            // 
            this.colllAKTIF.Caption = "Aktif mi?";
            this.colllAKTIF.FieldName = "AKTIF";
            this.colllAKTIF.Name = "colllAKTIF";
            this.colllAKTIF.OptionsColumn.AllowEdit = false;
            this.colllAKTIF.OptionsColumn.AllowFocus = false;
            this.colllAKTIF.OptionsColumn.AllowSize = false;
            this.colllAKTIF.OptionsColumn.ReadOnly = true;
            this.colllAKTIF.Visible = true;
            this.colllAKTIF.VisibleIndex = 4;
            this.colllAKTIF.Width = 70;
            // 
            // contextMenuStripdgcLocalUrunDTO
            // 
            this.contextMenuStripdgcLocalUrunDTO.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seciliUrunleriEslestirmedenKaldırToolStripMenuItem});
            this.contextMenuStripdgcLocalUrunDTO.Name = "contextMenuStripdgcLocalUrunDTO";
            this.contextMenuStripdgcLocalUrunDTO.Size = new System.Drawing.Size(256, 26);
            // 
            // seciliUrunleriEslestirmedenKaldırToolStripMenuItem
            // 
            this.seciliUrunleriEslestirmedenKaldırToolStripMenuItem.Name = "seciliUrunleriEslestirmedenKaldırToolStripMenuItem";
            this.seciliUrunleriEslestirmedenKaldırToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.seciliUrunleriEslestirmedenKaldırToolStripMenuItem.Text = "Seçili Ürünleri Eşleştirmeden Kaldır";
            this.seciliUrunleriEslestirmedenKaldırToolStripMenuItem.Click += new System.EventHandler(this.seciliUrunleriEslestirmedenKaldırToolStripMenuItem_Click);
            // 
            // ucsBTNKayitIpal1
            // 
            this.ucsBTNKayitIpal1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucsBTNKayitIpal1.IptalEnabled = true;
            this.ucsBTNKayitIpal1.IptalImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.IptalImage")));
            this.ucsBTNKayitIpal1.IptalText = "Kapa&t";
            this.ucsBTNKayitIpal1.IptalVisible = true;
            this.ucsBTNKayitIpal1.KaydetEnabled = true;
            this.ucsBTNKayitIpal1.KaydetImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.KaydetImage")));
            this.ucsBTNKayitIpal1.KaydetText = "&Kaydet";
            this.ucsBTNKayitIpal1.KaydetVisible = false;
            this.ucsBTNKayitIpal1.Location = new System.Drawing.Point(0, 526);
            this.ucsBTNKayitIpal1.Name = "ucsBTNKayitIpal1";
            this.ucsBTNKayitIpal1.Size = new System.Drawing.Size(1022, 52);
            this.ucsBTNKayitIpal1.TabIndex = 1;
            this.ucsBTNKayitIpal1.TemizleImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.TemizleImage")));
            this.ucsBTNKayitIpal1.TemizleText = "&Temizle";
            this.ucsBTNKayitIpal1.TemizleVisible = false;
            this.ucsBTNKayitIpal1.ClickIptal += new System.EventHandler(this.ucsBTNKayitIpal1_ClickIptal);
            // 
            // frmUrunEslestirmeleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 578);
            this.Controls.Add(this.ucsBTNKayitIpal1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmUrunEslestirmeleri";
            this.Text = "Ürün Eşleştirmeleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcUrunDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunDTO)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcLocalUrunCinsiDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalUrunCinsiDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiBtnOmegaStokAra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcLocalUrunDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalUrunDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUrunDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalUrunCinsiDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalUrunDTO)).EndInit();
            this.contextMenuStripdgcLocalUrunDTO.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraGrid.GridControl dgcUrunDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvUrunDTO;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.GridControl dgcLocalUrunCinsiDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvLocalUrunCinsiDTO;
        private DevExpress.XtraGrid.GridControl dgcLocalUrunDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvLocalUrunDTO;
        private System.Windows.Forms.BindingSource bsUrunDTO;
        private System.Windows.Forms.BindingSource bsLocalUrunCinsiDTO;
        private System.Windows.Forms.BindingSource bsLocalUrunDTO;
        private DevExpress.XtraGrid.Columns.GridColumn collId;
        private DevExpress.XtraGrid.Columns.GridColumn collUrunId;
        private DevExpress.XtraGrid.Columns.GridColumn collUrunKodu;
        private DevExpress.XtraGrid.Columns.GridColumn collIthalmi;
        private DevExpress.XtraGrid.Columns.GridColumn collUretimSekilId;
        private DevExpress.XtraGrid.Columns.GridColumn collUretimSekiliAdi;
        private DevExpress.XtraGrid.Columns.GridColumn collUrunCinsiAdi;
        private DevExpress.XtraGrid.Columns.GridColumn collOmegaStokSec;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rsiBtnOmegaStokAra;
        private DevExpress.XtraGrid.Columns.GridColumn colllUrunId;
        private DevExpress.XtraGrid.Columns.GridColumn colllUrunCinsiId;
        private DevExpress.XtraGrid.Columns.GridColumn colllUretimSekilId;
        private DevExpress.XtraGrid.Columns.GridColumn colllUrunKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colllSTKKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colllSTOKAD;
        private DevExpress.XtraGrid.Columns.GridColumn colllREYON;
        private DevExpress.XtraGrid.Columns.GridColumn colllREYONAD;
        private DevExpress.XtraGrid.Columns.GridColumn colllBARKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colllAKTIF;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripdgcLocalUrunDTO;
        private System.Windows.Forms.ToolStripMenuItem seciliUrunleriEslestirmedenKaldırToolStripMenuItem;
        private UserControls.ucsBTNKayitIpal ucsBTNKayitIpal1;
    }
}