namespace OmegaHKS.Views.Eslestirme
{
    partial class frmStokArama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokArama));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gcLocalStokListesi = new DevExpress.XtraGrid.GridControl();
            this.gvLocalStokListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTKKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOKAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREYON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREYONAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsLocalStoklar = new System.Windows.Forms.BindingSource();
            this.ucsBTNKayitIpal1 = new OmegaHKS.Views.UserControls.ucsBTNKayitIpal();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLocalStokListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLocalStokListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalStoklar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.gcLocalStokListesi);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(644, 427);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Omega Stok Listesi";
            // 
            // gcLocalStokListesi
            // 
            this.gcLocalStokListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLocalStokListesi.Location = new System.Drawing.Point(2, 21);
            this.gcLocalStokListesi.MainView = this.gvLocalStokListesi;
            this.gcLocalStokListesi.Name = "gcLocalStokListesi";
            this.gcLocalStokListesi.Size = new System.Drawing.Size(640, 404);
            this.gcLocalStokListesi.TabIndex = 0;
            this.gcLocalStokListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLocalStokListesi});
            // 
            // gvLocalStokListesi
            // 
            this.gvLocalStokListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTKKOD,
            this.colSTOKAD,
            this.colREYON,
            this.colREYONAD,
            this.colBARKOD});
            this.gvLocalStokListesi.GridControl = this.gcLocalStokListesi;
            this.gvLocalStokListesi.GroupPanelText = "Gruplamak İstediğiniz Kolonu Sürükleyip Buruya Bırakın";
            this.gvLocalStokListesi.Name = "gvLocalStokListesi";
            this.gvLocalStokListesi.OptionsView.ShowAutoFilterRow = true;
            // 
            // colSTKKOD
            // 
            this.colSTKKOD.Caption = "Stok Kodu";
            this.colSTKKOD.FieldName = "STKKOD";
            this.colSTKKOD.Name = "colSTKKOD";
            this.colSTKKOD.OptionsColumn.AllowEdit = false;
            this.colSTKKOD.OptionsColumn.AllowFocus = false;
            this.colSTKKOD.OptionsColumn.ReadOnly = true;
            this.colSTKKOD.Visible = true;
            this.colSTKKOD.VisibleIndex = 0;
            this.colSTKKOD.Width = 65;
            // 
            // colSTOKAD
            // 
            this.colSTOKAD.Caption = "Stok Adı";
            this.colSTOKAD.FieldName = "STOKAD";
            this.colSTOKAD.Name = "colSTOKAD";
            this.colSTOKAD.OptionsColumn.AllowEdit = false;
            this.colSTOKAD.OptionsColumn.AllowFocus = false;
            this.colSTOKAD.OptionsColumn.ReadOnly = true;
            this.colSTOKAD.Visible = true;
            this.colSTOKAD.VisibleIndex = 1;
            this.colSTOKAD.Width = 236;
            // 
            // colREYON
            // 
            this.colREYON.Caption = "Rey.No";
            this.colREYON.FieldName = "REYON";
            this.colREYON.Name = "colREYON";
            this.colREYON.OptionsColumn.AllowEdit = false;
            this.colREYON.OptionsColumn.AllowFocus = false;
            this.colREYON.OptionsColumn.ReadOnly = true;
            this.colREYON.Visible = true;
            this.colREYON.VisibleIndex = 2;
            this.colREYON.Width = 62;
            // 
            // colREYONAD
            // 
            this.colREYONAD.Caption = "Reyon";
            this.colREYONAD.FieldName = "REYONAD";
            this.colREYONAD.Name = "colREYONAD";
            this.colREYONAD.OptionsColumn.AllowEdit = false;
            this.colREYONAD.OptionsColumn.AllowFocus = false;
            this.colREYONAD.OptionsColumn.ReadOnly = true;
            this.colREYONAD.Visible = true;
            this.colREYONAD.VisibleIndex = 3;
            this.colREYONAD.Width = 188;
            // 
            // colBARKOD
            // 
            this.colBARKOD.Caption = "Barkod";
            this.colBARKOD.FieldName = "BARKOD";
            this.colBARKOD.Name = "colBARKOD";
            this.colBARKOD.OptionsColumn.AllowEdit = false;
            this.colBARKOD.OptionsColumn.AllowFocus = false;
            this.colBARKOD.OptionsColumn.ReadOnly = true;
            this.colBARKOD.Visible = true;
            this.colBARKOD.VisibleIndex = 4;
            this.colBARKOD.Width = 142;
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
            this.ucsBTNKayitIpal1.KaydetVisible = true;
            this.ucsBTNKayitIpal1.Location = new System.Drawing.Point(0, 445);
            this.ucsBTNKayitIpal1.Name = "ucsBTNKayitIpal1";
            this.ucsBTNKayitIpal1.Size = new System.Drawing.Size(668, 52);
            this.ucsBTNKayitIpal1.TabIndex = 2;
            this.ucsBTNKayitIpal1.TemizleImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.TemizleImage")));
            this.ucsBTNKayitIpal1.TemizleText = "&Temizle";
            this.ucsBTNKayitIpal1.TemizleVisible = false;
            this.ucsBTNKayitIpal1.ClickKaydet += new System.EventHandler(this.ucsBTNKayitIpal1_ClickKaydet);
            this.ucsBTNKayitIpal1.ClickIptal += new System.EventHandler(this.ucsBTNKayitIpal1_ClickIptal);
            // 
            // frmStokArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 497);
            this.Controls.Add(this.ucsBTNKayitIpal1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmStokArama";
            this.Text = "Omega Stok Arama";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLocalStokListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLocalStokListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalStoklar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gcLocalStokListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLocalStokListesi;
        private DevExpress.XtraGrid.Columns.GridColumn colSTKKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOKAD;
        private DevExpress.XtraGrid.Columns.GridColumn colREYON;
        private DevExpress.XtraGrid.Columns.GridColumn colREYONAD;
        private DevExpress.XtraGrid.Columns.GridColumn colBARKOD;
        private System.Windows.Forms.BindingSource bsLocalStoklar;
        private UserControls.ucsBTNKayitIpal ucsBTNKayitIpal1;
    }
}