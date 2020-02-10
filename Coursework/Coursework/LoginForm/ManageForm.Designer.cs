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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditEmploy = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnDeleteEmploy = new System.Windows.Forms.Button();
            this.createEmployee1 = new Component_A_ClassLibrary.CreateEmployee(this.components);
            this.editEmployee1 = new Component_A_ClassLibrary.EditEmployee(this.components);
            this.deleteEmployee1 = new Component_A_ClassLibrary.DeleteEmployee(this.components);
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
            this.createPanel.Location = new System.Drawing.Point(23, 71);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(150, 138);
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
            this.label7.Location = new System.Drawing.Point(355, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
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
            this.label6.Location = new System.Drawing.Point(355, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
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
            this.label8.Location = new System.Drawing.Point(355, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
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
            this.label5.Location = new System.Drawing.Point(355, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Postcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telephone number";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(567, 111);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 6;
            this.label26.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(567, 62);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(62, 13);
            this.label25.TabIndex = 5;
            this.label25.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
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
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(284, 37);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "ADD EMPLOYEE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEdit.Location = new System.Drawing.Point(283, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(284, 37);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "EDIT EMPLOYEE";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(567, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(284, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "DELETE EMPLOYEE";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            this.editPanel.Controls.Add(this.textBox1);
            this.editPanel.Controls.Add(this.label10);
            this.editPanel.Controls.Add(this.textBox2);
            this.editPanel.Controls.Add(this.label11);
            this.editPanel.Controls.Add(this.textBox3);
            this.editPanel.Controls.Add(this.label12);
            this.editPanel.Controls.Add(this.label13);
            this.editPanel.Controls.Add(this.label14);
            this.editPanel.Controls.Add(this.label15);
            this.editPanel.Controls.Add(this.label16);
            this.editPanel.Controls.Add(this.textBox4);
            this.editPanel.Controls.Add(this.textBox5);
            this.editPanel.Controls.Add(this.textBox6);
            this.editPanel.Controls.Add(this.textBox7);
            this.editPanel.Controls.Add(this.textBox8);
            this.editPanel.Location = new System.Drawing.Point(62, 71);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(744, 417);
            this.editPanel.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(624, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(204, 239);
            this.dataGridView1.TabIndex = 40;
            // 
            // btnEditEmploy
            // 
            this.btnEditEmploy.Location = new System.Drawing.Point(140, 344);
            this.btnEditEmploy.Name = "btnEditEmploy";
            this.btnEditEmploy.Size = new System.Drawing.Size(109, 37);
            this.btnEditEmploy.TabIndex = 39;
            this.btnEditEmploy.Text = "EDIT";
            this.btnEditEmploy.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(140, 49);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(143, 20);
            this.txtSearch.TabIndex = 37;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(287, 49);
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
            this.label9.Location = new System.Drawing.Point(452, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "County";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(452, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Street address ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(452, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(452, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "City/Town";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(452, 210);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(452, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Postcode";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(140, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Email Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(140, 223);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Telephone number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(140, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Last name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(140, 125);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "First name ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(140, 293);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 20);
            this.textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(140, 244);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 20);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(140, 195);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 20);
            this.textBox6.TabIndex = 22;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(452, 328);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(150, 20);
            this.textBox7.TabIndex = 21;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(140, 146);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(150, 20);
            this.textBox8.TabIndex = 20;
            // 
            // btnDeleteEmploy
            // 
            this.btnDeleteEmploy.Location = new System.Drawing.Point(282, 344);
            this.btnDeleteEmploy.Name = "btnDeleteEmploy";
            this.btnDeleteEmploy.Size = new System.Drawing.Size(109, 37);
            this.btnDeleteEmploy.TabIndex = 39;
            this.btnDeleteEmploy.Text = "DELETE";
            this.btnDeleteEmploy.UseVisualStyleBackColor = true;
            this.btnDeleteEmploy.Click += new System.EventHandler(this.BtnDeleteEmploy_Click);
            // 
            // createEmployee1
            // 
            this.createEmployee1.FName = null;
            this.createEmployee1.LName = null;
            this.createEmployee1.TeleNumber = ((long)(0));
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(852, 480);
            this.Controls.Add(this.createPanel);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Name = "ManageForm";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnDeleteEmploy;
        private Component_A_ClassLibrary.CreateEmployee createEmployee1;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.ComboBox cbxDept;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Component_A_ClassLibrary.EditEmployee editEmployee1;
        private Component_A_ClassLibrary.DeleteEmployee deleteEmployee1;
    }
}