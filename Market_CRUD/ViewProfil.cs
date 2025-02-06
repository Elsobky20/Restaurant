using Business.Models;
using Business.Services;
using Market_CRUD.Models;
using Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_CRUD
{
    public partial class View_Profil : Form
    {
        int userId;
        string User_Name;

        public View_Profil(int _userId, string _UserName)
        {
            InitializeComponent();
            userId = _userId;
            User_Name = _UserName;
        }

        private void text_Passowrd_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewProfil_Load(object sender, EventArgs e)
        {
            getUser();

        }
        public void getUser()
        {
            UserService userService = new UserService();
            UserVM myUser = userService.GetUserById(userId);
            text_Name.Text = myUser.Name;
            text_email.Text = myUser.Email;
            text_Passowrd.Text = myUser.Password;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            UserVM userVM = new UserVM();

            userVM.Name = text_Name.Text;
            userVM.Email = text_email.Text;
            userVM.Password = text_Passowrd.Text;
            userVM.ID = userId;


            if (userService.UpdateUser(userVM) > 0)
            {
                MessageBox.Show("Usert data Updated Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getUser();
            }
            else
            {
                MessageBox.Show("Error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Presentation.User(userId, User_Name).Show();
        }
    }
}
