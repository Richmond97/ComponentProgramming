using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                   var  varQueryName =   (from a in db.employees
                                      where String.IsNullOrWhiteSpace(searchQ.Text) && a.FirstName != "admin"
                                      || a.FirstName.Contains(searchQ.Text.Trim()) && a.FirstName != "admin"
                                          select a).ToList();

                    table.DataSource = varQueryName;
                }
                else
                {
                   var  varQueryID = (from a in db.employees
                                      where String.IsNullOrWhiteSpace(searchQ.Text) && a.StaffID != 111111
                                      || a.StaffID.ToString().Contains(searchQ.Text.Trim()) && a.StaffID != 111111
                                      select a).ToList();

                    table.DataSource = varQueryID;
                }

                // Remove unneeded columns 
                table.Columns["EmployeeID"].Visible = false;
                table.Columns["Password"].Visible = false;
                table.Columns["Address"].Visible = false;
                table.Columns["EmailAddress"].Visible = false;
                table.Columns["Telephone"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }     
        }


        public void EditDetails(DataGridView table, TextBox firstNa, TextBox lastNa,
                                TextBox telnumber, TextBox email, TextBox street, 
                                TextBox city, TextBox county, TextBox postcode
                                    )
        {
            // Change details for a selected emolyee
            var Selected = table[0, table.SelectedRows[0].Index].Value.ToString();

            try
            {
                var result = (from p in db.employees
                                 where p.EmployeeID == Convert.ToInt64(Selected)
                                 select p);

                //save change to the database
                if ((MessageBox.Show("Save changes", "Please Confirm Your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    foreach (var field in result)
                    {
                        field.FirstName = firstNa.Text;
                        field.LastName = lastNa.Text;
                        field.Telephone = telnumber.Text;
                        field.EmailAddress = email.Text;
                        field.Address = (street.Text + "-" + city.Text + "-" + county.Text + "-" + postcode.Text);
                    }

                    db.SubmitChanges();

                    //firstNa.Text = "";
                    //lastNa.Text = "";
                    //telnumber.Text = "";
                    //email.Text = "";
                    //street.Text = "";
                    //city.Text = "";
                    //county.Text = "";
                    //postcode.Text = "";

                    //table.CurrentRow.Selected = false;
                }
               

            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
                throw;
            }
                                  
        }
        
    }
}
