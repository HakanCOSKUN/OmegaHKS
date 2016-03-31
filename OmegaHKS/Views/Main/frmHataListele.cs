using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OmegaHKS.Views.Main
{
    public partial class frmHataListele : BaseForm
    {
        private IList<Models.ErrorLog> ErrorLog = null;
        public frmHataListele(IList<Models.ErrorLog> errLog)
        {
            InitializeComponent();
            this.ErrorLog = errLog;
            IniHataListele();
        }

        private void IniHataListele()
        {
            dgcErrorList.DataSource = this.ErrorLog;
        }

        private void ucsBTNKayitIpal1_ClickIptal(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}