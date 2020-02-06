using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            createEmployee1.AddToDB(txtName, txtSurname, txtNumber, txtEmail, txtStreet, txtCity, txtCounty, txtPostcode);            
        }
    }
}
