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
    public partial class Form_ShowCinema : Form
    {
        public Form_ShowCinema()
        {
            InitializeComponent();
        }

        private void buttonAddCinema_Click(object sender, EventArgs e)
        {
            Form_AddCinema form_AddCinema = new Form_AddCinema();
            form_AddCinema.ShowDialog();
        }

        private void Form_ShowCinema_Load(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanelCinema.Controls.Clear();
                CinemaDaoImpl cinemaDaoImpl = new CinemaDaoImpl();
                MemoryStream picture = new MemoryStream();
                DataTable dt = cinemaDaoImpl.GetListCinema();
                byte[] pic = null;
                Form_detailMovie detailMovie = new Form_detailMovie();
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        UserControl_Cinemas cinemaControl = new UserControl_Cinemas();
                        cinemaControl.cinema.Cid = dr["cid"].ToString();
                        cinemaControl.cinema.Cname = dr["cname"].ToString();
                        cinemaControl.cinema.Hotline = dr["hotline"].ToString();
                        cinemaControl.cinema.Area = dr["area"].ToString();
                        cinemaControl.cinema.Caddress = dr["caddress"].ToString();

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

                        cinemaControl.cinema.Image = image_Food;

                        cinemaControl.restart();
                        cinemaControl.Width = flowLayoutPanelCinema.Width + 40;
                        flowLayoutPanelCinema.Controls.Add(cinemaControl);

                        cinemaControl.buttonClick += (ss, ee) =>
                        {
                            Form_Cinema cinema = new Form_Cinema();
                            cinema.cinema = cinemaControl.cinema;
                            cinema.ShowDialog();
                        };

                        //edit
                        cinemaControl.editClick += (ss, ee) =>
                        {
                            //Form_EditCinema form_EditCinema = new Form_EditCinema();
                            //form_EditCinema.ShowDialog(this);
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddMovieSchedule_Click(object sender, EventArgs e)
        {
            Form_AddMovieSchedule form_AddMovie = new Form_AddMovieSchedule();
            form_AddMovie.ShowDialog();
        }
    }
}
