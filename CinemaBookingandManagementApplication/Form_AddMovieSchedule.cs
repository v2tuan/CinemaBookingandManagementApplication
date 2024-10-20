﻿using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
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
    public partial class Form_AddMovieSchedule : Form
    {
        public Form_AddMovieSchedule()
        {
            InitializeComponent();
            // Lấy danh sách movie
            MovieDaoImpl movieDao = new MovieDaoImpl();
            comboBoxMovie.DataSource = movieDao.GetListMovie();
            //comboBoxMovie.ValueMember = "mid";
            comboBoxMovie.DisplayMember = "moviename";

            // Lấy danh sách cinema
            CinemaDaoImpl cinemaDao = new CinemaDaoImpl();
            comboBoxCinema.DataSource = cinemaDao.GetListCinema();
            comboBoxCinema.ValueMember = "cid";
            comboBoxCinema.DisplayMember = "cname";

            // Lấy danh sách room
            RoomDaoImpl roomDao = new RoomDaoImpl();
            comboBoxRoom.DataSource = roomDao.GetRoomsByCinemaId(comboBoxCinema.SelectedValue.ToString());
            comboBoxRoom.ValueMember = "rid";
            comboBoxRoom.DisplayMember = "rname";

            //textboxSeatEmpty.Text = roomDao.GetTotalSeatsByRoomId(comboBoxRoom.SelectedValue.ToString()).ToString();
        }

        private void pic_movie_Click(object sender, EventArgs e)
        {

        }

        private void Form_AddMovieSchedule_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] pic = null;
            DataRowView row = (DataRowView)comboBoxMovie.SelectedItem;
            pic = (byte[])row["images"];
            MemoryStream picture = new MemoryStream(pic);
            pic_movie.Image = Image.FromStream(picture);
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomDaoImpl roomDao = new RoomDaoImpl();
            comboBoxRoom.DataSource = roomDao.GetRoomsByCinemaId(comboBoxCinema.SelectedValue.ToString());
            comboBoxRoom.ValueMember = "rid";
            comboBoxRoom.DisplayMember = "rname";
            textboxSeatEmpty.Text = roomDao.GetTotalSeatsByRoomId(comboBoxRoom.SelectionStart.ToString()).ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MovieSchedule movieSchedule = new MovieSchedule();
            movieSchedule.Shid = "";
            DataRowView row = (DataRowView)comboBoxMovie.SelectedItem;
            movieSchedule.Mid = row["mid"].ToString();
            movieSchedule.Rid = comboBoxRoom.SelectedValue.ToString();
            movieSchedule.SeatEmpty = int.Parse(textboxSeatEmpty.Text);
            movieSchedule.Sdate = dateTimePickerRelease.Value;
            movieSchedule.Stime = dateTimePickerShowtime.Value;
            movieSchedule.Etime = dateTimePickerFinishTime.Value;
            ShowTimeDaoImpl showTimeDao = new ShowTimeDaoImpl();
            showTimeDao.AddShowtime(movieSchedule);
        }

        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomDaoImpl roomDao = new RoomDaoImpl();
            textboxSeatEmpty.Text = roomDao.GetTotalSeatsByRoomId(comboBoxRoom.SelectedValue.ToString()).ToString();
        }
    }
}
