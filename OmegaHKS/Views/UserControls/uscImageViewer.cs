using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OmegaHKS.Views.UserControls
{
    public partial class uscImageViewer : DevExpress.XtraEditors.XtraUserControl
    {
        private Image currentImage = null;
        private int iCurrPage = 1, iPages = 1;

        public uscImageViewer()
        {
            InitializeComponent();
        }

        public void LoadImage(System.IO.Stream imgStream)
        {
            picLabel.Image = null;
            if (currentImage != null)
            {
                currentImage.Dispose();
                currentImage = null;
            }

            currentImage = Image.FromStream(imgStream);
            iCurrPage = 1;
            RefreshImage();
        }


        public void RefreshImage()
        {
            iPages = currentImage.GetFrameCount(System.Drawing.Imaging.FrameDimension.Page);
            lblNumOfLabels.Text = string.Format("Etiket {0} / {1}", iCurrPage, iPages);
            currentImage.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Page, iCurrPage - 1);
            picLabel.Image = new Bitmap(currentImage);
            SetImageLocation();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (iCurrPage > 1)
            {
                iCurrPage--;
                RefreshImage();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (iCurrPage < iPages)
            {
                iCurrPage++;
                RefreshImage();
            }
        }

        private void SetImageLocation()
        {
            var x = 0;
            var y = 0;

            if (picLabel.Width > pnlContainer.ClientRectangle.Width)
            {
                x = 0;
            }
            else
            {
                x = (pnlContainer.ClientRectangle.Width - picLabel.Width) / 2;
            }

            if (picLabel.Height > pnlContainer.ClientRectangle.Height)
            {
                y = 0;
            }
            else
            {
                y = (pnlContainer.ClientRectangle.Height - picLabel.Height) / 2;
            }

            picLabel.Location = new Point(x, y);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetImageLocation();
        }
    }
}
