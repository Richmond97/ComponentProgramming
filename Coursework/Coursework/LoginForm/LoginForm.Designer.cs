namespace LoginForm
{
    partial class LoginForm
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.staffID = new System.Windows.Forms.TextBox();
            this.loginComponent1 = new Component_A_ClassLibrary.LoginComponent(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.SystemColors.Info;
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.Title);
            this.LoginPanel.Controls.Add(this.btnLogin);
            this.LoginPanel.Controls.Add(this.password);
            this.LoginPanel.Controls.Add(this.staffID);
            this.LoginPanel.Location = new System.Drawing.Point(110, 7);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(580, 437);
            this.LoginPanel.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(228, 124);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(110, 36);
            this.Title.TabIndex = 3;
            this.Title.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(247, 333);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(203, 275);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(159, 20);
            this.password.TabIndex = 1;
            // 
            // staffID
            // 
            this.staffID.Location = new System.Drawing.Point(203, 226);
            this.staffID.Name = "staffID";
            this.staffID.Size = new System.Drawing.Size(159, 20);
            this.staffID.TabIndex = 0;
            // 
            // loginComponent1
            // 
            this.loginComponent1.Password = null;
            this.loginComponent1.StaffID = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Staff ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password : ";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 462);
            this.Controls.Add(this.LoginPanel);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox staffID;
        private Component_A_ClassLibrary.LoginComponent loginComponent1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

