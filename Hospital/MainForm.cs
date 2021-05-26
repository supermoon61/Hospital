using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Hospital.Model;
using System.Data.Entity;
using Hospital.Properties;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Configuration;

namespace Hospital
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        HospitalContext dbContext;
        public MainForm()
        {
            InitializeComponent();
            RefreshGrid();
        }
        public void RefreshGrid()
        {
            dbContext = new HospitalContext();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.Patients.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
               patientBindingSource.DataSource = dbContext.Patients.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void barLargeButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
            Settings.Default.Save();
        }

        private void aceEdit_Click(object sender, EventArgs e)
        {
            if (rowCount())
            {
                EditPatient editForm = new EditPatient(getrow(),this);
                editForm.ShowDialog();
            }
        }

        private int getrow()
        {
            int enID = Convert.ToInt32( gvPatientList.GetRowCellValue(gvPatientList.FocusedRowHandle, "PID"));
            return enID;
        }
        private bool rowCount()
        {
            return (gvPatientList.RowCount == 0) ? false : true;
        }

        private void aceAdd_Click(object sender, EventArgs e)
        {
            AddPatient admitForm = new AddPatient(this);
            admitForm.ShowDialog();
        }

        private void aceMedicine_Click(object sender, EventArgs e)
        {

        }

        private void aceExport_Click(object sender, EventArgs e)
        {
            if (rowCount())
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                { gvPatientList.ExportToXlsx(saveFileDialog.FileName); }
            }
        }

        private void aceDelete_Click(object sender, EventArgs e)
        {
            if (rowCount())
            {
                string message = "Are you sure you want to delete this item?";
                string title = "Delete Box";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = XtraMessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {

                }
                else if (result == DialogResult.Yes)
                {
                    patientBindingSource.RemoveCurrent();
                    dbContext.SaveChanges();
                    TostNotify.DeleteNotify();
                    RefreshGrid();
                }
            }
        }

        private void barLargeButtonRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshGrid();
        }

        private void barLargeButtonIBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

               // SaveAtLocation();
                SaveinDrive();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveAtLocation()
        {
            string destination;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "back files (*.bak)|*.bak|All files (*.*)|*.*";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                destination = saveFileDialog.FileName;
                string destdir = destination + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".bak";
                string command = @"BACKUP DATABASE DBHOSPITAL TO DISK='" + destdir + "'";
                SqlCommand oCommand = null;
                SqlConnection oConnection = null;
                oConnection = new SqlConnection();
                oConnection.ConnectionString = ConfigurationManager.ConnectionStrings["HospitalContext"].ConnectionString;
                if (oConnection.State != ConnectionState.Open)
                    oConnection.Open();
                oCommand = new SqlCommand(command, oConnection);
                oCommand.ExecuteNonQuery();
                XtraMessageBox.Show("Database BackUp has been created successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //gridControl.DataSource = new System.IO.DirectoryInfo("C:\\IELMS").GetFiles();
            }

        }

        private void SaveinDrive()
        {
            if ((!System.IO.Directory.Exists("C:\\HOBACK")))
            {
                System.IO.Directory.CreateDirectory("C:\\HOBACK");
            }
            string destdir = "C:\\HOBACK\\HODB " + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".bak";
            string command = @"BACKUP DATABASE DBHOSPITAL TO DISK='" + destdir + "'";
            SqlCommand oCommand = null;
            SqlConnection oConnection = null;
            oConnection = new SqlConnection();
            oConnection.ConnectionString = ConfigurationManager.ConnectionStrings["HospitalContext"].ConnectionString;
            if (oConnection.State != ConnectionState.Open)
                oConnection.Open();
            oCommand = new SqlCommand(command, oConnection);
            oCommand.ExecuteNonQuery();
            XtraMessageBox.Show("Database BackUp has been created successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void barButtonDataLoad_ItemClick(object sender, ItemClickEventArgs e)
        {
            BackupForm bkf = new BackupForm();
            bkf.ShowDialog();
        }
    }
}