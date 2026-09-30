using System.Data;

namespace hotel_reservation_system.Tabs
{
    public partial class UserControlSettings : UserControl
    {
        private int currentRowIndex = 0;
        private int curUserId = 0;

        public UserControlSettings()
        {
            InitializeComponent();
            LoadTable();
        }

        // Add User tab functionality
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

            LoadTable();
        }

        // Search User tab functionality
        private void btnSearch_Click(object sender, EventArgs e)
        {
            UsersManager manager = new UsersManager();

            DataTable dataTable = manager.SearchUser(txtSearchUsername.Text.Trim());

            if (dataTable.Rows.Count > 0)
            {
                dataGridViewUser.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("No records found");
            }
        }

        public void LoadTable()
        {
            UsersManager users = new UsersManager();

            DataTable dataTable = users.GetUsers();

            currentRowIndex = 0;

            dataGridViewUser.DataSource = dataTable;
            dataGridViewUser.Columns["Id"].Visible = false;
            dataGridViewUser.ReadOnly = true;
            dataGridViewUser.AllowUserToAddRows = false;

            if (dataTable.Rows.Count > 0)
            {
                currentRowIndex = 0;
                LoadFromGrid(currentRowIndex);
            }
            else
            {
                MessageBox.Show("No users found.");
            }
        }

        private void LoadFromGrid(int index)
        {
            if (index >= 0 && index < dataGridViewUser.Rows.Count)
            {
                DataGridViewRow row = dataGridViewUser.Rows[index];

                // Select the current row
                dataGridViewUser.ClearSelection();
                row.Selected = true;

                // Get User ID
                curUserId = Convert.ToInt32(row.Cells["Id"].Value);
                // Load username
                txtUsername1.Text = row.Cells["Username"].Value.ToString();
                // Load password
                txtPassword1.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentRowIndex = e.RowIndex;

                LoadFromGrid(currentRowIndex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UsersManager users = new UsersManager();

            Users user = new Users(0, txtUsername1.Text, txtPassword1.Text);

            if (users.UpdateUser(curUserId, user))
            {
                MessageBox.Show("Updated Successfully!");
                LoadTable();
            }
            else
            {
                MessageBox.Show("Failed to Update");
            }
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

            tabControlUser.SelectedTab = tabPageSearchUser;
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UsersManager users = new UsersManager();

            if (users.DeleteUser(curUserId))
            {
                MessageBox.Show("Delete SuccessFully");
                LoadTable();
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }
    }
}
