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
    public partial class Form_InformationMovie : Form
    {
        public Movies movie { get; set; }
        public Form_InformationMovie()
        {
            InitializeComponent();
        }

        private void Form_InformationMovie_Load(object sender, EventArgs e)
        {
            labelName.Text = movie.Moviename;
            labelReleaseDate.Text = movie.ReleaseDate.ToShortDateString();
            labelDuration.Text = movie.Duration.ToString();
            labelDescriptions.Text = movie.Descriptions.ToString();
            pic_movie.Image = movie.Image;
        }
    }
}
