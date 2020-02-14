using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Component_A_ClassLibrary
{
    public partial class CreateEmployee : Component
    {
        private readonly DataClasses1DataContext db = new DataClasses1DataContext();

        public CreateEmployee()
        {
            InitializeComponent();
        }

        public CreateEmployee(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

      public void AddToDB(TextBox firstNa, TextBox lastNa, TextBox telnumber,TextBox email, TextBox street, TextBox city, TextBox county, TextBox postcode, ComboBox typeDept, ComboBox typeRole)
        {
            try
            {
                // Query to find matching staffid and password in DB
                var verQuery = from a in db.employees
                               where a.FirstName == firstNa.Text  && a.LastName == lastNa.Text
                               select a;

                if (verQuery.Any())
                {
                    MessageBox.Show("Employee Already Exists In DB");
                }
                else
                {
                    // Create a new employlee object
                    employee addedEmployee = new employee();
                    addedEmployee.FirstName = firstNa.Text;
                    addedEmployee.LastName = lastNa.Text;
                    addedEmployee.Password = firstNa.Text;
                    addedEmployee.Telephone = telnumber.Text;
                    addedEmployee.EmailAddress = email.Text;
                    addedEmployee.Address = (street.Text + "-" + city.Text + "-" + county.Text + "-" + postcode.Text);
                    addedEmployee.DateJoined = DateTime.Today.Date;
                    addedEmployee.StaffID = IDcreation();
                    Console.WriteLine(" today date is " + DateTime.Today.Date);

                    // Add the Dept and Role to the employee
                    role addedRole = new role();
                    addedRole.RoleType = typeRole.Text;

                    department addedDept = new department();
                    addedDept.DeptName = typeDept.Text;

                    addedEmployee.departments.Add(addedDept);
                    addedEmployee.roles.Add(addedRole);

                    //Add new Employee to database
                    db.employees.InsertOnSubmit(addedEmployee);

                    //Save changes to Database.
                    db.SubmitChanges();

                    MessageBox.Show("Employee Added To DB");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }  
        }

        private long IDcreation()
        {
            // Creates a 6 digit staffID number which has not been used before
            long verifiedID;
            Random random = new Random();
            verifiedID = random.Next(100000, 999999);

            var verQuery = from a in db.employees
                               where a.StaffID == verifiedID
                               select a;

            if (verQuery.Any())
            {
                IDcreation();
            }

            return verifiedID;
        }

         public bool ValidEmail(string email)
        {
            try
            {
                MailAddress correctEmail = new MailAddress(email);
                return correctEmail.Address == email;
            }
            catch
            {
                return false;
            }
        }




    }
}
