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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Presentation
{
    public partial class Minu : Form
    {
        ProductService product = new ProductService();
        int userId;
        string UserName;
        public Minu(int _userId, string _UserName)
        {
            InitializeComponent();
            userId = _userId;
            UserName = _UserName;

        }

        private void Minu_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkRed;
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (ALL.BackColor == Color.Gainsboro)
            {
                //Un Checked
                ALL.BackColor = Color.DarkRed;
                Pizza.BackColor = Color.Gainsboro;
                Burger.BackColor = Color.Gainsboro;
                Dessert.BackColor = Color.Gainsboro;
                var productData = product.getProducts();
                dgv.DataSource = productData;
            }
            else
            {
                // Checked
                ALL.BackColor = Color.Gainsboro;
                dgv.DataSource = null;
            }
        }
        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (Pizza.BackColor == Color.Gainsboro)
            {
                //Un Checked
                Pizza.BackColor = Color.DarkRed;
                ALL.BackColor = Color.Gainsboro;
                Burger.BackColor = Color.Gainsboro;
                Dessert.BackColor = Color.Gainsboro;
                var productData = product.getProductCategort("Pizza");
                dgv.DataSource = productData;
            }
            else
            {
                // Checked
                Pizza.BackColor = Color.Gainsboro;
                dgv.DataSource = null;
            }
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            if (Dessert.BackColor == Color.Gainsboro)
            {
                //Un Checked
                Dessert.BackColor = Color.DarkRed;
                ALL.BackColor = Color.Gainsboro;
                Burger.BackColor = Color.Gainsboro;
                Pizza.BackColor = Color.Gainsboro;
                var productData = product.getProductCategort("Dessert");
                dgv.DataSource = productData;
            }
            else
            {
                // Checked
                Dessert.BackColor = Color.Gainsboro;
                dgv.DataSource = null;
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (Burger.BackColor == Color.Gainsboro)
            {
                //Un Checked
                Burger.BackColor = Color.DarkRed;
                ALL.BackColor = Color.Gainsboro;
                Dessert.BackColor = Color.Gainsboro;
                Pizza.BackColor = Color.Gainsboro;
                var productData = product.getProductCategort("Burger");
                dgv.DataSource = productData;
            }
            else
            {
                // Checked
                Burger.BackColor = Color.Gainsboro;
                dgv.DataSource = null;
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {



        }
        int productid;
        private void dgv_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            productid = (int)dgv.SelectedRows[0].Cells["Prod_Id"].Value;
            var productData = product.getOneProduct(productid);
            Text_product.Text = productData.Name.ToString();
            Text_Category.Text = productData.Ctg_Name.ToString();

        }

        private void All_guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void Button_Fav_Click(object sender, EventArgs e)
        {
            var productData = product.AddProductFavourite(userId, productid);
            if (productData > 0)
            {
                MessageBox.Show("Product Added to Fav Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Text_product.Text = "";
                Text_Category.Text = "";

                var Added = product.getFavProduct(userId);
                dgv.DataSource = Added;

            }
            else
            {
                MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User(userId , UserName).Show();

        }
    }
}
