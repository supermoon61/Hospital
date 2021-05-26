using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.XtraSplashScreen;
using System.Threading;
using DevExpress.LookAndFeel;
using Hospital.Properties;

namespace Hospital
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();

            SplashScreenManager.ShowForm(null, typeof(SplashScreen), false, true, false, 1000);
            Thread.Sleep(5000);
            SplashScreenManager.CloseForm();

            BonusSkins.Register();
            
            Application.Run(new LoginForm());
        }
    }

    
}
