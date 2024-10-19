using CinemaBookingandManagementApplication.dao.impl;
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
            for (int i = 0; i < 10; i++)
            {
                UserControl_Movie userControl = new UserControl_Movie();
                flowLayoutPanelMovie.Controls.Add(userControl);
                userControl.buttonClick += (ss, ee) =>
                {
                    buttonBuyClick?.Invoke(this, e);
                };
            }

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
                            MessageBox.Show("Properties.Resources.Image_Error.Save(picture, Properties.Resources.Image_Error.RawFormat)");
                            //Properties.Resources.Image_Error.Save(picture, Properties.Resources.Image_Error.RawFormat);
                        }
                        Image image_Food = Image.FromStream(picture);

                        movie.movie.Image = image_Food;

                        movie.restart();
                        flowLayoutPanelMovie.Controls.Add(movie);

                        movie.buttonClick += (ss, ee) =>
                        {
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
            using(Form_AddMovie frm = new Form_AddMovie())
            {
                frm.ShowDialog();
            }
        }
    }
}
