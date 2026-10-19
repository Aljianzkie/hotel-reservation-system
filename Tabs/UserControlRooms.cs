using hotel_reservation_system.Card;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hotel_reservation_system.Tabs
{
    public partial class UserControlRooms : UserControl
    {
        public UserControlRooms()
        {
            InitializeComponent();

            LoadRooms();
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        public void LoadRooms(string search = "")
        {
            flowRooms.Controls.Clear();

            DatabaseManager db = new DatabaseManager();

            string sql = @"
                SELECT Id, Room_Number, Room_Type, Price, Status, Image_Path
                FROM rooms
                WHERE Room_Number LIKE @search
                   OR Room_Type LIKE @search
                   OR Status LIKE @search
                ORDER BY Room_Number";

            var parameters = new Dictionary<string, object>
            {
                { "@search", "%" + search + "%" }
            };

            DataTable rooms = db.ExecuteQueryWithParams(sql, parameters);

            foreach (DataRow row in rooms.Rows)
            {
                RoomCard card = new RoomCard();

                card.SetRoom(
                    Convert.ToInt32(row["Id"]),
                    row["Room_Number"].ToString(),
                    row["Room_Type"].ToString(),
                    Convert.ToDecimal(row["Price"]),
                    row["Status"].ToString(),
                    row["Image_Path"].ToString()
                );

                flowRooms.Controls.Add(card);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRooms(txtSearch.Text);
        }
    }
}
