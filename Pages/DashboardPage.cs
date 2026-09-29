namespace hotel_reservation_system.Pages
{
    public partial class DashboardPage : Form
    {
        public string Username;
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt");
        }

        private void DashboardPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblUsername.Text = Username;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(btnDashboard);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            MovePanel(btnClient);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            MovePanel(btnRoom);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            MovePanel(btnReservation);
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            MovePanel(btnUserSettings);
            userControlSettings1.Clear();
            userControlSettings1.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
