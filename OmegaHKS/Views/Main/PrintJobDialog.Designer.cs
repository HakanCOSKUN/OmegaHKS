namespace OmegaHKS.Views.Main
{
    partial class PrintJobDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintJobDialog));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.cboPrinters = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtParallelPort = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cboFlowControl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboStopBits = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboParity = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtDataBits = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtBaudRate = new DevExpress.XtraEditors.TextEdit();
            this.cboSerialPorts = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.txtIPPort = new DevExpress.XtraEditors.TextEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.txtIPAddress = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.cboProgLang = new DevExpress.XtraEditors.ComboBoxEdit();
            this.nudDpi = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cboPrintOrientation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nudCopies = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPrinters.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParallelPort.Properties)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboFlowControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStopBits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboParity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaudRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSerialPorts.Properties)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIPPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIPAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProgLang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDpi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPrintOrientation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCopies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tabControl1);
            this.groupControl1.Controls.Add(this.cboProgLang);
            this.groupControl1.Controls.Add(this.nudDpi);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(383, 263);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Yazıcı Ayarları";
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(15, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabPage = this.xtraTabPage1;
            this.tabControl1.Size = new System.Drawing.Size(358, 200);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.cboPrinters);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(352, 172);
            this.xtraTabPage1.Text = "USB/Windows Driver";
            // 
            // cboPrinters
            // 
            this.cboPrinters.Location = new System.Drawing.Point(36, 67);
            this.cboPrinters.Name = "cboPrinters";
            this.cboPrinters.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPrinters.Properties.Items.AddRange(new object[] {
            "Normal Çıktı",
            "180  Derece Döndür",
            "90 Derece Döndür",
            "270 Derece Döndür"});
            this.cboPrinters.Size = new System.Drawing.Size(286, 20);
            this.cboPrinters.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(36, 48);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(48, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Yazıcı Adı:";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtParallelPort);
            this.xtraTabPage2.Controls.Add(this.labelControl6);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(352, 172);
            this.xtraTabPage2.Text = "LPT  Port";
            // 
            // txtParallelPort
            // 
            this.txtParallelPort.Location = new System.Drawing.Point(36, 67);
            this.txtParallelPort.Name = "txtParallelPort";
            this.txtParallelPort.Size = new System.Drawing.Size(286, 20);
            this.txtParallelPort.TabIndex = 8;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(36, 48);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "LPT Port Adı:";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.labelControl12);
            this.xtraTabPage3.Controls.Add(this.labelControl11);
            this.xtraTabPage3.Controls.Add(this.cboFlowControl);
            this.xtraTabPage3.Controls.Add(this.cboStopBits);
            this.xtraTabPage3.Controls.Add(this.cboParity);
            this.xtraTabPage3.Controls.Add(this.txtDataBits);
            this.xtraTabPage3.Controls.Add(this.labelControl10);
            this.xtraTabPage3.Controls.Add(this.txtBaudRate);
            this.xtraTabPage3.Controls.Add(this.cboSerialPorts);
            this.xtraTabPage3.Controls.Add(this.labelControl9);
            this.xtraTabPage3.Controls.Add(this.labelControl8);
            this.xtraTabPage3.Controls.Add(this.labelControl7);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(352, 172);
            this.xtraTabPage3.Text = "Seri Port";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(194, 64);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(32, 13);
            this.labelControl12.TabIndex = 16;
            this.labelControl12.Text = "Parity:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(194, 109);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(64, 13);
            this.labelControl11.TabIndex = 15;
            this.labelControl11.Text = "Flow Control:";
            // 
            // cboFlowControl
            // 
            this.cboFlowControl.Location = new System.Drawing.Point(194, 128);
            this.cboFlowControl.Name = "cboFlowControl";
            this.cboFlowControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFlowControl.Properties.Items.AddRange(new object[] {
            "Normal Çıktı",
            "180  Derece Döndür",
            "90 Derece Döndür",
            "270 Derece Döndür"});
            this.cboFlowControl.Size = new System.Drawing.Size(135, 20);
            this.cboFlowControl.TabIndex = 14;
            // 
            // cboStopBits
            // 
            this.cboStopBits.Location = new System.Drawing.Point(23, 128);
            this.cboStopBits.Name = "cboStopBits";
            this.cboStopBits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboStopBits.Properties.Items.AddRange(new object[] {
            "Normal Çıktı",
            "180  Derece Döndür",
            "90 Derece Döndür",
            "270 Derece Döndür"});
            this.cboStopBits.Size = new System.Drawing.Size(135, 20);
            this.cboStopBits.TabIndex = 13;
            // 
            // cboParity
            // 
            this.cboParity.Location = new System.Drawing.Point(194, 83);
            this.cboParity.Name = "cboParity";
            this.cboParity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboParity.Properties.Items.AddRange(new object[] {
            "Normal Çıktı",
            "180  Derece Döndür",
            "90 Derece Döndür",
            "270 Derece Döndür"});
            this.cboParity.Size = new System.Drawing.Size(135, 20);
            this.cboParity.TabIndex = 12;
            // 
            // txtDataBits
            // 
            this.txtDataBits.EditValue = "8";
            this.txtDataBits.Location = new System.Drawing.Point(23, 83);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(135, 20);
            this.txtDataBits.TabIndex = 11;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(194, 19);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(54, 13);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Baud Rate:";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.EditValue = "9600";
            this.txtBaudRate.Location = new System.Drawing.Point(194, 38);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(135, 20);
            this.txtBaudRate.TabIndex = 9;
            // 
            // cboSerialPorts
            // 
            this.cboSerialPorts.Location = new System.Drawing.Point(23, 38);
            this.cboSerialPorts.Name = "cboSerialPorts";
            this.cboSerialPorts.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSerialPorts.Properties.Items.AddRange(new object[] {
            "Normal Çıktı",
            "180  Derece Döndür",
            "90 Derece Döndür",
            "270 Derece Döndür"});
            this.cboSerialPorts.Size = new System.Drawing.Size(135, 20);
            this.cboSerialPorts.TabIndex = 7;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(23, 109);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(46, 13);
            this.labelControl9.TabIndex = 4;
            this.labelControl9.Text = "Stop Bits:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(23, 64);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(47, 13);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Data Bits:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(23, 19);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(66, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Seri Port  Adı:";
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.txtIPPort);
            this.xtraTabPage4.Controls.Add(this.labelControl14);
            this.xtraTabPage4.Controls.Add(this.txtIPAddress);
            this.xtraTabPage4.Controls.Add(this.labelControl13);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(352, 172);
            this.xtraTabPage4.Text = "Network";
            // 
            // txtIPPort
            // 
            this.txtIPPort.Location = new System.Drawing.Point(32, 105);
            this.txtIPPort.Name = "txtIPPort";
            this.txtIPPort.Size = new System.Drawing.Size(286, 20);
            this.txtIPPort.TabIndex = 12;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(32, 86);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(59, 13);
            this.labelControl14.TabIndex = 11;
            this.labelControl14.Text = "Yazıcı Portu:";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.EditValue = "127.0.0.1";
            this.txtIPAddress.Location = new System.Drawing.Point(32, 48);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(286, 20);
            this.txtIPAddress.TabIndex = 10;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(32, 29);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(142, 13);
            this.labelControl13.TabIndex = 9;
            this.labelControl13.Text = "Yazıcı IP Adresi  / Sunucu Adi:";
            // 
            // cboProgLang
            // 
            this.cboProgLang.Location = new System.Drawing.Point(266, 32);
            this.cboProgLang.Name = "cboProgLang";
            this.cboProgLang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboProgLang.Properties.Items.AddRange(new object[] {
            "ZPL",
            "EPL"});
            this.cboProgLang.Size = new System.Drawing.Size(82, 20);
            this.cboProgLang.TabIndex = 4;
            // 
            // nudDpi
            // 
            this.nudDpi.EditValue = new decimal(new int[] {
            203,
            0,
            0,
            0});
            this.nudDpi.Location = new System.Drawing.Point(106, 32);
            this.nudDpi.Name = "nudDpi";
            this.nudDpi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nudDpi.Properties.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudDpi.Properties.MaxValue = new decimal(new int[] {
            2400,
            0,
            0,
            0});
            this.nudDpi.Properties.MinValue = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.nudDpi.Size = new System.Drawing.Size(67, 20);
            this.nudDpi.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(184, 35);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Haberleşme Dili:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(85, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Çözünürlük (DPI):";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.cboPrintOrientation);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.nudCopies);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 283);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(383, 76);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Çıktı Özellikleri";
            // 
            // cboPrintOrientation
            // 
            this.cboPrintOrientation.Location = new System.Drawing.Point(230, 37);
            this.cboPrintOrientation.Name = "cboPrintOrientation";
            this.cboPrintOrientation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPrintOrientation.Properties.Items.AddRange(new object[] {
            "Portrait",
            "Portrait180",
            "Landscape90",
            "Landscape270"});
            this.cboPrintOrientation.Size = new System.Drawing.Size(143, 20);
            this.cboPrintOrientation.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(154, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Çıktıyı Döndür:";
            // 
            // nudCopies
            // 
            this.nudCopies.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCopies.Location = new System.Drawing.Point(74, 37);
            this.nudCopies.Name = "nudCopies";
            this.nudCopies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nudCopies.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCopies.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCopies.Size = new System.Drawing.Size(60, 20);
            this.nudCopies.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Çıktı Adedi :";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(222, 365);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Yazdır";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(320, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "İptal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PrintJobDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 399);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(423, 438);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(423, 438);
            this.Name = "PrintJobDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Etiket Yazdırma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrintJobDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPrinters.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParallelPort.Properties)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboFlowControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboStopBits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboParity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaudRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSerialPorts.Properties)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIPPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIPAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboProgLang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDpi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboPrintOrientation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCopies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cboPrintOrientation;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit nudCopies;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cboProgLang;
        private DevExpress.XtraEditors.SpinEdit nudDpi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraTab.XtraTabControl tabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraEditors.ComboBoxEdit cboPrinters;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtParallelPort;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit cboFlowControl;
        private DevExpress.XtraEditors.ComboBoxEdit cboStopBits;
        private DevExpress.XtraEditors.ComboBoxEdit cboParity;
        private DevExpress.XtraEditors.TextEdit txtDataBits;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtBaudRate;
        private DevExpress.XtraEditors.ComboBoxEdit cboSerialPorts;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtIPPort;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txtIPAddress;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}