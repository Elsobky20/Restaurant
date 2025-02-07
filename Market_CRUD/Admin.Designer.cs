namespace Presentation
{
    partial class Admin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            splitContainer1 = new SplitContainer();
            btn_logout = new Button();
            btn_Catigory = new Button();
            btn_Products = new Button();
            numericUpDown_price = new NumericUpDown();
            btn_Delete = new Button();
            btn_Edit = new Button();
            btn_Add = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox_Category = new ComboBox();
            textBox_name = new TextBox();
            dataGridView1 = new DataGridView();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(guna2ImageButton1);
            splitContainer1.Panel1.Controls.Add(btn_logout);
            splitContainer1.Panel1.Controls.Add(btn_Catigory);
            splitContainer1.Panel1.Controls.Add(btn_Products);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.DarkRed;
            splitContainer1.Panel2.Controls.Add(numericUpDown_price);
            splitContainer1.Panel2.Controls.Add(btn_Delete);
            splitContainer1.Panel2.Controls.Add(btn_Edit);
            splitContainer1.Panel2.Controls.Add(btn_Add);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(comboBox_Category);
            splitContainer1.Panel2.Controls.Add(textBox_name);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(579, 750);
            splitContainer1.SplitterDistance = 100;
            splitContainer1.TabIndex = 0;
            // 
            // btn_logout
            // 
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_logout.ForeColor = Color.DarkRed;
            btn_logout.Location = new Point(6, 548);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 29);
            btn_logout.TabIndex = 2;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_Catigory
            // 
            btn_Catigory.FlatAppearance.BorderSize = 0;
            btn_Catigory.FlatStyle = FlatStyle.Flat;
            btn_Catigory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_Catigory.ForeColor = Color.DarkRed;
            btn_Catigory.Location = new Point(6, 255);
            btn_Catigory.Name = "btn_Catigory";
            btn_Catigory.Size = new Size(94, 29);
            btn_Catigory.TabIndex = 1;
            btn_Catigory.Text = "Catigory";
            btn_Catigory.UseVisualStyleBackColor = true;
            btn_Catigory.Click += btn_Catigory_Click;
            // 
            // btn_Products
            // 
            btn_Products.FlatAppearance.BorderSize = 0;
            btn_Products.FlatStyle = FlatStyle.Flat;
            btn_Products.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_Products.ForeColor = Color.DarkRed;
            btn_Products.Location = new Point(6, 162);
            btn_Products.Name = "btn_Products";
            btn_Products.Size = new Size(94, 29);
            btn_Products.TabIndex = 0;
            btn_Products.Text = "Products";
            btn_Products.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_price
            // 
            numericUpDown_price.Location = new Point(198, 150);
            numericUpDown_price.Name = "numericUpDown_price";
            numericUpDown_price.Size = new Size(192, 27);
            numericUpDown_price.TabIndex = 13;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.White;
            btn_Delete.FlatAppearance.BorderColor = Color.DarkRed;
            btn_Delete.FlatAppearance.BorderSize = 0;
            btn_Delete.FlatAppearance.CheckedBackColor = Color.DarkRed;
            btn_Delete.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btn_Delete.ForeColor = Color.DarkRed;
            btn_Delete.Location = new Point(303, 316);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(87, 29);
            btn_Delete.TabIndex = 11;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.White;
            btn_Edit.FlatAppearance.BorderColor = Color.DarkRed;
            btn_Edit.FlatAppearance.BorderSize = 0;
            btn_Edit.FlatAppearance.CheckedBackColor = Color.DarkRed;
            btn_Edit.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btn_Edit.ForeColor = Color.DarkRed;
            btn_Edit.Location = new Point(83, 316);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(87, 29);
            btn_Edit.TabIndex = 10;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.FlatAppearance.BorderColor = Color.DarkRed;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatAppearance.CheckedBackColor = Color.DarkRed;
            btn_Add.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            btn_Add.ForeColor = Color.DarkRed;
            btn_Add.Location = new Point(198, 316);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(87, 29);
            btn_Add.TabIndex = 9;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(83, 225);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 8;
            label3.Text = "Category ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(83, 150);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 7;
            label2.Text = "Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(83, 70);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // comboBox_Category
            // 
            comboBox_Category.FormattingEnabled = true;
            comboBox_Category.Location = new Point(198, 222);
            comboBox_Category.Name = "comboBox_Category";
            comboBox_Category.Size = new Size(192, 28);
            comboBox_Category.TabIndex = 5;
            comboBox_Category.SelectedIndexChanged += comboBox_Category_SelectedIndexChanged;
            // 
            // textBox_name
            // 
            textBox_name.BorderStyle = BorderStyle.None;
            textBox_name.Location = new Point(198, 69);
            textBox_name.Name = "textBox_name";
            textBox_name.PlaceholderText = "Product Name";
            textBox_name.Size = new Size(192, 20);
            textBox_name.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 427);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(450, 276);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = Market_CRUD.Properties.Resources.images;
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.Location = new Point(12, 12);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ImageButton1.Size = new Size(80, 68);
            guna2ImageButton1.TabIndex = 3;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 750);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_price).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Button btn_logout;
        private Button btn_Catigory;
        private Button btn_Products;
        private Button btn_Delete;
        private Button btn_Edit;
        private Button btn_Add;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox_Category;
        private TextBox textBox_name;
        private NumericUpDown numericUpDown_price;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}