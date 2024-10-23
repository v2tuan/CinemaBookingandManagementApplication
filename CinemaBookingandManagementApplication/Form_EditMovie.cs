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
    public partial class Form_EditMovie : Form
    {
        public Movies movie;
        public Form_EditMovie(Movies currentmovie)
        {
            movie = currentmovie;
            InitializeComponent();
            comboBoxType.DataSource = MovieTypeDaoImpl.getListMovieType();
            comboBoxType.ValueMember = "mtid";
            comboBoxType.DisplayMember = "typename";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
           // Movies movie = new Movies();
            MovieDaoImpl MovieDao = new MovieDaoImpl();
            //movie.Mid = MovieDao.IDNext();
            movie.Moviename = textBoxMovieName.Text;
            movie.AgeRestriction = int.Parse(textBoxAgeRestriction.Text);
            movie.Revenue = 0;
            movie.Mtid = comboBoxType.SelectedValue.ToString();
            movie.ReleaseDate = DateTimePickerRelease.Value;
            movie.Duration = int.Parse(textDuration.Text);
            movie.Descriptions = richTextBoxDescription.Text;
            movie.Image = pictureBoxMovie.Image;
            MovieDao.update(movie);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            //Movies movie = new Movies();
            MovieDaoImpl MovieDao = new MovieDaoImpl();
            MovieDao.delete(movie);
        }

        private void Form_EditMovie_Load(object sender, EventArgs e)
        {
            textBoxMovieName.Text = movie.Moviename;
            textBoxAgeRestriction.Text = movie.AgeRestriction.ToString();
            textBoxRevenue.Text = movie.Revenue.ToString();
            comboBoxType.SelectedValue = movie.Mtid.ToString();
            DateTimePickerRelease.Value = movie.ReleaseDate;
            textDuration.Text = movie.Duration.ToString();
            richTextBoxDescription.Text = movie.Descriptions;
            pictureBoxMovie.Image = movie.Image;
        }
    }
}
