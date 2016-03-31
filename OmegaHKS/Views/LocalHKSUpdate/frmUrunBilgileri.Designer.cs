namespace OmegaHKS.Views.LocalHKSUpdate
{
    partial class frmUrunBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunBilgileri));
            this.bsUrunDTO = new System.Windows.Forms.BindingSource();
            this.bsUrunCinsiDTO = new System.Windows.Forms.BindingSource();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgcUrunDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvUrunDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUrunId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgcUrunCinsiDTO = new DevExpress.XtraGrid.GridControl();
            this.dgvUrunCinsiDTO = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCinsId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIthalmi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUretimSekilId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunCinsiAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCinsUrunId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucsBTNGuncelle1 = new OmegaHKS.Views.UserControls.ucsBTNGuncelle();
            ((System.ComponentModel.ISupportInitialize)(this.bsUrunDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUrunCinsiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcUrunDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcUrunCinsiDTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunCinsiDTO)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.groupControl3);
            this.splitContainer1.Size = new System.Drawing.Size(934, 471);
            this.splitContainer1.SplitterDistance = 299;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgcUrunDTO);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(299, 471);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Ürün Bilgisi Listesi";
            // 
            // dgcUrunDTO
            // 
            this.dgcUrunDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcUrunDTO.Location = new System.Drawing.Point(2, 21);
            this.dgcUrunDTO.MainView = this.dgvUrunDTO;
            this.dgcUrunDTO.Name = "dgcUrunDTO";
            this.dgcUrunDTO.Size = new System.Drawing.Size(295, 448);
            this.dgcUrunDTO.TabIndex = 0;
            this.dgcUrunDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvUrunDTO});
            // 
            // dgvUrunDTO
            // 
            this.dgvUrunDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUrunId,
            this.colUrunAdi});
            this.dgvUrunDTO.GridControl = this.dgcUrunDTO;
            this.dgvUrunDTO.Name = "dgvUrunDTO";
            this.dgvUrunDTO.OptionsView.ShowAutoFilterRow = true;
            this.dgvUrunDTO.OptionsView.ShowGroupPanel = false;
            this.dgvUrunDTO.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvUrunDTO_FocusedRowChanged);
            // 
            // colUrunId
            // 
            this.colUrunId.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colUrunId.Caption = "Id";
            this.colUrunId.FieldName = "Id";
            this.colUrunId.Name = "colUrunId";
            this.colUrunId.Visible = true;
            this.colUrunId.VisibleIndex = 0;
            this.colUrunId.Width = 55;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Açıklama";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.OptionsColumn.AllowFocus = false;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            this.colUrunAdi.Width = 266;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgcUrunCinsiDTO);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(631, 471);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Ürün Cins Listesi";
            // 
            // dgcUrunCinsiDTO
            // 
            this.dgcUrunCinsiDTO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcUrunCinsiDTO.Location = new System.Drawing.Point(2, 21);
            this.dgcUrunCinsiDTO.MainView = this.dgvUrunCinsiDTO;
            this.dgcUrunCinsiDTO.Name = "dgcUrunCinsiDTO";
            this.dgcUrunCinsiDTO.Size = new System.Drawing.Size(627, 448);
            this.dgcUrunCinsiDTO.TabIndex = 0;
            this.dgcUrunCinsiDTO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvUrunCinsiDTO});
            // 
            // dgvUrunCinsiDTO
            // 
            this.dgvUrunCinsiDTO.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCinsId,
            this.colIthalmi,
            this.colUretimSekilId,
            this.colUrunCinsiAdi,
            this.colCinsUrunId,
            this.colUrunKodu});
            this.dgvUrunCinsiDTO.GridControl = this.dgcUrunCinsiDTO;
            this.dgvUrunCinsiDTO.Name = "dgvUrunCinsiDTO";
            this.dgvUrunCinsiDTO.OptionsView.ShowAutoFilterRow = true;
            this.dgvUrunCinsiDTO.OptionsView.ShowGroupPanel = false;
            // 
            // colCinsId
            // 
            this.colCinsId.AppearanceCell.Options.UseTextOptions = true;
            this.colCinsId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCinsId.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCinsId.Caption = "Id";
            this.colCinsId.FieldName = "Id";
            this.colCinsId.Name = "colCinsId";
            this.colCinsId.OptionsColumn.AllowEdit = false;
            this.colCinsId.OptionsColumn.AllowFocus = false;
            this.colCinsId.OptionsColumn.ReadOnly = true;
            this.colCinsId.Visible = true;
            this.colCinsId.VisibleIndex = 0;
            this.colCinsId.Width = 42;
            // 
            // colIthalmi
            // 
            this.colIthalmi.AppearanceCell.Options.UseTextOptions = true;
            this.colIthalmi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colIthalmi.Caption = "İthalmi?";
            this.colIthalmi.FieldName = "Ithalmi";
            this.colIthalmi.Name = "colIthalmi";
            this.colIthalmi.OptionsColumn.AllowEdit = false;
            this.colIthalmi.OptionsColumn.AllowFocus = false;
            this.colIthalmi.OptionsColumn.ReadOnly = true;
            this.colIthalmi.Visible = true;
            this.colIthalmi.VisibleIndex = 1;
            this.colIthalmi.Width = 52;
            // 
            // colUretimSekilId
            // 
            this.colUretimSekilId.AppearanceCell.Options.UseTextOptions = true;
            this.colUretimSekilId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colUretimSekilId.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUretimSekilId.Caption = "Üretim Sekil Id";
            this.colUretimSekilId.FieldName = "UretimSekliId";
            this.colUretimSekilId.Name = "colUretimSekilId";
            this.colUretimSekilId.OptionsColumn.AllowEdit = false;
            this.colUretimSekilId.OptionsColumn.AllowFocus = false;
            this.colUretimSekilId.OptionsColumn.ReadOnly = true;
            this.colUretimSekilId.Visible = true;
            this.colUretimSekilId.VisibleIndex = 2;
            this.colUretimSekilId.Width = 80;
            // 
            // colUrunCinsiAdi
            // 
            this.colUrunCinsiAdi.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunCinsiAdi.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUrunCinsiAdi.Caption = "Cins Adı";
            this.colUrunCinsiAdi.FieldName = "UrunCinsiAdi";
            this.colUrunCinsiAdi.Name = "colUrunCinsiAdi";
            this.colUrunCinsiAdi.OptionsColumn.AllowEdit = false;
            this.colUrunCinsiAdi.OptionsColumn.AllowFocus = false;
            this.colUrunCinsiAdi.OptionsColumn.ReadOnly = true;
            this.colUrunCinsiAdi.Visible = true;
            this.colUrunCinsiAdi.VisibleIndex = 3;
            this.colUrunCinsiAdi.Width = 174;
            // 
            // colCinsUrunId
            // 
            this.colCinsUrunId.AppearanceCell.Options.UseTextOptions = true;
            this.colCinsUrunId.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCinsUrunId.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colCinsUrunId.Caption = "Ürün Id";
            this.colCinsUrunId.FieldName = "UrunId";
            this.colCinsUrunId.Name = "colCinsUrunId";
            this.colCinsUrunId.OptionsColumn.AllowEdit = false;
            this.colCinsUrunId.OptionsColumn.AllowFocus = false;
            this.colCinsUrunId.OptionsColumn.ReadOnly = true;
            this.colCinsUrunId.Visible = true;
            this.colCinsUrunId.VisibleIndex = 4;
            this.colCinsUrunId.Width = 70;
            // 
            // colUrunKodu
            // 
            this.colUrunKodu.AppearanceCell.Options.UseTextOptions = true;
            this.colUrunKodu.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colUrunKodu.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colUrunKodu.Caption = "Ürün Kodu";
            this.colUrunKodu.FieldName = "UrunKodu";
            this.colUrunKodu.Name = "colUrunKodu";
            this.colUrunKodu.OptionsColumn.AllowEdit = false;
            this.colUrunKodu.OptionsColumn.AllowFocus = false;
            this.colUrunKodu.OptionsColumn.ReadOnly = true;
            this.colUrunKodu.Visible = true;
            this.colUrunKodu.VisibleIndex = 5;
            this.colUrunKodu.Width = 85;
            // 
            // ucsBTNGuncelle1
            // 
            this.ucsBTNGuncelle1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucsBTNGuncelle1.GuncelleEnabled = true;
            this.ucsBTNGuncelle1.GuncelleVisible = true;
            this.ucsBTNGuncelle1.KapatEnabled = true;
            this.ucsBTNGuncelle1.KapatVisible = true;
            this.ucsBTNGuncelle1.Location = new System.Drawing.Point(0, 489);
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
            this.ucsBTNGuncelle1.Size = new System.Drawing.Size(958, 57);
            this.ucsBTNGuncelle1.TabIndex = 3;
            this.ucsBTNGuncelle1.ClickGuncelle += new System.EventHandler(this.ucsBTNGuncelle1_ClickGuncelle);
            this.ucsBTNGuncelle1.ClickKapat += new System.EventHandler(this.ucsBTNGuncelle1_ClickKapat);
            // 
            // frmUrunBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 546);
            this.Controls.Add(this.ucsBTNGuncelle1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUrunBilgileri";
            this.Text = "Ürün Güncellemeleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUrunBilgileri_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsUrunDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUrunCinsiDTO)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcUrunDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcUrunCinsiDTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunCinsiDTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsUrunDTO;
        private System.Windows.Forms.BindingSource bsUrunCinsiDTO;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgcUrunDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvUrunDTO;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl dgcUrunCinsiDTO;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvUrunCinsiDTO;
        private DevExpress.XtraGrid.Columns.GridColumn colCinsId;
        private DevExpress.XtraGrid.Columns.GridColumn colIthalmi;
        private DevExpress.XtraGrid.Columns.GridColumn colUretimSekilId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunCinsiAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colCinsUrunId;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunKodu;
        private UserControls.ucsBTNGuncelle ucsBTNGuncelle1;
    }
}