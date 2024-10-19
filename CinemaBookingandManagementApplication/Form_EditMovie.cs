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
        public Form_EditMovie()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
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

            Movie movie = new Movie();
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
    }
}
