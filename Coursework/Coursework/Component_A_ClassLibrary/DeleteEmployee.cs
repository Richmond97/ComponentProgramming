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
    
    public partial class DeleteEmployee : Component
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        public DeleteEmployee(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void DeleteStaff(DataGridView table)
        {
            //string deletedID = table[0, table.SelectedRows[0].Index].Value.ToString();

            if (table.SelectedRows.Count > 0)
            {
                string deletedID = table[0, table.SelectedRows[0].Index].Value.ToString();
                
                try
                {
                    var varQueryDelete = (from a in db.employees
                                          where a.EmployeeID == Convert.ToInt64(deletedID)
                                          select a);

                    var company = db.employees.FirstOrDefault(c => c.EmployeeID == Convert.ToInt64(deletedID));



                    db.employees.DeleteOnSubmit(company);

                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e}"); 
                    throw;
                }

                try
                {
                    db.SubmitChanges();

                }
                catch (Exception)
                {

                    throw;
                }

                //table.Refresh();

            }
                                                                               
        }

        public void PopulateTxtBox(DataGridView table, DataGridViewCellEventArgs e, TextBox firstNa, TextBox lastNa,
                                    TextBox telnumber, TextBox email, TextBox street, TextBox city, TextBox county,
                                    TextBox postcode, TextBox password, TextBox dateJoined
                                    )
        {

            table.CurrentRow.Selected = true;
            firstNa.Text = table.Rows[e.RowIndex].Cells["FirstName"].FormattedValue.ToString();
            lastNa.Text = table.Rows[e.RowIndex].Cells["LastName"].FormattedValue.ToString();
            telnumber.Text = table.Rows[e.RowIndex].Cells["Telephone"].FormattedValue.ToString();
            email.Text = table.Rows[e.RowIndex].Cells["EmailAddress"].FormattedValue.ToString();
            street.Text = Split(table.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString(), 0);
            city.Text = Split(table.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString(), 1);
            county.Text = Split(table.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString(), 2);
            postcode.Text = Split(table.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString(), 3);
            password.Text = table.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();
            dateJoined.Text = table.Rows[e.RowIndex].Cells["DateJoined"].FormattedValue.ToString();

        }

        public string Split(string address, int index)
        {
            if (String.IsNullOrEmpty(address))
            {

            }
            try
            {
                string[] words = address.Split('-');
                return words[index];

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
                throw e;
            }
            
        }


    }
}
