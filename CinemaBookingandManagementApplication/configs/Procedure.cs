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
using Guna.UI2.WinForms.Suite;

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
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = images.ToArray();
                        }
                        else
                        {
                            MessageBox.Show("không có ảnh");
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
        public static void CreateNewCinema(string cid, string cname, string caddress, string hotline, string area, MemoryStream images)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        // Thêm tham số hình ảnh (image có thể null)
                        if (images != null)
                        {
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = images.ToArray();
                        }
                        else
                        {
                            MessageBox.Show("không có ảnh");
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = DBNull.Value;
                        }
                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                       
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
        public static void UpdateCinema(string cid, string cname, string caddress, string hotline, string area, MemoryStream images)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        // Thêm tham số hình ảnh (image có thể null)
                        if (images != null)
                        {
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = images.ToArray();
                        }
                        else
                        {
                            MessageBox.Show("không có ảnh");
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = DBNull.Value;
                        }
                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

                        
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
        
        //add new seat
        public static void AddNewSeat(string rid, int states, string snumber, string srow)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("AddNewSeat", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@rid", rid);
                        cmd.Parameters.AddWithValue("@states", states);
                        cmd.Parameters.AddWithValue("@snumber", snumber);
                        cmd.Parameters.AddWithValue("@srow", srow);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                  
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
        //add new customer
        public static void AddNewCustomer(string cusid, string image, string phone, string fullname, string address)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("AddNewCustomer", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@cusid", cusid);
                        cmd.Parameters.AddWithValue("@image", image);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@fullname", fullname);
                        cmd.Parameters.AddWithValue("@address", address);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        
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
        //add new food item
        public static void AddNewFoodItem(string foodItemId, string foodItemName, decimal price, int quantity)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("AddNewFoodItem", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@foodItemId", foodItemId);
                        cmd.Parameters.AddWithValue("@foodItemName", foodItemName);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@quantity", quantity);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                      
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
        //add new combo
        public static void CreateNewCombo(string comboId, string comboName, decimal comboPrice, MemoryStream images, string descriptions)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("CreateNewCombo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@comboId", comboId);
                        cmd.Parameters.AddWithValue("@comboName", comboName);
                        cmd.Parameters.AddWithValue("@comboPrice", comboPrice);

                        // Thêm tham số cho image, nếu không có, thì gán là DBNull.Value
                        if (images != null)
                            cmd.Parameters.AddWithValue("@images", images);
                        else
                            cmd.Parameters.AddWithValue("@images", DBNull.Value);

                        cmd.Parameters.AddWithValue("@descriptions", descriptions);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
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

        //add new bill
        public static void CreateNewBill(string bId, decimal price, int states, string cusid)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("CreateNewBill", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@bId", bId);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@states", states);
                        cmd.Parameters.AddWithValue("@cusid", cusid);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                       
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
        //add new ticket
        public static void AddNewTicket(string tid, decimal price, DateTime tdate, string bId, string shid, int seatid)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("AddNewTicket", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@tid", tid);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@tdate", tdate);
                        cmd.Parameters.AddWithValue("@bId", bId);
                        cmd.Parameters.AddWithValue("@shid", shid);
                        cmd.Parameters.AddWithValue("@seatid", seatid);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                       
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
        //add new show time
        public static void AddShowtime(string shid, string mid, DateTime sdate, DateTime stime, DateTime etime, int seatEmpty, string rid)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("AddShowtime", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@shid", shid);
                        cmd.Parameters.AddWithValue("@mid", mid);
                        cmd.Parameters.AddWithValue("@sdate", sdate);
                        cmd.Parameters.AddWithValue("@stime", stime.TimeOfDay); // Chỉ lấy thời gian từ DateTime
                        cmd.Parameters.AddWithValue("@etime", etime.TimeOfDay); // Chỉ lấy thời gian từ DateTime
                        cmd.Parameters.AddWithValue("@seatEmpty", seatEmpty);
                        cmd.Parameters.AddWithValue("@rid", rid);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
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

        //add new room
        public static void CreateNewRoom(string rid, string rname, string cid)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("CreateNewRoom", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@rid", rid);
                        cmd.Parameters.AddWithValue("@rname", rname);
                     
                        cmd.Parameters.AddWithValue("@cid", cid);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        
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
        //update seat
         public static void UpdateSeat(int seatid, string rid, int states, string snumber, string srow)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("UpdateSeat", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@seatid", seatid);
                        cmd.Parameters.AddWithValue("@rid", rid);
                        cmd.Parameters.AddWithValue("@states", states);
                        cmd.Parameters.AddWithValue("@snumber", snumber);
                        cmd.Parameters.AddWithValue("@srow", srow);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật chỗ ngồi thành công!");
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
        //update customer
        public static void UpdateCustomer(string cusid, string image, string phone, string fullname, string address)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("UpdateCustomer", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@cusid", cusid);
                        cmd.Parameters.AddWithValue("@image", image);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@fullname", fullname);
                        cmd.Parameters.AddWithValue("@address", address);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin khách hàng thành công!");
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
        //update food item
        public static void UpdateFoodItem(string foodItemId, string foodItemName, decimal price, int quantity)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("UpdateFoodItem", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@foodItemId", foodItemId);
                        cmd.Parameters.AddWithValue("@foodItemName", foodItemName);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@quantity", quantity);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin sản phẩm thực phẩm thành công!");
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
        //update combo
        public static void UpdateCombo(string comboId, string comboName, decimal comboPrice, MemoryStream images, string descriptions)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("UpdateCombo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@comboId", comboId);
                        cmd.Parameters.AddWithValue("@comboName", comboName);
                        cmd.Parameters.AddWithValue("@comboPrice", comboPrice);

                        // Thêm tham số cho image, nếu không có, thì gán là DBNull.Value
                        if (images != null)
                            cmd.Parameters.AddWithValue("@images", images);
                        else
                            cmd.Parameters.AddWithValue("@images", DBNull.Value);

                        cmd.Parameters.AddWithValue("@descriptions", descriptions);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin combo thành công!");
                    }

                }
                catch (Exception ex)
                {
                    // Xử lý lỗi
                    MessageBox.Show("An error occurred: " + ex.Message);
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

        //Update bill
        public static void UpdateBill(string billId, decimal price, int states, string customerId)
        {
            using (SqlConnection conn = myDB.getConnectionFromFile()) // Kết nối cơ sở dữ liệu
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                try
                {
                    conn.Open();
                    // Sử dụng SqlCommand để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("UpdateBill", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@bId", billId);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@states", states);
                        cmd.Parameters.AddWithValue("@cusid", customerId);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin hóa đơn thành công.");
                        
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi
                    MessageBox.Show("An error occurred: " + ex.Message);
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
        //update ticket
        public static void UpdateTicket(string ticketId, decimal price, DateTime ticketDate, string billId, string showtimeId, int seatId)
        {
            using (SqlConnection conn = myDB.getConnectionFromFile()) // Kết nối cơ sở dữ liệu
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                try
                {
                    conn.Open();
                    // Sử dụng SqlCommand để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("UpdateTicket", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@tid", ticketId);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@tdate", ticketDate);
                        cmd.Parameters.AddWithValue("@bId", billId);
                        cmd.Parameters.AddWithValue("@shid", showtimeId);
                        cmd.Parameters.AddWithValue("@seatid", seatId);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin vé xem phim thành công.");
                        
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi    
                    MessageBox.Show("An error occurred: " + ex.Message);
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
        //update Room
        public static void UpdateRoom(string rid, string rname, string cid)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("UpdateRoom", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@rid", rid);
                        cmd.Parameters.AddWithValue("@rname", rname);
                    
                        cmd.Parameters.AddWithValue("@cid", cid);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật phòng chiếu thành công!");
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
        //update showtime
        public static void UpdateShowtime(string shid, string mid, DateTime sdate, TimeSpan stime, TimeSpan etime, int states, string rid)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("UpdateShowtime", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@shid", shid);
                        cmd.Parameters.AddWithValue("@mid", mid);
                        cmd.Parameters.AddWithValue("@sdate", sdate);
                        cmd.Parameters.AddWithValue("@stime", stime);
                        cmd.Parameters.AddWithValue("@etime", etime);
                        cmd.Parameters.AddWithValue("@states", states);
                        cmd.Parameters.AddWithValue("@rid", rid);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật lịch chiếu thành công!");
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


        // hàm thủ tục delete movie
        public static void DeleteMovie(string movieId)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand(" EXEC DELETE_MOVIE", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@MID", movieId);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa phim thành công!");
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

        // hàm thủ tục
        public static void DeleteRoom(string roomId)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                // Đăng ký sự kiện để xử lý thông báo từ SQL Server
                conn.InfoMessage += (sender, e) =>
                {
                   
                        MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand(" EXEC DELETE_ROOM", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@ROOMID", roomId);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

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


        // hàm xóa seat 
        public static void DeleteSeat(int seatId)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                // Đăng ký sự kiện để xử lý thông báo từ SQL Server
                conn.InfoMessage += (sender, e) =>
                {
                    
                        MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("EXEC DELETE_SEAT", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@SEATID", seatId);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
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

        // delete customer
        public static void DeleteCustomer(string customerId)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                // Đăng ký sự kiện để xử lý thông báo từ SQL Server
                conn.InfoMessage += (sender, e) =>
                {
                   
                        MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand(" EXEC DELETE_CUSTOMER", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@CUSID", customerId);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
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


        // ham xoa combo
        public static void DeleteCombo(string comboId)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                // Đăng ký sự kiện để xử lý thông báo từ SQL Server
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand(" EXEC DELETE_COMBO", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@COMBOID", comboId);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa combo thành công!");
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



        // ham delete cinema
        public static void DeleteCinema(string cinemaId)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                // Đăng ký sự kiện để xử lý thông báo từ SQL Server
                conn.InfoMessage += (sender, e) =>
                {
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand(" EXEC DELETE_CINEMA", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@CINEMAID", cinemaId);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
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

        // hàm xóa lịch chiếu
        public static void DeleteShowtime(string showtimeId)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                // Đăng ký sự kiện để xử lý thông báo từ SQL Server
                conn.InfoMessage += (sender, e) =>
                {
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("EXEC DELETE_SHOWTIME", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@ShowtimeID", showtimeId);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
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


        // cập nhập doanh thu phim sau khi thêm vé 
        public static void UpdateMovieRevenue(string movieId)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("EXEC UPDATE_MOVIE_REVENUE", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@MovieID", movieId);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật doanh thu cho phim thành công!");
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


        // proc hàm check số ghế trống
        public static void CheckAvailableSeats(string showtimeId)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                // Đăng ký sự kiện để xử lý thông báo từ SQL Server
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("CHECK_AVAILABLE_SEATS", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@shid", showtimeId);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
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

        // hàm thực hiện thanh toán 
        public static void ProcessPayment(string billId, string paymentMethod, int paymentStatus)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                // Đăng ký sự kiện để xử lý thông báo từ SQL Server
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure
                    using (SqlCommand cmd = new SqlCommand("EXEC PROCESS_PAYMENT", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@bId", billId);
                        cmd.Parameters.AddWithValue("@paymentStatus", paymentStatus);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
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
