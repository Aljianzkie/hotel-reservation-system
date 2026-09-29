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
            dataGridViewUser = new DataGridView();
            txtSearchUsername = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tabPageUpdateDeleteUser = new TabPage();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtPassword1 = new TextBox();
            label6 = new Label();
            txtUsername1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            tabControlUser.SuspendLayout();
            tabPageAddUser.SuspendLayout();
            tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            tabPageUpdateDeleteUser.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlUser
            // 
            tabControlUser.Alignment = TabAlignment.Bottom;
            tabControlUser.Anchor = AnchorStyles.None;
            tabControlUser.Controls.Add(tabPageAddUser);
            tabControlUser.Controls.Add(tabPageSearchUser);
            tabControlUser.Controls.Add(tabPageUpdateDeleteUser);
            tabControlUser.Location = new Point(18, 6);
            tabControlUser.Name = "tabControlUser";
            tabControlUser.SelectedIndex = 0;
            tabControlUser.Size = new Size(760, 351);
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
            tabPageAddUser.Size = new Size(752, 323);
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
            btnAddUser.Location = new Point(91, 183);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(100, 36);
            btnAddUser.TabIndex = 5;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += this.btnAddUser_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(437, 139);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(244, 23);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(437, 119);
            label3.Name = "label3";
            label3.Size = new Size(71, 16);
            label3.TabIndex = 3;
            label3.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(91, 139);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 23);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(91, 119);
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
            label1.Location = new Point(15, 6);
            label1.Name = "label1";
            label1.Size = new Size(78, 18);
            label1.TabIndex = 0;
            label1.Text = "Add User:";
            // 
            // tabPageSearchUser
            // 
            tabPageSearchUser.Controls.Add(dataGridViewUser);
            tabPageSearchUser.Controls.Add(txtSearchUsername);
            tabPageSearchUser.Controls.Add(label5);
            tabPageSearchUser.Controls.Add(label4);
            tabPageSearchUser.Location = new Point(4, 4);
            tabPageSearchUser.Name = "tabPageSearchUser";
            tabPageSearchUser.Padding = new Padding(3);
            tabPageSearchUser.Size = new Size(752, 323);
            tabPageSearchUser.TabIndex = 1;
            tabPageSearchUser.Text = "Search User";
            tabPageSearchUser.UseVisualStyleBackColor = true;
            tabPageSearchUser.Enter += tabPageSearchUser_Enter;
            tabPageSearchUser.Leave += tabPageSearchUser_Leave;
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.Anchor = AnchorStyles.None;
            dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUser.BorderStyle = BorderStyle.None;
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(15, 133);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.Size = new Size(716, 150);
            dataGridViewUser.TabIndex = 5;
            // 
            // txtSearchUsername
            // 
            txtSearchUsername.Anchor = AnchorStyles.None;
            txtSearchUsername.Location = new Point(15, 104);
            txtSearchUsername.Name = "txtSearchUsername";
            txtSearchUsername.Size = new Size(244, 23);
            txtSearchUsername.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label5.Location = new Point(15, 84);
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
            label4.Location = new Point(15, 9);
            label4.Name = "label4";
            label4.Size = new Size(99, 18);
            label4.TabIndex = 0;
            label4.Text = "Search User:";
            // 
            // tabPageUpdateDeleteUser
            // 
            tabPageUpdateDeleteUser.Controls.Add(btnDelete);
            tabPageUpdateDeleteUser.Controls.Add(btnUpdate);
            tabPageUpdateDeleteUser.Controls.Add(txtPassword1);
            tabPageUpdateDeleteUser.Controls.Add(label6);
            tabPageUpdateDeleteUser.Controls.Add(txtUsername1);
            tabPageUpdateDeleteUser.Controls.Add(label8);
            tabPageUpdateDeleteUser.Controls.Add(label7);
            tabPageUpdateDeleteUser.Location = new Point(4, 4);
            tabPageUpdateDeleteUser.Name = "tabPageUpdateDeleteUser";
            tabPageUpdateDeleteUser.Padding = new Padding(3);
            tabPageUpdateDeleteUser.Size = new Size(752, 323);
            tabPageUpdateDeleteUser.TabIndex = 2;
            tabPageUpdateDeleteUser.Text = "Update and Delete User";
            tabPageUpdateDeleteUser.UseVisualStyleBackColor = true;
            tabPageUpdateDeleteUser.Leave += tabPageUpdateDeleteUser_Leave;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(206, 178);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 36);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.RoyalBlue;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(91, 178);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 36);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // txtPassword1
            // 
            txtPassword1.Anchor = AnchorStyles.None;
            txtPassword1.Location = new Point(437, 134);
            txtPassword1.Name = "txtPassword1";
            txtPassword1.Size = new Size(244, 23);
            txtPassword1.TabIndex = 10;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label6.Location = new Point(437, 114);
            label6.Name = "label6";
            label6.Size = new Size(71, 16);
            label6.TabIndex = 9;
            label6.Text = "Password:";
            // 
            // txtUsername1
            // 
            txtUsername1.Anchor = AnchorStyles.None;
            txtUsername1.Location = new Point(91, 134);
            txtUsername1.Name = "txtUsername1";
            txtUsername1.Size = new Size(244, 23);
            txtUsername1.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.RoyalBlue;
            label8.Location = new Point(9, 3);
            label8.Name = "label8";
            label8.Size = new Size(187, 18);
            label8.TabIndex = 6;
            label8.Text = "Update and Delete User:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label7.Location = new Point(91, 114);
            label7.Name = "label7";
            label7.Size = new Size(75, 16);
            label7.TabIndex = 7;
            label7.Text = "Username:";
            // 
            // UserControlSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tabControlUser);
            Name = "UserControlSettings";
            Size = new Size(796, 366);
            tabControlUser.ResumeLayout(false);
            tabPageAddUser.ResumeLayout(false);
            tabPageAddUser.PerformLayout();
            tabPageSearchUser.ResumeLayout(false);
            tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            tabPageUpdateDeleteUser.ResumeLayout(false);
            tabPageUpdateDeleteUser.PerformLayout();
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
        private TabPage tabPageUpdateDeleteUser;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtPassword1;
        private Label label6;
        private TextBox txtUsername1;
        private Label label7;
        private Label label8;
    }
}
