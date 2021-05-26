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
using Hospital.Model;
using DevExpress.LookAndFeel;
using Hospital.Properties;
using EducareSMS.Control;

namespace Hospital
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        Loading loading = new Loading();
        public LoginForm()
        {
            
            InitializeComponent();
            UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                textUser.Text = Properties.Settings.Default.UserName;
                textPassword.Text = Properties.Settings.Default.Password;
                BtnLogin.Focus();
                checkBoxRemember.Checked = true;
            }
            else { textUser.Focus(); }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
                Login login = new Login();
                loading.dbLogin(true);
            string usrName = this.textUser.Text;
                string usrPassword = this.textPassword.Text;
                bool x = login.AuthUser(usrName, usrPassword);
            if (x)
            {
                if (checkBoxRemember.Checked)
                {
                    Properties.Settings.Default.UserName = textUser.Text;
                    Properties.Settings.Default.Password = textPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.UserName = string.Empty;
                    Properties.Settings.Default.Password = string.Empty;
                    Properties.Settings.Default.Save();
                }
                using (var dbContext = new HospitalContext())
                {

                    this.Hide();
                   
                    MainForm mf = new MainForm();
                    loading.dbLogin(false);
                    mf.ShowDialog();
                    this.Close();

                }
            }

                
            }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }
    }
}