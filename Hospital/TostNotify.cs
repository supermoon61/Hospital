using DevExpress.XtraBars.ToastNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public static class TostNotify
    {
        static ToastNotificationsManager toastNotificationsManager = new ToastNotificationsManager();

        public static void Notify(int tostId)
        {

            toastNotificationsManager.ApplicationId = "d6735698-70f5-4dad-b9ce-a4a2d9834987";
            toastNotificationsManager.ApplicationName = "Hospital";

            toastNotificationsManager.Notifications.AddRange(new IToastNotificationProperties[] {
                    new ToastNotification("0001",Properties.Resources.apply_32x32, "Data Save Success", "Your data has been successfully saved.", "", ToastNotificationTemplate.ImageAndText03),
                    new ToastNotification("0002",Properties.Resources.cancel_32x32, "Data Delete Success", "Your data has been successfully deleted.", "", ToastNotificationTemplate.ImageAndText03),
                    
            });

            DevExpress.Data.ShellHelper.TryCreateShortcut(toastNotificationsManager.ApplicationId, toastNotificationsManager.ApplicationName);
            toastNotificationsManager.ShowNotification(toastNotificationsManager.Notifications[tostId]);
        }
        public static void SaveNotify()
        {
            Notify(0);
        }
        public static void DeleteNotify()
        {
            Notify(1);
        }
       
    }
}
