using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
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
    public partial class Form_AddCinema : Form
    {
        public Form_AddCinema()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Cinema cinema = new Cinema();
            CinemaDaoImpl CinemaDao = new CinemaDaoImpl();
            cinema.Cid = CinemaDao.IDNext();
            cinema.Cname = textBoxCinemaName.Text;
            cinema.Caddress = textBoxAddress.Text;
            cinema.Hotline = TextBoxHotline.Text;
            cinema.Image = pictureBoxCinema.Image;
            CinemaDao.insert(cinema);
        }
    }
}
