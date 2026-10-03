namespace hotel_reservation_system.Tabs
{
    partial class UserControlSettings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlUser = new TabControl();
            tabPageAddUser = new TabPage();
            btnAddUser = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchUser = new TabPage();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtPassword1 = new TextBox();
            label6 = new Label();
            txtUsername1 = new TextBox();
            btnSearch = new Button();
            dataGridViewUser = new DataGridView();
            txtSearchUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tabControlUser.SuspendLayout();
            tabPageAddUser.SuspendLayout();
            tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            SuspendLayout();
            // 
            // tabControlUser
            // 
            tabControlUser.Alignment = TabAlignment.Bottom;
            tabControlUser.Anchor = AnchorStyles.None;
            tabControlUser.Controls.Add(tabPageAddUser);
            tabControlUser.Controls.Add(tabPageSearchUser);
            tabControlUser.Location = new Point(14, 19);
            tabControlUser.Name = "tabControlUser";
            tabControlUser.SelectedIndex = 0;
            tabControlUser.Size = new Size(974, 408);
            tabControlUser.TabIndex = 1;
            // 
            // tabPageAddUser
            // 
            tabPageAddUser.Controls.Add(btnAddUser);
            tabPageAddUser.Controls.Add(txtPassword);
            tabPageAddUser.Controls.Add(label3);
            tabPageAddUser.Controls.Add(txtUsername);
            tabPageAddUser.Controls.Add(label2);
            tabPageAddUser.Controls.Add(label1);
            tabPageAddUser.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            tabPageAddUser.Location = new Point(4, 4);
            tabPageAddUser.Name = "tabPageAddUser";
            tabPageAddUser.Padding = new Padding(3);
            tabPageAddUser.Size = new Size(1023, 387);
            tabPageAddUser.TabIndex = 0;
            tabPageAddUser.Text = "Add User";
            tabPageAddUser.UseVisualStyleBackColor = true;
            tabPageAddUser.Leave += tabPageAddUser_Leave;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.None;
            btnAddUser.BackColor = Color.RoyalBlue;
            btnAddUser.Cursor = Cursors.Hand;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(91, 206);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(100, 41);
            btnAddUser.TabIndex = 5;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(437, 158);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(244, 23);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(437, 134);
            label3.Name = "label3";
            label3.Size = new Size(71, 16);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(91, 158);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 23);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(91, 134);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(78, 18);
            label1.TabIndex = 0;
            label1.Text = "Add User:";
            // 
            // tabPageSearchUser
            // 
            tabPageSearchUser.Controls.Add(btnDelete);
            tabPageSearchUser.Controls.Add(btnUpdate);
            tabPageSearchUser.Controls.Add(txtPassword1);
            tabPageSearchUser.Controls.Add(label6);
            tabPageSearchUser.Controls.Add(txtUsername1);
            tabPageSearchUser.Controls.Add(btnSearch);
            tabPageSearchUser.Controls.Add(dataGridViewUser);
            tabPageSearchUser.Controls.Add(txtSearchUsername);
            tabPageSearchUser.Controls.Add(label5);
            tabPageSearchUser.Controls.Add(label4);
            tabPageSearchUser.Location = new Point(4, 4);
            tabPageSearchUser.Name = "tabPageSearchUser";
            tabPageSearchUser.Padding = new Padding(3);
            tabPageSearchUser.Size = new Size(966, 378);
            tabPageSearchUser.TabIndex = 1;
            tabPageSearchUser.Text = "Search User";
            tabPageSearchUser.UseVisualStyleBackColor = true;
            tabPageSearchUser.Leave += tabPageSearchUser_Leave;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.RoyalBlue;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(750, 321);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 41);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.RoyalBlue;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(606, 320);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 41);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtPassword1
            // 
            txtPassword1.Anchor = AnchorStyles.None;
            txtPassword1.Location = new Point(606, 245);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(244, 22);
            txtPassword1.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label6.Location = new Point(606, 224);
            label6.Name = "label6";
            label6.Size = new Size(71, 16);
            label6.TabIndex = 8;
            label6.Text = "Password:";
            // 
            // txtUsername1
            // 
            txtUsername1.Anchor = AnchorStyles.None;
            txtUsername1.Location = new Point(606, 173);
            txtUsername1.Name = "txtUsername1";
            txtUsername1.Size = new Size(244, 22);
            txtUsername1.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.BackColor = Color.RoyalBlue;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(274, 81);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(64, 28);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.Anchor = AnchorStyles.None;
            dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUser.BorderStyle = BorderStyle.None;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(24, 136);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.Size = new Size(469, 225);
            dataGridViewUser.TabIndex = 5;
            dataGridViewUser.CellClick += dataGridViewUser_CellClick;
            // 
            // txtSearchUsername
            // 
            txtSearchUsername.Anchor = AnchorStyles.None;
            txtSearchUsername.Location = new Point(24, 81);
            txtSearchUsername.Name = "txtSearchUsername";
            txtSearchUsername.Size = new Size(241, 22);
            txtSearchUsername.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label5.Location = new Point(606, 151);
            label5.Name = "label5";
            label5.Size = new Size(75, 16);
            label5.TabIndex = 3;
            label5.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(6, 3);
            label4.Name = "label4";
            label4.Size = new Size(99, 18);
            label4.TabIndex = 0;
            label4.Text = "Search User:";
            // 
            // UserControlSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tabControlUser);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlSettings";
            Size = new Size(1000, 461);
            tabControlUser.ResumeLayout(false);
            tabPageAddUser.ResumeLayout(false);
            tabPageAddUser.PerformLayout();
            tabPageSearchUser.ResumeLayout(false);
            tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlUser;
        private TabPage tabPageAddUser;
        private Button btnAddUser;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private TabPage tabPageSearchUser;
        private DataGridView dataGridViewUser;
        private TextBox txtSearchUsername;
        private Label label5;
        private Label label4;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtPassword1;
        private Label label6;
        private TextBox txtUsername1;
    }
}
