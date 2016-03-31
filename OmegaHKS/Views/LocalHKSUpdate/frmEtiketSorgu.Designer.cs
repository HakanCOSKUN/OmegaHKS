namespace OmegaHKS.Views.LocalHKSUpdate
{
    partial class frmEtiketSorgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEtiketSorgu));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
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
            this.btnEtiketGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSorgula = new DevExpress.XtraEditors.SimpleButton();
            this.dtTarih = new DevExpress.XtraEditors.DateEdit();
            this.bsLocalDepoSube = new System.Windows.Forms.BindingSource(this.components);
            this.dgcEtiketListesi = new DevExpress.XtraGrid.GridControl();
            this.dgvEtiketListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcDepoSubeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepoSubeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalDepoSube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEtiketListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtiketListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtBelgeNo);
            this.groupControl1.Controls.Add(this.dgcDepoSubeListesi);
            this.groupControl1.Controls.Add(this.btnEtiketGuncelle);
            this.groupControl1.Controls.Add(this.btnSorgula);
            this.groupControl1.Controls.Add(this.dtTarih);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(948, 197);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Şube / Depo Seçimi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(835, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Belge No";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(835, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Bildirim Tarihi";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(835, 87);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(100, 20);
            this.txtBelgeNo.TabIndex = 3;
            // 
            // dgcDepoSubeListesi
            // 
            this.dgcDepoSubeListesi.Location = new System.Drawing.Point(2, 23);
            this.dgcDepoSubeListesi.MainView = this.dgvDepoSubeListesi;
            this.dgcDepoSubeListesi.Name = "dgcDepoSubeListesi";
            this.dgcDepoSubeListesi.Size = new System.Drawing.Size(821, 169);
            this.dgcDepoSubeListesi.TabIndex = 2;
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
            this.dgvDepoSubeListesi.OptionsView.ShowGroupPanel = false;
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
            // 
            // btnEtiketGuncelle
            // 
            this.btnEtiketGuncelle.Location = new System.Drawing.Point(836, 146);
            this.btnEtiketGuncelle.Name = "btnEtiketGuncelle";
            this.btnEtiketGuncelle.Size = new System.Drawing.Size(99, 46);
            this.btnEtiketGuncelle.TabIndex = 1;
            this.btnEtiketGuncelle.Text = "Etiketleri Güncelle";
            this.btnEtiketGuncelle.Click += new System.EventHandler(this.btnEtiketGuncelle_Click);
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(835, 117);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(99, 23);
            this.btnSorgula.TabIndex = 1;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dtTarih
            // 
            this.dtTarih.EditValue = null;
            this.dtTarih.Location = new System.Drawing.Point(835, 42);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTarih.Size = new System.Drawing.Size(100, 20);
            this.dtTarih.TabIndex = 0;
            // 
            // dgcEtiketListesi
            // 
            this.dgcEtiketListesi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgcEtiketListesi.Location = new System.Drawing.Point(12, 215);
            this.dgcEtiketListesi.MainView = this.dgvEtiketListesi;
            this.dgcEtiketListesi.Name = "dgcEtiketListesi";
            this.dgcEtiketListesi.Size = new System.Drawing.Size(948, 310);
            this.dgcEtiketListesi.TabIndex = 1;
            this.dgcEtiketListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvEtiketListesi});
            // 
            // dgvEtiketListesi
            // 
            this.dgvEtiketListesi.GridControl = this.dgcEtiketListesi;
            this.dgvEtiketListesi.Name = "dgvEtiketListesi";
            this.dgvEtiketListesi.OptionsView.ShowGroupPanel = false;
            // 
            // frmEtiketSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 550);
            this.Controls.Add(this.dgcEtiketListesi);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEtiketSorgu";
            this.Text = "Künye Bildirim Sorgulama";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcDepoSubeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepoSubeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocalDepoSube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEtiketListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtiketListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSorgula;
        private DevExpress.XtraEditors.DateEdit dtTarih;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
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
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bsLocalDepoSube;
        private DevExpress.XtraGrid.GridControl dgcEtiketListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvEtiketListesi;
        private DevExpress.XtraEditors.SimpleButton btnEtiketGuncelle;
    }
}