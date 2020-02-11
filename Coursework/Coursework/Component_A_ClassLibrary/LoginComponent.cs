using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Windows.Forms;

namespace Component_A_ClassLibrary
{
    public partial class LoginComponent : Component
    {
        private int staffID = 0;
        private string password = "";

        // Connection to the DataBase and access to entity classes
        DataClasses1DataContext db = new DataClasses1DataContext();
        


        public LoginComponent()
        {
            InitializeComponent();
        }

        public LoginComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public int StaffID { get => staffID; set => staffID = value; }
        public string Password { get => password; set => password = value; }


        // Verification Method for both Admin and Staff
        public bool Verification()
        {
            long someQuery;
            try
            {   
                Console.WriteLine(db.Connection);

                // Query to find matching staffid and password in DB
                var verQuery = from a in db.employees
                               where a.StaffID == StaffID && a.Password == Password
                               select a.EmployeeID;
                              

                var quer = verQuery.ToList();
                someQuery = quer.ElementAtOrDefault(0);

                Console.WriteLine("Query successfully");

                if (verQuery.Any())
                {
                    // If any query has an object call auth method
                    Console.WriteLine("User Exists in DB");
                    return Authentication(someQuery);              
                }
                else
                {
                    // Else check the staffid exists
                    var userQuery = (from b in db.employees
                                     where b.StaffID == StaffID
                                     select b);
                    //Console.WriteLine(db.GetCommand(userQuery).CommandText);

                    if (userQuery.Any())
                    {
                        Console.WriteLine("User Exists in DB, Wrong Password");
                        //popup box
                        MessageBox.Show("User Exists in DB, Wrong Password");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("User Does Not Exist, Please contact Admin");
                        //pop up box
                        MessageBox.Show("User Does Not Exist, Please contact Admin");
                        return false;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //pop up box
                MessageBox.Show($"{e}");
                throw;
            }               

        }

        public bool Authentication(long employID)
        {
            try
            {
                //DataClasses1DataContext db = new DataClasses1DataContext();

                var joinQuery = from r in db.roles
                                where r.employee.EmployeeID == employID
                                select r;
                Console.WriteLine(db.GetCommand(joinQuery).CommandText);

                var singleQuery = joinQuery.Single();

                if (singleQuery.RoleType == "Admin")
                {
                    MessageBox.Show("Admin has logged in successfully");
                    
                    return true;
                }
                else
                {
                    MessageBox.Show("Unauthorised Access Denied");
                    return false;
                }

            }
            catch (Exception)
            {

                throw;
            }        


            
        }

    }
}
