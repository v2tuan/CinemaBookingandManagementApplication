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
    public partial class Form_ListCinema : Form
    {
        public Form_ListCinema()
        {
            InitializeComponent();
        }

        private void Form_ListCinema_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    flowLayoutPanelCinema.Controls.Clear();
            //    CinemaDaoImpl cinemaDaoImpl = new CinemaDaoImpl();
            //    MemoryStream picture = new MemoryStream();
            //    DataTable dt = cinemaDaoImpl.GetListMovie();
            //    //UserControl_Movie movie = null;
            //    byte[] pic = null;
            //    Form_detailMovie detailMovie = new Form_detailMovie();
            //    if (dt != null)
            //    {
            //        foreach (DataRow dr in dt.Rows)
            //        {
            //            UserControl_Cinema cinemaControl = new UserControl_Cinema();
            //            cinema.movie.Mid = dr["mid"].ToString();
            //            cinema.movie.Moviename = dr["moviename"].ToString();
            //            cinema.movie.AgeRestriction = int.Parse(dr["ageRestriction"].ToString());
            //            cinema.movie.Revenue = decimal.Parse(dr["revenue"].ToString());
            //            cinema.movie.Mtid = dr["mtid"].ToString();
            //            cinema.movie.ReleaseDate = DateTime.Parse(dr["releaseDate"].ToString());
            //            cinema.movie.Duration = int.Parse(dr["duration"].ToString());
            //            cinema.movie.Descriptions = dr["descriptions"].ToString();

            //            if (dr["images"] != DBNull.Value)
            //            {
            //                pic = (byte[])dr["images"];
            //                picture = new MemoryStream(pic);
            //            }
            //            else
            //            {
            //                picture = new MemoryStream();
            //                MessageBox.Show("Properties.Resources.Image_Error.Save(picture, Properties.Resources.Image_Error.RawFormat)");
            //                //Properties.Resources.Image_Error.Save(picture, Properties.Resources.Image_Error.RawFormat);
            //            }
            //            Image image_Food = Image.FromStream(picture);

            //            cinemaControl.cinema.Image = image_Food;

            //            cinemaControl.restart();
            //            flowLayoutPanelCinema.Controls.Add(cinemaControl);

            //            cinemaControl.buttonClick += (ss, ee) =>
            //            {
            //                detailMovie.movie = movie.movie;
            //                detailMovie.ShowDialog();
            //            };
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Form_AddCinema form_AddCinema = new Form_AddCinema();
            form_AddCinema.ShowDialog();
        }
    }
}
