namespace LoginForm
{
    partial class ManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.createPanel = new System.Windows.Forms.Panel();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.cbxDept = new System.Windows.Forms.ComboBox();
            this.btnCreateEmploy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.editPanel = new System.Windows.Forms.Panel();
            this.btnDeleteEmploy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditEmploy = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtECounty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEStreet = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtECity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEEmail = new System.Windows.Forms.TextBox();
            this.txtETele = new System.Windows.Forms.TextBox();
            this.txtELast = new System.Windows.Forms.TextBox();
            this.txtEPost = new System.Windows.Forms.TextBox();
            this.txtEFirst = new System.Windows.Forms.TextBox();
            this.createEmployee1 = new Component_A_ClassLibrary.CreateEmployee(this.components);
            this.editEmployee1 = new Component_A_ClassLibrary.EditEmployee(this.components);
            this.deleteEmployee1 = new Component_A_ClassLibrary.DeleteEmployee(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.createPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // createPanel
            // 
            this.createPanel.Controls.Add(this.cbxRole);
            this.createPanel.Controls.Add(this.cbxDept);
            this.createPanel.Controls.Add(this.btnCreateEmploy);
            this.createPanel.Controls.Add(this.label7);
            this.createPanel.Controls.Add(this.txtCounty);
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Controls.Add(this.txtStreet);
            this.createPanel.Controls.Add(this.label8);
            this.createPanel.Controls.Add(this.txtCity);
            this.createPanel.Controls.Add(this.label5);
            this.createPanel.Controls.Add(this.label4);
            this.createPanel.Controls.Add(this.label3);
            this.createPanel.Controls.Add(this.label26);
            this.createPanel.Controls.Add(this.label2);
            this.createPanel.Controls.Add(this.label25);
            this.createPanel.Controls.Add(this.label1);
            this.createPanel.Controls.Add(this.txtEmail);
            this.createPanel.Controls.Add(this.txtNumber);
            this.createPanel.Controls.Add(this.txtSurname);
            this.createPanel.Controls.Add(this.txtPostcode);
            this.createPanel.Controls.Add(this.txtName);
            this.createPanel.Location = new System.Drawing.Point(9, 43);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(798, 428);
            this.createPanel.TabIndex = 0;
            // 
            // cbxRole
            // 
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(567, 133);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(121, 21);
            this.cbxRole.TabIndex = 40;
            // 
            // cbxDept
            // 
            this.cbxDept.FormattingEnabled = true;
            this.cbxDept.Location = new System.Drawing.Point(567, 84);
            this.cbxDept.Name = "cbxDept";
            this.cbxDept.Size = new System.Drawing.Size(121, 21);
            this.cbxDept.TabIndex = 40;
            // 
            // btnCreateEmploy
            // 
            this.btnCreateEmploy.Location = new System.Drawing.Point(371, 360);
            this.btnCreateEmploy.Name = "btnCreateEmploy";
            this.btnCreateEmploy.Size = new System.Drawing.Size(109, 37);
            this.btnCreateEmploy.TabIndex = 39;
            this.btnCreateEmploy.Text = "CREATE";
            this.btnCreateEmploy.UseVisualStyleBackColor = true;
            this.btnCreateEmploy.Click += new System.EventHandler(this.BtnCreateEmploy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(355, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "County";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(355, 202);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(150, 20);
            this.txtCounty.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(355, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Street address ";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(355, 84);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(150, 20);
            this.txtStreet.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(355, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "City/Town";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(355, 143);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(150, 20);
            this.txtCity.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(355, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Postcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(121, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(121, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telephone number";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(567, 111);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 16);
            this.label26.TabIndex = 6;
            this.label26.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(121, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(567, 62);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 16);
            this.label25.TabIndex = 5;
            this.label25.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(121, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "First name ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 231);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(121, 182);
            this.txtNumber.MaxLength = 11;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(150, 20);
            this.txtNumber.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(121, 133);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(150, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(355, 261);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(150, 20);
            this.txtPostcode.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCreate.Location = new System.Drawing.Point(-2, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(217, 37);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "ADD EMPLOYEE";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEdit.Location = new System.Drawing.Point(207, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(217, 37);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "EDIT EMPLOYEE";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDelete.Location = new System.Drawing.Point(421, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(217, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE EMPLOYEE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.btnDeleteEmploy);
            this.editPanel.Controls.Add(this.dataGridView1);
            this.editPanel.Controls.Add(this.btnEditEmploy);
            this.editPanel.Controls.Add(this.txtSearch);
            this.editPanel.Controls.Add(this.btnSearch);
            this.editPanel.Controls.Add(this.label9);
            this.editPanel.Controls.Add(this.txtECounty);
            this.editPanel.Controls.Add(this.label10);
            this.editPanel.Controls.Add(this.txtEStreet);
            this.editPanel.Controls.Add(this.label11);
            this.editPanel.Controls.Add(this.txtECity);
            this.editPanel.Controls.Add(this.label12);
            this.editPanel.Controls.Add(this.label13);
            this.editPanel.Controls.Add(this.label14);
            this.editPanel.Controls.Add(this.label15);
            this.editPanel.Controls.Add(this.label16);
            this.editPanel.Controls.Add(this.txtEEmail);
            this.editPanel.Controls.Add(this.txtETele);
            this.editPanel.Controls.Add(this.txtELast);
            this.editPanel.Controls.Add(this.txtEPost);
            this.editPanel.Controls.Add(this.txtEFirst);
            this.editPanel.Location = new System.Drawing.Point(665, 90);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(145, 116);
            this.editPanel.TabIndex = 4;
            // 
            // btnDeleteEmploy
            // 
            this.btnDeleteEmploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmploy.Location = new System.Drawing.Point(659, 316);
            this.btnDeleteEmploy.Name = "btnDeleteEmploy";
            this.btnDeleteEmploy.Size = new System.Drawing.Size(109, 37);
            this.btnDeleteEmploy.TabIndex = 39;
            this.btnDeleteEmploy.Text = "DELETE";
            this.btnDeleteEmploy.UseVisualStyleBackColor = true;
            this.btnDeleteEmploy.Click += new System.EventHandler(this.BtnDeleteEmploy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(436, 113);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // btnEditEmploy
            // 
            this.btnEditEmploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmploy.Location = new System.Drawing.Point(659, 242);
            this.btnEditEmploy.Name = "btnEditEmploy";
            this.btnEditEmploy.Size = new System.Drawing.Size(109, 37);
            this.btnEditEmploy.TabIndex = 39;
            this.btnEditEmploy.Text = "EDIT";
            this.btnEditEmploy.UseVisualStyleBackColor = true;
            this.btnEditEmploy.Click += new System.EventHandler(this.BtnEditEmploy_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(284, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(143, 20);
            this.txtSearch.TabIndex = 37;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(446, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 23);
            this.btnSearch.TabIndex = 36;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(371, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "County";
            // 
            // txtECounty
            // 
            this.txtECounty.Location = new System.Drawing.Point(371, 312);
            this.txtECounty.Name = "txtECounty";
            this.txtECounty.Size = new System.Drawing.Size(150, 20);
            this.txtECounty.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(371, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Street address ";
            // 
            // txtEStreet
            // 
            this.txtEStreet.Location = new System.Drawing.Point(371, 214);
            this.txtEStreet.Name = "txtEStreet";
            this.txtEStreet.Size = new System.Drawing.Size(150, 20);
            this.txtEStreet.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(371, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "City / Town";
            // 
            // txtECity
            // 
            this.txtECity.Location = new System.Drawing.Point(371, 263);
            this.txtECity.Name = "txtECity";
            this.txtECity.Size = new System.Drawing.Size(150, 20);
            this.txtECity.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(368, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Postcode";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(79, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Email Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(79, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Telephone number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(79, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "Last name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(78, 187);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 17);
            this.label16.TabIndex = 25;
            this.label16.Text = "First name ";
            // 
            // txtEEmail
            // 
            this.txtEEmail.Location = new System.Drawing.Point(79, 361);
            this.txtEEmail.Name = "txtEEmail";
            this.txtEEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEEmail.TabIndex = 24;
            // 
            // txtETele
            // 
            this.txtETele.Location = new System.Drawing.Point(79, 312);
            this.txtETele.Name = "txtETele";
            this.txtETele.Size = new System.Drawing.Size(150, 20);
            this.txtETele.TabIndex = 23;
            // 
            // txtELast
            // 
            this.txtELast.Location = new System.Drawing.Point(79, 263);
            this.txtELast.Name = "txtELast";
            this.txtELast.Size = new System.Drawing.Size(150, 20);
            this.txtELast.TabIndex = 22;
            // 
            // txtEPost
            // 
            this.txtEPost.Location = new System.Drawing.Point(371, 361);
            this.txtEPost.Name = "txtEPost";
            this.txtEPost.Size = new System.Drawing.Size(150, 20);
            this.txtEPost.TabIndex = 21;
            // 
            // txtEFirst
            // 
            this.txtEFirst.Location = new System.Drawing.Point(79, 214);
            this.txtEFirst.Name = "txtEFirst";
            this.txtEFirst.Size = new System.Drawing.Size(150, 20);
            this.txtEFirst.TabIndex = 20;
            // 
            // createEmployee1
            // 
            this.createEmployee1.FName = null;
            this.createEmployee1.LName = null;
            this.createEmployee1.TeleNumber = ((long)(0));
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnLogout.Location = new System.Drawing.Point(636, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(217, 37);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(852, 480);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageForm";
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Button btnCreateEmploy;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Button btnEditEmploy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtECounty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEStreet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtECity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEEmail;
        private System.Windows.Forms.TextBox txtETele;
        private System.Windows.Forms.TextBox txtELast;
        private System.Windows.Forms.TextBox txtEPost;
        private System.Windows.Forms.TextBox txtEFirst;
        private System.Windows.Forms.Button btnDeleteEmploy;
        private Component_A_ClassLibrary.CreateEmployee createEmployee1;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.ComboBox cbxDept;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Component_A_ClassLibrary.EditEmployee editEmployee1;
        private Component_A_ClassLibrary.DeleteEmployee deleteEmployee1;
        private System.Windows.Forms.Button btnLogout;
    }
}