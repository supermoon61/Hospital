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
using System.Data.Entity;

namespace Hospital
{
    public partial class EditPatient : DevExpress.XtraEditors.XtraForm
    {
        HospitalContext dbContext = new HospitalContext();
        private MainForm ptList;
        public EditPatient(int pid, MainForm mf)
        {
            ptList = mf;
            InitializeComponent();
            dbContext.Patients.LoadAsync().ContinueWith(loadTask =>
            {
                patientBindingSource.DataSource = dbContext.Patients.Where(s => s.PID == pid).ToList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider.Validate())
            {
                    if (XtraMessageBox.Show("Do you really want to change Fee Data", "Save Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                    {
                        patientBindingSource.EndEdit();
                        dbContext.SaveChanges();
                        ptList.RefreshGrid();
                        
                    }
                
            }
        }
    }
}