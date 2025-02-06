namespace Presentation
{
    partial class User
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            btn_Minu = new Button();
            btn_Fav = new Button();
            guna2GradientTileButton2 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            btn_Profile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(12, 117);
            label1.Name = "label1";
            label1.Size = new Size(197, 42);
            label1.TabIndex = 20;
            label1.Text = "Welcome,  ";
            // 
            // btn_Minu
            // 
            btn_Minu.BackColor = Color.DarkRed;
            btn_Minu.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Minu.ForeColor = Color.White;
            btn_Minu.Location = new Point(155, 402);
            btn_Minu.Name = "btn_Minu";
            btn_Minu.Size = new Size(265, 42);
            btn_Minu.TabIndex = 21;
            btn_Minu.Text = "Menu";
            btn_Minu.UseVisualStyleBackColor = false;
            btn_Minu.Click += btn_Minu_Click;
            // 
            // btn_Fav
            // 
            btn_Fav.BackColor = Color.DarkRed;
            btn_Fav.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Fav.ForeColor = Color.White;
            btn_Fav.Location = new Point(155, 535);
            btn_Fav.Name = "btn_Fav";
            btn_Fav.Size = new Size(265, 42);
            btn_Fav.TabIndex = 22;
            btn_Fav.Text = "Favourite";
            btn_Fav.UseVisualStyleBackColor = false;
            btn_Fav.Click += btn_Fav_Click;
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
            guna2GradientTileButton2.Location = new Point(455, 41);
            guna2GradientTileButton2.Name = "guna2GradientTileButton2";
            guna2GradientTileButton2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientTileButton2.Size = new Size(79, 42);
            guna2GradientTileButton2.TabIndex = 24;
            guna2GradientTileButton2.Text = ">";
            guna2GradientTileButton2.Click += guna2GradientTileButton2_Click;
            // 
            // btn_Profile
            // 
            btn_Profile.BackColor = Color.DarkRed;
            btn_Profile.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Profile.ForeColor = Color.White;
            btn_Profile.Location = new Point(155, 279);
            btn_Profile.Name = "btn_Profile";
            btn_Profile.Size = new Size(265, 42);
            btn_Profile.TabIndex = 25;
            btn_Profile.Text = "View Profile";
            btn_Profile.UseVisualStyleBackColor = false;
            btn_Profile.Click += btn_Profile_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(579, 750);
            Controls.Add(btn_Profile);
            Controls.Add(guna2GradientTileButton2);
            Controls.Add(btn_Fav);
            Controls.Add(btn_Minu);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += User_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Minu;
        private Button btn_Fav;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton2;
        private Button btn_Profile;
    }
}