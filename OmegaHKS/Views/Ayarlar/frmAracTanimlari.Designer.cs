namespace OmegaHKS.Views.Ayarlar
{
    partial class frmAracTanimlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracTanimlari));
            this.ucsBTNKayitIpal1 = new OmegaHKS.Views.UserControls.ucsBTNKayitIpal();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgcAracPlaka = new DevExpress.XtraGrid.GridControl();
            this.dgvAracPlaka = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDMBNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLAKANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsAracPlaka = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcAracPlaka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracPlaka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAracPlaka)).BeginInit();
            this.SuspendLayout();
            // 
            // ucsBTNKayitIpal1
            // 
            this.ucsBTNKayitIpal1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucsBTNKayitIpal1.IptalEnabled = true;
            this.ucsBTNKayitIpal1.IptalImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.IptalImage")));
            this.ucsBTNKayitIpal1.IptalText = "&Kapat";
            this.ucsBTNKayitIpal1.IptalVisible = true;
            this.ucsBTNKayitIpal1.KaydetEnabled = true;
            this.ucsBTNKayitIpal1.KaydetImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.KaydetImage")));
            this.ucsBTNKayitIpal1.KaydetText = "&Kaydet";
            this.ucsBTNKayitIpal1.KaydetVisible = true;
            this.ucsBTNKayitIpal1.Location = new System.Drawing.Point(0, 447);
            this.ucsBTNKayitIpal1.Name = "ucsBTNKayitIpal1";
            this.ucsBTNKayitIpal1.Size = new System.Drawing.Size(625, 52);
            this.ucsBTNKayitIpal1.TabIndex = 0;
            this.ucsBTNKayitIpal1.TemizleImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.TemizleImage")));
            this.ucsBTNKayitIpal1.TemizleText = "&Temizle";
            this.ucsBTNKayitIpal1.TemizleVisible = false;
            this.ucsBTNKayitIpal1.ClickKaydet += new System.EventHandler(this.ucsBTNKayitIpal1_ClickKaydet);
            this.ucsBTNKayitIpal1.ClickIptal += new System.EventHandler(this.ucsBTNKayitIpal1_ClickIptal);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.dgcAracPlaka);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(601, 429);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Araç Plaka Tanımları";
            // 
            // dgcAracPlaka
            // 
            this.dgcAracPlaka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcAracPlaka.Location = new System.Drawing.Point(2, 20);
            this.dgcAracPlaka.MainView = this.dgvAracPlaka;
            this.dgcAracPlaka.Name = "dgcAracPlaka";
            this.dgcAracPlaka.Size = new System.Drawing.Size(597, 407);
            this.dgcAracPlaka.TabIndex = 0;
            this.dgcAracPlaka.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvAracPlaka});
            // 
            // dgvAracPlaka
            // 
            this.dgvAracPlaka.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDMBNO,
            this.colACIKLAMA,
            this.colPLAKANO});
            this.dgvAracPlaka.GridControl = this.dgcAracPlaka;
            this.dgvAracPlaka.Name = "dgvAracPlaka";
            this.dgvAracPlaka.OptionsView.ShowGroupPanel = false;
            // 
            // colDMBNO
            // 
            this.colDMBNO.Caption = "No";
            this.colDMBNO.FieldName = "DMBNO";
            this.colDMBNO.Name = "colDMBNO";
            this.colDMBNO.OptionsColumn.AllowEdit = false;
            this.colDMBNO.OptionsColumn.AllowFocus = false;
            this.colDMBNO.OptionsColumn.ReadOnly = true;
            this.colDMBNO.Visible = true;
            this.colDMBNO.VisibleIndex = 0;
            this.colDMBNO.Width = 66;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.Caption = "Açıklama";
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.OptionsColumn.AllowEdit = false;
            this.colACIKLAMA.OptionsColumn.AllowFocus = false;
            this.colACIKLAMA.OptionsColumn.ReadOnly = true;
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 1;
            this.colACIKLAMA.Width = 351;
            // 
            // colPLAKANO
            // 
            this.colPLAKANO.Caption = "Plaka";
            this.colPLAKANO.FieldName = "PLAKANO";
            this.colPLAKANO.Name = "colPLAKANO";
            this.colPLAKANO.Visible = true;
            this.colPLAKANO.VisibleIndex = 2;
            this.colPLAKANO.Width = 133;
            // 
            // frmAracTanimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 499);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ucsBTNKayitIpal1);
            this.Name = "frmAracTanimlari";
            this.Text = "Depo Araç Plaka Tanımları";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcAracPlaka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracPlaka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAracPlaka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucsBTNKayitIpal ucsBTNKayitIpal1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgcAracPlaka;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvAracPlaka;
        private DevExpress.XtraGrid.Columns.GridColumn colDMBNO;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colPLAKANO;
        private System.Windows.Forms.BindingSource bsAracPlaka;
    }
}