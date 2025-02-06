using Market_CRUD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Presentation
{
    public partial class User : Form
    {
        int userId;
        string UserName;

        public User(int _userId, string _UserName)
        {
            userId = _userId;
            UserName = _UserName;
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            label1.Text += UserName;
        }

        private void btn_Minu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Minu(userId, UserName).Show();

        }

        private void btn_Fav_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Favourite(userId, UserName).Show();

        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new View_Profil(userId, UserName).Show();
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
