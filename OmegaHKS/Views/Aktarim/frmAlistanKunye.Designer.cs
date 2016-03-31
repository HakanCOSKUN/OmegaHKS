namespace OmegaHKS.Views.Aktarim
{
    partial class frmAlistanKunye
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlistanKunye));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gcIrsaliyeListesi = new DevExpress.XtraGrid.GridControl();
            this.gvIrsaliyeListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPOAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIRSNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCARKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCARIUNVAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDVTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKUNYETARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKONTROL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHKSID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHKSILID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHKSILCEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHKSBELDEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERGINO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chKunyeDahil = new DevExpress.XtraEditors.CheckEdit();
            this.btnIrsaliyeleriListele = new DevExpress.XtraEditors.SimpleButton();
            this.txtDateEditTarihB = new DevExpress.XtraEditors.DateEdit();
            this.txtDateEditTarihS = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBtnCariFirma = new DevExpress.XtraEditors.ButtonEdit();
            this.txtBtnIrsaliyeDeposu = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ucsBTNKayitIpal1 = new OmegaHKS.Views.UserControls.ucsBTNKayitIpal();
            this.colPLAKANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnCariFirma.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnIrsaliyeDeposu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.gcIrsaliyeListesi);
            this.groupControl2.Location = new System.Drawing.Point(11, 128);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(879, 413);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "İrsaliye Listesi";
            // 
            // gcIrsaliyeListesi
            // 
            this.gcIrsaliyeListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcIrsaliyeListesi.Location = new System.Drawing.Point(2, 20);
            this.gcIrsaliyeListesi.MainView = this.gvIrsaliyeListesi;
            this.gcIrsaliyeListesi.Name = "gcIrsaliyeListesi";
            this.gcIrsaliyeListesi.Size = new System.Drawing.Size(875, 391);
            this.gcIrsaliyeListesi.TabIndex = 0;
            this.gcIrsaliyeListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvIrsaliyeListesi});
            // 
            // gvIrsaliyeListesi
            // 
            this.gvIrsaliyeListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTARIH,
            this.colDEPNO,
            this.colDEPOAD,
            this.colTIP,
            this.colIRSNO,
            this.colBELGENO,
            this.colCARKOD,
            this.colCARIUNVAN,
            this.colTUTAR,
            this.colKDVTUTAR,
            this.colPLAKANO,
            this.colKUNYETARIH,
            this.colKONTROL,
            this.colHKSID,
            this.colHKSILID,
            this.colHKSILCEID,
            this.colHKSBELDEID,
            this.colVERGINO});
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format0";
            formatConditionRuleExpression2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            formatConditionRuleExpression2.Appearance.ForeColor = System.Drawing.Color.Red;
            formatConditionRuleExpression2.Appearance.Options.UseFont = true;
            formatConditionRuleExpression2.Appearance.Options.UseForeColor = true;
            formatConditionRuleExpression2.Expression = "[KONTROL] = 0";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.gvIrsaliyeListesi.FormatRules.Add(gridFormatRule2);
            this.gvIrsaliyeListesi.GridControl = this.gcIrsaliyeListesi;
            this.gvIrsaliyeListesi.GroupPanelText = "Gruplamak istediğiniz kolonu buruya sürükleyip bırakın";
            this.gvIrsaliyeListesi.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "KDVTUTAR", this.colKDVTUTAR, "{0:n2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TUTAR", this.colTUTAR, "{0:n2}")});
            this.gvIrsaliyeListesi.Name = "gvIrsaliyeListesi";
            this.gvIrsaliyeListesi.OptionsView.ShowFooter = true;
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
            // colDEPOAD
            // 
            this.colDEPOAD.Caption = "Depo / Şube";
            this.colDEPOAD.FieldName = "DEPOAD";
            this.colDEPOAD.Name = "colDEPOAD";
            this.colDEPOAD.OptionsColumn.AllowEdit = false;
            this.colDEPOAD.OptionsColumn.AllowFocus = false;
            this.colDEPOAD.OptionsColumn.ReadOnly = true;
            this.colDEPOAD.Visible = true;
            this.colDEPOAD.VisibleIndex = 1;
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
            this.colTIP.VisibleIndex = 2;
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
            this.colIRSNO.VisibleIndex = 3;
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
            this.colBELGENO.VisibleIndex = 4;
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
            // colCARIUNVAN
            // 
            this.colCARIUNVAN.Caption = "Firma Acıklama";
            this.colCARIUNVAN.FieldName = "CARIUNVAN";
            this.colCARIUNVAN.Name = "colCARIUNVAN";
            this.colCARIUNVAN.OptionsColumn.AllowEdit = false;
            this.colCARIUNVAN.OptionsColumn.AllowFocus = false;
            this.colCARIUNVAN.OptionsColumn.ReadOnly = true;
            this.colCARIUNVAN.Visible = true;
            this.colCARIUNVAN.VisibleIndex = 5;
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
            // colKUNYETARIH
            // 
            this.colKUNYETARIH.Caption = "Kinye Tar.";
            this.colKUNYETARIH.FieldName = "KUNYETARIH";
            this.colKUNYETARIH.Name = "colKUNYETARIH";
            this.colKUNYETARIH.OptionsColumn.AllowEdit = false;
            this.colKUNYETARIH.OptionsColumn.AllowFocus = false;
            this.colKUNYETARIH.OptionsColumn.ReadOnly = true;
            this.colKUNYETARIH.Visible = true;
            this.colKUNYETARIH.VisibleIndex = 9;
            // 
            // colKONTROL
            // 
            this.colKONTROL.Caption = "KONTROL";
            this.colKONTROL.FieldName = "KONTROL";
            this.colKONTROL.Name = "colKONTROL";
            this.colKONTROL.OptionsColumn.AllowEdit = false;
            this.colKONTROL.OptionsColumn.AllowFocus = false;
            this.colKONTROL.OptionsColumn.ReadOnly = true;
            // 
            // colHKSID
            // 
            this.colHKSID.Caption = "HKSID";
            this.colHKSID.FieldName = "HKSID";
            this.colHKSID.Name = "colHKSID";
            this.colHKSID.OptionsColumn.AllowEdit = false;
            this.colHKSID.OptionsColumn.AllowFocus = false;
            this.colHKSID.OptionsColumn.ReadOnly = true;
            // 
            // colHKSILID
            // 
            this.colHKSILID.Caption = "HKSILID";
            this.colHKSILID.FieldName = "HKSILID";
            this.colHKSILID.Name = "colHKSILID";
            this.colHKSILID.OptionsColumn.AllowEdit = false;
            this.colHKSILID.OptionsColumn.AllowFocus = false;
            this.colHKSILID.OptionsColumn.ReadOnly = true;
            // 
            // colHKSILCEID
            // 
            this.colHKSILCEID.Caption = "HKSILCEID";
            this.colHKSILCEID.FieldName = "HKSILCEID";
            this.colHKSILCEID.Name = "colHKSILCEID";
            this.colHKSILCEID.OptionsColumn.AllowEdit = false;
            this.colHKSILCEID.OptionsColumn.AllowFocus = false;
            this.colHKSILCEID.OptionsColumn.ReadOnly = true;
            // 
            // colHKSBELDEID
            // 
            this.colHKSBELDEID.Caption = "HKSBELDEID";
            this.colHKSBELDEID.FieldName = "HKSBELDEID";
            this.colHKSBELDEID.Name = "colHKSBELDEID";
            this.colHKSBELDEID.OptionsColumn.AllowEdit = false;
            this.colHKSBELDEID.OptionsColumn.AllowFocus = false;
            this.colHKSBELDEID.OptionsColumn.ReadOnly = true;
            // 
            // colVERGINO
            // 
            this.colVERGINO.Caption = "VERGINO";
            this.colVERGINO.FieldName = "VERGINO";
            this.colVERGINO.Name = "colVERGINO";
            this.colVERGINO.OptionsColumn.AllowEdit = false;
            this.colVERGINO.OptionsColumn.AllowFocus = false;
            this.colVERGINO.OptionsColumn.ReadOnly = true;
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
            this.groupControl1.Controls.Add(this.txtBtnCariFirma);
            this.groupControl1.Controls.Add(this.txtBtnIrsaliyeDeposu);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(11, 42);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(879, 82);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "İrsaliye Seçim İşlemleri";
            // 
            // chKunyeDahil
            // 
            this.chKunyeDahil.Location = new System.Drawing.Point(590, 53);
            this.chKunyeDahil.Name = "chKunyeDahil";
            this.chKunyeDahil.Properties.Caption = "Künye Alınanlar Dahil";
            this.chKunyeDahil.Size = new System.Drawing.Size(126, 19);
            this.chKunyeDahil.TabIndex = 5;
            // 
            // btnIrsaliyeleriListele
            // 
            this.btnIrsaliyeleriListele.Image = ((System.Drawing.Image)(resources.GetObject("btnIrsaliyeleriListele.Image")));
            this.btnIrsaliyeleriListele.Location = new System.Drawing.Point(732, 51);
            this.btnIrsaliyeleriListele.Name = "btnIrsaliyeleriListele";
            this.btnIrsaliyeleriListele.Size = new System.Drawing.Size(119, 23);
            this.btnIrsaliyeleriListele.TabIndex = 4;
            this.btnIrsaliyeleriListele.Text = "İrsaliyeleri Listele";
            this.btnIrsaliyeleriListele.Click += new System.EventHandler(this.btnIrsaliyeleriListele_Click);
            // 
            // txtDateEditTarihB
            // 
            this.txtDateEditTarihB.EditValue = null;
            this.txtDateEditTarihB.Location = new System.Drawing.Point(126, 53);
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
            this.txtDateEditTarihS.Location = new System.Drawing.Point(424, 54);
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
            this.labelControl2.Location = new System.Drawing.Point(356, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Sevk Eden Firma";
            // 
            // txtBtnCariFirma
            // 
            this.txtBtnCariFirma.Location = new System.Drawing.Point(441, 27);
            this.txtBtnCariFirma.Name = "txtBtnCariFirma";
            this.txtBtnCariFirma.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F9), serializableAppearanceObject1, "Karşı Depo / Şube Bul", null, null, true)});
            this.txtBtnCariFirma.Size = new System.Drawing.Size(410, 20);
            this.txtBtnCariFirma.TabIndex = 1;
            this.txtBtnCariFirma.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBtnCariFirma_ButtonClick);
            // 
            // txtBtnIrsaliyeDeposu
            // 
            this.txtBtnIrsaliyeDeposu.Location = new System.Drawing.Point(126, 27);
            this.txtBtnIrsaliyeDeposu.Name = "txtBtnIrsaliyeDeposu";
            this.txtBtnIrsaliyeDeposu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F9), serializableAppearanceObject2, "Sev Eden Depo / Şube Bul", null, null, true)});
            this.txtBtnIrsaliyeDeposu.Size = new System.Drawing.Size(209, 20);
            this.txtBtnIrsaliyeDeposu.TabIndex = 0;
            this.txtBtnIrsaliyeDeposu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBtnIrsaliyeDeposu_ButtonClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 56);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Sevk Tarih Başlangıcı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(319, 57);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Sevk Tarih Başlangıcı";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "İrsaliye Deposu";
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
            this.ucsBTNKayitIpal1.Location = new System.Drawing.Point(0, 561);
            this.ucsBTNKayitIpal1.Name = "ucsBTNKayitIpal1";
            this.ucsBTNKayitIpal1.Size = new System.Drawing.Size(902, 52);
            this.ucsBTNKayitIpal1.TabIndex = 6;
            this.ucsBTNKayitIpal1.TemizleImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.TemizleImage")));
            this.ucsBTNKayitIpal1.TemizleText = "&Temizle";
            this.ucsBTNKayitIpal1.TemizleVisible = false;
            this.ucsBTNKayitIpal1.ClickKaydet += new System.EventHandler(this.ucsBTNKayitIpal1_ClickKaydet);
            this.ucsBTNKayitIpal1.ClickIptal += new System.EventHandler(this.ucsBTNKayitIpal1_ClickIptal);
            // 
            // colPLAKANO
            // 
            this.colPLAKANO.Caption = "Plaka No";
            this.colPLAKANO.FieldName = "PLAKANO";
            this.colPLAKANO.Name = "colPLAKANO";
            this.colPLAKANO.Visible = true;
            this.colPLAKANO.VisibleIndex = 8;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(902, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 613);
            this.barDockControlBottom.Size = new System.Drawing.Size(902, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 593);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(902, 20);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 593);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // frmAlistanKunye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 613);
            this.Controls.Add(this.ucsBTNKayitIpal1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmAlistanKunye";
            this.Text = "frmAlistanKunye";
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
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnCariFirma.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnIrsaliyeDeposu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gcIrsaliyeListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvIrsaliyeListesi;
        private DevExpress.XtraGrid.Columns.GridColumn colTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPOAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTIP;
        private DevExpress.XtraGrid.Columns.GridColumn colIRSNO;
        private DevExpress.XtraGrid.Columns.GridColumn colBELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn colTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colKDVTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colCARKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colKUNYETARIH;
        private DevExpress.XtraGrid.Columns.GridColumn colKONTROL;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnIrsaliyeleriListele;
        private DevExpress.XtraEditors.DateEdit txtDateEditTarihB;
        private DevExpress.XtraEditors.DateEdit txtDateEditTarihS;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit txtBtnCariFirma;
        private DevExpress.XtraEditors.ButtonEdit txtBtnIrsaliyeDeposu;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colCARIUNVAN;
        private DevExpress.XtraGrid.Columns.GridColumn colHKSID;
        private DevExpress.XtraGrid.Columns.GridColumn colHKSILID;
        private DevExpress.XtraGrid.Columns.GridColumn colHKSILCEID;
        private DevExpress.XtraGrid.Columns.GridColumn colHKSBELDEID;
        private DevExpress.XtraGrid.Columns.GridColumn colVERGINO;
        private UserControls.ucsBTNKayitIpal ucsBTNKayitIpal1;
        private DevExpress.XtraEditors.CheckEdit chKunyeDahil;
        private DevExpress.XtraGrid.Columns.GridColumn colPLAKANO;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}