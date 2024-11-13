using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication
{
    public partial class Form_HomeManager : Form
    {
        CinemaDaoImpl cinemaDao = new CinemaDaoImpl();
        public Form_HomeManager()
        {
            InitializeComponent();
            // Lấy danh sách cinema
            CinemaDaoImpl cinemaDao = new CinemaDaoImpl();
            comboBoxCinema.DataSource = cinemaDao.GetListCinema();
            comboBoxCinema.ValueMember = "cid";
            comboBoxCinema.DisplayMember = "cname";
            start();
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            start();
        }

        private void start()
        {
            try
            {
                DataTable dt = cinemaDao.GetCinemaStatistics(comboBoxCinema.SelectedValue.ToString());
                DataTable dt_Bill = cinemaDao.GetBillsByCinemaId(comboBoxCinema.SelectedValue.ToString());
                DataTable dt_Movies = cinemaDao.GetMoviesSortedByRevenue(comboBoxCinema.SelectedValue.ToString());

                labelRevenue.Text = dt.Rows[0][2].ToString();
                labelEmployees.Text = dt.Rows[0][3].ToString();
                labelBills.Text = dt_Bill.Rows.Count.ToString();
                labelMovies.Text = dt.Rows[0][4].ToString();
                labelRoom.Text = dt.Rows[0][5].ToString();


                flowLayoutPanelMovie.Controls.Clear();
                MemoryStream picture = new MemoryStream();
                byte[] pic = null;
                if (dt != null)
                {
                    foreach (DataRow dr in dt_Movies.Rows)
                    {

                        UserControl_MovieType2 movie = new UserControl_MovieType2();
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
