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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            loginComponent1.StaffID = Int32.Parse(staffID.Text);
            loginComponent1.Password = password.Text;

            if (loginComponent1.Verification())
            {
                //Go to manage form panel
            }        
        }
    }
}
