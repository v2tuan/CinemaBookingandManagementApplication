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

namespace CinemaBookingandManagementApplication.UserControls
{
    public partial class UserControl_Cinema : UserControl
    {
        public Cinema cinema { get; set; } = new Cinema();

        public UserControl_Cinema()
        {
            InitializeComponent();
        }

        public void restart()
        {
            PictureBoxCinema.Image = cinema.Image;
            labelName.Text = cinema.Cname;
        }
    }
}