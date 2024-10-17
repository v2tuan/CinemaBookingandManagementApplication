using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public List<Movie> findAll()
        {
            throw new NotImplementedException();
        }

        public Movie findById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Movie> findName(string keyword)
        {
            throw new NotImplementedException();
        }

        public float getRevenue(Movie movie)
        {
            throw new NotImplementedException();
        }

        public void insert(Movie movie)
        {
            //Procedure.AddNewMovie(movie.);
            throw new NotImplementedException();
        }

        public void update(Movie category)
        {
            throw new NotImplementedException();
        }

        public String IDNext()
        {
            try
            {
                int count = 0;
                count++;
                string nextID = "D" + count.ToString("D6");

                while (!checkID(nextID))
                {
                    count++;
                    nextID = "D" + count.ToString("D6");
                }
                return nextID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add DISHES", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public bool checkID(string id)
        {
            //SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM DISHES WHERE Dis_ID = @Id", conn);
            //cmd.Parameters.AddWithValue("id", id);
            //conn.Open();
            //if ((int)cmd.ExecuteScalar() >= 1)
            //{
            //    conn.Close();
            //    return false;
            //}
            //else
            //{
            //    conn.Close();
            //    return true;
            //}
            return bool.Parse("1");
        }
    }
}
