using Business.Models;
using Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

            GetAllProducts();
            CategoryService categoryService = new CategoryService();
            var categoryData = categoryService.getCategory();
            comboBox_Category.DataSource = categoryData;
            comboBox_Category.ValueMember = "Id";
            comboBox_Category.DisplayMember = "Name";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this student", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ProductService productService = new ProductService();
                if (productService.DeleteProduct(id) > 0)
                {

                    MessageBox.Show("Product Deleted Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_name.Text = "";
                    numericUpDown_price.Value = 0;
                    GetAllProducts();
                }
                else
                {
                    MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {



        }
        public void GetAllProducts()
        {
            ProductService productService = new ProductService();
            var productData = productService.getProducts();
            dataGridView1.DataSource = productData;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ProductVM productVM = new ProductVM();
            productVM.Name = textBox_name.Text;
            productVM.Price = (int)numericUpDown_price.Value;
            productVM.Ctg_Id = (int)comboBox_Category.SelectedValue;

            ProductService product = new ProductService();

            if (product.AddProduct(productVM) > 0)
            {
                MessageBox.Show("Product Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_name.Text = "";
                numericUpDown_price.Value = 0;
                GetAllProducts();
            }
            else
            {
                MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void comboBox_Category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            ProductVM productVM = new ProductVM();
            productVM.ID = id;
            productVM.Name = textBox_name.Text;
            productVM.Price = (int)numericUpDown_price.Value;
            productVM.Ctg_Id = (int)(comboBox_Category.SelectedValue);
            if (productService.UpdateProduct(productVM) > 0)
            {
                MessageBox.Show("Product Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_name.Text = "";
                numericUpDown_price.Value = 0;
                GetAllProducts();
            }
            else
            {
                MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int id;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            textBox_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            numericUpDown_price.Value =(int) dataGridView1.SelectedRows[0].Cells[3].Value;
            comboBox_Category.SelectedValue = dataGridView1.SelectedRows[0].Cells[4].Value;
           
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btn_Catigory_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin_Category().Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
