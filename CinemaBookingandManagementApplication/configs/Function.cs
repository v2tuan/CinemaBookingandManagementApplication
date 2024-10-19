using CinemaBookingandManagementApplication.Dao;
using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CinemaBookingandManagementApplication.configs
{
    static class Function
    {
        public static SqlConnection conn = new My_DB().getConnectionFromFile();
        public static DataTable getListMovieType()
        {
            DataTable movieTypes = new DataTable();
            try
            {
                conn.Open();

                // Gọi hàm SQL
                using (SqlCommand command = new SqlCommand("SELECT * FROM GET_ALL_MOVIE_TYPES()", conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(movieTypes);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng lại
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return movieTypes;
        }

        // ham kiem tra id cua movie
        public static bool checkMovieID(string movieID)
        {
            bool exists = false;
            try
            {
                conn.Open();
                int result;
                // Gọi hàm SQL
                using (SqlCommand command = new SqlCommand("SELECT dbo.CHECK_MOVIE(@MOVIEID)", conn))
                {
                    command.Parameters.AddWithValue("@MOVIEID", movieID);
                    result = (Int32)command.ExecuteScalar();
                    if (result != null && result == 1)
                    {
                        exists = true; // Kết quả là kiểu boolean
                    }
                    else
                    {
                        exists = false; // Không có kết quả hợp lệ
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng lại
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return exists;
        }
        //hàm list cinema
        public static DataTable GetListCinema()
        {
            DataTable cinema = new DataTable();
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM LIST_CINEMA()", conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(cinema);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return cinema;
        }
        //check id cinema

        public static bool checkCinemaID(string cinemaID)
        {
            bool exists = false;
            try
            {
                conn.Open();
                int result;
                using (SqlCommand command = new SqlCommand("SELECT dbo.COUNT_CINEMA(@CINEMAID)", conn))
                {
                    command.Parameters.AddWithValue("@CINEMAID", cinemaID);
                    result = (Int32)command.ExecuteScalar();

                    if (result != null && result == 1)
                    {
                        exists = true;
                    }
                    else
                    {
                        exists = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return exists;
        }
        //hàm list phim
        public static DataTable GetListMovie()
        {
            DataTable movie = new DataTable();
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM LIST_MOVIE()", conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(movie);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return movie;
        }
        //ham tim kiem phim theo ten phim
        public static DataTable SearchMovieByName(string movieName)
        {
            DataTable resultTable = new DataTable();
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    // Sử dụng câu lệnh để gọi hàm SQL
                    using (SqlCommand command = new SqlCommand("SELECT * FROM SearchMovieByName(@movieName)", conn))
                    {
                        command.Parameters.AddWithValue("@movieName", movieName);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(resultTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            return resultTable; // Trả về bảng kết quả
        }
        //hàm tìm kiếm rap chieu theo ten rap
        public static DataTable SearchCinemaByName(string cinemaName)
        {
            DataTable resultTable = new DataTable();
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    // Sử dụng câu lệnh để gọi hàm SQL
                    using (SqlCommand command = new SqlCommand("SELECT * FROM SearchCinemaByName(@cinemaName)", conn))
                    {
                        command.Parameters.AddWithValue("@cinemaName", cinemaName);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(resultTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            return resultTable; // Trả về bảng kết quả
        }
    }
}
}
