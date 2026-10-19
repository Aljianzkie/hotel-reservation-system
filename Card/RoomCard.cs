using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace hotel_reservation_system.Card
{
    public partial class RoomCard : UserControl
    {
        public RoomCard()
        {
            InitializeComponent();
        }

        public void SetRoom(
            int roomId,
            string roomNumber,
            string roomType,
            decimal price,
            string status,
            string imagePath)
        {
            lblRoomNumber.Text = roomNumber;
            lblRoomType.Text = roomType;
            lblPrice.Text = "Room Price per night: ₱" + price.ToString("N2");
            lblStatus.Text = "Status: " + status;

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                picRoom.Image = Image.FromFile(imagePath);
            }
            else
            {
                picRoom.Image = null;
            }
        }
    }
}
