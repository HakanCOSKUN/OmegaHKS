namespace OmegaHKS.Views.Aktarim
{
    partial class frmIrsaliyeAktarimlari
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIrsaliyeAktarimlari));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcIrsaliyeListesi = new DevExpress.XtraGrid.GridControl();
            this.gvIrsaliyeListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEVKDEPOAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALDEP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKARSIDEPOAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIRSNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDVTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCARKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUNYETARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPOID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUBEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKONTROL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chKunyeDahil = new DevExpress.XtraEditors.CheckEdit();
            this.btnIrsaliyeleriListele = new DevExpress.XtraEditors.SimpleButton();
            this.txtDateEditTarihB = new DevExpress.XtraEditors.DateEdit();
            this.txtDateEditTarihS = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBtnKarsiDepo = new DevExpress.XtraEditors.ButtonEdit();
            this.txtBtnSevkEdenDepo = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ucsBTNKayitIpal1 = new OmegaHKS.Views.UserControls.ucsBTNKayitIpal();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcIrsaliyeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIrsaliyeListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chKunyeDahil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEditTarihB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEditTarihB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEditTarihS.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEditTarihS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnKarsiDepo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnSevkEdenDepo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.gcIrsaliyeListesi);
            this.groupControl2.Location = new System.Drawing.Point(12, 103);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(836, 436);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "İrsaliye Listesi";
            // 
            // gcIrsaliyeListesi
            // 
            this.gcIrsaliyeListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcIrsaliyeListesi.Location = new System.Drawing.Point(2, 15);
            this.gcIrsaliyeListesi.MainView = this.gvIrsaliyeListesi;
            this.gcIrsaliyeListesi.Name = "gcIrsaliyeListesi";
            this.gcIrsaliyeListesi.Size = new System.Drawing.Size(832, 419);
            this.gcIrsaliyeListesi.TabIndex = 0;
            this.gcIrsaliyeListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIrsaliyeListesi});
            // 
            // gvIrsaliyeListesi
            // 
            this.gvIrsaliyeListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTARIH,
            this.colDEPNO,
            this.colSEVKDEPOAD,
            this.colALDEP,
            this.colKARSIDEPOAD,
            this.colTIP,
            this.colIRSNO,
            this.colBELGENO,
            this.colTUTAR,
            this.colKDVTUTAR,
            this.colCARKOD,
            this.colKUNYETARIH,
            this.colDEPOID,
            this.colSUBEID,
            this.colKONTROL});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleExpression1.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleExpression1.Appearance.Options.UseFont = true;
            formatConditionRuleExpression1.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression1.Expression = "[KONTROL] = 0";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gvIrsaliyeListesi.FormatRules.Add(gridFormatRule1);
            this.gvIrsaliyeListesi.GridControl = this.gcIrsaliyeListesi;
            this.gvIrsaliyeListesi.GroupPanelText = "Gruplamak istediğiniz kolonu buruya sürükleyip bırakın";
            this.gvIrsaliyeListesi.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KDVTUTAR", this.colKDVTUTAR, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", this.colTUTAR, "{0:n2}")});
            this.gvIrsaliyeListesi.Name = "gvIrsaliyeListesi";
            this.gvIrsaliyeListesi.OptionsView.ShowFooter = true;
            this.gvIrsaliyeListesi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvIrsaliyeListesi_KeyUp);
            this.gvIrsaliyeListesi.DoubleClick += new System.EventHandler(this.gvIrsaliyeListesi_DoubleClick);
            // 
            // colTARIH
            // 
            this.colTARIH.Caption = "Tarih";
            this.colTARIH.DisplayFormat.FormatString = "d";
            this.colTARIH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTARIH.FieldName = "TARIH";
            this.colTARIH.Name = "colTARIH";
            this.colTARIH.OptionsColumn.AllowEdit = false;
            this.colTARIH.OptionsColumn.AllowFocus = false;
            this.colTARIH.OptionsColumn.ReadOnly = true;
            this.colTARIH.Visible = true;
            this.colTARIH.VisibleIndex = 0;
            // 
            // colDEPNO
            // 
            this.colDEPNO.Caption = "Depo No";
            this.colDEPNO.FieldName = "DEPNO";
            this.colDEPNO.Name = "colDEPNO";
            this.colDEPNO.OptionsColumn.AllowEdit = false;
            this.colDEPNO.OptionsColumn.AllowFocus = false;
            this.colDEPNO.OptionsColumn.ReadOnly = true;
            // 
            // colSEVKDEPOAD
            // 
            this.colSEVKDEPOAD.Caption = "Sevk Depo / Şube";
            this.colSEVKDEPOAD.FieldName = "SEVKDEPOAD";
            this.colSEVKDEPOAD.Name = "colSEVKDEPOAD";
            this.colSEVKDEPOAD.OptionsColumn.AllowEdit = false;
            this.colSEVKDEPOAD.OptionsColumn.AllowFocus = false;
            this.colSEVKDEPOAD.OptionsColumn.ReadOnly = true;
            this.colSEVKDEPOAD.Visible = true;
            this.colSEVKDEPOAD.VisibleIndex = 1;
            // 
            // colALDEP
            // 
            this.colALDEP.Caption = "Kar.Dep.No";
            this.colALDEP.FieldName = "ALDEP";
            this.colALDEP.Name = "colALDEP";
            this.colALDEP.OptionsColumn.AllowEdit = false;
            this.colALDEP.OptionsColumn.AllowFocus = false;
            this.colALDEP.OptionsColumn.ReadOnly = true;
            // 
            // colKARSIDEPOAD
            // 
            this.colKARSIDEPOAD.Caption = "Karşı Depo / Şube ";
            this.colKARSIDEPOAD.FieldName = "KARSIDEPOAD";
            this.colKARSIDEPOAD.Name = "colKARSIDEPOAD";
            this.colKARSIDEPOAD.OptionsColumn.AllowEdit = false;
            this.colKARSIDEPOAD.OptionsColumn.AllowFocus = false;
            this.colKARSIDEPOAD.OptionsColumn.ReadOnly = true;
            this.colKARSIDEPOAD.Visible = true;
            this.colKARSIDEPOAD.VisibleIndex = 2;
            // 
            // colTIP
            // 
            this.colTIP.Caption = "Tip";
            this.colTIP.FieldName = "TIP";
            this.colTIP.Name = "colTIP";
            this.colTIP.OptionsColumn.AllowEdit = false;
            this.colTIP.OptionsColumn.AllowFocus = false;
            this.colTIP.OptionsColumn.ReadOnly = true;
            this.colTIP.Visible = true;
            this.colTIP.VisibleIndex = 3;
            // 
            // colIRSNO
            // 
            this.colIRSNO.Caption = "İrsaliye No";
            this.colIRSNO.FieldName = "IRSNO";
            this.colIRSNO.Name = "colIRSNO";
            this.colIRSNO.OptionsColumn.AllowEdit = false;
            this.colIRSNO.OptionsColumn.AllowFocus = false;
            this.colIRSNO.OptionsColumn.ReadOnly = true;
            this.colIRSNO.Visible = true;
            this.colIRSNO.VisibleIndex = 4;
            // 
            // colBELGENO
            // 
            this.colBELGENO.Caption = "Bel. No.";
            this.colBELGENO.FieldName = "BELGENO";
            this.colBELGENO.Name = "colBELGENO";
            this.colBELGENO.OptionsColumn.AllowEdit = false;
            this.colBELGENO.OptionsColumn.AllowFocus = false;
            this.colBELGENO.OptionsColumn.ReadOnly = true;
            this.colBELGENO.Visible = true;
            this.colBELGENO.VisibleIndex = 5;
            // 
            // colTUTAR
            // 
            this.colTUTAR.Caption = "Tutar";
            this.colTUTAR.DisplayFormat.FormatString = "n2";
            this.colTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTUTAR.FieldName = "TUTAR";
            this.colTUTAR.Name = "colTUTAR";
            this.colTUTAR.OptionsColumn.AllowEdit = false;
            this.colTUTAR.OptionsColumn.AllowFocus = false;
            this.colTUTAR.OptionsColumn.ReadOnly = true;
            this.colTUTAR.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", "{0:n2}")});
            this.colTUTAR.Visible = true;
            this.colTUTAR.VisibleIndex = 6;
            // 
            // colKDVTUTAR
            // 
            this.colKDVTUTAR.Caption = "Kdv Tutar";
            this.colKDVTUTAR.DisplayFormat.FormatString = "n2";
            this.colKDVTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKDVTUTAR.FieldName = "KDVTUTAR";
            this.colKDVTUTAR.Name = "colKDVTUTAR";
            this.colKDVTUTAR.OptionsColumn.AllowEdit = false;
            this.colKDVTUTAR.OptionsColumn.AllowFocus = false;
            this.colKDVTUTAR.OptionsColumn.ReadOnly = true;
            this.colKDVTUTAR.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KDVTUTAR", "{0:n2}")});
            this.colKDVTUTAR.Visible = true;
            this.colKDVTUTAR.VisibleIndex = 7;
            // 
            // colCARKOD
            // 
            this.colCARKOD.Caption = "Cari Kod";
            this.colCARKOD.FieldName = "CARKOD";
            this.colCARKOD.Name = "colCARKOD";
            this.colCARKOD.OptionsColumn.AllowEdit = false;
            this.colCARKOD.OptionsColumn.AllowFocus = false;
            this.colCARKOD.OptionsColumn.ReadOnly = true;
            // 
            // colKUNYETARIH
            // 
            this.colKUNYETARIH.Caption = "Kinye Tar.";
            this.colKUNYETARIH.FieldName = "KUNYETARIH";
            this.colKUNYETARIH.Name = "colKUNYETARIH";
            this.colKUNYETARIH.OptionsColumn.AllowEdit = false;
            this.colKUNYETARIH.OptionsColumn.AllowFocus = false;
            this.colKUNYETARIH.OptionsColumn.ReadOnly = true;
            this.colKUNYETARIH.Visible = true;
            this.colKUNYETARIH.VisibleIndex = 8;
            // 
            // colDEPOID
            // 
            this.colDEPOID.Caption = "DEPOID";
            this.colDEPOID.FieldName = "DEPOID";
            this.colDEPOID.Name = "colDEPOID";
            this.colDEPOID.OptionsColumn.AllowEdit = false;
            this.colDEPOID.OptionsColumn.AllowFocus = false;
            this.colDEPOID.OptionsColumn.ReadOnly = true;
            // 
            // colSUBEID
            // 
            this.colSUBEID.Caption = "SUBEID";
            this.colSUBEID.FieldName = "SUBEID";
            this.colSUBEID.Name = "colSUBEID";
            this.colSUBEID.OptionsColumn.AllowEdit = false;
            this.colSUBEID.OptionsColumn.AllowFocus = false;
            this.colSUBEID.OptionsColumn.ReadOnly = true;
            // 
            // colKONTROL
            // 
            this.colKONTROL.Caption = "KONTROL";
            this.colKONTROL.FieldName = "KONTROL";
            this.colKONTROL.Name = "colKONTROL";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.chKunyeDahil);
            this.groupControl1.Controls.Add(this.btnIrsaliyeleriListele);
            this.groupControl1.Controls.Add(this.txtDateEditTarihB);
            this.groupControl1.Controls.Add(this.txtDateEditTarihS);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtBtnKarsiDepo);
            this.groupControl1.Controls.Add(this.txtBtnSevkEdenDepo);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 15);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(836, 82);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "İrsaliye Seçim İşlemleri";
            // 
            // chKunyeDahil
            // 
            this.chKunyeDahil.Location = new System.Drawing.Point(574, 49);
            this.chKunyeDahil.Name = "chKunyeDahil";
            this.chKunyeDahil.Properties.Caption = "Künye Alınanlar Dahil";
            this.chKunyeDahil.Size = new System.Drawing.Size(126, 19);
            this.chKunyeDahil.TabIndex = 3;
            // 
            // btnIrsaliyeleriListele
            // 
            this.btnIrsaliyeleriListele.Image = ((System.Drawing.Image)(resources.GetObject("btnIrsaliyeleriListele.Image")));
            this.btnIrsaliyeleriListele.Location = new System.Drawing.Point(706, 47);
            this.btnIrsaliyeleriListele.Name = "btnIrsaliyeleriListele";
            this.btnIrsaliyeleriListele.Size = new System.Drawing.Size(116, 23);
            this.btnIrsaliyeleriListele.TabIndex = 4;
            this.btnIrsaliyeleriListele.Text = "İrsaliyeleri Listele";
            this.btnIrsaliyeleriListele.Click += new System.EventHandler(this.btnIrsaliyeleriListele_Click);
            // 
            // txtDateEditTarihB
            // 
            this.txtDateEditTarihB.EditValue = null;
            this.txtDateEditTarihB.Location = new System.Drawing.Point(126, 49);
            this.txtDateEditTarihB.Name = "txtDateEditTarihB";
            this.txtDateEditTarihB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateEditTarihB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateEditTarihB.Size = new System.Drawing.Size(147, 20);
            this.txtDateEditTarihB.TabIndex = 1;
            // 
            // txtDateEditTarihS
            // 
            this.txtDateEditTarihS.EditValue = null;
            this.txtDateEditTarihS.Location = new System.Drawing.Point(421, 49);
            this.txtDateEditTarihS.Name = "txtDateEditTarihS";
            this.txtDateEditTarihS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateEditTarihS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDateEditTarihS.Size = new System.Drawing.Size(147, 20);
            this.txtDateEditTarihS.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(436, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Karşı Depo / Şube";
            // 
            // txtBtnKarsiDepo
            // 
            this.txtBtnKarsiDepo.Location = new System.Drawing.Point(527, 23);
            this.txtBtnKarsiDepo.Name = "txtBtnKarsiDepo";
            this.txtBtnKarsiDepo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F9), serializableAppearanceObject1, "Karşı Depo / Şube Bul", null, null, true)});
            this.txtBtnKarsiDepo.Size = new System.Drawing.Size(295, 20);
            this.txtBtnKarsiDepo.TabIndex = 1;
            this.txtBtnKarsiDepo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBtnKarsiDepo_ButtonClick);
            // 
            // txtBtnSevkEdenDepo
            // 
            this.txtBtnSevkEdenDepo.Location = new System.Drawing.Point(126, 23);
            this.txtBtnSevkEdenDepo.Name = "txtBtnSevkEdenDepo";
            this.txtBtnSevkEdenDepo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F9), serializableAppearanceObject2, "Sev Eden Depo / Şube Bul", null, null, true)});
            this.txtBtnSevkEdenDepo.Size = new System.Drawing.Size(295, 20);
            this.txtBtnSevkEdenDepo.TabIndex = 0;
            this.txtBtnSevkEdenDepo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBtnSevkEdenDepo_ButtonClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Sevk Tarih Başlangıcı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(308, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Sevk Tarih Başlangıcı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sev Eden Depo / Şube";
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
            this.ucsBTNKayitIpal1.KaydetText = "&Bildirim";
            this.ucsBTNKayitIpal1.KaydetVisible = true;
            this.ucsBTNKayitIpal1.Location = new System.Drawing.Point(0, 547);
            this.ucsBTNKayitIpal1.Name = "ucsBTNKayitIpal1";
            this.ucsBTNKayitIpal1.Size = new System.Drawing.Size(860, 52);
            this.ucsBTNKayitIpal1.TabIndex = 4;
            this.ucsBTNKayitIpal1.TemizleImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.TemizleImage")));
            this.ucsBTNKayitIpal1.TemizleText = "&Temizle";
            this.ucsBTNKayitIpal1.TemizleVisible = false;
            this.ucsBTNKayitIpal1.ClickKaydet += new System.EventHandler(this.ucsBTNKayitIpal1_ClickKaydet);
            this.ucsBTNKayitIpal1.ClickIptal += new System.EventHandler(this.ucsBTNKayitIpal1_ClickIptal);
            // 
            // frmIrsaliyeAktarimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 599);
            this.Controls.Add(this.ucsBTNKayitIpal1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIrsaliyeAktarimlari";
            this.Text = "Hal Kayıt Sistemine İrsaliye Bildirimi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcIrsaliyeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvIrsaliyeListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chKunyeDahil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEditTarihB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEditTarihB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEditTarihS.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEditTarihS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnKarsiDepo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnSevkEdenDepo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcIrsaliyeListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIrsaliyeListesi;
        private DevExpress.XtraGrid.Columns.GridColumn colTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colSEVKDEPOAD;
        private DevExpress.XtraGrid.Columns.GridColumn colALDEP;
        private DevExpress.XtraGrid.Columns.GridColumn colKARSIDEPOAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTIP;
        private DevExpress.XtraGrid.Columns.GridColumn colIRSNO;
        private DevExpress.XtraGrid.Columns.GridColumn colBELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn colTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colKDVTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colCARKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colKUNYETARIH;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPOID;
        private DevExpress.XtraGrid.Columns.GridColumn colSUBEID;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chKunyeDahil;
        private DevExpress.XtraEditors.SimpleButton btnIrsaliyeleriListele;
        private DevExpress.XtraEditors.DateEdit txtDateEditTarihB;
        private DevExpress.XtraEditors.DateEdit txtDateEditTarihS;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit txtBtnKarsiDepo;
        private DevExpress.XtraEditors.ButtonEdit txtBtnSevkEdenDepo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UserControls.ucsBTNKayitIpal ucsBTNKayitIpal1;
        private DevExpress.XtraGrid.Columns.GridColumn colKONTROL;
    }
}