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
            //labelCinemaName.Text = CinemaName;
            //CinemaDaoImpl cinemaDaoImpl = new CinemaDaoImpl();
            ////DataTable dt = cinemaDaoImpl.GetMovieSchedulesByCinema(CinemaID, );
            //flowLayoutPanelShowTime.Controls.Clear();
            //if (dt != null)
            //{
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        UserControl_CinemaShowTime CinemaShowTime = new UserControl_CinemaShowTime();
            //        CinemaShowTime.movie = movie;
            //        CinemaShowTime.CinemaName = dr["cname"].ToString();
            //        CinemaShowTime.CinemaID = dr["cid"].ToString();
            //        //flowLayoutPanelShow.Controls.Add(CinemaShowTime);
            //    }
            //}
        }
    }
}
