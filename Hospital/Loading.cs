using DevExpress.XtraSplashScreen;
using System;
using System.Linq;

namespace EducareSMS.Control
{
    class Loading
    {
        string caption;
        string desc;

        public void dbLoading(Boolean load)
        {
            this.caption = "Data Loading";
            this.desc = "Please wait ...";

            preLoading(load);
        }
        public void dbLogin(Boolean load)
        {
            this.caption = "Checking credential";
            this.desc = "Please wait ...";

            preLoading(load);
        }

        public void frmLoading(Boolean load)
        {
            this.caption = "Form Loading";
            this.desc = "Please wait ...";

            preLoading(load);
        }
       
        public void preLoading(Boolean load)
        {
            if (load)
            {
                SplashScreenManager.ShowForm(typeof(LoadingForm), true, true);
                SplashScreenManager.Default.SetWaitFormCaption(caption);
                SplashScreenManager.Default.SetWaitFormDescription(desc);
            }
            else
            {
                SplashScreenManager.CloseForm();
            }
        }
       
    }
}
