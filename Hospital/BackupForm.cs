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
using System.Data.SqlClient;
using FlyoutDialogPopup;
using EducareSMS.Control;
using System.Configuration;

namespace Hospital
{
    public partial class BackupForm : DevExpress.XtraEditors.XtraForm
    {
        public BackupForm()
        {
            InitializeComponent();
            if ((!System.IO.Directory.Exists("C:\\HOBACK")))
            {
                System.IO.Directory.CreateDirectory("C:\\HOBACK");
            }
            gridControl.DataSource = new System.IO.DirectoryInfo("C:\\HOBACK").GetFiles();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you want to quit the application?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                try
                {
                    string fileName = gridView.GetRowCellValue(gridView.FocusedRowHandle, "FullName").ToString();
                    if ((System.IO.File.Exists(fileName)))
                    {
                        System.IO.File.Delete(fileName);
                        gridControl.DataSource = new System.IO.DirectoryInfo("C:\\HOBACK").GetFiles();
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message + "remove filtering");
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (CustomFlyoutDialog.ShowForm(this, null, new DialogMaker()) == DialogResult.OK)
            {
                try
                {
                    string filename = gridView.GetRowCellValue(gridView.FocusedRowHandle, "FullName").ToString();
                    SqlConn cc = new SqlConn();
                    Cursor = Cursors.WaitCursor;

                    SqlConnection.ClearAllPools();
                    cc.con = new SqlConnection();
                    cc.con.ConnectionString = ConfigurationManager.ConnectionStrings["EducareContext"].ConnectionString;
                    cc.con.Open();
                    string cb = "IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'" + "DBHOSPITAL" + "') USE Master DROP DATABASE " + "DBHOSPITAL" + " RESTORE DATABASE " + "DBHOSPITAL" + " FROM DISK = '" + filename + "'";
                    cc.cmd = new SqlCommand(cb);
                    cc.cmd.CommandTimeout = 0;
                    cc.cmd.Connection = cc.con;
                    cc.cmd.ExecuteReader();
                    cc.con.Close();
                    Cursor = Cursors.Default;
                    MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cursor = Cursors.Default;
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (CustomFlyoutDialog.ShowForm(this, null, new DialogMaker()) == DialogResult.OK)
            {

                string flname;
                openFileDialog.Filter = "back files (*.bak)|*.bak|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    flname = openFileDialog.FileName;

                    try
                    {

                        SqlConn cc = new SqlConn();
                        Cursor = Cursors.WaitCursor;

                        SqlConnection.ClearAllPools();
                        cc.con = new SqlConnection();
                        cc.con.ConnectionString = ConfigurationManager.ConnectionStrings["EducareContext"].ConnectionString;
                        cc.con.Open();
                        string cb = "IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'" + "DBHOSPITAL" + "') USE Master DROP DATABASE " + "DBHOSPITAL" + " RESTORE DATABASE " + "DBHOSPITAL" + " FROM DISK = '" + flname + "'";
                        cc.cmd = new SqlCommand(cb);
                        cc.cmd.CommandTimeout = 0;
                        cc.cmd.Connection = cc.con;
                        cc.cmd.ExecuteReader();
                        cc.con.Close();
                        Cursor = Cursors.Default;
                        MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor = Cursors.Default;
                    }
                }

            }
        }
    }
}