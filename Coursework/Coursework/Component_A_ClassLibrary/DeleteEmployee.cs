using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component_A_ClassLibrary
{
    
    public partial class DeleteEmployee : Component
    {
        private readonly DataClasses1DataContext db = new DataClasses1DataContext();

        
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

                    db.SubmitChanges();

                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e}"); 
                    throw;
                }


            }
                                                                               
        }




    }
}
