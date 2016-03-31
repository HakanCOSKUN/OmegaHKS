namespace OmegaHKS.Views.Ayarlar
{
    partial class frmWebServiceBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWebServiceBilgileri));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkEditSifreGoster = new DevExpress.XtraEditors.CheckEdit();
            this.txtWebServicePassword = new DevExpress.XtraEditors.TextEdit();
            this.txtWebUserPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtWebUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ucsBTNKayitIpal1 = new OmegaHKS.Views.UserControls.ucsBTNKayitIpal();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnYekiVer = new DevExpress.XtraEditors.SimpleButton();
            this.txtErisimSifresi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSifreGoster.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebServicePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebUserPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtErisimSifresi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.checkEditSifreGoster);
            this.groupControl1.Controls.Add(this.txtWebServicePassword);
            this.groupControl1.Controls.Add(this.txtWebUserPassword);
            this.groupControl1.Controls.Add(this.txtWebUserName);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Enabled = false;
            this.groupControl1.Location = new System.Drawing.Point(23, 126);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(375, 140);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Web Servis Bilgileri";
            // 
            // checkEditSifreGoster
            // 
            this.checkEditSifreGoster.Location = new System.Drawing.Point(122, 102);
            this.checkEditSifreGoster.Name = "checkEditSifreGoster";
            this.checkEditSifreGoster.Properties.Caption = "Şifreleri Göster";
            this.checkEditSifreGoster.Size = new System.Drawing.Size(106, 19);
            this.checkEditSifreGoster.TabIndex = 2;
            this.checkEditSifreGoster.CheckedChanged += new System.EventHandler(this.checkEditSifreGoster_CheckedChanged);
            // 
            // txtWebServicePassword
            // 
            this.txtWebServicePassword.Location = new System.Drawing.Point(122, 76);
            this.txtWebServicePassword.Name = "txtWebServicePassword";
            this.txtWebServicePassword.Properties.UseSystemPasswordChar = true;
            this.txtWebServicePassword.Size = new System.Drawing.Size(214, 20);
            this.txtWebServicePassword.TabIndex = 1;
            // 
            // txtWebUserPassword
            // 
            this.txtWebUserPassword.Location = new System.Drawing.Point(122, 50);
            this.txtWebUserPassword.Name = "txtWebUserPassword";
            this.txtWebUserPassword.Properties.UseSystemPasswordChar = true;
            this.txtWebUserPassword.Size = new System.Drawing.Size(214, 20);
            this.txtWebUserPassword.TabIndex = 1;
            // 
            // txtWebUserName
            // 
            this.txtWebUserName.Location = new System.Drawing.Point(122, 24);
            this.txtWebUserName.Name = "txtWebUserName";
            this.txtWebUserName.Size = new System.Drawing.Size(214, 20);
            this.txtWebUserName.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 79);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Web Service Şifresi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(85, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Şifre";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(52, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı";
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
            this.ucsBTNKayitIpal1.KaydetVisible = true;
            this.ucsBTNKayitIpal1.Location = new System.Drawing.Point(0, 283);
            this.ucsBTNKayitIpal1.Name = "ucsBTNKayitIpal1";
            this.ucsBTNKayitIpal1.Size = new System.Drawing.Size(419, 52);
            this.ucsBTNKayitIpal1.TabIndex = 1;
            this.ucsBTNKayitIpal1.TemizleImage = ((System.Drawing.Image)(resources.GetObject("ucsBTNKayitIpal1.TemizleImage")));
            this.ucsBTNKayitIpal1.TemizleText = "&Temizle";
            this.ucsBTNKayitIpal1.TemizleVisible = false;
            this.ucsBTNKayitIpal1.ClickKaydet += new System.EventHandler(this.ucsBTNKayitIpal1_ClickKaydet);
            this.ucsBTNKayitIpal1.ClickIptal += new System.EventHandler(this.ucsBTNKayitIpal1_ClickIptal);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnYekiVer);
            this.groupControl2.Controls.Add(this.txtErisimSifresi);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Location = new System.Drawing.Point(23, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(375, 100);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Erişim Şifresi";
            // 
            // btnYekiVer
            // 
            this.btnYekiVer.Image = ((System.Drawing.Image)(resources.GetObject("btnYekiVer.Image")));
            this.btnYekiVer.Location = new System.Drawing.Point(201, 62);
            this.btnYekiVer.Name = "btnYekiVer";
            this.btnYekiVer.Size = new System.Drawing.Size(135, 23);
            this.btnYekiVer.TabIndex = 2;
            this.btnYekiVer.Text = "Yetkili Kontrol Et";
            this.btnYekiVer.Click += new System.EventHandler(this.btnYekiVer_Click);
            // 
            // txtErisimSifresi
            // 
            this.txtErisimSifresi.Location = new System.Drawing.Point(156, 36);
            this.txtErisimSifresi.Name = "txtErisimSifresi";
            this.txtErisimSifresi.Properties.UseSystemPasswordChar = true;
            this.txtErisimSifresi.Size = new System.Drawing.Size(180, 20);
            this.txtErisimSifresi.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 39);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(120, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Bilgilere Erişmek İçin Şifre";
            // 
            // frmWebServiceBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 335);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.ucsBTNKayitIpal1);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(435, 500);
            this.MinimumSize = new System.Drawing.Size(435, 275);
            this.Name = "frmWebServiceBilgileri";
            this.Text = "H.K.S Web Service Parametre Tanımları";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditSifreGoster.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebServicePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebUserPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtErisimSifresi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtWebServicePassword;
        private DevExpress.XtraEditors.TextEdit txtWebUserPassword;
        private DevExpress.XtraEditors.TextEdit txtWebUserName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private UserControls.ucsBTNKayitIpal ucsBTNKayitIpal1;
        private DevExpress.XtraEditors.CheckEdit checkEditSifreGoster;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnYekiVer;
        private DevExpress.XtraEditors.TextEdit txtErisimSifresi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}