using Hospital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    class Login
    {
        HospitalContext dbContext = new HospitalContext();

        public bool AuthUser(string usrName, string usrPassword)
        {

            if (usrName != string.Empty && usrPassword != string.Empty)
            {
                //Check if user with given username exist?
                var userExist = dbContext.Users.FirstOrDefault(a => a.UserName.Equals(usrName));
                if (userExist != null)//if exist then check password match or not?
                {
                    if (userExist.Password.Equals(usrPassword))
                    {
                        GlobalValue.CUserId = userExist.UID;
                        GlobalValue.CUserName = userExist.Name;
                        GlobalValue.CEmail = userExist.Email;
                        GlobalValue.CRole = Convert.ToInt32(userExist.Role);

                        return (true);
                    }

                    else
                    {
                        MessageBox.Show("Password mismatch");
                        return (false);
                    }

                }
                else
                {

                    MessageBox.Show("User not found");
                    return (false);
                }

            }
            else
            {
                MessageBox.Show("Insert fields");
                return (false);
            }

        }

    }
}
