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
    public partial class UserControl_MovieType2 : UserControl
    {
        public Movies movie { get; set; } = new Movies();
        public UserControl_MovieType2()
        {
            InitializeComponent();
        }

        public void restart()
        {
            pic_movie.Image = movie.Image;
            labelName.Text = movie.Moviename;
            labelReleaseDate.Text = movie.ReleaseDate.ToString();
        }
    }
}
