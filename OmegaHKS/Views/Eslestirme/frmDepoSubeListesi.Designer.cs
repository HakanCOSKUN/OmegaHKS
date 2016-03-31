namespace OmegaHKS.Views.Eslestirme
{
    partial class frmDepoSubeListesi
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepoSubeListesi));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgcDepoSubeListesi = new DevExpress.XtraGrid.GridControl();
            this.dgvDepoSubeListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDMBNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colILCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHKSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHKSISYERITURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHKSBELDEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHKSILCEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHKSILID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsLocalDepoSube = new System.Windows.Forms.BindingSource(this.components);
            this.ucsBTNKayitIpal1 = new OmegaHKS.Views.UserControls.ucsBTNKayitIpal();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcDepoSubeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepoSubeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalDepoSube)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.dgcDepoSubeListesi);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(720, 402);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // dgcDepoSubeListesi
            // 
            this.dgcDepoSubeListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcDepoSubeListesi.Location = new System.Drawing.Point(2, 20);
            this.dgcDepoSubeListesi.MainView = this.dgvDepoSubeListesi;
            this.dgcDepoSubeListesi.Name = "dgcDepoSubeListesi";
            this.dgcDepoSubeListesi.Size = new System.Drawing.Size(716, 380);
            this.dgcDepoSubeListesi.TabIndex = 0;
            this.dgcDepoSubeListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDepoSubeListesi});
            // 
            // dgvDepoSubeListesi
            // 
            this.dgvDepoSubeListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDMBNO,
            this.colAD,
            this.colADRES,
            this.colILCE,
            this.colIL,
            this.colHKSID,
            this.colHKSISYERITURU,
            this.colHKSBELDEID,
            this.colHKSILCEID,
            this.colHKSILID});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "[HKSID] = 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.dgvDepoSubeListesi.FormatRules.Add(gridFormatRule1);
            this.dgvDepoSubeListesi.GridControl = this.dgcDepoSubeListesi;
            this.dgvDepoSubeListesi.Name = "dgvDepoSubeListesi";
            this.dgvDepoSubeListesi.OptionsView.ShowAutoFilterRow = true;
            this.dgvDepoSubeListesi.OptionsView.ShowGroupPanel = false;
            this.dgvDepoSubeListesi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDepoSubeListesi_KeyUp);
            this.dgvDepoSubeListesi.DoubleClick += new System.EventHandler(this.dgvDepoSubeListesi_DoubleClick);
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
            this.colDMBNO.Width = 63;
            // 
            // colAD
            // 
            this.colAD.Caption = "Açıklama";
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.OptionsColumn.AllowEdit = false;
            this.colAD.OptionsColumn.AllowFocus = false;
            this.colAD.OptionsColumn.ReadOnly = true;
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 1;
            this.colAD.Width = 172;
            // 
            // colADRES
            // 
            this.colADRES.Caption = "Adres";
            this.colADRES.FieldName = "ADRES";
            this.colADRES.Name = "colADRES";
            this.colADRES.OptionsColumn.AllowEdit = false;
            this.colADRES.OptionsColumn.AllowFocus = false;
            this.colADRES.OptionsColumn.ReadOnly = true;
            this.colADRES.Visible = true;
            this.colADRES.VisibleIndex = 2;
            this.colADRES.Width = 49;
            // 
            // colILCE
            // 
            this.colILCE.Caption = "İlçe";
            this.colILCE.FieldName = "ILCE";
            this.colILCE.Name = "colILCE";
            this.colILCE.OptionsColumn.AllowEdit = false;
            this.colILCE.OptionsColumn.AllowFocus = false;
            this.colILCE.OptionsColumn.ReadOnly = true;
            this.colILCE.Visible = true;
            this.colILCE.VisibleIndex = 3;
            this.colILCE.Width = 49;
            // 
            // colIL
            // 
            this.colIL.Caption = "İl";
            this.colIL.FieldName = "IL";
            this.colIL.Name = "colIL";
            this.colIL.OptionsColumn.AllowEdit = false;
            this.colIL.OptionsColumn.AllowFocus = false;
            this.colIL.OptionsColumn.ReadOnly = true;
            this.colIL.Visible = true;
            this.colIL.VisibleIndex = 4;
            this.colIL.Width = 49;
            // 
            // colHKSID
            // 
            this.colHKSID.Caption = "H.K.S. Id";
            this.colHKSID.FieldName = "HKSID";
            this.colHKSID.Name = "colHKSID";
            this.colHKSID.OptionsColumn.AllowEdit = false;
            this.colHKSID.OptionsColumn.AllowFocus = false;
            this.colHKSID.OptionsColumn.ReadOnly = true;
            this.colHKSID.Visible = true;
            this.colHKSID.VisibleIndex = 5;
            this.colHKSID.Width = 49;
            // 
            // colHKSISYERITURU
            // 
            this.colHKSISYERITURU.Caption = "H.K.S. İşyeri Türü";
            this.colHKSISYERITURU.FieldName = "HKSISYERITURU";
            this.colHKSISYERITURU.Name = "colHKSISYERITURU";
            this.colHKSISYERITURU.OptionsColumn.AllowEdit = false;
            this.colHKSISYERITURU.OptionsColumn.AllowFocus = false;
            this.colHKSISYERITURU.OptionsColumn.ReadOnly = true;
            this.colHKSISYERITURU.Visible = true;
            this.colHKSISYERITURU.VisibleIndex = 6;
            this.colHKSISYERITURU.Width = 49;
            // 
            // colHKSBELDEID
            // 
            this.colHKSBELDEID.Caption = "Belde Id";
            this.colHKSBELDEID.FieldName = "HKSBELDEID";
            this.colHKSBELDEID.Name = "colHKSBELDEID";
            this.colHKSBELDEID.OptionsColumn.AllowEdit = false;
            this.colHKSBELDEID.OptionsColumn.AllowFocus = false;
            this.colHKSBELDEID.OptionsColumn.ReadOnly = true;
            this.colHKSBELDEID.Visible = true;
            this.colHKSBELDEID.VisibleIndex = 7;
            this.colHKSBELDEID.Width = 49;
            // 
            // colHKSILCEID
            // 
            this.colHKSILCEID.Caption = "İlçe Id";
            this.colHKSILCEID.FieldName = "HKSILCEID";
            this.colHKSILCEID.Name = "colHKSILCEID";
            this.colHKSILCEID.OptionsColumn.AllowEdit = false;
            this.colHKSILCEID.OptionsColumn.AllowFocus = false;
            this.colHKSILCEID.OptionsColumn.ReadOnly = true;
            this.colHKSILCEID.Visible = true;
            this.colHKSILCEID.VisibleIndex = 8;
            this.colHKSILCEID.Width = 49;
            // 
            // colHKSILID
            // 
            this.colHKSILID.Caption = "İl Id";
            this.colHKSILID.FieldName = "HKSILID";
            this.colHKSILID.Name = "colHKSILID";
            this.colHKSILID.OptionsColumn.AllowEdit = false;
            this.colHKSILID.OptionsColumn.AllowFocus = false;
            this.colHKSILID.OptionsColumn.ReadOnly = true;
            this.colHKSILID.Visible = true;
            this.colHKSILID.VisibleIndex = 9;
            this.colHKSILID.Width = 56;
            // 
            // ucsBTNKayitIpal1
            // 
            this.ucsBTNKayitIpal1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucsBTNKayitIpal1.IptalEnabled = true;
            this.ucsBTNKayitIpal1.IptalImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.IptalImage")));
            this.ucsBTNKayitIpal1.IptalText = "Kapa&t";
            this.ucsBTNKayitIpal1.IptalVisible = true;
            this.ucsBTNKayitIpal1.KaydetEnabled = true;
            this.ucsBTNKayitIpal1.KaydetImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.KaydetImage")));
            this.ucsBTNKayitIpal1.KaydetText = "&Kaydet";
            this.ucsBTNKayitIpal1.KaydetVisible = false;
            this.ucsBTNKayitIpal1.Location = new System.Drawing.Point(0, 420);
            this.ucsBTNKayitIpal1.Name = "ucsBTNKayitIpal1";
            this.ucsBTNKayitIpal1.Size = new System.Drawing.Size(744, 52);
            this.ucsBTNKayitIpal1.TabIndex = 1;
            this.ucsBTNKayitIpal1.TemizleImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.TemizleImage")));
            this.ucsBTNKayitIpal1.TemizleText = "&Temizle";
            this.ucsBTNKayitIpal1.TemizleVisible = false;
            this.ucsBTNKayitIpal1.ClickIptal += new System.EventHandler(this.ucsBTNKayitIpal1_ClickIptal);
            // 
            // frmDepoSubeListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 472);
            this.Controls.Add(this.ucsBTNKayitIpal1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDepoSubeListesi";
            this.Text = "frmDepoSubeListesi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcDepoSubeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepoSubeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalDepoSube)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgcDepoSubeListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDepoSubeListesi;
        private DevExpress.XtraGrid.Columns.GridColumn colDMBNO;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colADRES;
        private DevExpress.XtraGrid.Columns.GridColumn colILCE;
        private DevExpress.XtraGrid.Columns.GridColumn colIL;
        private DevExpress.XtraGrid.Columns.GridColumn colHKSID;
        private DevExpress.XtraGrid.Columns.GridColumn colHKSISYERITURU;
        private DevExpress.XtraGrid.Columns.GridColumn colHKSBELDEID;
        private DevExpress.XtraGrid.Columns.GridColumn colHKSILCEID;
        private DevExpress.XtraGrid.Columns.GridColumn colHKSILID;
        private System.Windows.Forms.BindingSource bsLocalDepoSube;
        private UserControls.ucsBTNKayitIpal ucsBTNKayitIpal1;
    }
}