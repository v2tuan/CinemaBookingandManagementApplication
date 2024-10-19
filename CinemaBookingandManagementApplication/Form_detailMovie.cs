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
    public partial class Form_detailMovie : Form
    {
        public Movie movie { get; set; }
        public Form_detailMovie()
        {
            InitializeComponent();
        }

        private void Form_detailMovie_Load(object sender, EventArgs e)
        {
            labelName.Text = movie.Moviename;
            labelReleaseDate.Text = movie.ReleaseDate.ToShortDateString();
            labelDuration.Text = movie.Duration.ToString();
            labelDescriptions.Text = movie.Descriptions.ToString();
            pic_movie.Image = movie.Image;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
