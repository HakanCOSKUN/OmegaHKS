namespace OmegaHKS.Views.UserControls
{
    partial class ucsBTNGuncelle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucsBTNGuncelle));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblProgresText = new DevExpress.XtraEditors.LabelControl();
            this.prBarControll = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnVerileriGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prBarControll.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblProgresText);
            this.panelControl1.Controls.Add(this.prBarControll);
            this.panelControl1.Controls.Add(this.btnKapat);
            this.panelControl1.Controls.Add(this.btnVerileriGuncelle);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(638, 57);
            this.panelControl1.TabIndex = 1;
            // 
            // lblProgresText
            // 
            this.lblProgresText.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProgresText.Location = new System.Drawing.Point(12, 5);
            this.lblProgresText.Name = "lblProgresText";
            this.lblProgresText.Size = new System.Drawing.Size(76, 13);
            this.lblProgresText.TabIndex = 3;
            this.lblProgresText.Text = "Yapılan İşlem";
            // 
            // prBarControll
            // 
            this.prBarControll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prBarControll.Location = new System.Drawing.Point(12, 24);
            this.prBarControll.Name = "prBarControll";
            this.prBarControll.Properties.ShowTitle = true;
            this.prBarControll.Properties.Step = 0;
            this.prBarControll.Size = new System.Drawing.Size(362, 21);
            this.prBarControll.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.Image")));
            this.btnKapat.Location = new System.Drawing.Point(537, 8);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(84, 41);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            // 
            // btnVerileriGuncelle
            // 
            this.btnVerileriGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerileriGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnVerileriGuncelle.Image")));
            this.btnVerileriGuncelle.Location = new System.Drawing.Point(402, 8);
            this.btnVerileriGuncelle.Name = "btnVerileriGuncelle";
            this.btnVerileriGuncelle.Size = new System.Drawing.Size(120, 41);
            this.btnVerileriGuncelle.TabIndex = 0;
            this.btnVerileriGuncelle.Text = "Verileri Güncelle";
            // 
            // ucsBTNGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucsBTNGuncelle";
            this.Size = new System.Drawing.Size(638, 57);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prBarControll.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblProgresText;
        private DevExpress.XtraEditors.ProgressBarControl prBarControll;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnVerileriGuncelle;
    }
}
