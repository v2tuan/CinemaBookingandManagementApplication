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
    public partial class Form_AddRoom : Form
    {
        public string CinemaID {  get; set; }
        public Form_AddRoom()
        {
            InitializeComponent();
        }

        private void Form_AddRoom_Load(object sender, EventArgs e)
        {
            flowLayoutPanelSeat.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    UserControl_Seat userControl_Seat = new UserControl_Seat();
                    userControl_Seat.setNumberSeat(j + 1);
                    flowLayoutPanelSeat.Controls.Add(userControl_Seat);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            RoomDaoImpl RoomDao = new RoomDaoImpl();
            room.Rid = RoomDao.IDNext();
            room.Cid = CinemaID;
            room.Rname = textBoxCinemaName.Text;

            RoomDao.insert(room);
        }
    }
}
