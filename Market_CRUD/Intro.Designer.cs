namespace Presentation
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            label1 = new Label();
            label2 = new Label();
            btn_getStarted = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(229, 58);
            label1.Name = "label1";
            label1.Size = new Size(120, 40);
            label1.TabIndex = 1;
            label1.Text = "Enjoy ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(186, 116);
            label2.Name = "label2";
            label2.Size = new Size(185, 40);
            label2.TabIndex = 2;
            label2.Text = "Your Food";
            // 
            // btn_getStarted
            // 
            btn_getStarted.BackColor = Color.White;
            btn_getStarted.FlatAppearance.BorderSize = 30;
            btn_getStarted.FlatStyle = FlatStyle.Popup;
            btn_getStarted.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_getStarted.ForeColor = Color.DarkRed;
            btn_getStarted.Location = new Point(99, 600);
            btn_getStarted.Name = "btn_getStarted";
            btn_getStarted.Size = new Size(360, 50);
            btn_getStarted.TabIndex = 3;
            btn_getStarted.Text = "Get Started";
            btn_getStarted.UseVisualStyleBackColor = false;
            btn_getStarted.Click += btn_getStarted_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(99, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 350);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Intro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(579, 750);
            Controls.Add(pictureBox1);
            Controls.Add(btn_getStarted);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Intro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Intro";
            Load += Intro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private Label label2;
        private Button btn_getStarted;
        private PictureBox pictureBox1;
    }
}