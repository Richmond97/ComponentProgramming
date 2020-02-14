using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace Component_A_ClassLibrary
{
    public partial class EditEmployee : Component 
    {
        private readonly DataClasses1DataContext db = new DataClasses1DataContext();
        

        public EditEmployee()
        {
            InitializeComponent();            
        }

        public EditEmployee(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        
        public void SearchEmployee(DataGridView table, TextBox searchQ, RadioButton searchName)
        {
            try
            {
                // Search based on whether the name radio button has been selected  
                if (searchName.Checked)
                {
                    var varQueryName = (from a in db.employees
                                        where String.IsNullOrWhiteSpace(searchQ.Text) && a.FirstName != "admin"
                                        || a.FirstName.Contains(searchQ.Text.Trim()) && a.FirstName != "admin"
                                        join b in db.departments on a.EmployeeID equals b.EmployeeID
                                        join c in db.roles on a.EmployeeID equals c.EmployeeID
                                        //select //a).ToList();
                                        select new
                                        {
                                            a.StaffID,
                                            a.FirstName,
                                            a.LastName, 
                                            Department = b.DeptName,
                                            Role = c.RoleType,
                                            a.DateJoined,
                                            a.Password,
                                            a.Address,
                                            a.EmailAddress,
                                            a.Telephone
                                        }).ToList();

                    table.DataSource = varQueryName;
                }
                else
                {
                   var  varQueryID = (from a in db.employees
                                      where String.IsNullOrWhiteSpace(searchQ.Text) && a.StaffID != 111111
                                      || a.StaffID.ToString().Contains(searchQ.Text.Trim()) && a.StaffID != 111111
                                      //select a).ToList();
                                        join b in db.departments on a.EmployeeID equals b.EmployeeID
                                        join c in db.roles on a.EmployeeID equals c.EmployeeID
                                        //select //a).ToList();
                                        select new
                                        {
                                            a.StaffID,
                                            a.FirstName,
                                            a.LastName,
                                            Department = b.DeptName,
                                            Role = c.RoleType,
                                            a.DateJoined,
                                            a.Password,
                                            a.Address,
                                            a.EmailAddress,
                                            a.Telephone
                                        }).ToList();

                    table.DataSource = varQueryID;
                }
                // Remove unneeded columns 
                //table.Columns["EmployeeID"].Visible = false;
                table.Columns["Password"].Visible = false;
                table.Columns["Address"].Visible = false;
                table.Columns["EmailAddress"].Visible = false;
                table.Columns["Telephone"].Visible = false;
                table.Columns["Department"].Visible = false;
                table.Columns["Role"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }     
        }


        public void EditDetails(DataGridView table, TextBox firstNa, TextBox lastNa,
                                TextBox telnumber, TextBox email, TextBox street, 
                                TextBox city, TextBox county, TextBox postcode,
                                ComboBox dept, ComboBox roletext)
        {
            // Change details for a selected emolyee
            var Selected = table[0, table.SelectedRows[0].Index].Value.ToString();

            try
            {
                var roleRes = (from r in db.roles
                               where r.EmployeeID == Convert.ToInt64(Selected)
                               select r).SingleOrDefault();

                var test = roleRes.EmployeeID;
                Console.WriteLine(test);

                var result = (from p in db.employees
                                 where p.EmployeeID == Convert.ToInt64(Selected)
                                 select p);

                //var result1 = from p in db.employees
                //              join d in db.departments on p.EmployeeID equals d.EmployeeID
                //              //join r in db.roles on p.EmployeeID equals r.EmployeeID 
                //              where p.EmployeeID == Convert.ToInt64(Selected)
                //              select new
                //              {
                //                  emp = p.EmployeeID,
                //                  fname = p.FirstName,
                //                  p.LastName, 
                //                  Department = d.DeptName,
                //                  //Role = r.RoleType,
                //                  p.DateJoined
                //              };



                var depRes = (from d in db.departments
                              where d.EmployeeID == Convert.ToInt64(Selected)
                              select d);

                //save change to the database
                if ((MessageBox.Show("Save changes", "Please Confirm Your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    foreach (var field in result)
                    {
                        var test2 = field.EmployeeID;
                        field.FirstName = firstNa.Text;
                        field.LastName = lastNa.Text;
                        field.Telephone = telnumber.Text;
                        field.EmailAddress = email.Text;
                        field.Address = (street.Text + "-" + city.Text + "-" + county.Text + "-" + postcode.Text);
                        
                        Console.WriteLine(test2);

                        //.departments.Remove(field.departments.First());

                        //department addedDept = new department();
                        //addedDept.DeptName = dept.Text;
                        //field.departments.Add(addedDept);

                        //field.roles.Remove(field.roles.First());
                        //role addedRole = new role();
                        //addedRole.RoleType = roletext.Text;
                        //field.roles.Add(addedRole);                                                                                          

                    }

                    //if (roleRes.Any())
                    //{
                    //    MessageBox.Show("found in role table");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("nothing found in role table");
                    //}
                    //foreach (var s in roleRes)
                    //{
                    //    Console.WriteLine("heloooo im working");
                    //    try
                    //    {
                    //        s.RoleType = roletext.Text;
                    //        Console.WriteLine(roletext.Text);
                    //    }
                    //    catch (Exception e)

                    //    {
                    //        MessageBox.Show($"{e}");
                    //        throw;
                    //    }
                    //}
                    foreach (var x in depRes)
                    {
                        x.DeptName = dept.Text;
                    }


                    db.SubmitChanges();

                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
                                  
        }


        //field.FirstName = firstNa.Text;
        //                field.LastName = lastNa.Text;
        //                field.Telephone = telnumber.Text;
        //                field.EmailAddress = email.Text;
        //                field.Address = (street.Text + "-" + city.Text + "-" + county.Text + "-" + postcode.Text);
        //public string FirstName
        //{
        //    get { return FirstName; }
        //    set { FirstName = value; }
        //}
        //public string Passvalue
        //{
        //    get { return Username; }
        //    set { Username = value; }
        //}
        //public string Passvalue
        //{
        //    get { return Username; }
        //    set { Username = value; }
        //}
        //public string Passvalue
        //{
        //    get { return Username; }
        //    set { Username = value; }
        //}
        //public string Passvalue
        //{
        //    get { return Username; }
        //    set { Username = value; }
        //}
        //public string Passvalue
        //{
        //    get { return Username; }
        //    set { Username = value; }
        //}

    }
}
