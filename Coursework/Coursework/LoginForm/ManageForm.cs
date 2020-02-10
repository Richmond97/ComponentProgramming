using Component_A_ClassLibrary;
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
            ArrangePanels();
            BtnCreate_Click();

            cbxDept.DataSource = Enum.GetValues(typeof(DepartmentType));
            cbxRole.DataSource = Enum.GetValues(typeof(Roletype));
        }

        private void ArrangePanels()
        {
            createPanel.Location = new Point(0, 37);
            editPanel.Location = new Point(0, 37);

            createPanel.Size = new Size(851, 443);
            editPanel.Size = new Size(851, 443);
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            createPanel.Visible = true;
            btnCreate.BackColor = Color.DarkGray;
            btnEdit.BackColor = Color.White;
            btnDelete.BackColor = Color.White;

            editPanel.Visible = false;
        }

        private void BtnCreate_Click()
        {
            createPanel.Visible = true;
            btnCreate.BackColor = Color.DarkGray;
            btnEdit.BackColor = Color.White;
            btnDelete.BackColor = Color.White;

            editPanel.Visible = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            editPanel.Visible = true;
            btnCreate.BackColor = Color.White;
            btnEdit.BackColor = Color.DarkGray;
            btnDelete.BackColor = Color.White;

            createPanel.Visible = false;
            btnEditEmploy.Show();
            btnDeleteEmploy.Hide();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            editPanel.Visible = true;
            btnCreate.BackColor = Color.White;
            btnEdit.BackColor = Color.White;
            btnDelete.BackColor = Color.DarkGray;

            createPanel.Visible = false;
            btnEditEmploy.Hide();
            btnDeleteEmploy.Show();

        }


        private void BtnCreateEmploy_Click(object sender, EventArgs e)
        {
            createEmployee1.AddToDB(txtName, txtSurname, txtNumber, txtEmail, txtStreet, txtCity, txtCounty, txtPostcode, cbxDept, cbxRole);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            editEmployee1.searchEmployee(dataGridView1, txtSearch);
        }

        private void BtnDeleteEmploy_Click(object sender, EventArgs e)
        {
            deleteEmployee1.DeleteStaff(dataGridView1);

            editEmployee1.searchEmployee(dataGridView1, txtSearch);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!= null)
            {                
                deleteEmployee1.PopulateTxtBox(dataGridView1, e, txtEFirst, txtELast, txtETele, txtEEmail, txtEStreet, txtECity, txtECounty, txtEPost);
            }
            editPanel.Update();
        }

        private void BtnEditEmploy_Click(object sender, EventArgs e)
        {
            editEmployee1.editEmployee(dataGridView1, txtEFirst, txtELast, txtETele, txtEEmail, txtEStreet, txtECity, txtECounty, txtEPost);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {

           // DialogResult dialogResult = MessageBox.Show("Log Out", "Please Confirm Your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question;

            if ((MessageBox.Show("Log Out", "Please Confirm Your Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                this.Dispose();
                LoginForm login = new LoginForm();
                login.Show();

            }

            //DialogResult dialogResult = MessageBox.Show("Log Out", "Please Confirm Your Action", MessageBoxButtons., MessageBoxIcon.Question);
            


        }
    }
}
