using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Component_A_ClassLibrary
{
    public partial class CreateEmployee : Component
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        private string fName;
        private string lName;
        private long teleNumber;

        public CreateEmployee()
        {
            InitializeComponent();
        }

        public CreateEmployee(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public long TeleNumber { get => teleNumber; set => teleNumber = value; }
        
        //enum roletype {Head, DeputyHead, Manager, Apprentice, JuniorMember, SeniorMember }
        //enum departType {Engineering, Plumbing, Roofing, Carpentry, Bricklaying, Office }

        
      public void AddToDB(TextBox firstNa, TextBox lastNa, TextBox telnumber,TextBox email, TextBox street, TextBox city, TextBox county, TextBox postcode, ComboBox typeDept, ComboBox typeRole)
        {
            try
            {
                //look up employee on database with matching ID to query
                //based on employee.id
                // Query to find matching staffid and password in DB
                var verQuery = from a in db.employees
                               where a.FirstName == firstNa.Text  && a.LastName == lastNa.Text
                               select a;
                
                Console.WriteLine("Query successfully");

                if (verQuery.Any())
                {
                    firstNa.Text = String.Empty;
                    lastNa.Text = String.Empty;
                    telnumber.Text = String.Empty;
                    email.Text = String.Empty;
                    street.Text = String.Empty;
                    city.Text = String.Empty;
                    county.Text = String.Empty;
                    postcode.Text = String.Empty;
                    MessageBox.Show("Employee Already Exists In DB");
                }
                else
                {
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

                    firstNa.Text = String.Empty;
                    lastNa.Text = String.Empty;
                    telnumber.Text = String.Empty;
                    email.Text = String.Empty;
                    street.Text = String.Empty;
                    city.Text = String.Empty;
                    county.Text = String.Empty;
                    postcode.Text = String.Empty;
                }

            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                MessageBox.Show($"{e}");
                throw;
            }  
        }

        private long IDcreation()
        {
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

        
    }
}
