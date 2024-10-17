﻿using System;
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
    public partial class UserControl_Movie : UserControl
    {
        public event EventHandler buttonClick = null;
        public UserControl_Movie()
        {
            InitializeComponent();
            pic_cover.Visible = false;
            btn_buy.Visible = false;
        }

        private void pic_movie_MouseEnter(object sender, EventArgs e)
        {
            btn_buy.Visible = true;
            pic_cover.Visible = true;
        }

        private void pic_movie_MouseLeave(object sender, EventArgs e)
        {
            pic_cover.Visible = false;
            btn_buy.Visible = false;
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            buttonClick?.Invoke(this, e);
        }

        private void btn_buy_MouseEnter(object sender, EventArgs e)
        {
            btn_buy.Visible = true;
            pic_cover.Visible = true;
        }
    }
}