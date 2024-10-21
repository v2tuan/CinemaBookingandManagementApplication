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
    public partial class Form_detailMovie : Form
    {
        public Movies movie { get; set; } = null;
        public Form_detailMovie()
        {
            InitializeComponent();
            dateTimePickerDate.Value = DateTime.Now;
        }

        private void Form_detailMovie_Load(object sender, EventArgs e)
        {
            labelName.Text = movie.Moviename;
            labelReleaseDate.Text = movie.ReleaseDate.ToShortDateString();
            labelDuration.Text = movie.Duration.ToString();
            labelDescriptions.Text = movie.Descriptions.ToString();
            pic_movie.Image = movie.Image;

            CinemaDaoImpl cinemaDaoImpl = new CinemaDaoImpl();
            DataTable dt = cinemaDaoImpl.GetCinemasWithMovieSchedules(movie.Mid, dateTimePickerDate.Value);
            flowLayoutPanelShow.Controls.Clear();
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    UserControl_CinemaShowTime CinemaShowTime = new UserControl_CinemaShowTime();
                    CinemaShowTime.movie = movie;
                    CinemaShowTime.CinemaName = dr["cname"].ToString();
                    CinemaShowTime.CinemaID = dr["cid"].ToString();
                    flowLayoutPanelShow.Controls.Add(CinemaShowTime);
                }
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            if (movie != null)
            {
                CinemaDaoImpl cinemaDaoImpl = new CinemaDaoImpl();
                DataTable dt = cinemaDaoImpl.GetCinemasWithMovieSchedules(movie.Mid, dateTimePickerDate.Value);
                flowLayoutPanelShow.Controls.Clear();
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        UserControl_CinemaShowTime CinemaShowTime = new UserControl_CinemaShowTime();
                        CinemaShowTime.movie = movie;
                        CinemaShowTime.CinemaName = dr["cname"].ToString();
                        CinemaShowTime.CinemaID = dr["cid"].ToString();
                        flowLayoutPanelShow.Controls.Add(CinemaShowTime);
                    }
                }
            }
        }
    }
}
