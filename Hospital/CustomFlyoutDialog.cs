﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System.Windows.Forms;

namespace FlyoutDialogPopup
{
    public class CustomFlyoutDialog : FlyoutDialog
    {
        public CustomFlyoutDialog(Form owner, FlyoutAction actions, UserControl UserControleToShow)
            : base(owner, actions)
        {
            this.Properties.HeaderOffset = 0;
            this.Properties.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Properties.Style = FlyoutStyle.Popup;
            this.FlyoutControl = UserControleToShow;
        }
        public static DialogResult ShowForm(Form owner, FlyoutAction actions, UserControl UserControlToShow)
        {
            CustomFlyoutDialog customFlyout = new CustomFlyoutDialog(owner, actions, UserControlToShow);
            return customFlyout.ShowDialog();
        }
    }
}
