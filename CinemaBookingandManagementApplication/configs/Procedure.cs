using CinemaBookingandManagementApplication.Dao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CinemaBookingandManagementApplication.configs
{
    static class Procedure
    {
        private static My_DB myDB = new My_DB();  // Sử dụng lớp My_DB để lấy kết nối

        public static void AddNewMovie(string mid, string moviename, int ageRestriction, decimal revenue, string mtid,
                                DateTime releaseDate, int duration, string descriptions, MemoryStream images)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    foreach (SqlError error in e.Errors)
                    {
                        Console.WriteLine("SQL Message: " + error.Message);
                    }
                };
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("AddNewMovie", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@mid", mid);
                        cmd.Parameters.AddWithValue("@moviename", moviename);
                        cmd.Parameters.AddWithValue("@ageRestriction", ageRestriction);
                        cmd.Parameters.AddWithValue("@revenue", revenue);
                        cmd.Parameters.AddWithValue("@mtid", mtid);
                        cmd.Parameters.AddWithValue("@releaseDate", releaseDate);
                        cmd.Parameters.AddWithValue("@duration", duration);
                        cmd.Parameters.AddWithValue("@descriptions", descriptions);

                        // Thêm tham số hình ảnh (image có thể null)
                        if (images != null)
                        {
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = images;
                        }
                        else
                        {
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = DBNull.Value;
                        }

                        // Thực thi stored procedure và kiểm tra số hàng bị ảnh hưởng
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
                finally
                {
                    // Đảm bảo đóng kết nối
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
        public static void CreateNewCinema(string cid, string cname, string caddress, string hotline, string area)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    foreach (SqlError error in e.Errors)
                    {
                        Console.WriteLine("SQL Message: " + error.Message);
                    }
                };
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("CreateNewCinema", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@cname", cname);
                        cmd.Parameters.AddWithValue("@caddress", caddress);
                        cmd.Parameters.AddWithValue("@hotline", hotline);
                        cmd.Parameters.AddWithValue("@area", area);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cơ sở rạp được tạo thành công!");
                    }
                }
                catch (SqlException ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
                finally
                {
                    // Đảm bảo đóng kết nối
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
        public static void UpdateCinema(string cid, string cname, string caddress, string hotline, string area)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    foreach (SqlError error in e.Errors)
                    {
                        Console.WriteLine("SQL Message: " + error.Message);
                    }
                };
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("UpdateCinema", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@cname", cname);
                        cmd.Parameters.AddWithValue("@caddress", caddress);
                        cmd.Parameters.AddWithValue("@hotline", hotline);
                        cmd.Parameters.AddWithValue("@area", area);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

                        // Nếu có thông báo từ stored procedure, nó sẽ hiển thị ở đây
                        MessageBox.Show("Cập nhật thông tin rạp chiếu thành công!");
                    }
                }
                catch (SqlException ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
                finally
                {
                    // Đảm bảo đóng kết nối
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

    }
}
