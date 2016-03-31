namespace OmegaHKS.Views.LocalHKSUpdate
{
    partial class frmLokasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLokasyon));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgcUlkeDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvUlkeDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUlkeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUlkeAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgcIlDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvIlDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSehirID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSehirAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgcIlceDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvIlceDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIlceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIlceAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dgcBeldeDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvBeldeDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBeldeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBeldeAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsUlkeDTO = new System.Windows.Forms.BindingSource();
            this.bsIlDTO = new System.Windows.Forms.BindingSource();
            this.bsIlceDTO = new System.Windows.Forms.BindingSource();
            this.bsBeldeDTO = new System.Windows.Forms.BindingSource();
            this.ucsBTNGuncelle1 = new OmegaHKS.Views.UserControls.ucsBTNGuncelle();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcUlkeDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlkeDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcIlDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcIlceDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlceDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcBeldeDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeldeDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUlkeDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIlDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIlceDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBeldeDTO)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1140, 488);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgcUlkeDTO);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(278, 488);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Ülke Listesi";
            // 
            // dgcUlkeDTO
            // 
            this.dgcUlkeDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcUlkeDTO.Location = new System.Drawing.Point(2, 21);
            this.dgcUlkeDTO.MainView = this.dgvUlkeDTO;
            this.dgcUlkeDTO.Name = "dgcUlkeDTO";
            this.dgcUlkeDTO.Size = new System.Drawing.Size(274, 465);
            this.dgcUlkeDTO.TabIndex = 0;
            this.dgcUlkeDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvUlkeDTO});
            // 
            // dgvUlkeDTO
            // 
            this.dgvUlkeDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUlkeId,
            this.colUlkeAdi});
            this.dgvUlkeDTO.GridControl = this.dgcUlkeDTO;
            this.dgvUlkeDTO.Name = "dgvUlkeDTO";
            this.dgvUlkeDTO.OptionsView.ShowAutoFilterRow = true;
            this.dgvUlkeDTO.OptionsView.ShowGroupPanel = false;
            // 
            // colUlkeId
            // 
            this.colUlkeId.AppearanceCell.Options.UseTextOptions = true;
            this.colUlkeId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colUlkeId.Caption = "Id";
            this.colUlkeId.FieldName = "Id";
            this.colUlkeId.Name = "colUlkeId";
            this.colUlkeId.OptionsColumn.AllowEdit = false;
            this.colUlkeId.OptionsColumn.AllowFocus = false;
            this.colUlkeId.OptionsColumn.ReadOnly = true;
            this.colUlkeId.Visible = true;
            this.colUlkeId.VisibleIndex = 0;
            this.colUlkeId.Width = 55;
            // 
            // colUlkeAdi
            // 
            this.colUlkeAdi.Caption = "Ülke Adı";
            this.colUlkeAdi.FieldName = "UlkeAdi";
            this.colUlkeAdi.Name = "colUlkeAdi";
            this.colUlkeAdi.OptionsColumn.AllowEdit = false;
            this.colUlkeAdi.OptionsColumn.AllowFocus = false;
            this.colUlkeAdi.OptionsColumn.ReadOnly = true;
            this.colUlkeAdi.Visible = true;
            this.colUlkeAdi.VisibleIndex = 1;
            this.colUlkeAdi.Width = 266;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupControl2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(858, 488);
            this.splitContainer2.SplitterDistance = 285;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgcIlDTO);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(285, 488);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Şehir Listesi";
            // 
            // dgcIlDTO
            // 
            this.dgcIlDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcIlDTO.Location = new System.Drawing.Point(2, 21);
            this.dgcIlDTO.MainView = this.dgvIlDTO;
            this.dgcIlDTO.Name = "dgcIlDTO";
            this.dgcIlDTO.Size = new System.Drawing.Size(281, 465);
            this.dgcIlDTO.TabIndex = 0;
            this.dgcIlDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvIlDTO});
            // 
            // dgvIlDTO
            // 
            this.dgvIlDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSehirID,
            this.colSehirAdi});
            this.dgvIlDTO.GridControl = this.dgcIlDTO;
            this.dgvIlDTO.Name = "dgvIlDTO";
            this.dgvIlDTO.OptionsView.ShowAutoFilterRow = true;
            this.dgvIlDTO.OptionsView.ShowGroupPanel = false;
            this.dgvIlDTO.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvIlDTO_FocusedRowChanged);
            // 
            // colSehirID
            // 
            this.colSehirID.AppearanceCell.Options.UseTextOptions = true;
            this.colSehirID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSehirID.Caption = "Id";
            this.colSehirID.FieldName = "Id";
            this.colSehirID.Name = "colSehirID";
            this.colSehirID.OptionsColumn.AllowEdit = false;
            this.colSehirID.OptionsColumn.AllowFocus = false;
            this.colSehirID.OptionsColumn.ReadOnly = true;
            this.colSehirID.Visible = true;
            this.colSehirID.VisibleIndex = 0;
            this.colSehirID.Width = 55;
            // 
            // colSehirAdi
            // 
            this.colSehirAdi.Caption = "Şehir Adı";
            this.colSehirAdi.FieldName = "IlAdi";
            this.colSehirAdi.Name = "colSehirAdi";
            this.colSehirAdi.OptionsColumn.AllowEdit = false;
            this.colSehirAdi.OptionsColumn.AllowFocus = false;
            this.colSehirAdi.OptionsColumn.ReadOnly = true;
            this.colSehirAdi.Visible = true;
            this.colSehirAdi.VisibleIndex = 1;
            this.colSehirAdi.Width = 266;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupControl3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupControl4);
            this.splitContainer3.Size = new System.Drawing.Size(569, 488);
            this.splitContainer3.SplitterDistance = 273;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgcIlceDTO);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(273, 488);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "İlçe Liste";
            // 
            // dgcIlceDTO
            // 
            this.dgcIlceDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcIlceDTO.Location = new System.Drawing.Point(2, 21);
            this.dgcIlceDTO.MainView = this.dgvIlceDTO;
            this.dgcIlceDTO.Name = "dgcIlceDTO";
            this.dgcIlceDTO.Size = new System.Drawing.Size(269, 465);
            this.dgcIlceDTO.TabIndex = 0;
            this.dgcIlceDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvIlceDTO});
            // 
            // dgvIlceDTO
            // 
            this.dgvIlceDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIlceId,
            this.colIlceAdi});
            this.dgvIlceDTO.GridControl = this.dgcIlceDTO;
            this.dgvIlceDTO.Name = "dgvIlceDTO";
            this.dgvIlceDTO.OptionsView.ShowAutoFilterRow = true;
            this.dgvIlceDTO.OptionsView.ShowGroupPanel = false;
            this.dgvIlceDTO.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvIlceDTO_FocusedRowChanged);
            // 
            // colIlceId
            // 
            this.colIlceId.AppearanceCell.Options.UseTextOptions = true;
            this.colIlceId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colIlceId.Caption = "Id";
            this.colIlceId.FieldName = "Id";
            this.colIlceId.Name = "colIlceId";
            this.colIlceId.OptionsColumn.AllowEdit = false;
            this.colIlceId.OptionsColumn.AllowFocus = false;
            this.colIlceId.OptionsColumn.ReadOnly = true;
            this.colIlceId.Visible = true;
            this.colIlceId.VisibleIndex = 0;
            this.colIlceId.Width = 55;
            // 
            // colIlceAdi
            // 
            this.colIlceAdi.Caption = "İlçe Adı";
            this.colIlceAdi.FieldName = "IlceAdi";
            this.colIlceAdi.Name = "colIlceAdi";
            this.colIlceAdi.OptionsColumn.AllowEdit = false;
            this.colIlceAdi.OptionsColumn.AllowFocus = false;
            this.colIlceAdi.OptionsColumn.ReadOnly = true;
            this.colIlceAdi.Visible = true;
            this.colIlceAdi.VisibleIndex = 1;
            this.colIlceAdi.Width = 266;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.dgcBeldeDTO);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(292, 488);
            this.groupControl4.TabIndex = 5;
            this.groupControl4.Text = "Belde Listesi";
            // 
            // dgcBeldeDTO
            // 
            this.dgcBeldeDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcBeldeDTO.Location = new System.Drawing.Point(2, 21);
            this.dgcBeldeDTO.MainView = this.dgvBeldeDTO;
            this.dgcBeldeDTO.Name = "dgcBeldeDTO";
            this.dgcBeldeDTO.Size = new System.Drawing.Size(288, 465);
            this.dgcBeldeDTO.TabIndex = 0;
            this.dgcBeldeDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvBeldeDTO});
            // 
            // dgvBeldeDTO
            // 
            this.dgvBeldeDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBeldeId,
            this.colBeldeAdi});
            this.dgvBeldeDTO.GridControl = this.dgcBeldeDTO;
            this.dgvBeldeDTO.Name = "dgvBeldeDTO";
            this.dgvBeldeDTO.OptionsView.ShowAutoFilterRow = true;
            this.dgvBeldeDTO.OptionsView.ShowGroupPanel = false;
            // 
            // colBeldeId
            // 
            this.colBeldeId.AppearanceCell.Options.UseTextOptions = true;
            this.colBeldeId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBeldeId.Caption = "Id";
            this.colBeldeId.FieldName = "Id";
            this.colBeldeId.Name = "colBeldeId";
            this.colBeldeId.OptionsColumn.AllowEdit = false;
            this.colBeldeId.OptionsColumn.AllowFocus = false;
            this.colBeldeId.OptionsColumn.ReadOnly = true;
            this.colBeldeId.Visible = true;
            this.colBeldeId.VisibleIndex = 0;
            this.colBeldeId.Width = 55;
            // 
            // colBeldeAdi
            // 
            this.colBeldeAdi.Caption = "Belde Adı";
            this.colBeldeAdi.FieldName = "BeldeAdi";
            this.colBeldeAdi.Name = "colBeldeAdi";
            this.colBeldeAdi.OptionsColumn.AllowEdit = false;
            this.colBeldeAdi.OptionsColumn.AllowFocus = false;
            this.colBeldeAdi.OptionsColumn.ReadOnly = true;
            this.colBeldeAdi.Visible = true;
            this.colBeldeAdi.VisibleIndex = 1;
            this.colBeldeAdi.Width = 266;
            // 
            // ucsBTNGuncelle1
            // 
            this.ucsBTNGuncelle1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucsBTNGuncelle1.GuncelleEnabled = true;
            this.ucsBTNGuncelle1.GuncelleVisible = true;
            this.ucsBTNGuncelle1.KapatEnabled = true;
            this.ucsBTNGuncelle1.KapatVisible = true;
            this.ucsBTNGuncelle1.Location = new System.Drawing.Point(0, 506);
            this.ucsBTNGuncelle1.Name = "ucsBTNGuncelle1";
            this.ucsBTNGuncelle1.ProgressBarControllEnabled = true;
            this.ucsBTNGuncelle1.ProgressBarControllVisible = true;
            this.ucsBTNGuncelle1.ProgressBarControlMaxValue = 100;
            this.ucsBTNGuncelle1.ProgressBarControlPosition = 0;
            this.ucsBTNGuncelle1.ProgressBarControlStep = 0;
            this.ucsBTNGuncelle1.ProgressTextEnabled = true;
            this.ucsBTNGuncelle1.ProgressTextVisible = true;
            this.ucsBTNGuncelle1.ProgressTextYazi = "Yapılan İşlem";
            this.ucsBTNGuncelle1.ProgressValue = 0;
            this.ucsBTNGuncelle1.Size = new System.Drawing.Size(1164, 57);
            this.ucsBTNGuncelle1.TabIndex = 1;
            this.ucsBTNGuncelle1.ClickGuncelle += new System.EventHandler(this.ucsBTNGuncelle1_ClickGuncelle);
            this.ucsBTNGuncelle1.ClickKapat += new System.EventHandler(this.ucsBTNGuncelle1_ClickKapat);
            // 
            // frmLokasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 563);
            this.Controls.Add(this.ucsBTNGuncelle1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLokasyon";
            this.Text = "Lokasyon Bilgileri Güncelleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLokasyon_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcUlkeDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUlkeDTO)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcIlDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlDTO)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcIlceDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlceDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcBeldeDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeldeDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUlkeDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIlDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsIlceDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBeldeDTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsUlkeDTO;
        private System.Windows.Forms.BindingSource bsIlDTO;
        private System.Windows.Forms.BindingSource bsIlceDTO;
        private System.Windows.Forms.BindingSource bsBeldeDTO;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgcUlkeDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvUlkeDTO;
        private DevExpress.XtraGrid.Columns.GridColumn colUlkeId;
        private DevExpress.XtraGrid.Columns.GridColumn colUlkeAdi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgcIlDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvIlDTO;
        private DevExpress.XtraGrid.Columns.GridColumn colSehirID;
        private DevExpress.XtraGrid.Columns.GridColumn colSehirAdi;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl dgcIlceDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvIlceDTO;
        private DevExpress.XtraGrid.Columns.GridColumn colIlceId;
        private DevExpress.XtraGrid.Columns.GridColumn colIlceAdi;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl dgcBeldeDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvBeldeDTO;
        private DevExpress.XtraGrid.Columns.GridColumn colBeldeId;
        private DevExpress.XtraGrid.Columns.GridColumn colBeldeAdi;
        private UserControls.ucsBTNGuncelle ucsBTNGuncelle1;
    }
}