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
            panelSlide.Parent = btn.Parent;
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
            panelSlide.BringToFront();
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
            userControlSettings1.Hide();
            userSettingsLabel.Visible = false;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            MovePanel(btnClient);
            userControlSettings1.Hide();
            userSettingsLabel.Visible = false;
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            MovePanel(btnRoom);
            userControlSettings1.Hide();
            userSettingsLabel.Visible = false;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            MovePanel(btnReservation);
            userControlSettings1.Hide();
            userSettingsLabel.Visible = false;
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            MovePanel(btnUserSettings);
            userControlSettings1.Clear();
            userControlSettings1.Show();
            userSettingsLabel.Visible = true;
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
