using CinemaBookingandManagementApplication.dao.impl;
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
    public partial class Form_HomeManager : Form
    {
        public Form_HomeManager()
        {
            InitializeComponent();
            // Lấy danh sách cinema
            CinemaDaoImpl cinemaDao = new CinemaDaoImpl();
            comboBoxCinema.DataSource = cinemaDao.GetListCinema();
            comboBoxCinema.ValueMember = "cid";
            comboBoxCinema.DisplayMember = "cname";
        }
    }
}
