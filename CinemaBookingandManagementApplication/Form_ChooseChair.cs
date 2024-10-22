using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
using CinemaBookingandManagementApplication.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication
{
    public partial class Form_ChooseChair : Form
    {
        public MovieSchedule movieSchedule { get; set; }
        public Form_ChooseChair()
        {
            InitializeComponent();
        }

        private void Form_ChooseChair_Load(object sender, EventArgs e)
        {
            buttonScreening.Text = $"{movieSchedule.Stime.Hours}:{movieSchedule.Stime.Minutes:D2}";
        }

        public void setSeat()
        {
            try
            {
                flowLayoutPanelSeat.Controls.Clear();
                RoomDaoImpl roomDaoImpl = new RoomDaoImpl();
                DataTable dt = roomDaoImpl.GetSeatsByRoomId(movieSchedule.Rid);
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
                        userControl_Seat.setNumberSeat(int.Parse(seat.Snumber));

                        flowLayoutPanelSeat.Controls.Add(userControl_Seat);

                        userControl_Seat.buttonClick += (ss, ee) =>
                        {
                            /*
                             */
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
