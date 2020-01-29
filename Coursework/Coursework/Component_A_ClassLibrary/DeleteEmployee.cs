using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component_A_ClassLibrary
{
    
    public partial class DeleteEmployee : Component
    {

       



        public DeleteEmployee()
        {
            InitializeComponent();
        }

        public DeleteEmployee(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public bool DeleteStaff(int staffID)
        {
            bool deleted = true;
            //remove them from the database
            //based on employee.id

            if (true)
            {
                //if successful
            }

            return deleted;
        }
        
        
    }
}
