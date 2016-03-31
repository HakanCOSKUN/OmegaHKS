using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace OmegaHKS.Views
{
    public partial class BaseForm : DevExpress.XtraEditors.XtraForm
    {
        public BaseForm()
        {
            InitializeComponent();
            System.Net.ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
            {
                return true;
            };
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
            Load += BaseForm_Load;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            GridAyarla(this);
        }

        private void GridAyarla(Control control)
        {
            if (control is GridControl)
            {
                var grid = control as GridControl;
                grid.UseEmbeddedNavigator = true;
                grid.EmbeddedNavigator.Buttons.Append.Visible = false;
                grid.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
                grid.EmbeddedNavigator.Buttons.Edit.Visible = false;
                grid.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
                grid.EmbeddedNavigator.Buttons.Remove.Visible = false;

                foreach (GridView view in grid.Views)
                {
                    foreach (GridColumn column in view.Columns)
                    {
                        var font = column.AppearanceHeader.Font;
                        column.AppearanceHeader.Font = new Font(font.Name, font.Size, FontStyle.Bold);
                        column.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    }
                }
            }
            if (control.Controls != null)
            {
                foreach (Control item in control.Controls)
                {
                    GridAyarla(item);
                }
            }
        }
    }
}
