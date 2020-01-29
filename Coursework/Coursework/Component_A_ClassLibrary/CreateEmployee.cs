using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Component_A_ClassLibrary
{
    public partial class CreateEmployee : Component
    {
        public CreateEmployee()
        {
            InitializeComponent();
        }

        public CreateEmployee(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void createEmployee()
        {
            //look up employee on database with matching ID to query
            //based on employee.id
            //    var bd = new 

            //    if (true)
            //    {
            //        //if successful
            //    }

            //    string name = enam

            //        string namechanmge(name)
            //    {
            //        name = john;
            //    }

            //    return deleted;
  
        }
    }
}
