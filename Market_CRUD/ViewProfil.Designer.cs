namespace Market_CRUD
{
    partial class View_Profil
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            labelName = new Label();
            text_Name = new TextBox();
            btn_Update = new Button();
            text_Passowrd = new TextBox();
            text_email = new TextBox();
            UserName = new Label();
            guna2GradientTileButton2 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(labelName);
            panel1.Controls.Add(text_Name);
            panel1.Controls.Add(btn_Update);
            panel1.Controls.Add(text_Passowrd);
            panel1.Controls.Add(text_email);
            panel1.Location = new Point(99, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 467);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 168);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 108);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(5, 53);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 5;
            labelName.Text = "Name";
            // 
            // text_Name
            // 
            text_Name.Cursor = Cursors.IBeam;
            text_Name.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_Name.Location = new Point(94, 47);
            text_Name.Name = "text_Name";
            text_Name.Size = new Size(221, 30);
            text_Name.TabIndex = 3;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.DarkRed;
            btn_Update.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Update.ForeColor = Color.White;
            btn_Update.Location = new Point(28, 303);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(287, 54);
            btn_Update.TabIndex = 2;
            btn_Update.Text = "Update";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // text_Passowrd
            // 
            text_Passowrd.Location = new Point(94, 168);
            text_Passowrd.Name = "text_Passowrd";
            text_Passowrd.Size = new Size(221, 27);
            text_Passowrd.TabIndex = 1;
            text_Passowrd.UseSystemPasswordChar = true;
            text_Passowrd.TextChanged += text_Passowrd_TextChanged;
            // 
            // text_email
            // 
            text_email.Cursor = Cursors.IBeam;
            text_email.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text_email.Location = new Point(94, 102);
            text_email.Name = "text_email";
            text_email.Size = new Size(221, 30);
            text_email.TabIndex = 0;
            // 
            // UserName
            // 
            UserName.AutoSize = true;
            UserName.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserName.ForeColor = Color.White;
            UserName.Location = new Point(189, 50);
            UserName.Name = "UserName";
            UserName.Size = new Size(0, 70);
            UserName.TabIndex = 3;
            // 
            // guna2GradientTileButton2
            // 
            guna2GradientTileButton2.BackColor = Color.DarkRed;
            guna2GradientTileButton2.CustomizableEdges = customizableEdges1;
            guna2GradientTileButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientTileButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientTileButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientTileButton2.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientTileButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientTileButton2.FillColor = Color.Silver;
            guna2GradientTileButton2.FillColor2 = Color.DarkGray;
            guna2GradientTileButton2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2GradientTileButton2.ForeColor = Color.DarkRed;
            guna2GradientTileButton2.Location = new Point(456, 32);
            guna2GradientTileButton2.Name = "guna2GradientTileButton2";
            guna2GradientTileButton2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientTileButton2.Size = new Size(79, 42);
            guna2GradientTileButton2.TabIndex = 25;
            guna2GradientTileButton2.Text = ">";
            guna2GradientTileButton2.Click += guna2GradientTileButton2_Click;
            // 
            // View_Profil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(561, 703);
            Controls.Add(guna2GradientTileButton2);
            Controls.Add(panel1);
            Controls.Add(UserName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "View_Profil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewProfile";
            Load += ViewProfil_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox text_Name;
        private Button btn_Update;
        private TextBox text_Passowrd;
        private TextBox text_email;
        private Label UserName;
        private Label label3;
        private Label label2;
        private Label labelName; // Update this part
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton2;
    }
}
