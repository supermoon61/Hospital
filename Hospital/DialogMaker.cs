using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Hospital.Model;

namespace EducareSMS.Control
{
    public partial class DialogMaker : DevExpress.XtraEditors.XtraUserControl
    {
        public DialogMaker()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            HospitalContext dbContext = new HospitalContext();
            var user = dbContext.Users.Where(s => s.UserName == UserNameTextEdit.Text && s.Password == PasswordTextEdit.Text && s.Role == 1).FirstOrDefault();
            if (dxValidationProvider.Validate() && (user != null))
            {
                UserNameTextEdit.ResetBackColor();
                PasswordTextEdit.ResetBackColor();
                this.ParentForm.DialogResult = DialogResult.OK;
            }
            else
            {
                UserNameTextEdit.BackColor = Color.Red;
                PasswordTextEdit.BackColor = Color.Red;
            }
        }
    }
}
