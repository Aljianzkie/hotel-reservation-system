namespace hotel_reservation_system.Tabs
{
    partial class UserControlRooms
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
            txtSearch = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            flowRooms = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(18, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(229, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Search Rooms";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 64);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowRooms);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 397);
            panel2.TabIndex = 5;
            // 
            // flowRooms
            // 
            flowRooms.AutoScroll = true;
            flowRooms.Dock = DockStyle.Fill;
            flowRooms.Location = new Point(0, 0);
            flowRooms.Name = "flowRooms";
            flowRooms.Padding = new Padding(10);
            flowRooms.Size = new Size(1000, 397);
            flowRooms.TabIndex = 0;
            // 
            // UserControlRooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "UserControlRooms";
            Size = new Size(1000, 461);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearch;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowRooms;
    }
}
