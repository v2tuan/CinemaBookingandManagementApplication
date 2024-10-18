﻿using CinemaBookingandManagementApplication.Dao;
using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                Console.WriteLine("An error occurred: " + ex.Message);
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
            bool exists =false;
            try
            {
                conn.Open();
                int result;
                // Gọi hàm SQL
                using (SqlCommand command = new SqlCommand("SELECT dbo.COUNT_MOVIE(@MOVIEID)", conn))
                {
                    command.Parameters.AddWithValue("@MOVIEID", movieID);
                    result = (Int32)command.ExecuteScalar();
                    if (result != null && result ==1)
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
                Console.WriteLine("An error occurred: " + ex.Message);
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
                    Console.WriteLine("An error occurred: " + ex.Message);
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

                // Gọi hàm SQL để kiểm tra cinemaID
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM cinemas WHERE cid = @CINEMAID", conn))
                {
                    command.Parameters.AddWithValue("@CINEMAID", cinemaID);
                    result = (Int32)command.ExecuteScalar();

                    // Nếu kết quả là 1, tức là cinemaID tồn tại
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
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Đảm bảo đóng kết nối
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return exists;
        }
    }

}
