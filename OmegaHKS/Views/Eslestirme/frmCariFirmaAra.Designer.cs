namespace OmegaHKS.Views.Eslestirme
{
    partial class frmCariFirmaAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariFirmaAra));
            this.ucsBTNKayitIpal1 = new OmegaHKS.Views.UserControls.ucsBTNKayitIpal();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgcCariListe = new DevExpress.XtraGrid.GridControl();
            this.dgvCariListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCARKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNVAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERGIDAIRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERGINO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsCariList = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcCariListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCariList)).BeginInit();
            this.SuspendLayout();
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
            this.ucsBTNKayitIpal1.Location = new System.Drawing.Point(0, 332);
            this.ucsBTNKayitIpal1.Name = "ucsBTNKayitIpal1";
            this.ucsBTNKayitIpal1.Size = new System.Drawing.Size(672, 52);
            this.ucsBTNKayitIpal1.TabIndex = 0;
            this.ucsBTNKayitIpal1.TemizleImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.TemizleImage")));
            this.ucsBTNKayitIpal1.TemizleText = "&Temizle";
            this.ucsBTNKayitIpal1.TemizleVisible = false;
            this.ucsBTNKayitIpal1.ClickIptal += new System.EventHandler(this.ucsBTNKayitIpal1_ClickIptal);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.dgcCariListe);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(648, 304);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Firma Listesi";
            // 
            // dgcCariListe
            // 
            this.dgcCariListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcCariListe.Location = new System.Drawing.Point(2, 21);
            this.dgcCariListe.MainView = this.dgvCariListe;
            this.dgcCariListe.Name = "dgcCariListe";
            this.dgcCariListe.Size = new System.Drawing.Size(644, 281);
            this.dgcCariListe.TabIndex = 0;
            this.dgcCariListe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvCariListe});
            // 
            // dgvCariListe
            // 
            this.dgvCariListe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCARKOD,
            this.colUNVAN,
            this.colVERGIDAIRE,
            this.colVERGINO});
            this.dgvCariListe.GridControl = this.dgcCariListe;
            this.dgvCariListe.Name = "dgvCariListe";
            this.dgvCariListe.OptionsView.ShowAutoFilterRow = true;
            this.dgvCariListe.OptionsView.ShowGroupPanel = false;
            this.dgvCariListe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvCariListe_KeyUp);
            this.dgvCariListe.DoubleClick += new System.EventHandler(this.dgvCariListe_DoubleClick);
            // 
            // colCARKOD
            // 
            this.colCARKOD.Caption = "Car Kod";
            this.colCARKOD.FieldName = "CARKOD";
            this.colCARKOD.Name = "colCARKOD";
            this.colCARKOD.OptionsColumn.AllowEdit = false;
            this.colCARKOD.OptionsColumn.AllowFocus = false;
            this.colCARKOD.OptionsColumn.ReadOnly = true;
            this.colCARKOD.Visible = true;
            this.colCARKOD.VisibleIndex = 0;
            this.colCARKOD.Width = 88;
            // 
            // colUNVAN
            // 
            this.colUNVAN.Caption = "Cari Ünvanı";
            this.colUNVAN.FieldName = "UNVAN";
            this.colUNVAN.Name = "colUNVAN";
            this.colUNVAN.OptionsColumn.AllowEdit = false;
            this.colUNVAN.OptionsColumn.AllowFocus = false;
            this.colUNVAN.OptionsColumn.ReadOnly = true;
            this.colUNVAN.Visible = true;
            this.colUNVAN.VisibleIndex = 1;
            this.colUNVAN.Width = 292;
            // 
            // colVERGIDAIRE
            // 
            this.colVERGIDAIRE.Caption = "Vergi Dairesi";
            this.colVERGIDAIRE.FieldName = "VERGIDAIRE";
            this.colVERGIDAIRE.Name = "colVERGIDAIRE";
            this.colVERGIDAIRE.OptionsColumn.AllowEdit = false;
            this.colVERGIDAIRE.OptionsColumn.AllowFocus = false;
            this.colVERGIDAIRE.OptionsColumn.ReadOnly = true;
            this.colVERGIDAIRE.Visible = true;
            this.colVERGIDAIRE.VisibleIndex = 2;
            this.colVERGIDAIRE.Width = 120;
            // 
            // colVERGINO
            // 
            this.colVERGINO.Caption = "TC / Vergi No";
            this.colVERGINO.FieldName = "VERGINO";
            this.colVERGINO.Name = "colVERGINO";
            this.colVERGINO.OptionsColumn.AllowEdit = false;
            this.colVERGINO.OptionsColumn.AllowFocus = false;
            this.colVERGINO.OptionsColumn.ReadOnly = true;
            this.colVERGINO.Visible = true;
            this.colVERGINO.VisibleIndex = 3;
            this.colVERGINO.Width = 126;
            // 
            // frmCariFirmaAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 384);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucsBTNKayitIpal1);
            this.Name = "frmCariFirmaAra";
            this.Text = "Cari Firma Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcCariListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCariList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucsBTNKayitIpal ucsBTNKayitIpal1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgcCariListe;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvCariListe;
        private DevExpress.XtraGrid.Columns.GridColumn colCARKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colUNVAN;
        private DevExpress.XtraGrid.Columns.GridColumn colVERGIDAIRE;
        private DevExpress.XtraGrid.Columns.GridColumn colVERGINO;
        private System.Windows.Forms.BindingSource bsCariList;
    }
}