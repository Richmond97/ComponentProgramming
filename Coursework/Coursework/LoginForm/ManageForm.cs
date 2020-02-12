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

        private ManageForm()
        {
            InitializeComponent();
            ArrangePanels();
            BtnCreate_Click();

            cbxDept.DataSource = Enum.GetValues(typeof(DepartmentType));
            cbxRole.DataSource = Enum.GetValues(typeof(Roletype));
        }

        private static readonly object locker = new object();
        private static ManageForm instance = null;
        public static ManageForm Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ManageForm();
                    }
                    return instance;
                }
            }
        }

        private void ArrangePanels()
        {
            createPanel.Location = new Point(0, 37);
            editPanel.Location = new Point(0, 37);

            createPanel.Size = new Size(851, 443);
            editPanel.Size = new Size(851, 443);

            rdName.Checked = true;
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
            editEmployee1.searchEmployee(dataGridView1, txtSearch, rdID,rdName);
        }

        private void BtnDeleteEmploy_Click(object sender, EventArgs e)
        {
            deleteEmployee1.DeleteStaff(dataGridView1);
            dataGridView1.Update();
            dataGridView1.Refresh();

            //editEmployee1.searchEmployee(dataGridView1, txtSearch, rdID, rdName);
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // ignore header row and any column
                if (e.RowIndex == -1)  
                {
                    return;
                }
                else if (dataGridView1.CurrentCell.Value != null)
                {
                    PopulateTxtBox(dataGridView1, e, txtEFirst, txtELast, txtETele, txtEEmail, txtEStreet, txtECity, txtECounty, txtEPost, txtEPassword, txtEDateJoined);
                }
                editPanel.Update();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                throw new ArgumentOutOfRangeException("Index parameter is out of range.", ex);
            }            
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
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();    

            }

            //DialogResult dialogResult = MessageBox.Show("Log Out", "Please Confirm Your Action", MessageBoxButtons., MessageBoxIcon.Question);

            



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
            try
            {
                string[] words = address.Split('-');
                return words[index];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }

        }
    }
}
