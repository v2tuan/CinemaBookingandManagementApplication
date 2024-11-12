using CinemaBookingandManagementApplication.Dao;
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
    static class Views
    {
        public static SqlConnection conn = new My_DB().getConnectionFromFile();
        //view 5 combo best seller 
        public static DataTable GetTop5BestSellingCombos()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM Top5BestSellingCombos"; // Truy vấn view

            try
            {
                conn.Open(); // Mở kết nối

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable); // Lấp dữ liệu vào DataTable
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close(); // Đảm bảo đóng kết nối
            }

            return dataTable;
        }
        //view những phim mà độ tuổi > 18
        public static DataTable GetMoviesAbove18()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM MoviesAbove18"; // Truy vấn view

            try
            {
                conn.Open(); // Mở kết nối

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close(); 
            }

            return dataTable;
        }
        // view của Huy
        public static DataTable GetMovieRevenueView()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM MovieRevenueView"; // Truy vấn view MovieRevenueView

            try
            {
                conn.Open(); // Mở kết nối

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable); // Điền dữ liệu vào DataTable
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message); // Xử lý lỗi nếu có
            }
            finally
            {
                conn.Close(); // Đảm bảo đóng kết nối
            }

            return dataTable; // Trả về DataTable chứa dữ liệu
        }


    }

}
