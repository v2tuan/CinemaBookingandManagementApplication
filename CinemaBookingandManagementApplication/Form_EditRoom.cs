using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
using CinemaBookingandManagementApplication.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication
{
    public partial class Form_EditRoom : Form
    {
        public Room room;
        public Form_EditRoom(Room room)
        {
            InitializeComponent();
            this.room = room;
            textBoxCinemaName.Text = room.Rname;
        }

        private void Form_EditRoom_Load(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanelSeat.Controls.Clear();
                RoomDaoImpl roomDaoImpl = new RoomDaoImpl();
                DataTable dt = roomDaoImpl.GetSeatsByRoomId(room.Rid);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        UserControl_Seat userControl_Seat = new UserControl_Seat();
                        Seat seat = new Seat();
                        seat.SeatId = int.Parse(dr["seatid"].ToString());
                        seat.Rid = dr["rid"].ToString();
                        seat.States = int.Parse(dr["states"].ToString());
                        seat.Snumber = dr["snumber"].ToString();
                        seat.Srow = dr["srow"].ToString();
                        userControl_Seat.seat = seat;
                        //userControl_Seat.setNumberSeat(int.Parse(seat.Snumber));

                        flowLayoutPanelSeat.Controls.Add(userControl_Seat);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            RoomDaoImpl roomDaoImpl = new RoomDaoImpl();
            room.Rname = textBoxCinemaName.Text;
            roomDaoImpl.update(room);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RoomDaoImpl roomDaoImpl = new RoomDaoImpl();
            roomDaoImpl.delete(room);
        }
    }
}
