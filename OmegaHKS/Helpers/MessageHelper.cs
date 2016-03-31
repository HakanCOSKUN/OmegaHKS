using DevExpress.XtraEditors;
using OmegaHKS.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OmegaHKS.Helpers
{
    public static class MessageHelper
    {
        private static DialogResult Show(string mesaj, MessageBoxButtons button, MessageBoxIcon icon)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
            return XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default,  mesaj, Core.StaticDegiskenler.APP_NAME, button, icon);
        }

        public static void ShowInformation(string mesaj)
        {
            Show(mesaj, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(string mesaj)
        {
            Show(mesaj, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ShowQuestion(string mesaj)
        {
            return Show(mesaj, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static bool SecilenKayitlarSilinecektir()
        {
            return ShowQuestion("Seçilen Kayıtlar Silinecektir emin misiniz?");
        }
    }
}
