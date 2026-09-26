using hotel_reservation_system.Pages;

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
    }
}
