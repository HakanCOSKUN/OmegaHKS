using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OmegaHKS.Views.UserControls
{
    public partial class ucsBTNGuncelle : DevExpress.XtraEditors.XtraUserControl
    {
        public ucsBTNGuncelle()
        {
            InitializeComponent();

            Dock = DockStyle.Bottom;

            btnVerileriGuncelle.Click += (o, e) =>
            {
                if (ClickGuncelle != null)
                {
                    ClickGuncelle(o, e);
                }
            };

            btnKapat.Click += (o, e) =>
            {
                if (ClickKapat != null)
                {
                    ClickKapat(o, e);
                }
            };
        }

        public event EventHandler ClickGuncelle;
        public event EventHandler ClickKapat;

        private int progressValue;
        public int ProgressValue
        {
            get
            {
                return progressValue;
            }
            set
            {
                if (progressValue != value)
                {
                    progressValue = value;
                    prBarControll.PerformStep();
                }
            }
        }

        public bool ProgressTextVisible
        {
            get
            {
                return lblProgresText.Visible;
            }
            set
            {
                lblProgresText.Visible = value;
            }
        }
        public bool ProgressTextEnabled
        {
            get
            {
                return lblProgresText.Enabled;
            }
            set
            {
                lblProgresText.Enabled = value;
            }
        }
        public string ProgressTextYazi
        {
            get
            {
                return lblProgresText.Text;
            }
            set
            {
                lblProgresText.Text = value;
            }
        }

        public bool ProgressBarControllVisible
        {
            get
            {
                return prBarControll.Visible;
            }
            set
            {
                prBarControll.Visible = value;
            }
        }
        public bool ProgressBarControllEnabled
        {
            get
            {
                return prBarControll.Enabled;
            }
            set
            {
                prBarControll.Enabled = value;
            }
        }
        public int ProgressBarControlMaxValue
        {
            get
            {
                return prBarControll.Properties.Maximum;
            }
            set
            {
                prBarControll.Properties.Maximum = value;
            }
        }
        public int ProgressBarControlStep
        {
            get
            {
                return prBarControll.Properties.Step;
            }
            set
            {
                prBarControll.Properties.Step = value;
            }
        }

        public int ProgressBarControlPosition
        {
            get
            {
                return prBarControll.Position;
            }
            set
            {
                prBarControll.Position = value;
            }
        }

        public bool GuncelleVisible
        {
            get
            {
                return btnVerileriGuncelle.Visible;
            }
            set
            {
                btnVerileriGuncelle.Visible = value;
            }
        }
        public bool KapatVisible
        {
            get
            {
                return btnKapat.Visible;
            }
            set
            {
                btnKapat.Visible = value;
            }
        }
        public bool GuncelleEnabled
        {
            get
            {
                return btnVerileriGuncelle.Enabled;
            }
            set
            {
                btnVerileriGuncelle.Enabled = value;
            }
        }
        public bool KapatEnabled
        {
            get
            {
                return btnKapat.Enabled;
            }
            set
            {
                btnKapat.Enabled = value;
            }
        }
    }
}
