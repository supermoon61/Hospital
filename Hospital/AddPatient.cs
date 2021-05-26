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
    public partial class AddPatient : DevExpress.XtraEditors.XtraForm
    {
        private HospitalContext dbContext;
        private MainForm ptList;
        public AddPatient(MainForm mf)
        {
            InitializeComponent();
            ptList = mf;
            dbContext = new HospitalContext();
            dbContext.Patients.Load();

           patientBindingSource.DataSource = dbContext.Patients.Local.ToBindingList();
            patientBindingSource.AddNew();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do You Want To Close Patient Form ?", "Question Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
            {
                this.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider.Validate())
            {
                if (XtraMessageBox.Show("Do You Want To Save Student Data To Database ?", "Save Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    SaveStudent();
                    this.Close();
                }
            }
        }

        private void SaveStudent()
        {
            Patient patient = patientBindingSource.Current as Patient;
            patient.CreatedAt = DateTime.Today;
            patientBindingSource.EndEdit();
            dbContext.SaveChanges();
            TostNotify.SaveNotify();
            //studentList.RefreshGrid();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider.Validate())
            {
                if (XtraMessageBox.Show("Do You Want To Save Student Data and Create New One ?", "Save Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
                {
                    SaveStudent();
                    ptList.RefreshGrid();
                    this.Close();
                    
                }
            }
        }
    }
}