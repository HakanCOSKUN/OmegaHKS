namespace OmegaHKS.Views.Main
{
    partial class frmHataListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHataListele));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgcErrorList = new DevExpress.XtraGrid.GridControl();
            this.dgvErrorList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHataTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHataBilgisi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucsBTNKayitIpal1 = new OmegaHKS.Views.UserControls.ucsBTNKayitIpal();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcErrorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.dgcErrorList);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(647, 378);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Oluşan Hatalar Listesi";
            // 
            // dgcErrorList
            // 
            this.dgcErrorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcErrorList.Location = new System.Drawing.Point(2, 21);
            this.dgcErrorList.MainView = this.dgvErrorList;
            this.dgcErrorList.Name = "dgcErrorList";
            this.dgcErrorList.Size = new System.Drawing.Size(643, 355);
            this.dgcErrorList.TabIndex = 0;
            this.dgcErrorList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvErrorList});
            // 
            // dgvErrorList
            // 
            this.dgvErrorList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTarih,
            this.colHataTipi,
            this.colHataBilgisi});
            this.dgvErrorList.GridControl = this.dgcErrorList;
            this.dgvErrorList.Name = "dgvErrorList";
            this.dgvErrorList.OptionsView.ShowGroupPanel = false;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.OptionsColumn.AllowFocus = false;
            this.colTarih.OptionsColumn.ReadOnly = true;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            this.colTarih.Width = 83;
            // 
            // colHataTipi
            // 
            this.colHataTipi.Caption = "Hata Tipi";
            this.colHataTipi.FieldName = "HataTipi";
            this.colHataTipi.Name = "colHataTipi";
            this.colHataTipi.OptionsColumn.AllowEdit = false;
            this.colHataTipi.OptionsColumn.AllowFocus = false;
            this.colHataTipi.OptionsColumn.ReadOnly = true;
            this.colHataTipi.Visible = true;
            this.colHataTipi.VisibleIndex = 1;
            this.colHataTipi.Width = 82;
            // 
            // colHataBilgisi
            // 
            this.colHataBilgisi.Caption = "Hata İceriği";
            this.colHataBilgisi.FieldName = "HataBilgisi";
            this.colHataBilgisi.Name = "colHataBilgisi";
            this.colHataBilgisi.OptionsColumn.AllowEdit = false;
            this.colHataBilgisi.OptionsColumn.AllowFocus = false;
            this.colHataBilgisi.OptionsColumn.ReadOnly = true;
            this.colHataBilgisi.Visible = true;
            this.colHataBilgisi.VisibleIndex = 2;
            this.colHataBilgisi.Width = 689;
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
            this.ucsBTNKayitIpal1.KaydetVisible = false;
            this.ucsBTNKayitIpal1.Location = new System.Drawing.Point(0, 396);
            this.ucsBTNKayitIpal1.Name = "ucsBTNKayitIpal1";
            this.ucsBTNKayitIpal1.Size = new System.Drawing.Size(678, 52);
            this.ucsBTNKayitIpal1.TabIndex = 1;
            this.ucsBTNKayitIpal1.TemizleImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.TemizleImage")));
            this.ucsBTNKayitIpal1.TemizleText = "&Temizle";
            this.ucsBTNKayitIpal1.TemizleVisible = false;
            this.ucsBTNKayitIpal1.ClickIptal += new System.EventHandler(this.ucsBTNKayitIpal1_ClickIptal);
            // 
            // frmHataListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 448);
            this.Controls.Add(this.ucsBTNKayitIpal1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHataListele";
            this.Text = "Olşan Hata Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcErrorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrorList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgcErrorList;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvErrorList;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colHataTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colHataBilgisi;
        private UserControls.ucsBTNKayitIpal ucsBTNKayitIpal1;
    }
}