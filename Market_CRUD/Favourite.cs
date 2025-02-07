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
    public partial class Favourite : Form
    {
        ProductService product = new ProductService();
        int userId;
        string UserName;
        public Favourite(int _userId, string _UserName)
        {
            userId = _userId;
            UserName = _UserName;
            InitializeComponent();
        }

        private void Favourite_Load(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            var data = productService.getFavProduct(userId);
            dgv.DataSource = data;
            dgv.Columns[4].Visible = false;
            dgv.Columns[0].Visible = false;
        }
        

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new User(userId, UserName).Show();

        }

        private void Button_Fav_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            var data = productService.DeleteProductFavourite(userId,productid);
            if (data>0)
            {
                MessageBox.Show("Product Deleted from Fav Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Text_product.Text = "";
                Text_Category.Text = "";

                
                var DeletedFat = productService.getFavProduct(userId);
                dgv.DataSource = DeletedFat;
                dgv.Columns[4].Visible = false;
                dgv.Columns[0].Visible = false;

            }
            else
            {
                MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int productid;
        private void dgv_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            productid = (int)dgv.SelectedRows[0].Cells["Id"].Value;
            var productData = product.getOneProduct(productid);
            Text_product.Text = productData.Name.ToString();
            Text_Category.Text = productData.Ctg_Name.ToString();
        }
    }
}
