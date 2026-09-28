namespace hotel_reservation_system.Pages
{
    partial class DashboardPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panelSlide = new Panel();
            btnReservation = new Button();
            btnRoom = new Button();
            btnClient = new Button();
            btnDashboard = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lblUsername = new Label();
            label4 = new Label();
            panel4 = new Panel();
            lblDateTime = new Label();
            btnLogout = new Button();
            panel5 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(panelSlide);
            panel1.Controls.Add(btnReservation);
            panel1.Controls.Add(btnRoom);
            panel1.Controls.Add(btnClient);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 606);
            panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.Location = new Point(38, 275);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(11, 45);
            panelSlide.TabIndex = 0;
            // 
            // btnReservation
            // 
            btnReservation.FlatStyle = FlatStyle.Flat;
            btnReservation.ForeColor = Color.White;
            btnReservation.Location = new Point(38, 433);
            btnReservation.Margin = new Padding(3, 4, 3, 4);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(285, 45);
            btnReservation.TabIndex = 4;
            btnReservation.Text = "Reservation";
            btnReservation.UseVisualStyleBackColor = true;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnRoom
            // 
            btnRoom.FlatStyle = FlatStyle.Flat;
            btnRoom.ForeColor = Color.White;
            btnRoom.Location = new Point(38, 380);
            btnRoom.Margin = new Padding(3, 4, 3, 4);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(285, 45);
            btnRoom.TabIndex = 3;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnClient
            // 
            btnClient.FlatStyle = FlatStyle.Flat;
            btnClient.ForeColor = Color.White;
            btnClient.Location = new Point(38, 327);
            btnClient.Margin = new Padding(3, 4, 3, 4);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(285, 45);
            btnClient.TabIndex = 2;
            btnClient.Text = "Client";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(38, 275);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(285, 45);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 160);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(124, 115);
            label3.Name = "label3";
            label3.Size = new Size(94, 28);
            label3.TabIndex = 0;
            label3.Text = "System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 84);
            label2.Name = "label2";
            label2.Size = new Size(212, 28);
            label2.TabIndex = 0;
            label2.Text = "Hotel Reservation";
            // 
            // panel3
            // 
            panel3.BackColor = Color.RoyalBlue;
            panel3.Controls.Add(lblUsername);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(339, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(886, 160);
            panel3.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(116, 104);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(21, 23);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 104);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 1;
            label4.Text = "Welcome:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblDateTime);
            panel4.Controls.Add(btnLogout);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(886, 78);
            panel4.TabIndex = 0;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.ForeColor = Color.RoyalBlue;
            lblDateTime.Location = new Point(17, 37);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(18, 19);
            lblDateTime.TabIndex = 0;
            lblDateTime.Text = "?";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(790, 37);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(84, 30);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(339, 558);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(886, 48);
            panel5.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 17);
            label1.Name = "label1";
            label1.Size = new Size(339, 18);
            label1.TabIndex = 0;
            label1.Text = "Copyright @ 2026, All Rights Reserved. Aniaaa";
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(339, 160);
            panel6.Name = "panel6";
            panel6.Size = new Size(886, 398);
            panel6.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // DashboardPage
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1225, 606);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardPage";
            Load += DashboardPage_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label1;
        private Label label2;
        private Button btnLogout;
        private Label label3;
        private Label label4;
        private Label lblDateTime;
        private Label lblUsername;
        private Button btnDashboard;
        private Button btnReservation;
        private Button btnRoom;
        private Button btnClient;
        private Panel panelSlide;
        private Panel panel6;
        private System.Windows.Forms.Timer timer1;
    }
}