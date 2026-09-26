using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hotel_reservation_system.Pages
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input all fields");
                return;
            }

            UsersManager manager = new UsersManager();
            Users user = new Users(0, txtUsername.Text, txtPassword.Text);

            manager.SignUpUser(user);

            txtUsername.Clear();
            txtPassword.Clear();

            txtUsername.Focus();
        }
    }
}
