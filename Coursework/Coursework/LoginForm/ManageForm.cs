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


        #region Panel and toolbar button settings
        private void ArrangePanels()
        {
            createPanel.Location = new Point(0, 37);
            editPanel.Location = new Point(0, 37);

            createPanel.Size = new Size(851, 443);
            editPanel.Size = new Size(851, 443);

            rdName.Checked = true;

            cbxDept.DataSource = Enum.GetValues(typeof(DepartmentType));
            cbxEDept.DataSource = Enum.GetValues(typeof(DepartmentType));

            cbxRole.DataSource = Enum.GetValues(typeof(Roletype));
            cbxERole.DataSource = Enum.GetValues(typeof(Roletype));
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            BtnCreate_Click();
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
            txtName.Text = String.Empty;
            txtSurname.Text = String.Empty;
            txtNumber.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtStreet.Text = String.Empty;
            txtCity.Text = String.Empty;
            txtCounty.Text = String.Empty;
            txtPostcode.Text = String.Empty;
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

        #endregion



        #region Action Button Functions
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            editEmployee1.SearchEmployee(dataGridView1, txtSearch,rdName);
        }

        private void BtnDeleteEmploy_Click(object sender, EventArgs e)
        {
            deleteEmployee1.DeleteStaff(dataGridView1);

            RefreshGrid();
        }              

        private void BtnEditEmploy_Click(object sender, EventArgs e)
        {
            editEmployee1.EditDetails(dataGridView1, txtEFirst, txtELast, txtETele, txtEEmail, txtEStreet, txtECity, txtECounty, txtEPost);
            dataGridView1.CurrentRow.Selected = false;

            ClearFields();


            RefreshGrid();
        }
                

        #endregion



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
                    PopulateTxtBox(dataGridView1, e, txtEFirst, txtELast, txtETele, txtEEmail, txtEStreet, txtECity, txtECounty, txtEPost,cbxEDept, cbxERole, txtEPassword, txtEDateJoined);
                }
                editPanel.Update();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                throw new ArgumentOutOfRangeException("Index parameter is out of range.", ex);
            }
        }

        public void PopulateTxtBox(DataGridView table, DataGridViewCellEventArgs e, TextBox firstNa, TextBox lastNa,
                                    TextBox telnumber, TextBox email, TextBox street, TextBox city, TextBox county,
                                    TextBox postcode, ComboBox dept, ComboBox role, TextBox password, TextBox dateJoined
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



            //dept.SelectedText = table.Rows[e.RowIndex].Cells["Department"].FormattedValue.ToString();
            //role.SelectedText = table.Rows[e.RowIndex].Cells["Role"].FormattedValue.ToString();



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

        public void ClearFields()
        {
            txtEFirst.Text = String.Empty;
            txtELast.Text = String.Empty;
            txtETele.Text = String.Empty;
            txtEEmail.Text = String.Empty;
            txtEStreet.Text = String.Empty;
            txtECity.Text = String.Empty;
            txtECounty.Text = String.Empty;
            txtEPost.Text = String.Empty;
            txtEPassword.Text = String.Empty;
            txtEDateJoined.Text = String.Empty;
        }

        public void RefreshGrid()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void ChbxDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxDetails.Checked)
            {
                cbxEDept.Enabled = true;
                cbxERole.Enabled = true;
                txtEPassword.Enabled = true;
            }
            else
            {
                cbxEDept.Enabled = false;
                cbxERole.Enabled = false;
                txtEPassword.Enabled = false;
            }
        }
    }
}
