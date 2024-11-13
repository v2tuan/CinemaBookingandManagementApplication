using CinemaBookingandManagementApplication.configs;
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
using System.Xml.Linq;

namespace CinemaBookingandManagementApplication
{
    public partial class Form_detailMovie : Form
    {
        public Movies movie { get; set; } = null;
        public DateTime ShowDate { get; set; }
        public string CinemaId { get; set; }
    public Form_detailMovie()
        {
            InitializeComponent();
        }

        private void Form_detailMovie_Load(object sender, EventArgs e)
        {
            if(Constant.role =="admin")
            {
                dateTimePickerDate.Value = ShowDate;
                //string name = Function.GetCinemaNameById(CinemaId);
                //cinemaCombox.DisplayMember = name;
                labelName.Text = movie.Moviename;
                labelReleaseDate.Text = movie.ReleaseDate.ToShortDateString();
                labelDuration.Text = movie.Duration.ToString();
                labelDescriptions.Text = movie.Descriptions.ToString();
                pic_movie.Image = movie.Image;
                AreaCombobox.DataSource = Function.getListArea();
                AreaCombobox.ValueMember = "area";
                AreaCombobox.DisplayMember = "area";

                //CinemaDaoImpl cinemaDaoImpl = new CinemaDaoImpl();
                //DataTable dt = cinemaDaoImpl.GetCinemasWithMovieSchedules(movie.Mid, dateTimePickerDate.Value);
                //flowLayoutPanelShow.Controls.Clear();
                //if (dt != null)
                //{
                //    foreach (DataRow dr in dt.Rows)
                //    {
                //        UserControl_CinemaShowTime CinemaShowTime = new UserControl_CinemaShowTime();
                //        CinemaShowTime.movie = movie;
                //        CinemaShowTime.CinemaName = dr["cname"].ToString();
                //        CinemaShowTime.CinemaID = dr["cid"].ToString();
                //        flowLayoutPanelShow.Controls.Add(CinemaShowTime);
                //    }
                //}
                if (movie != null)
                {
                    CinemaDaoImpl cinemaDaoImpl = new CinemaDaoImpl();
                    DataTable dt = cinemaDaoImpl.GetCinemasWithMovieSchedules(movie.Mid, dateTimePickerDate.Value);
                    flowLayoutPanelShow.Controls.Clear();
                    int i = 0;
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            UserControl_CinemaShowTime CinemaShowTime = new UserControl_CinemaShowTime();
                            CinemaShowTime.movie = movie;
                            CinemaShowTime.CinemaName = dr["cname"].ToString();
                            CinemaShowTime.CinemaID = dr["cid"].ToString();
                            CinemaShowTime.Date = dateTimePickerDate.Value;
                            CinemaShowTime.Width = panelDate.Width;
                            if (i % 2 != 0)
                            {
                                CinemaShowTime.setColor();
                            }
                            flowLayoutPanelShow.Controls.Add(CinemaShowTime);
                            i++;
                        }
                    }
                }
            }
            else
            {
                dateTimePickerDate.Value = ShowDate;
                string name = Function.GetCinemaNameById(CinemaId);
                string aname = Function.GetCinemaAreaById(CinemaId);
                cinemaCombox.DataSource = null;
                cinemaCombox.Items.Clear();     // Xóa tất cả các mục trong Items
                cinemaCombox.Items.Add(name);   // Thêm giá trị name tạm thời vào ComboBox
                cinemaCombox.SelectedIndex = 0;
                cinemaCombox.Enabled = false;
                AreaCombobox.DataSource = null;
                AreaCombobox.Items.Clear();
                AreaCombobox.Items.Add(aname);
                AreaCombobox.SelectedIndex = 0;
                AreaCombobox.Enabled = false;
                labelName.Text = movie.Moviename;
                labelReleaseDate.Text = movie.ReleaseDate.ToShortDateString();
                labelDuration.Text = movie.Duration.ToString();
                labelDescriptions.Text = movie.Descriptions.ToString();
                pic_movie.Image = movie.Image;
                if (movie != null)
                {
                    CinemaDaoImpl cinemaDaoImpl = new CinemaDaoImpl();
                    DataTable dt = cinemaDaoImpl.GetMovieSchedulesByCinema(CinemaId, movie.Mid, dateTimePickerDate.Value);
                    flowLayoutPanelShow.Controls.Clear();
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
                                frm.CinemaID = CinemaId;
                                frm.CinemaName = name;
                                frm.movieSchedule = schedule;
                                frm.ShowDialog();
                            };
                            flowLayoutPanelShow.Controls.Add(show_Schedule);
                        }
                    }
                }
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
           if(Constant.role =="admin")
            {
                if (movie != null)
                {
                    CinemaDaoImpl cinemaDaoImpl = new CinemaDaoImpl();
                    DataTable dt = cinemaDaoImpl.GetCinemasWithMovieSchedules(movie.Mid, dateTimePickerDate.Value);
                    flowLayoutPanelShow.Controls.Clear();
                    int i = 0;
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            UserControl_CinemaShowTime CinemaShowTime = new UserControl_CinemaShowTime();
                            CinemaShowTime.movie = movie;
                            CinemaShowTime.CinemaName = dr["cname"].ToString();
                            CinemaShowTime.CinemaID = dr["cid"].ToString();
                            CinemaShowTime.Date = dateTimePickerDate.Value;
                            CinemaShowTime.Width = panelDate.Width;
                            if (i % 2 != 0)
                            {
                                CinemaShowTime.setColor();
                            }
                            flowLayoutPanelShow.Controls.Add(CinemaShowTime);
                            i++;
                        }
                    }
                }
            }
           else
            {
                CinemaDaoImpl cinemaDaoImpl = new CinemaDaoImpl();
                string name = Function.GetCinemaNameById(CinemaId);
                DataTable dt = cinemaDaoImpl.GetMovieSchedulesByCinema(CinemaId, movie.Mid, dateTimePickerDate.Value);
                flowLayoutPanelShow.Controls.Clear();
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
                            frm.CinemaID = CinemaId;
                            frm.CinemaName = name;
                            frm.movieSchedule = schedule;
                            frm.ShowDialog();
                        };
                        flowLayoutPanelShow.Controls.Add(show_Schedule);
                    }
                }

            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(AreaCombobox.Text)) 
            {
                cinemaCombox.DataSource = Function.getListCinemaByArea(AreaCombobox.Text); 
                cinemaCombox.ValueMember = "cid";     
                cinemaCombox.DisplayMember = "cname"; 
            }
            if (movie != null)
            {
                CinemaDaoImpl cinemaDaoImpl = new CinemaDaoImpl();
                DataTable dt = cinemaDaoImpl.GetCinemasWithMovieSchedules(movie.Mid, dateTimePickerDate.Value);
                flowLayoutPanelShow.Controls.Clear();
                int i = 0;
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        UserControl_CinemaShowTime CinemaShowTime = new UserControl_CinemaShowTime();
                        CinemaShowTime.movie = movie;
                        CinemaShowTime.CinemaName = dr["cname"].ToString();
                        CinemaShowTime.CinemaID = dr["cid"].ToString();
                        CinemaShowTime.Date = dateTimePickerDate.Value;
                        CinemaShowTime.Width = panelDate.Width;
                        if (i % 2 != 0)
                        {
                            CinemaShowTime.setColor();
                        }
                        flowLayoutPanelShow.Controls.Add(CinemaShowTime);
                        i++;
                    }
                }
            }
        }

        private void cinemaCombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
