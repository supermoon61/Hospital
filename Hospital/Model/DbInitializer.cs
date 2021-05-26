using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Model
{
    class DBInitializer : CreateDatabaseIfNotExists<HospitalContext>
    {
        protected override void Seed(HospitalContext context)
        {
           

            //Add deafult User for database

            IList<User> defaultUser = new List<User>();
            defaultUser.Add(new User() { Name = "Osizone",  Email = "insided04@gmail.com", Password = "admin123", UserName = "osiadmin", Role = 1 });
            defaultUser.Add(new User() { Name = "Office Staff", Email = "chsingh61@gmail.com", Password = "manager321", UserName = "osimanager", Role = 2 });
            defaultUser.Add(new User() { Name = "Staff3", Email = "dawnstorm17@gmail.com", Password = "office786", UserName = "osioffice", Role = 3 });



            // Module Id 1 for Enquiry and Email or SMS category; 
            // Same for other Module

            context.Users.AddRange(defaultUser);
         
            base.Seed(context);
        }
    }

   
}
