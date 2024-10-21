using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication.dao.impl
{
    internal class MovieDaoImpl : IMovieDao
    {
        public bool checkid(string id)
        {
           return Function.checkMovieID(id);
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movies> findAll()
        {
            throw new NotImplementedException();
        }

        public Movies findById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movies> findName(string keyword)
        {
            throw new NotImplementedException();
        }

        public float getRevenue(Movies movie)
        {
            throw new NotImplementedException();
        }

        public void insert(Movies movie)
        {
            string mid = movie.Mid;
            string moviename = movie.Moviename;
            int ageRestriction =  movie.AgeRestriction;
            decimal revenue = movie.Revenue;
            string mtid = movie.Mtid;
            DateTime releaseDate = movie.ReleaseDate;
            int duration = movie.Duration;
            string descriptions = movie.Descriptions;

            MemoryStream pic = new MemoryStream();
            movie.Image.Save(pic, movie.Image.RawFormat);
            Procedure.AddNewMovie(mid, moviename, ageRestriction, revenue, mtid, releaseDate, duration, descriptions, pic);
        }

        public void update(Movies category)
        {
            throw new NotImplementedException();
        }

        public String IDNext()
        {
            try
            {
                int count = 0;
                count++;
                string nextID = "M" + count.ToString("D6");

                while (checkID(nextID))
                {
                    count++;
                    nextID = "M" + count.ToString("D6");
                }
                return nextID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Movies", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public bool checkID(string id)
        {
            return Function.checkMovieID(id);
        }

        public System.Data.DataTable GetListMovie()
        {
            return Function.GetListMovie();
        }
    }
}
