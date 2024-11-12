using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
using CinemaBookingandManagementApplication.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication
{
    public partial class Form_ShowMovie : Form
    {
        public event EventHandler buttonBuyClick = null;
        public Form_ShowMovie()
        {
         
            InitializeComponent();
        }

        private void Form_ShowMovie_Load(object sender, EventArgs e)
        {
   
            try
            {
                flowLayoutPanelMovie.Controls.Clear();
                MovieDaoImpl movieDaoImpl = new MovieDaoImpl();
                MemoryStream picture = new MemoryStream();
                DataTable dt = movieDaoImpl.GetListMovie();
                //UserControl_Movie movie = null;
                byte[] pic = null;
                Form_detailMovie detailMovie = new Form_detailMovie();
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        UserControl_Movie movie = new UserControl_Movie();
                        movie.movie.Mid = dr["mid"].ToString();
                        movie.movie.Moviename = dr["moviename"].ToString();
                        movie.movie.AgeRestriction = int.Parse(dr["ageRestriction"].ToString());
                        movie.movie.Revenue = decimal.Parse(dr["revenue"].ToString());
                        movie.movie.Mtid = dr["mtid"].ToString();
                        movie.movie.ReleaseDate = DateTime.Parse(dr["releaseDate"].ToString());
                        movie.movie.Duration = int.Parse(dr["duration"].ToString());
                        movie.movie.Descriptions = dr["descriptions"].ToString();
                        if (dr["images"] != DBNull.Value)
                        {
                            pic = (byte[])dr["images"];
                            picture = new MemoryStream(pic);
                        }
                        else
                        {
                            picture = new MemoryStream();
                            Properties.Resources.nullImage.Save(picture, Properties.Resources.nullImage.RawFormat);
                        }
                        Image image_Food = Image.FromStream(picture);
                        movie.movie.Image = image_Food;

                        movie.restart();
                        flowLayoutPanelMovie.Controls.Add(movie);

                        movie.buttonClick += (ss, ee) =>
                        {
                            detailMovie.ShowDate = dateTimePickerDate.Value;
                            detailMovie.CinemaId = Constant.idcinema;
                            //buttonBuyClick?.Invoke(this, e);
                            detailMovie.movie = movie.movie;
                            detailMovie.ShowDialog();
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanelMovie.Controls.Clear();
                MovieDaoImpl movieDaoImpl = new MovieDaoImpl();
                MemoryStream picture = new MemoryStream();
                DataTable dt = new DataTable();
                if (Constant.role == "admin")
                {
                    dt = movieDaoImpl.GetListMovieByTime(dateTimePickerDate.Value.Date);
                }
                else {
                    dt = movieDaoImpl.GetListMovieByCIDandTime(Constant.idcinema, dateTimePickerDate.Value.Date);
                }
                byte[] pic = null;
                Form_detailMovie detailMovie = new Form_detailMovie();
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        UserControl_Movie movie = new UserControl_Movie();
                        movie.movie.Mid = dr["mid"].ToString();
                        movie.movie.Moviename = dr["moviename"].ToString();
                        movie.movie.AgeRestriction = int.Parse(dr["ageRestriction"].ToString());
                        movie.movie.Revenue = decimal.Parse(dr["revenue"].ToString());
                        movie.movie.Mtid = dr["mtid"].ToString();
                        movie.movie.ReleaseDate = DateTime.Parse(dr["releaseDate"].ToString());
                        movie.movie.Duration = int.Parse(dr["duration"].ToString());
                        movie.movie.Descriptions = dr["descriptions"].ToString();

                        if (dr["images"] != DBNull.Value)
                        {
                            pic = (byte[])dr["images"];
                            picture = new MemoryStream(pic);
                        }
                        else
                        {
                            picture = new MemoryStream();
                            Properties.Resources.nullImage.Save(picture, Properties.Resources.nullImage.RawFormat);
                        }
                        Image image_Food = Image.FromStream(picture);

                        movie.movie.Image = image_Food;
                        movie.restart();
                        flowLayoutPanelMovie.Controls.Add(movie);

                        movie.buttonClick += (ss, ee) =>
                        {
                            detailMovie.ShowDate = dateTimePickerDate.Value;
                            detailMovie.CinemaId = Constant.idcinema;
                            //buttonBuyClick?.Invoke(this, e);
                            detailMovie.movie = movie.movie;
                            detailMovie.ShowDialog();
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
