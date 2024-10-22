using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication.UserControls
{
    public partial class UserControl_CinemaShowTime : UserControl
    {
        public Cinemas cinema {  get; set; } = new Cinemas();
        public string CinemaID { get; set; } = string.Empty;
        public string CinemaName { get; set; } = string.Empty;
        public Movies movie { get; set; }
        public DateTime Date { get; set; }

        public UserControl_CinemaShowTime()
        {
            InitializeComponent();
        }

        private void UserControl_CinemaShowTime_Load(object sender, EventArgs e)
        {
            if (movie != null)
            {
                
                labelCinemaName.Text = CinemaName;
                CinemaDaoImpl cinemaDaoImpl = new CinemaDaoImpl();

                DataTable dt = cinemaDaoImpl.GetMovieSchedulesByCinema(CinemaID, movie.Mid, Date);
                flowLayoutPanelShowTime.Controls.Clear();
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        UserControl_show_schedule show_Schedule = new UserControl_show_schedule();
                        MovieSchedule schedule = new MovieSchedule();
                        schedule.Shid = dr["shid"].ToString();
                        schedule.Mid = dr["mid"].ToString();
                        schedule.Sdate = DateTime.Parse(dr["sdate"].ToString());
                        schedule.Stime = TimeSpan.Parse(dr["stime"].ToString());
                        schedule.Etime = TimeSpan.Parse(dr["etime"].ToString());
                        schedule.SeatEmpty = int.Parse(dr["seatEmpty"].ToString());
                        schedule.Rid = dr["rid"].ToString();

                        show_Schedule.movieSchedule = schedule;

                        show_Schedule.buttonClick += (ss, ee) =>
                        {
                            Form_Booking frm = new Form_Booking();
                            frm.movie = movie;
                            frm.CinemaID = CinemaID;
                            frm.CinemaName = CinemaName;
                            frm.movieSchedule = schedule;
                            frm.ShowDialog();
                        };
                        flowLayoutPanelShowTime.Controls.Add(show_Schedule);
                    }
                }
            }
        }

        public void setColor()
        {
            panelBackground.FillColor = Color.FromArgb(253, 251, 250);
        }
    }
}
