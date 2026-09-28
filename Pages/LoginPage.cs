using hotel_reservation_system.Pages;
using PhilippineFoodFestival;

namespace hotel_reservation_system
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpPage signup = new SignUpPage();
            signup.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input all fields");
                return;
            }

            Authenticator auth = new Authenticator();

            if (auth.AdminLogin(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Login Successfully");
                DashboardPage dashboard = new DashboardPage();
                this.Hide();
                dashboard.ShowDialog();
                this.Show();

                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
