using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component_A_ClassLibrary
{
    public partial class EditEmployee : Component
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

        public EditEmployee(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void editemployee()
        {
            //look up employee on database with matching ID to query
            //based on employee.id

            if (true)
            {
                //if successful
            }

            //return deleted;
        }
    }
}
