namespace OmegaHKS.Views.Eslestirme
{
    partial class frmDMEslestirme
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgcLocalSubeDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvLocalSubeDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubeAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsyeriTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsletmeTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeldeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeldeAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlceAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDMBNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rsiBtnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colLocalDepoAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDMBNOKONTROL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucsBTNGuncelle1 = new OmegaHKS.Views.UserControls.ucsBTNGuncelle();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcLocalSubeDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalSubeDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiBtnEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.dgcLocalSubeDTO);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(888, 464);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Dağıtım Merkezi Tanımları";
            // 
            // dgcLocalSubeDTO
            // 
            this.dgcLocalSubeDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcLocalSubeDTO.Location = new System.Drawing.Point(2, 21);
            this.dgcLocalSubeDTO.MainView = this.dgvLocalSubeDTO;
            this.dgcLocalSubeDTO.Name = "dgcLocalSubeDTO";
            this.dgcLocalSubeDTO.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rsiBtnEdit});
            this.dgcLocalSubeDTO.Size = new System.Drawing.Size(884, 441);
            this.dgcLocalSubeDTO.TabIndex = 0;
            this.dgcLocalSubeDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvLocalSubeDTO});
            // 
            // dgvLocalSubeDTO
            // 
            this.dgvLocalSubeDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSubeAdi,
            this.colIsyeriTuru,
            this.colIsletmeTuruAdi,
            this.colAdres,
            this.colBeldeId,
            this.colBeldeAdi,
            this.colIlceId,
            this.colIlceAdi,
            this.colIlId,
            this.colIlAdi,
            this.colDMBNO,
            this.colLocalDepoAd,
            this.colLocalAdres,
            this.colLocalIlce,
            this.colLocalI,
            this.colDMBNOKONTROL});
            this.dgvLocalSubeDTO.GridControl = this.dgcLocalSubeDTO;
            this.dgvLocalSubeDTO.Name = "dgvLocalSubeDTO";
            this.dgvLocalSubeDTO.OptionsView.ShowGroupPanel = false;
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
            // colSubeAdi
            // 
            this.colSubeAdi.Caption = "Şube Adı";
            this.colSubeAdi.FieldName = "SubeAdi";
            this.colSubeAdi.Name = "colSubeAdi";
            this.colSubeAdi.OptionsColumn.AllowEdit = false;
            this.colSubeAdi.OptionsColumn.AllowFocus = false;
            this.colSubeAdi.OptionsColumn.ReadOnly = true;
            this.colSubeAdi.Visible = true;
            this.colSubeAdi.VisibleIndex = 1;
            // 
            // colIsyeriTuru
            // 
            this.colIsyeriTuru.Caption = "İşyeri Tür Id";
            this.colIsyeriTuru.FieldName = "IsyeriTuru";
            this.colIsyeriTuru.Name = "colIsyeriTuru";
            // 
            // colIsletmeTuruAdi
            // 
            this.colIsletmeTuruAdi.Caption = "İşletme Türü";
            this.colIsletmeTuruAdi.FieldName = "IsletmeTuruAdi";
            this.colIsletmeTuruAdi.Name = "colIsletmeTuruAdi";
            this.colIsletmeTuruAdi.Visible = true;
            this.colIsletmeTuruAdi.VisibleIndex = 2;
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
            this.colAdres.VisibleIndex = 3;
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
            this.colBeldeAdi.VisibleIndex = 4;
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
            this.colIlceAdi.VisibleIndex = 5;
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
            this.colIlAdi.VisibleIndex = 6;
            // 
            // colDMBNO
            // 
            this.colDMBNO.Caption = "Sube No";
            this.colDMBNO.ColumnEdit = this.rsiBtnEdit;
            this.colDMBNO.FieldName = "DMBNO";
            this.colDMBNO.Name = "colDMBNO";
            this.colDMBNO.Visible = true;
            this.colDMBNO.VisibleIndex = 7;
            // 
            // rsiBtnEdit
            // 
            this.rsiBtnEdit.AutoHeight = false;
            this.rsiBtnEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F9), serializableAppearanceObject1, "", null, null, true)});
            this.rsiBtnEdit.Name = "rsiBtnEdit";
            this.rsiBtnEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.rsiBtnEdit_ButtonClick);
            // 
            // colLocalDepoAd
            // 
            this.colLocalDepoAd.Caption = "Omega Şube Adı";
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
            // colDMBNOKONTROL
            // 
            this.colDMBNOKONTROL.Caption = "DMBNOKONTROL";
            this.colDMBNOKONTROL.FieldName = "DMBNOKONTROL";
            this.colDMBNOKONTROL.Name = "colDMBNOKONTROL";
            // 
            // ucsBTNGuncelle1
            // 
            this.ucsBTNGuncelle1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucsBTNGuncelle1.GuncelleEnabled = true;
            this.ucsBTNGuncelle1.GuncelleVisible = true;
            this.ucsBTNGuncelle1.KapatEnabled = true;
            this.ucsBTNGuncelle1.KapatVisible = true;
            this.ucsBTNGuncelle1.Location = new System.Drawing.Point(0, 482);
            this.ucsBTNGuncelle1.Name = "ucsBTNGuncelle1";
            this.ucsBTNGuncelle1.ProgressBarControllEnabled = false;
            this.ucsBTNGuncelle1.ProgressBarControllVisible = false;
            this.ucsBTNGuncelle1.ProgressBarControlMaxValue = 100;
            this.ucsBTNGuncelle1.ProgressBarControlPosition = 0;
            this.ucsBTNGuncelle1.ProgressBarControlStep = 0;
            this.ucsBTNGuncelle1.ProgressTextEnabled = false;
            this.ucsBTNGuncelle1.ProgressTextVisible = false;
            this.ucsBTNGuncelle1.ProgressTextYazi = "Yapılan İşlem";
            this.ucsBTNGuncelle1.ProgressValue = 0;
            this.ucsBTNGuncelle1.Size = new System.Drawing.Size(912, 57);
            this.ucsBTNGuncelle1.TabIndex = 4;
            this.ucsBTNGuncelle1.ClickGuncelle += new System.EventHandler(this.ucsBTNGuncelle1_ClickGuncelle);
            this.ucsBTNGuncelle1.ClickKapat += new System.EventHandler(this.ucsBTNGuncelle1_ClickKapat);
            // 
            // frmDMEslestirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 539);
            this.Controls.Add(this.ucsBTNGuncelle1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDMEslestirme";
            this.Text = "Dağıtım Merkezi Eşleştirme";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcLocalSubeDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalSubeDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiBtnEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgcLocalSubeDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvLocalSubeDTO;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSubeAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIsyeriTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colIsletmeTuruAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colBeldeId;
        private DevExpress.XtraGrid.Columns.GridColumn colBeldeAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIlceId;
        private DevExpress.XtraGrid.Columns.GridColumn colIlceAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIlId;
        private DevExpress.XtraGrid.Columns.GridColumn colIlAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDMBNO;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rsiBtnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalDepoAd;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalI;
        private DevExpress.XtraGrid.Columns.GridColumn colDMBNOKONTROL;
        private UserControls.ucsBTNGuncelle ucsBTNGuncelle1;
    }
}