namespace OmegaHKS.Views.LocalHKSUpdate
{
    partial class frmBildirimYardimciBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBildirimYardimciBilgileri));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgcSifatDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvSifatDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifatAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgcBildirimTuruDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvBildirimTuruDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBildirimTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgcBelgeTipiDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvBelgeTipiDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colllId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeTipiAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgcIsletmeTuruDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvIsletmeTuruDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collllId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsletmeTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsSifatDTO = new System.Windows.Forms.BindingSource();
            this.bsBildirimTuruDTO = new System.Windows.Forms.BindingSource();
            this.bsBelgeTipiDTO = new System.Windows.Forms.BindingSource();
            this.bsIsletmeTuruDTO = new System.Windows.Forms.BindingSource();
            this.ucsBTNGuncelle1 = new OmegaHKS.Views.UserControls.ucsBTNGuncelle();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcSifatDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSifatDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcBildirimTuruDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBildirimTuruDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcBelgeTipiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBelgeTipiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcIsletmeTuruDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsletmeTuruDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSifatDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBildirimTuruDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBelgeTipiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIsletmeTuruDTO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.splitContainer1);
            this.groupControl1.Location = new System.Drawing.Point(12, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1057, 491);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Bidirim Yardımcı Bilgileri";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 21);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgcSifatDTO);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1053, 468);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgcSifatDTO
            // 
            this.dgcSifatDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcSifatDTO.Location = new System.Drawing.Point(0, 0);
            this.dgcSifatDTO.MainView = this.dgvSifatDTO;
            this.dgcSifatDTO.Name = "dgcSifatDTO";
            this.dgcSifatDTO.Size = new System.Drawing.Size(250, 468);
            this.dgcSifatDTO.TabIndex = 0;
            this.dgcSifatDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvSifatDTO});
            // 
            // dgvSifatDTO
            // 
            this.dgvSifatDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colSifatAdi});
            this.dgvSifatDTO.GridControl = this.dgcSifatDTO;
            this.dgvSifatDTO.Name = "dgvSifatDTO";
            this.dgvSifatDTO.OptionsView.ShowGroupPanel = false;
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
            this.colId.Width = 52;
            // 
            // colSifatAdi
            // 
            this.colSifatAdi.Caption = "Sifat Adı";
            this.colSifatAdi.FieldName = "SifatAdi";
            this.colSifatAdi.Name = "colSifatAdi";
            this.colSifatAdi.OptionsColumn.AllowEdit = false;
            this.colSifatAdi.OptionsColumn.AllowFocus = false;
            this.colSifatAdi.OptionsColumn.ReadOnly = true;
            this.colSifatAdi.Visible = true;
            this.colSifatAdi.VisibleIndex = 1;
            this.colSifatAdi.Width = 177;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgcBildirimTuruDTO);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(799, 468);
            this.splitContainer2.SplitterDistance = 256;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgcBildirimTuruDTO
            // 
            this.dgcBildirimTuruDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcBildirimTuruDTO.Location = new System.Drawing.Point(0, 0);
            this.dgcBildirimTuruDTO.MainView = this.dgvBildirimTuruDTO;
            this.dgcBildirimTuruDTO.Name = "dgcBildirimTuruDTO";
            this.dgcBildirimTuruDTO.Size = new System.Drawing.Size(256, 468);
            this.dgcBildirimTuruDTO.TabIndex = 0;
            this.dgcBildirimTuruDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBildirimTuruDTO});
            // 
            // dgvBildirimTuruDTO
            // 
            this.dgvBildirimTuruDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collId,
            this.colBildirimTuruAdi});
            this.dgvBildirimTuruDTO.GridControl = this.dgcBildirimTuruDTO;
            this.dgvBildirimTuruDTO.Name = "dgvBildirimTuruDTO";
            this.dgvBildirimTuruDTO.OptionsView.ShowGroupPanel = false;
            // 
            // collId
            // 
            this.collId.Caption = "Id";
            this.collId.FieldName = "Id";
            this.collId.Name = "collId";
            this.collId.OptionsColumn.AllowEdit = false;
            this.collId.OptionsColumn.AllowFocus = false;
            this.collId.OptionsColumn.ReadOnly = true;
            this.collId.Visible = true;
            this.collId.VisibleIndex = 0;
            this.collId.Width = 47;
            // 
            // colBildirimTuruAdi
            // 
            this.colBildirimTuruAdi.Caption = "Bildirim Turu Adi";
            this.colBildirimTuruAdi.FieldName = "BildirimTuruAdi";
            this.colBildirimTuruAdi.Name = "colBildirimTuruAdi";
            this.colBildirimTuruAdi.OptionsColumn.AllowEdit = false;
            this.colBildirimTuruAdi.OptionsColumn.AllowFocus = false;
            this.colBildirimTuruAdi.OptionsColumn.ReadOnly = true;
            this.colBildirimTuruAdi.Visible = true;
            this.colBildirimTuruAdi.VisibleIndex = 1;
            this.colBildirimTuruAdi.Width = 188;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgcBelgeTipiDTO);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgcIsletmeTuruDTO);
            this.splitContainer3.Size = new System.Drawing.Size(539, 468);
            this.splitContainer3.SplitterDistance = 268;
            this.splitContainer3.TabIndex = 0;
            // 
            // dgcBelgeTipiDTO
            // 
            this.dgcBelgeTipiDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcBelgeTipiDTO.Location = new System.Drawing.Point(0, 0);
            this.dgcBelgeTipiDTO.MainView = this.dgvBelgeTipiDTO;
            this.dgcBelgeTipiDTO.Name = "dgcBelgeTipiDTO";
            this.dgcBelgeTipiDTO.Size = new System.Drawing.Size(268, 468);
            this.dgcBelgeTipiDTO.TabIndex = 0;
            this.dgcBelgeTipiDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBelgeTipiDTO});
            // 
            // dgvBelgeTipiDTO
            // 
            this.dgvBelgeTipiDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colllId,
            this.colBelgeTipiAdi});
            this.dgvBelgeTipiDTO.GridControl = this.dgcBelgeTipiDTO;
            this.dgvBelgeTipiDTO.Name = "dgvBelgeTipiDTO";
            this.dgvBelgeTipiDTO.OptionsView.ShowGroupPanel = false;
            // 
            // colllId
            // 
            this.colllId.Caption = "Id";
            this.colllId.FieldName = "Id";
            this.colllId.Name = "colllId";
            this.colllId.OptionsColumn.AllowEdit = false;
            this.colllId.OptionsColumn.AllowFocus = false;
            this.colllId.OptionsColumn.ReadOnly = true;
            this.colllId.Visible = true;
            this.colllId.VisibleIndex = 0;
            this.colllId.Width = 50;
            // 
            // colBelgeTipiAdi
            // 
            this.colBelgeTipiAdi.Caption = "Belge Tipi Adı";
            this.colBelgeTipiAdi.FieldName = "BelgeTipiAdi";
            this.colBelgeTipiAdi.Name = "colBelgeTipiAdi";
            this.colBelgeTipiAdi.OptionsColumn.AllowEdit = false;
            this.colBelgeTipiAdi.OptionsColumn.AllowFocus = false;
            this.colBelgeTipiAdi.OptionsColumn.ReadOnly = true;
            this.colBelgeTipiAdi.Visible = true;
            this.colBelgeTipiAdi.VisibleIndex = 1;
            this.colBelgeTipiAdi.Width = 197;
            // 
            // dgcIsletmeTuruDTO
            // 
            this.dgcIsletmeTuruDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcIsletmeTuruDTO.Location = new System.Drawing.Point(0, 0);
            this.dgcIsletmeTuruDTO.MainView = this.dgvIsletmeTuruDTO;
            this.dgcIsletmeTuruDTO.Name = "dgcIsletmeTuruDTO";
            this.dgcIsletmeTuruDTO.Size = new System.Drawing.Size(267, 468);
            this.dgcIsletmeTuruDTO.TabIndex = 1;
            this.dgcIsletmeTuruDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvIsletmeTuruDTO});
            // 
            // dgvIsletmeTuruDTO
            // 
            this.dgvIsletmeTuruDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collllId,
            this.colIsletmeTuruAdi});
            this.dgvIsletmeTuruDTO.GridControl = this.dgcIsletmeTuruDTO;
            this.dgvIsletmeTuruDTO.Name = "dgvIsletmeTuruDTO";
            this.dgvIsletmeTuruDTO.OptionsView.ShowGroupPanel = false;
            // 
            // collllId
            // 
            this.collllId.Caption = "Id";
            this.collllId.FieldName = "Id";
            this.collllId.Name = "collllId";
            this.collllId.OptionsColumn.AllowEdit = false;
            this.collllId.OptionsColumn.AllowFocus = false;
            this.collllId.OptionsColumn.ReadOnly = true;
            this.collllId.Visible = true;
            this.collllId.VisibleIndex = 0;
            this.collllId.Width = 51;
            // 
            // colIsletmeTuruAdi
            // 
            this.colIsletmeTuruAdi.Caption = "Isletme Türü Adi";
            this.colIsletmeTuruAdi.FieldName = "IsletmeTuruAdi";
            this.colIsletmeTuruAdi.Name = "colIsletmeTuruAdi";
            this.colIsletmeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colIsletmeTuruAdi.OptionsColumn.AllowFocus = false;
            this.colIsletmeTuruAdi.OptionsColumn.ReadOnly = true;
            this.colIsletmeTuruAdi.Visible = true;
            this.colIsletmeTuruAdi.VisibleIndex = 1;
            this.colIsletmeTuruAdi.Width = 195;
            // 
            // ucsBTNGuncelle1
            // 
            this.ucsBTNGuncelle1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucsBTNGuncelle1.GuncelleEnabled = true;
            this.ucsBTNGuncelle1.GuncelleVisible = true;
            this.ucsBTNGuncelle1.KapatEnabled = true;
            this.ucsBTNGuncelle1.KapatVisible = true;
            this.ucsBTNGuncelle1.Location = new System.Drawing.Point(0, 501);
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
            this.ucsBTNGuncelle1.Size = new System.Drawing.Size(1081, 57);
            this.ucsBTNGuncelle1.TabIndex = 1;
            this.ucsBTNGuncelle1.ClickGuncelle += new System.EventHandler(this.ucsBTNGuncelle1_ClickGuncelle);
            this.ucsBTNGuncelle1.ClickKapat += new System.EventHandler(this.ucsBTNGuncelle1_ClickKapat);
            // 
            // frmBildirimYardimciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 558);
            this.Controls.Add(this.ucsBTNGuncelle1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBildirimYardimciBilgileri";
            this.Text = "Bildirim Yardımcı Bilgileri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcSifatDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSifatDTO)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcBildirimTuruDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBildirimTuruDTO)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcBelgeTipiDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBelgeTipiDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcIsletmeTuruDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsletmeTuruDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSifatDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBildirimTuruDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBelgeTipiDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIsletmeTuruDTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsSifatDTO;
        private System.Windows.Forms.BindingSource bsBildirimTuruDTO;
        private System.Windows.Forms.BindingSource bsBelgeTipiDTO;
        private System.Windows.Forms.BindingSource bsIsletmeTuruDTO;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private DevExpress.XtraGrid.GridControl dgcSifatDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvSifatDTO;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colSifatAdi;
        private DevExpress.XtraGrid.GridControl dgcBildirimTuruDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBildirimTuruDTO;
        private DevExpress.XtraGrid.Columns.GridColumn collId;
        private DevExpress.XtraGrid.GridControl dgcBelgeTipiDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBelgeTipiDTO;
        private DevExpress.XtraGrid.Columns.GridColumn colllId;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeTipiAdi;
        private DevExpress.XtraGrid.GridControl dgcIsletmeTuruDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvIsletmeTuruDTO;
        private DevExpress.XtraGrid.Columns.GridColumn collllId;
        private DevExpress.XtraGrid.Columns.GridColumn colIsletmeTuruAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBildirimTuruAdi;
        private UserControls.ucsBTNGuncelle ucsBTNGuncelle1;
    }
}