namespace hotel_reservation_system.Tabs
{
    public partial class UserControlSettings : UserControl
    {
        public UserControlSettings()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }

        public void Clear1()
        {
            txtUsername1.Clear();
            txtPassword1.Clear();
            tabControlUser.SelectedTab = tabPageUpdateDeleteUser;
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            //txtSearchUsername.Clear();
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            txtSearchUsername.Clear();
        }

        private void tabPageUpdateDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
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
