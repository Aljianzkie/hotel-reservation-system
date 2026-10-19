namespace hotel_reservation_system.Card
{
    partial class RoomCard
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
            picRoom = new PictureBox();
            lblRoomNumber = new Label();
            lblRoomType = new Label();
            lblPrice = new Label();
            lblStatus = new Label();
            btnViewInfo = new Button();
            ((System.ComponentModel.ISupportInitialize)picRoom).BeginInit();
            SuspendLayout();
            // 
            // picRoom
            // 
            picRoom.Location = new Point(3, 3);
            picRoom.Name = "picRoom";
            picRoom.Size = new Size(342, 180);
            picRoom.SizeMode = PictureBoxSizeMode.Zoom;
            picRoom.TabIndex = 0;
            picRoom.TabStop = false;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(16, 205);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(96, 15);
            lblRoomNumber.TabIndex = 1;
            lblRoomNumber.Text = "lblRoomNumber";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(16, 242);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(77, 15);
            lblRoomType.TabIndex = 2;
            lblRoomType.Text = "lblRoomType";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(16, 284);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(46, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "lblPrice";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(16, 323);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "lblStatus";
            // 
            // btnViewInfo
            // 
            btnViewInfo.Location = new Point(16, 367);
            btnViewInfo.Name = "btnViewInfo";
            btnViewInfo.Size = new Size(96, 34);
            btnViewInfo.TabIndex = 5;
            btnViewInfo.Text = "View Info";
            btnViewInfo.UseVisualStyleBackColor = true;
            // 
            // RoomCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnViewInfo);
            Controls.Add(lblStatus);
            Controls.Add(lblPrice);
            Controls.Add(lblRoomType);
            Controls.Add(lblRoomNumber);
            Controls.Add(picRoom);
            Name = "RoomCard";
            Size = new Size(348, 428);
            ((System.ComponentModel.ISupportInitialize)picRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picRoom;
        private Label lblRoomNumber;
        private Label lblRoomType;
        private Label lblPrice;
        private Label lblStatus;
        private Button btnViewInfo;
    }
}
