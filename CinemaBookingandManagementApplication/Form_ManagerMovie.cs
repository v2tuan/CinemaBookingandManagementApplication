using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
using CinemaBookingandManagementApplication.UserControls;
using Guna.UI2.WinForms.Suite;
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
    public partial class Form_ManagerMovie : Form
    {
        public Form_ManagerMovie()
        {
            InitializeComponent();
        }
        private void LoadMovies()
        {
            try
            {
                flowLayoutPanelMovie.Controls.Clear();
                MovieDaoImpl movieDaoImpl = new MovieDaoImpl();

                MemoryStream picture = new MemoryStream();
                DataTable dt = movieDaoImpl.GetListMovie();
                byte[] pic = null;

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        UserControl_EditMovie movie = new UserControl_EditMovie();
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
                            Form_EditMovie editMovie = new Form_EditMovie(movie.movie);
                            if (editMovie.ShowDialog() == DialogResult.OK) // Làm mới nếu chỉnh sửa thành công
                            {
                                LoadMovies();
                            }
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_ManagerMovie_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            using (Form_AddMovie frm = new Form_AddMovie())
            {
                if (frm.ShowDialog() == DialogResult.OK) // Chỉ làm mới nếu người dùng đã thêm thành công
                {
                    LoadMovies();
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form_AgeRestrictionMovie form_AgeRestrictionMovie = new Form_AgeRestrictionMovie();
            form_AgeRestrictionMovie.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Form_ManagerMovie_Load(sender, e);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FormHuy a = new FormHuy();
            a.ShowDialog();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                flowLayoutPanelMovie.Controls.Clear();
                MovieDaoImpl movieDaoImpl = new MovieDaoImpl();
                MemoryStream picture = new MemoryStream();
                DataTable dt = new DataTable();
                dt = Function.SearchMoviesByName(textBoxSearch.Text.Trim());
                byte[] pic = null;
                Form_detailMovie detailMovie = new Form_detailMovie();
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        UserControl_EditMovie movie = new UserControl_EditMovie();
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
                            Form_EditMovie editMovie = new Form_EditMovie(movie.movie);
                            editMovie.ShowDialog();
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
