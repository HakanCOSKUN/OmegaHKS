using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SoftwareLocker;
using System.Globalization;
using System.Threading;

namespace OmegaHKS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();

            //Application.Run(new Views.Main.frmMain(false));

            TrialMaker t = new TrialMaker("OmegaHKS", Application.StartupPath + "\\OmegaHKS.ldf",
            Application.StartupPath + "\\OmegaHKS.dbf",
            "Tel : +90 312 4785421\nGSM: +90 532 532511250 - GSM:+90 532 3722404\nMail:metin@nebil.com.tr - hakan@nebil.com.tr", 15, 50, "511");

            byte[] MyOwnKey = { 97, 250, 1, 5, 84, 21, 7, 63, 4, 54, 87, 56, 123, 10, 3, 62, 7, 9, 20, 36, 37, 21, 101, 57 };
            t.TripleDESKey = MyOwnKey;

            TrialMaker.RunTypes RT = t.ShowDialog();
            bool is_trial;
            if (RT != TrialMaker.RunTypes.Expired)
            {
                if (RT == TrialMaker.RunTypes.Full)
                    is_trial = false;
                else
                    is_trial = true;

                Application.Run(new Views.Main.frmMain(is_trial));
            }
        }
    }
}
