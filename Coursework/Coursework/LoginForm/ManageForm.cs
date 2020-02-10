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
            btnEdit.BackColor = Color.Transparent;
            btnDelete.BackColor = Color.Transparent;

            editPanel.Visible = false;
        }

        private void BtnCreate_Click()
        {
            createPanel.Visible = true;
            btnCreate.BackColor = Color.DarkGray;
            btnEdit.BackColor = Color.Transparent;
            btnDelete.BackColor = Color.Transparent;

            editPanel.Visible = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            editPanel.Visible = true;
            btnCreate.BackColor = Color.Transparent;
            btnEdit.BackColor = Color.DarkGray;
            btnDelete.BackColor = Color.Transparent;

            createPanel.Visible = false;
            btnEditEmploy.Show();
            btnDeleteEmploy.Hide();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            editPanel.Visible = true;
            btnCreate.BackColor = Color.Transparent;
            btnEdit.BackColor = Color.Transparent;
            btnDelete.BackColor = Color.DarkGray;

            createPanel.Visible = false;
            btnEditEmploy.Hide();
            btnDeleteEmploy.Show();

        }


        private void BtnCreateEmploy_Click(object sender, EventArgs e)
        {
            createEmployee1.AddToDB(txtName, txtSurname, txtNumber, txtEmail, txtStreet, txtCity, txtCounty, txtPostcode);
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
    }
}
