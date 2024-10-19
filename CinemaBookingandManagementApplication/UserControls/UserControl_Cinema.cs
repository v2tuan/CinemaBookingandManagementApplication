﻿using CinemaBookingandManagementApplication.models;
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
    public partial class UserControl_Cinema : UserControl
    {
        public Cinema cinema { get; set; } = new Cinema();
        public event EventHandler buttonClick = null;
        public UserControl_Cinema()
        {
            InitializeComponent();
        }

        public void restart()
        {
            PictureBoxCinema.Image = cinema.Image;
            labelName.Text = cinema.Cname;
            labelAddress.Text = cinema.Caddress;
            labelHotline.Text = cinema.Hotline;
        }

        private void UserControl_Cinema_Load(object sender, EventArgs e)
        {
            
        }

        private void UserControl_Cinema_Click(object sender, EventArgs e)
        {
           
        }

        private void UserControl_Cinema_DoubleClick(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ShadowPanel1_DoubleClick(object sender, EventArgs e)
        {
            buttonClick?.Invoke(this, e);
        }
    }
}