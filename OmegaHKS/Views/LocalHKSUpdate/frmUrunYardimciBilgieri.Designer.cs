namespace OmegaHKS.Views.LocalHKSUpdate
{
    partial class frmUrunYardimciBilgieri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunYardimciBilgieri));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgcUretimSekliDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvUretimSekliDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUretimSekliAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgcMalinNiteligiDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvMalinNiteligiDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collMalinNiteligiAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgcUrunBirimiDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvUrunBirimiDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colllId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunBirimAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsUrunBirimiDTO = new System.Windows.Forms.BindingSource();
            this.bsMalinNiteligiDTO = new System.Windows.Forms.BindingSource();
            this.bsUretimSekliDTO = new System.Windows.Forms.BindingSource();
            this.ucsBTNGuncelle1 = new OmegaHKS.Views.UserControls.ucsBTNGuncelle();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcUretimSekliDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUretimSekliDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcMalinNiteligiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalinNiteligiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcUrunBirimiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunBirimiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUrunBirimiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMalinNiteligiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUretimSekliDTO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.splitContainer1);
            this.groupControl1.Location = new System.Drawing.Point(12, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(888, 490);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ürün Yardımcı Tanımları";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(2, 21);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgcUretimSekliDTO);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(884, 467);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgcUretimSekliDTO
            // 
            this.dgcUretimSekliDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcUretimSekliDTO.Location = new System.Drawing.Point(0, 0);
            this.dgcUretimSekliDTO.MainView = this.dgvUretimSekliDTO;
            this.dgcUretimSekliDTO.Name = "dgcUretimSekliDTO";
            this.dgcUretimSekliDTO.Size = new System.Drawing.Size(294, 467);
            this.dgcUretimSekliDTO.TabIndex = 0;
            this.dgcUretimSekliDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvUretimSekliDTO});
            // 
            // dgvUretimSekliDTO
            // 
            this.dgvUretimSekliDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colUretimSekliAdi});
            this.dgvUretimSekliDTO.GridControl = this.dgcUretimSekliDTO;
            this.dgvUretimSekliDTO.Name = "dgvUretimSekliDTO";
            this.dgvUretimSekliDTO.OptionsView.ShowGroupPanel = false;
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
            this.colId.Width = 51;
            // 
            // colUretimSekliAdi
            // 
            this.colUretimSekliAdi.Caption = "Üretim Şekli";
            this.colUretimSekliAdi.FieldName = "UretimSekliAdi";
            this.colUretimSekliAdi.Name = "colUretimSekliAdi";
            this.colUretimSekliAdi.OptionsColumn.AllowEdit = false;
            this.colUretimSekliAdi.OptionsColumn.AllowFocus = false;
            this.colUretimSekliAdi.OptionsColumn.ReadOnly = true;
            this.colUretimSekliAdi.Visible = true;
            this.colUretimSekliAdi.VisibleIndex = 1;
            this.colUretimSekliAdi.Width = 222;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgcMalinNiteligiDTO);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgcUrunBirimiDTO);
            this.splitContainer2.Size = new System.Drawing.Size(586, 467);
            this.splitContainer2.SplitterDistance = 281;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgcMalinNiteligiDTO
            // 
            this.dgcMalinNiteligiDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcMalinNiteligiDTO.Location = new System.Drawing.Point(0, 0);
            this.dgcMalinNiteligiDTO.MainView = this.dgvMalinNiteligiDTO;
            this.dgcMalinNiteligiDTO.Name = "dgcMalinNiteligiDTO";
            this.dgcMalinNiteligiDTO.Size = new System.Drawing.Size(281, 467);
            this.dgcMalinNiteligiDTO.TabIndex = 0;
            this.dgcMalinNiteligiDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMalinNiteligiDTO});
            // 
            // dgvMalinNiteligiDTO
            // 
            this.dgvMalinNiteligiDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collId,
            this.collMalinNiteligiAdi});
            this.dgvMalinNiteligiDTO.GridControl = this.dgcMalinNiteligiDTO;
            this.dgvMalinNiteligiDTO.Name = "dgvMalinNiteligiDTO";
            this.dgvMalinNiteligiDTO.OptionsView.ShowGroupPanel = false;
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
            this.collId.Width = 59;
            // 
            // collMalinNiteligiAdi
            // 
            this.collMalinNiteligiAdi.Caption = "Ürünün Niteliği";
            this.collMalinNiteligiAdi.FieldName = "MalinNiteligiAdi";
            this.collMalinNiteligiAdi.Name = "collMalinNiteligiAdi";
            this.collMalinNiteligiAdi.OptionsColumn.AllowEdit = false;
            this.collMalinNiteligiAdi.OptionsColumn.AllowFocus = false;
            this.collMalinNiteligiAdi.OptionsColumn.ReadOnly = true;
            this.collMalinNiteligiAdi.Visible = true;
            this.collMalinNiteligiAdi.VisibleIndex = 1;
            this.collMalinNiteligiAdi.Width = 204;
            // 
            // dgcUrunBirimiDTO
            // 
            this.dgcUrunBirimiDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcUrunBirimiDTO.Location = new System.Drawing.Point(0, 0);
            this.dgcUrunBirimiDTO.MainView = this.dgvUrunBirimiDTO;
            this.dgcUrunBirimiDTO.Name = "dgcUrunBirimiDTO";
            this.dgcUrunBirimiDTO.Size = new System.Drawing.Size(301, 467);
            this.dgcUrunBirimiDTO.TabIndex = 0;
            this.dgcUrunBirimiDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvUrunBirimiDTO});
            // 
            // dgvUrunBirimiDTO
            // 
            this.dgvUrunBirimiDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colllId,
            this.colUrunBirimAdi});
            this.dgvUrunBirimiDTO.GridControl = this.dgcUrunBirimiDTO;
            this.dgvUrunBirimiDTO.Name = "dgvUrunBirimiDTO";
            this.dgvUrunBirimiDTO.OptionsView.ShowGroupPanel = false;
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
            this.colllId.Width = 48;
            // 
            // colUrunBirimAdi
            // 
            this.colUrunBirimAdi.Caption = "Ürün Birimi Adı";
            this.colUrunBirimAdi.FieldName = "UrunBirimAdi";
            this.colUrunBirimAdi.Name = "colUrunBirimAdi";
            this.colUrunBirimAdi.OptionsColumn.AllowEdit = false;
            this.colUrunBirimAdi.OptionsColumn.AllowFocus = false;
            this.colUrunBirimAdi.OptionsColumn.ReadOnly = true;
            this.colUrunBirimAdi.Visible = true;
            this.colUrunBirimAdi.VisibleIndex = 1;
            this.colUrunBirimAdi.Width = 232;
            // 
            // ucsBTNGuncelle1
            // 
            this.ucsBTNGuncelle1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucsBTNGuncelle1.GuncelleEnabled = true;
            this.ucsBTNGuncelle1.GuncelleVisible = true;
            this.ucsBTNGuncelle1.KapatEnabled = true;
            this.ucsBTNGuncelle1.KapatVisible = true;
            this.ucsBTNGuncelle1.Location = new System.Drawing.Point(0, 499);
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
            this.ucsBTNGuncelle1.Size = new System.Drawing.Size(912, 57);
            this.ucsBTNGuncelle1.TabIndex = 1;
            this.ucsBTNGuncelle1.ClickGuncelle += new System.EventHandler(this.ucsBTNGuncelle1_ClickGuncelle);
            this.ucsBTNGuncelle1.ClickKapat += new System.EventHandler(this.ucsBTNGuncelle1_ClickKapat);
            // 
            // frmUrunYardimciBilgieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 556);
            this.Controls.Add(this.ucsBTNGuncelle1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUrunYardimciBilgieri";
            this.Text = "Ürün Bildirimi Yardımcı Bilgiler";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcUretimSekliDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUretimSekliDTO)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcMalinNiteligiDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalinNiteligiDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcUrunBirimiDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunBirimiDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUrunBirimiDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMalinNiteligiDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUretimSekliDTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsUrunBirimiDTO;
        private System.Windows.Forms.BindingSource bsMalinNiteligiDTO;
        private System.Windows.Forms.BindingSource bsUretimSekliDTO;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraGrid.GridControl dgcUretimSekliDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvUretimSekliDTO;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colUretimSekliAdi;
        private DevExpress.XtraGrid.GridControl dgcMalinNiteligiDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMalinNiteligiDTO;
        private DevExpress.XtraGrid.Columns.GridColumn collId;
        private DevExpress.XtraGrid.Columns.GridColumn collMalinNiteligiAdi;
        private DevExpress.XtraGrid.GridControl dgcUrunBirimiDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvUrunBirimiDTO;
        private DevExpress.XtraGrid.Columns.GridColumn colllId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunBirimAdi;
        private UserControls.ucsBTNGuncelle ucsBTNGuncelle1;
    }
}