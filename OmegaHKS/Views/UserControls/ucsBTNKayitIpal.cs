using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OmegaHKS.Views.UserControls
{
    public partial class ucsBTNKayitIpal : DevExpress.XtraEditors.XtraUserControl
    {
        public ucsBTNKayitIpal()
        {
            InitializeComponent();
            Dock = DockStyle.Bottom;

            btnTemizle.Click += (o, e) =>
            {
                if (ClickTemizle != null)
                {
                    ClickTemizle(o, e);
                }
            };

            btnKaydet.Click += (o, e) =>
            {
                if (ClickKaydet != null)
                {
                    ClickKaydet(o, e);
                }
            };

            btnIptal.Click += (o, e) =>
            {
                if (ClickIptal != null)
                {
                    ClickIptal(o, e);
                }
            };
        }

        public event EventHandler ClickTemizle;
        public event EventHandler ClickKaydet;
        public event EventHandler ClickIptal;

        // public virtual Image Image { get; set; }
        public bool TemizleVisible
        {
            get
            {
                return btnTemizle.Visible;
            }
            set
            {
                btnTemizle.Visible = value;
            }
        }
        public bool KaydetVisible
        {
            get
            {
                return btnKaydet.Visible;
            }
            set
            {
                btnKaydet.Visible = value;
            }
        }
        public bool IptalVisible
        {
            get
            {
                return btnIptal.Visible;
            }
            set
            {
                btnIptal.Visible = value;
            }
        }
        public string KaydetText
        {
            get
            {
                return btnKaydet.Text;
            }
            set
            {
                btnKaydet.Text = value;
            }
        }
        public string IptalText
        {
            get
            {
                return btnIptal.Text;
            }
            set
            {
                btnIptal.Text = value;
            }
        }
        public string TemizleText
        {
            get
            {
                return btnTemizle.Text;
            }
            set
            {
                btnTemizle.Text = value;
            }
        }
        public bool KaydetEnabled
        {
            get
            {
                return btnKaydet.Enabled;
            }
            set
            {
                btnKaydet.Enabled = value;
            }
        }
        public bool IptalEnabled
        {
            get
            {
                return btnIptal.Enabled;
            }
            set
            {
                btnIptal.Enabled = value;
            }
        }
        public Image KaydetImage
        {
            get
            {
                return btnKaydet.Image;
            }
            set
            {
                btnKaydet.Image = value;
            }
        }
        public Image IptalImage
        {
            get
            {
                return btnIptal.Image;
            }
            set
            {
                btnIptal.Image = value;
            }
        }
        public Image TemizleImage
        {
            get
            {
                return btnTemizle.Image;
            }
            set
            {
                btnTemizle.Image = value;
            }
        }
    }
}
