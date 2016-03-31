namespace OmegaHKS.Views.Eslestirme
{
    partial class frmDepoEslestirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepoEslestirme));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgcLocalDepoDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvLocalDepoDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeldeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeldeAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlceAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHalicimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDMBNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditDepoListesi = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colLocalDepoAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsLocalDepoDTO = new System.Windows.Forms.BindingSource();
            this.ucsBTNGuncelle1 = new OmegaHKS.Views.UserControls.ucsBTNGuncelle();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcLocalDepoDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDepoDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDepoListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalDepoDTO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.dgcLocalDepoDTO);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(932, 462);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Depo Tanımları";
            // 
            // dgcLocalDepoDTO
            // 
            this.dgcLocalDepoDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcLocalDepoDTO.Location = new System.Drawing.Point(2, 21);
            this.dgcLocalDepoDTO.MainView = this.dgvLocalDepoDTO;
            this.dgcLocalDepoDTO.Name = "dgcLocalDepoDTO";
            this.dgcLocalDepoDTO.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEditDepoListesi});
            this.dgcLocalDepoDTO.Size = new System.Drawing.Size(928, 439);
            this.dgcLocalDepoDTO.TabIndex = 0;
            this.dgcLocalDepoDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvLocalDepoDTO});
            // 
            // dgvLocalDepoDTO
            // 
            this.dgvLocalDepoDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDepoAdi,
            this.colAdres,
            this.colBeldeId,
            this.colBeldeAdi,
            this.colIlceId,
            this.colIlceAdi,
            this.colIlId,
            this.colIlAdi,
            this.colHalicimi,
            this.colDMBNO,
            this.colLocalDepoAd,
            this.colLocalAdres,
            this.colLocalIlce,
            this.colLocalI});
            this.dgvLocalDepoDTO.GridControl = this.dgcLocalDepoDTO;
            this.dgvLocalDepoDTO.Name = "dgvLocalDepoDTO";
            this.dgvLocalDepoDTO.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.AllowFocus = false;
            this.colId.OptionsColumn.ReadOnly = true;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colDepoAdi
            // 
            this.colDepoAdi.Caption = "Depo Adı";
            this.colDepoAdi.FieldName = "DepoAdi";
            this.colDepoAdi.Name = "colDepoAdi";
            this.colDepoAdi.OptionsColumn.AllowEdit = false;
            this.colDepoAdi.OptionsColumn.AllowFocus = false;
            this.colDepoAdi.OptionsColumn.ReadOnly = true;
            this.colDepoAdi.Visible = true;
            this.colDepoAdi.VisibleIndex = 1;
            // 
            // colAdres
            // 
            this.colAdres.Caption = "Adres";
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.OptionsColumn.AllowEdit = false;
            this.colAdres.OptionsColumn.AllowFocus = false;
            this.colAdres.OptionsColumn.ReadOnly = true;
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 2;
            // 
            // colBeldeId
            // 
            this.colBeldeId.Caption = "Belde Id";
            this.colBeldeId.FieldName = "BeldeId";
            this.colBeldeId.Name = "colBeldeId";
            this.colBeldeId.OptionsColumn.AllowEdit = false;
            this.colBeldeId.OptionsColumn.AllowFocus = false;
            this.colBeldeId.OptionsColumn.ReadOnly = true;
            // 
            // colBeldeAdi
            // 
            this.colBeldeAdi.Caption = "Belde";
            this.colBeldeAdi.FieldName = "BeldeAdi";
            this.colBeldeAdi.Name = "colBeldeAdi";
            this.colBeldeAdi.OptionsColumn.AllowEdit = false;
            this.colBeldeAdi.OptionsColumn.AllowFocus = false;
            this.colBeldeAdi.OptionsColumn.ReadOnly = true;
            this.colBeldeAdi.Visible = true;
            this.colBeldeAdi.VisibleIndex = 3;
            // 
            // colIlceId
            // 
            this.colIlceId.Caption = "Ilce Id";
            this.colIlceId.FieldName = "IlceId";
            this.colIlceId.Name = "colIlceId";
            this.colIlceId.OptionsColumn.AllowEdit = false;
            this.colIlceId.OptionsColumn.AllowFocus = false;
            this.colIlceId.OptionsColumn.ReadOnly = true;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.Caption = "Ilce Adı";
            this.colIlceAdi.FieldName = "IlceAdi";
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.OptionsColumn.AllowFocus = false;
            this.colIlceAdi.OptionsColumn.ReadOnly = true;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.VisibleIndex = 4;
            // 
            // colIlId
            // 
            this.colIlId.Caption = "Il Id";
            this.colIlId.FieldName = "IlId";
            this.colIlId.Name = "colIlId";
            this.colIlId.OptionsColumn.AllowEdit = false;
            this.colIlId.OptionsColumn.AllowFocus = false;
            this.colIlId.OptionsColumn.ReadOnly = true;
            // 
            // colIlAdi
            // 
            this.colIlAdi.Caption = "İl Adı";
            this.colIlAdi.FieldName = "IlAdi";
            this.colIlAdi.Name = "colIlAdi";
            this.colIlAdi.OptionsColumn.AllowEdit = false;
            this.colIlAdi.OptionsColumn.AllowFocus = false;
            this.colIlAdi.OptionsColumn.ReadOnly = true;
            this.colIlAdi.Visible = true;
            this.colIlAdi.VisibleIndex = 5;
            // 
            // colHalicimi
            // 
            this.colHalicimi.Caption = "Halicimi";
            this.colHalicimi.FieldName = "Halicimi";
            this.colHalicimi.Name = "colHalicimi";
            this.colHalicimi.OptionsColumn.AllowEdit = false;
            this.colHalicimi.OptionsColumn.AllowFocus = false;
            this.colHalicimi.OptionsColumn.ReadOnly = true;
            this.colHalicimi.Visible = true;
            this.colHalicimi.VisibleIndex = 6;
            // 
            // colDMBNO
            // 
            this.colDMBNO.Caption = "Depo No";
            this.colDMBNO.ColumnEdit = this.btnEditDepoListesi;
            this.colDMBNO.FieldName = "DMBNO";
            this.colDMBNO.Name = "colDMBNO";
            this.colDMBNO.Visible = true;
            this.colDMBNO.VisibleIndex = 7;
            // 
            // btnEditDepoListesi
            // 
            this.btnEditDepoListesi.AutoHeight = false;
            this.btnEditDepoListesi.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btnEditDepoListesi.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F9), serializableAppearanceObject2, "Local Şube Listesi", null, null, true)});
            this.btnEditDepoListesi.Name = "btnEditDepoListesi";
            this.btnEditDepoListesi.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditDepoListesi_ButtonClick);
            // 
            // colLocalDepoAd
            // 
            this.colLocalDepoAd.Caption = "Omega Depo Adı";
            this.colLocalDepoAd.FieldName = "LocalDepoAd";
            this.colLocalDepoAd.Name = "colLocalDepoAd";
            this.colLocalDepoAd.OptionsColumn.AllowEdit = false;
            this.colLocalDepoAd.OptionsColumn.AllowFocus = false;
            this.colLocalDepoAd.OptionsColumn.ReadOnly = true;
            this.colLocalDepoAd.Visible = true;
            this.colLocalDepoAd.VisibleIndex = 8;
            // 
            // colLocalAdres
            // 
            this.colLocalAdres.Caption = "Omega Adres";
            this.colLocalAdres.FieldName = "LocalAdres";
            this.colLocalAdres.Name = "colLocalAdres";
            this.colLocalAdres.OptionsColumn.AllowEdit = false;
            this.colLocalAdres.OptionsColumn.AllowFocus = false;
            this.colLocalAdres.OptionsColumn.ReadOnly = true;
            this.colLocalAdres.Visible = true;
            this.colLocalAdres.VisibleIndex = 9;
            // 
            // colLocalIlce
            // 
            this.colLocalIlce.Caption = "Omega İlce";
            this.colLocalIlce.FieldName = "LocalIlce";
            this.colLocalIlce.Name = "colLocalIlce";
            this.colLocalIlce.OptionsColumn.AllowEdit = false;
            this.colLocalIlce.OptionsColumn.AllowFocus = false;
            this.colLocalIlce.OptionsColumn.ReadOnly = true;
            this.colLocalIlce.Visible = true;
            this.colLocalIlce.VisibleIndex = 10;
            // 
            // colLocalI
            // 
            this.colLocalI.Caption = "Omega İl";
            this.colLocalI.FieldName = "LocalI";
            this.colLocalI.Name = "colLocalI";
            this.colLocalI.OptionsColumn.AllowEdit = false;
            this.colLocalI.OptionsColumn.AllowFocus = false;
            this.colLocalI.OptionsColumn.ReadOnly = true;
            this.colLocalI.Visible = true;
            this.colLocalI.VisibleIndex = 11;
            // 
            // ucsBTNGuncelle1
            // 
            this.ucsBTNGuncelle1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucsBTNGuncelle1.GuncelleEnabled = true;
            this.ucsBTNGuncelle1.GuncelleVisible = true;
            this.ucsBTNGuncelle1.KapatEnabled = true;
            this.ucsBTNGuncelle1.KapatVisible = true;
            this.ucsBTNGuncelle1.Location = new System.Drawing.Point(0, 480);
            this.ucsBTNGuncelle1.Name = "ucsBTNGuncelle1";
            this.ucsBTNGuncelle1.ProgressBarControllEnabled = true;
            this.ucsBTNGuncelle1.ProgressBarControllVisible = false;
            this.ucsBTNGuncelle1.ProgressBarControlMaxValue = 100;
            this.ucsBTNGuncelle1.ProgressBarControlPosition = 0;
            this.ucsBTNGuncelle1.ProgressBarControlStep = 0;
            this.ucsBTNGuncelle1.ProgressTextEnabled = true;
            this.ucsBTNGuncelle1.ProgressTextVisible = false;
            this.ucsBTNGuncelle1.ProgressTextYazi = "Yapılan İşlem";
            this.ucsBTNGuncelle1.ProgressValue = 0;
            this.ucsBTNGuncelle1.Size = new System.Drawing.Size(956, 57);
            this.ucsBTNGuncelle1.TabIndex = 2;
            this.ucsBTNGuncelle1.ClickGuncelle += new System.EventHandler(this.ucsBTNGuncelle1_ClickGuncelle);
            this.ucsBTNGuncelle1.ClickKapat += new System.EventHandler(this.ucsBTNGuncelle1_ClickKapat);
            // 
            // frmDepoEslestirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 537);
            this.Controls.Add(this.ucsBTNGuncelle1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDepoEslestirme";
            this.Text = "Depo H.K.S. Sistemi Eşleştirme ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcLocalDepoDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDepoDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditDepoListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalDepoDTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgcLocalDepoDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvLocalDepoDTO;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEditDepoListesi;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colBeldeId;
        private DevExpress.XtraGrid.Columns.GridColumn colIlceId;
        private DevExpress.XtraGrid.Columns.GridColumn colIlId;
        private DevExpress.XtraGrid.Columns.GridColumn colHalicimi;
        private DevExpress.XtraGrid.Columns.GridColumn colDMBNO;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalDepoAd;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalI;
        private System.Windows.Forms.BindingSource bsLocalDepoDTO;
        private UserControls.ucsBTNGuncelle ucsBTNGuncelle1;
        private DevExpress.XtraGrid.Columns.GridColumn colBeldeAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIlceAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIlAdi;
    }
}