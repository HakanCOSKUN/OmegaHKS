namespace OmegaHKS.Views.Aktarim
{
    partial class frmIrsaliyesizBildirim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIrsaliyesizBildirim));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barDEIslemTarihB = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barDEIslemTarihS = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barBTNSorgula = new DevExpress.XtraBars.BarButtonItem();
            this.barLueKarsiSube = new DevExpress.XtraBars.BarEditItem();
            this.rsiSevkEdilecekSube = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.barBtnBildirimYap = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barEIKarsiSube = new DevExpress.XtraBars.BarEditItem();
            this.rsiSevkEdilecekSubessss = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dgcReferansListesi = new DevExpress.XtraGrid.GridControl();
            this.bildirimSorguDTOLocalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvReferansListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSECIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnalizStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeTipi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBildirimTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBildirimTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBildirimciTcKimlikVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGidecekIsyeriId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGidecekYerTuruId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKunyeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinKodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinCinsKodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinCinsi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKalanMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEVKMIKTARI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktarBirimiAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinSahibiTcKimlikVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinSatisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMalinTuruKodNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktarBirimId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRusumMiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUniqueId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUreticiTcKimlikVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiSevkEdilecekSube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiSevkEdilecekSubessss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcReferansListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildirimSorguDTOLocalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferansListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEIKarsiSube,
            this.barDEIslemTarihB,
            this.barBTNSorgula,
            this.barLueKarsiSube,
            this.barBtnBildirimYap,
            this.barDEIslemTarihS});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rsiSevkEdilecekSubessss,
            this.repositoryItemDateEdit1,
            this.rsiSevkEdilecekSube,
            this.repositoryItemDateEdit2});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barDEIslemTarihB, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barDEIslemTarihS, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBTNSorgula, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barLueKarsiSube, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnBildirimYap, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barDEIslemTarihB
            // 
            this.barDEIslemTarihB.Caption = "İlk Tarih";
            this.barDEIslemTarihB.Edit = this.repositoryItemDateEdit1;
            this.barDEIslemTarihB.EditWidth = 200;
            this.barDEIslemTarihB.Glyph = ((System.Drawing.Image)(resources.GetObject("barDEIslemTarihB.Glyph")));
            this.barDEIslemTarihB.Id = 1;
            this.barDEIslemTarihB.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barDEIslemTarihB.LargeGlyph")));
            this.barDEIslemTarihB.Name = "barDEIslemTarihB";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // barDEIslemTarihS
            // 
            this.barDEIslemTarihS.Caption = "Son Tarih";
            this.barDEIslemTarihS.Edit = this.repositoryItemDateEdit2;
            this.barDEIslemTarihS.EditWidth = 200;
            this.barDEIslemTarihS.Glyph = ((System.Drawing.Image)(resources.GetObject("barDEIslemTarihS.Glyph")));
            this.barDEIslemTarihS.Id = 6;
            this.barDEIslemTarihS.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barDEIslemTarihS.LargeGlyph")));
            this.barDEIslemTarihS.Name = "barDEIslemTarihS";
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // barBTNSorgula
            // 
            this.barBTNSorgula.Caption = "Künye Sorgula";
            this.barBTNSorgula.Glyph = ((System.Drawing.Image)(resources.GetObject("barBTNSorgula.Glyph")));
            this.barBTNSorgula.Id = 2;
            this.barBTNSorgula.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBTNSorgula.LargeGlyph")));
            this.barBTNSorgula.Name = "barBTNSorgula";
            this.barBTNSorgula.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBTNSorgula_ItemClick);
            // 
            // barLueKarsiSube
            // 
            this.barLueKarsiSube.Caption = "Sevk Edilecek Şube";
            this.barLueKarsiSube.Edit = this.rsiSevkEdilecekSube;
            this.barLueKarsiSube.EditWidth = 250;
            this.barLueKarsiSube.Glyph = ((System.Drawing.Image)(resources.GetObject("barLueKarsiSube.Glyph")));
            this.barLueKarsiSube.Id = 4;
            this.barLueKarsiSube.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barLueKarsiSube.LargeGlyph")));
            this.barLueKarsiSube.Name = "barLueKarsiSube";
            this.barLueKarsiSube.EditValueChanged += new System.EventHandler(this.barLueKarsiSube_EditValueChanged);
            // 
            // rsiSevkEdilecekSube
            // 
            this.rsiSevkEdilecekSube.AutoHeight = false;
            this.rsiSevkEdilecekSube.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rsiSevkEdilecekSube.Name = "rsiSevkEdilecekSube";
            this.rsiSevkEdilecekSube.NullText = "Şube / Depo Seciniz ";
            // 
            // barBtnBildirimYap
            // 
            this.barBtnBildirimYap.Caption = "Bildirim Yap";
            this.barBtnBildirimYap.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnBildirimYap.Glyph")));
            this.barBtnBildirimYap.Id = 5;
            this.barBtnBildirimYap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnBildirimYap.LargeGlyph")));
            this.barBtnBildirimYap.Name = "barBtnBildirimYap";
            this.barBtnBildirimYap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBildirimYap_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(973, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 540);
            this.barDockControlBottom.Size = new System.Drawing.Size(973, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 516);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(973, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 516);
            // 
            // barEIKarsiSube
            // 
            this.barEIKarsiSube.Caption = "Sev Edilecek Şube";
            this.barEIKarsiSube.Edit = this.rsiSevkEdilecekSubessss;
            this.barEIKarsiSube.EditValue = ((short)(0));
            this.barEIKarsiSube.EditWidth = 250;
            this.barEIKarsiSube.Glyph = ((System.Drawing.Image)(resources.GetObject("barEIKarsiSube.Glyph")));
            this.barEIKarsiSube.Id = 0;
            this.barEIKarsiSube.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barEIKarsiSube.LargeGlyph")));
            this.barEIKarsiSube.Name = "barEIKarsiSube";
            this.barEIKarsiSube.Tag = ((short)(0));
            // 
            // rsiSevkEdilecekSubessss
            // 
            this.rsiSevkEdilecekSubessss.AutoHeight = false;
            this.rsiSevkEdilecekSubessss.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rsiSevkEdilecekSubessss.DisplayMember = "SubeAdi";
            this.rsiSevkEdilecekSubessss.Name = "rsiSevkEdilecekSubessss";
            this.rsiSevkEdilecekSubessss.NullText = "0";
            this.rsiSevkEdilecekSubessss.Tag = ((short)(0));
            this.rsiSevkEdilecekSubessss.ValueMember = "Id";
            // 
            // dgcReferansListesi
            // 
            this.dgcReferansListesi.DataSource = this.bildirimSorguDTOLocalBindingSource;
            this.dgcReferansListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgcReferansListesi.Location = new System.Drawing.Point(0, 24);
            this.dgcReferansListesi.MainView = this.dgvReferansListesi;
            this.dgcReferansListesi.MenuManager = this.barManager1;
            this.dgcReferansListesi.Name = "dgcReferansListesi";
            this.dgcReferansListesi.Size = new System.Drawing.Size(973, 516);
            this.dgcReferansListesi.TabIndex = 4;
            this.dgcReferansListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvReferansListesi});
            // 
            // bildirimSorguDTOLocalBindingSource
            // 
            this.bildirimSorguDTOLocalBindingSource.DataSource = typeof(OmegaHKS.Models.BildirimSorguDTOLocal);
            // 
            // dgvReferansListesi
            // 
            this.dgvReferansListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSECIM,
            this.colAnalizStatus,
            this.colBelgeNo,
            this.colBelgeTipi,
            this.colBildirimTarihi,
            this.colBildirimTuru,
            this.colBildirimciTcKimlikVergiNo,
            this.colGidecekIsyeriId,
            this.colGidecekYerTuruId,
            this.colKunyeNo,
            this.colMalinKodNo,
            this.colMalinAdi,
            this.colMalinCinsKodNo,
            this.colMalinCinsi,
            this.colMalinMiktari,
            this.colKalanMiktar,
            this.colSEVKMIKTARI,
            this.colMiktarBirimiAd,
            this.colMalinSahibiTcKimlikVergiNo,
            this.colMalinSatisFiyati,
            this.colMalinTuru,
            this.colMalinTuruKodNo,
            this.colMiktarBirimId,
            this.colRusumMiktari,
            this.colUniqueId,
            this.colUreticiTcKimlikVergiNo});
            this.dgvReferansListesi.GridControl = this.dgcReferansListesi;
            this.dgvReferansListesi.Name = "dgvReferansListesi";
            this.dgvReferansListesi.OptionsView.EnableAppearanceOddRow = true;
            this.dgvReferansListesi.OptionsView.ShowGroupPanel = false;
            // 
            // colSECIM
            // 
            this.colSECIM.Caption = "Seçim";
            this.colSECIM.FieldName = "SECIM";
            this.colSECIM.Name = "colSECIM";
            // 
            // colAnalizStatus
            // 
            this.colAnalizStatus.FieldName = "AnalizStatus";
            this.colAnalizStatus.Name = "colAnalizStatus";
            this.colAnalizStatus.OptionsColumn.AllowEdit = false;
            this.colAnalizStatus.OptionsColumn.AllowFocus = false;
            this.colAnalizStatus.OptionsColumn.ReadOnly = true;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.OptionsColumn.AllowFocus = false;
            this.colBelgeNo.OptionsColumn.ReadOnly = true;
            // 
            // colBelgeTipi
            // 
            this.colBelgeTipi.FieldName = "BelgeTipi";
            this.colBelgeTipi.Name = "colBelgeTipi";
            this.colBelgeTipi.OptionsColumn.AllowEdit = false;
            this.colBelgeTipi.OptionsColumn.AllowFocus = false;
            this.colBelgeTipi.OptionsColumn.ReadOnly = true;
            // 
            // colBildirimTarihi
            // 
            this.colBildirimTarihi.FieldName = "BildirimTarihi";
            this.colBildirimTarihi.Name = "colBildirimTarihi";
            this.colBildirimTarihi.OptionsColumn.AllowEdit = false;
            this.colBildirimTarihi.OptionsColumn.AllowFocus = false;
            this.colBildirimTarihi.OptionsColumn.ReadOnly = true;
            this.colBildirimTarihi.Visible = true;
            this.colBildirimTarihi.VisibleIndex = 0;
            // 
            // colBildirimTuru
            // 
            this.colBildirimTuru.FieldName = "BildirimTuru";
            this.colBildirimTuru.Name = "colBildirimTuru";
            this.colBildirimTuru.OptionsColumn.AllowEdit = false;
            this.colBildirimTuru.OptionsColumn.AllowFocus = false;
            this.colBildirimTuru.OptionsColumn.ReadOnly = true;
            this.colBildirimTuru.Visible = true;
            this.colBildirimTuru.VisibleIndex = 1;
            // 
            // colBildirimciTcKimlikVergiNo
            // 
            this.colBildirimciTcKimlikVergiNo.FieldName = "BildirimciTcKimlikVergiNo";
            this.colBildirimciTcKimlikVergiNo.Name = "colBildirimciTcKimlikVergiNo";
            this.colBildirimciTcKimlikVergiNo.OptionsColumn.AllowEdit = false;
            this.colBildirimciTcKimlikVergiNo.OptionsColumn.AllowFocus = false;
            this.colBildirimciTcKimlikVergiNo.OptionsColumn.ReadOnly = true;
            // 
            // colGidecekIsyeriId
            // 
            this.colGidecekIsyeriId.FieldName = "GidecekIsyeriId";
            this.colGidecekIsyeriId.Name = "colGidecekIsyeriId";
            this.colGidecekIsyeriId.OptionsColumn.AllowEdit = false;
            this.colGidecekIsyeriId.OptionsColumn.AllowFocus = false;
            this.colGidecekIsyeriId.OptionsColumn.ReadOnly = true;
            this.colGidecekIsyeriId.Visible = true;
            this.colGidecekIsyeriId.VisibleIndex = 2;
            // 
            // colGidecekYerTuruId
            // 
            this.colGidecekYerTuruId.FieldName = "GidecekYerTuruId";
            this.colGidecekYerTuruId.Name = "colGidecekYerTuruId";
            this.colGidecekYerTuruId.OptionsColumn.AllowEdit = false;
            this.colGidecekYerTuruId.OptionsColumn.AllowFocus = false;
            this.colGidecekYerTuruId.OptionsColumn.ReadOnly = true;
            this.colGidecekYerTuruId.Visible = true;
            this.colGidecekYerTuruId.VisibleIndex = 3;
            // 
            // colKunyeNo
            // 
            this.colKunyeNo.FieldName = "KunyeNo";
            this.colKunyeNo.Name = "colKunyeNo";
            this.colKunyeNo.OptionsColumn.AllowEdit = false;
            this.colKunyeNo.OptionsColumn.AllowFocus = false;
            this.colKunyeNo.OptionsColumn.ReadOnly = true;
            this.colKunyeNo.Visible = true;
            this.colKunyeNo.VisibleIndex = 4;
            // 
            // colMalinKodNo
            // 
            this.colMalinKodNo.FieldName = "MalinKodNo";
            this.colMalinKodNo.Name = "colMalinKodNo";
            this.colMalinKodNo.OptionsColumn.AllowEdit = false;
            this.colMalinKodNo.OptionsColumn.AllowFocus = false;
            this.colMalinKodNo.OptionsColumn.ReadOnly = true;
            this.colMalinKodNo.Visible = true;
            this.colMalinKodNo.VisibleIndex = 5;
            // 
            // colMalinAdi
            // 
            this.colMalinAdi.FieldName = "MalinAdi";
            this.colMalinAdi.Name = "colMalinAdi";
            this.colMalinAdi.OptionsColumn.AllowEdit = false;
            this.colMalinAdi.OptionsColumn.AllowFocus = false;
            this.colMalinAdi.OptionsColumn.ReadOnly = true;
            this.colMalinAdi.Visible = true;
            this.colMalinAdi.VisibleIndex = 6;
            // 
            // colMalinCinsKodNo
            // 
            this.colMalinCinsKodNo.FieldName = "MalinCinsKodNo";
            this.colMalinCinsKodNo.Name = "colMalinCinsKodNo";
            this.colMalinCinsKodNo.OptionsColumn.AllowEdit = false;
            this.colMalinCinsKodNo.OptionsColumn.AllowFocus = false;
            this.colMalinCinsKodNo.OptionsColumn.ReadOnly = true;
            this.colMalinCinsKodNo.Visible = true;
            this.colMalinCinsKodNo.VisibleIndex = 7;
            // 
            // colMalinCinsi
            // 
            this.colMalinCinsi.FieldName = "MalinCinsi";
            this.colMalinCinsi.Name = "colMalinCinsi";
            this.colMalinCinsi.OptionsColumn.AllowEdit = false;
            this.colMalinCinsi.OptionsColumn.AllowFocus = false;
            this.colMalinCinsi.OptionsColumn.ReadOnly = true;
            this.colMalinCinsi.Visible = true;
            this.colMalinCinsi.VisibleIndex = 8;
            // 
            // colMalinMiktari
            // 
            this.colMalinMiktari.FieldName = "MalinMiktari";
            this.colMalinMiktari.Name = "colMalinMiktari";
            this.colMalinMiktari.OptionsColumn.AllowEdit = false;
            this.colMalinMiktari.OptionsColumn.AllowFocus = false;
            this.colMalinMiktari.OptionsColumn.ReadOnly = true;
            this.colMalinMiktari.Visible = true;
            this.colMalinMiktari.VisibleIndex = 9;
            // 
            // colKalanMiktar
            // 
            this.colKalanMiktar.DisplayFormat.FormatString = "n3";
            this.colKalanMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKalanMiktar.FieldName = "KalanMiktar";
            this.colKalanMiktar.Name = "colKalanMiktar";
            this.colKalanMiktar.OptionsColumn.AllowEdit = false;
            this.colKalanMiktar.OptionsColumn.AllowFocus = false;
            this.colKalanMiktar.OptionsColumn.ReadOnly = true;
            this.colKalanMiktar.Visible = true;
            this.colKalanMiktar.VisibleIndex = 10;
            // 
            // colSEVKMIKTARI
            // 
            this.colSEVKMIKTARI.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colSEVKMIKTARI.AppearanceCell.Options.UseBackColor = true;
            this.colSEVKMIKTARI.Caption = "Sevk Miktari";
            this.colSEVKMIKTARI.DisplayFormat.FormatString = "n3";
            this.colSEVKMIKTARI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSEVKMIKTARI.FieldName = "SEVKMIKTARI";
            this.colSEVKMIKTARI.Name = "colSEVKMIKTARI";
            this.colSEVKMIKTARI.Visible = true;
            this.colSEVKMIKTARI.VisibleIndex = 11;
            // 
            // colMiktarBirimiAd
            // 
            this.colMiktarBirimiAd.FieldName = "MiktarBirimiAd";
            this.colMiktarBirimiAd.Name = "colMiktarBirimiAd";
            this.colMiktarBirimiAd.OptionsColumn.AllowEdit = false;
            this.colMiktarBirimiAd.OptionsColumn.AllowFocus = false;
            this.colMiktarBirimiAd.OptionsColumn.ReadOnly = true;
            this.colMiktarBirimiAd.Visible = true;
            this.colMiktarBirimiAd.VisibleIndex = 12;
            // 
            // colMalinSahibiTcKimlikVergiNo
            // 
            this.colMalinSahibiTcKimlikVergiNo.FieldName = "MalinSahibiTcKimlikVergiNo";
            this.colMalinSahibiTcKimlikVergiNo.Name = "colMalinSahibiTcKimlikVergiNo";
            this.colMalinSahibiTcKimlikVergiNo.OptionsColumn.AllowEdit = false;
            this.colMalinSahibiTcKimlikVergiNo.OptionsColumn.AllowFocus = false;
            this.colMalinSahibiTcKimlikVergiNo.OptionsColumn.ReadOnly = true;
            // 
            // colMalinSatisFiyati
            // 
            this.colMalinSatisFiyati.FieldName = "MalinSatisFiyati";
            this.colMalinSatisFiyati.Name = "colMalinSatisFiyati";
            this.colMalinSatisFiyati.OptionsColumn.AllowEdit = false;
            this.colMalinSatisFiyati.OptionsColumn.AllowFocus = false;
            this.colMalinSatisFiyati.OptionsColumn.ReadOnly = true;
            this.colMalinSatisFiyati.Visible = true;
            this.colMalinSatisFiyati.VisibleIndex = 13;
            // 
            // colMalinTuru
            // 
            this.colMalinTuru.FieldName = "MalinTuru";
            this.colMalinTuru.Name = "colMalinTuru";
            this.colMalinTuru.OptionsColumn.AllowEdit = false;
            this.colMalinTuru.OptionsColumn.AllowFocus = false;
            this.colMalinTuru.OptionsColumn.ReadOnly = true;
            this.colMalinTuru.Visible = true;
            this.colMalinTuru.VisibleIndex = 14;
            // 
            // colMalinTuruKodNo
            // 
            this.colMalinTuruKodNo.FieldName = "MalinTuruKodNo";
            this.colMalinTuruKodNo.Name = "colMalinTuruKodNo";
            this.colMalinTuruKodNo.OptionsColumn.AllowEdit = false;
            this.colMalinTuruKodNo.OptionsColumn.AllowFocus = false;
            this.colMalinTuruKodNo.OptionsColumn.ReadOnly = true;
            // 
            // colMiktarBirimId
            // 
            this.colMiktarBirimId.FieldName = "MiktarBirimId";
            this.colMiktarBirimId.Name = "colMiktarBirimId";
            this.colMiktarBirimId.OptionsColumn.AllowEdit = false;
            this.colMiktarBirimId.OptionsColumn.AllowFocus = false;
            this.colMiktarBirimId.OptionsColumn.ReadOnly = true;
            // 
            // colRusumMiktari
            // 
            this.colRusumMiktari.FieldName = "RusumMiktari";
            this.colRusumMiktari.Name = "colRusumMiktari";
            this.colRusumMiktari.OptionsColumn.AllowEdit = false;
            this.colRusumMiktari.OptionsColumn.AllowFocus = false;
            this.colRusumMiktari.OptionsColumn.ReadOnly = true;
            this.colRusumMiktari.Visible = true;
            this.colRusumMiktari.VisibleIndex = 15;
            // 
            // colUniqueId
            // 
            this.colUniqueId.FieldName = "UniqueId";
            this.colUniqueId.Name = "colUniqueId";
            this.colUniqueId.OptionsColumn.AllowEdit = false;
            this.colUniqueId.OptionsColumn.AllowFocus = false;
            this.colUniqueId.OptionsColumn.ReadOnly = true;
            // 
            // colUreticiTcKimlikVergiNo
            // 
            this.colUreticiTcKimlikVergiNo.FieldName = "UreticiTcKimlikVergiNo";
            this.colUreticiTcKimlikVergiNo.Name = "colUreticiTcKimlikVergiNo";
            this.colUreticiTcKimlikVergiNo.OptionsColumn.AllowEdit = false;
            this.colUreticiTcKimlikVergiNo.OptionsColumn.AllowFocus = false;
            this.colUreticiTcKimlikVergiNo.OptionsColumn.ReadOnly = true;
            // 
            // frmIrsaliyesizBildirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 563);
            this.Controls.Add(this.dgcReferansListesi);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmIrsaliyesizBildirim";
            this.Text = "HKS Stok Sıfırlama";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiSevkEdilecekSube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rsiSevkEdilecekSubessss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcReferansListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildirimSorguDTOLocalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReferansListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem barEIKarsiSube;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rsiSevkEdilecekSubessss;
        private DevExpress.XtraGrid.GridControl dgcReferansListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvReferansListesi;
        private System.Windows.Forms.BindingSource bildirimSorguDTOLocalBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSECIM;
        private DevExpress.XtraGrid.Columns.GridColumn colAnalizStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeTipi;
        private DevExpress.XtraGrid.Columns.GridColumn colBildirimTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colBildirimTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBildirimciTcKimlikVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colGidecekIsyeriId;
        private DevExpress.XtraGrid.Columns.GridColumn colGidecekYerTuruId;
        private DevExpress.XtraGrid.Columns.GridColumn colKalanMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKunyeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinKodNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinCinsKodNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinCinsi;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colSEVKMIKTARI;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinSahibiTcKimlikVergiNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinSatisFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colMalinTuruKodNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktarBirimId;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktarBirimiAd;
        private DevExpress.XtraGrid.Columns.GridColumn colRusumMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colUniqueId;
        private DevExpress.XtraGrid.Columns.GridColumn colUreticiTcKimlikVergiNo;
        private DevExpress.XtraBars.BarEditItem barDEIslemTarihB;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarButtonItem barBTNSorgula;
        private DevExpress.XtraBars.BarEditItem barLueKarsiSube;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rsiSevkEdilecekSube;
        private DevExpress.XtraBars.BarButtonItem barBtnBildirimYap;
        private DevExpress.XtraBars.BarEditItem barDEIslemTarihS;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
    }
}