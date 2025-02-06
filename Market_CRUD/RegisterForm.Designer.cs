namespace Presentation
{
    partial class RegisterForm
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
            panel1 = new Panel();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            label2 = new Label();
            link_SignUp = new LinkLabel();
            btnRegister = new Button();
            txtFullName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(link_SignUp);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(txtFullName);
            panel1.Location = new Point(131, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 406);
            panel1.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(51, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(221, 30);
            txtEmail.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(51, 146);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter password";
            txtPassword.Size = new Size(221, 27);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(51, 202);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm password";
            txtConfirmPassword.Size = new Size(221, 27);
            txtConfirmPassword.TabIndex = 7;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(51, 343);
            label2.Name = "label2";
            label2.Size = new Size(153, 17);
            label2.TabIndex = 6;
            label2.Text = "Do you have account?";
            // 
            // link_SignUp
            // 
            link_SignUp.AutoSize = true;
            link_SignUp.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            link_SignUp.LinkBehavior = LinkBehavior.HoverUnderline;
            link_SignUp.LinkColor = Color.DarkRed;
            link_SignUp.Location = new Point(207, 341);
            link_SignUp.Name = "link_SignUp";
            link_SignUp.Size = new Size(54, 19);
            link_SignUp.TabIndex = 5;
            link_SignUp.TabStop = true;
            link_SignUp.Text = "Log in";
            link_SignUp.LinkClicked += link_SignUp_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.DarkRed;
            btnRegister.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(73, 266);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(168, 42);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // txtFullName
            // 
            txtFullName.Cursor = Cursors.IBeam;
            txtFullName.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(51, 30);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Name";
            txtFullName.Size = new Size(221, 30);
            txtFullName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(170, 65);
            label1.Name = "label1";
            label1.Size = new Size(269, 70);
            label1.TabIndex = 3;
            label1.Text = "Register";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(579, 750);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private LinkLabel link_SignUp;
        private Button btnRegister;
        private TextBox txtFullName;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtEmail;
    }
}