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
        /*
        //add new seat
        public static void AddNewSeat(string rid, int states, string snumber, string srow)
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
                        MessageBox.Show("Ghế đã được thêm thành công!");
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
                        MessageBox.Show("Khách hàng đã được thêm thành công!");
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
                        MessageBox.Show("Món ăn đã được thêm thành công!");
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
        public static void CreateNewCombo(string comboId, string comboName, decimal comboPrice, int quantity)
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
                    using (SqlCommand cmd = new SqlCommand("CreateNewCombo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@comboId", comboId);
                        cmd.Parameters.AddWithValue("@comboName", comboName);
                        cmd.Parameters.AddWithValue("@comboPrice", comboPrice);
                        cmd.Parameters.AddWithValue("@quantity", quantity);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Combo đã được tạo thành công!");
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
                        MessageBox.Show("Bill đã được tạo thành công!");
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
                        MessageBox.Show("Ticket đã được thêm thành công!");
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
        public static void AddShowtime(string shid, string mid, DateTime sdate, TimeSpan stime, TimeSpan etime, int states, int seatEmpty, string rid)
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
                    using (SqlCommand cmd = new SqlCommand("AddShowtime", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@shid", shid);
                        cmd.Parameters.AddWithValue("@mid", mid);
                        cmd.Parameters.AddWithValue("@sdate", sdate);
                        cmd.Parameters.AddWithValue("@stime", stime);
                        cmd.Parameters.AddWithValue("@etime", etime);
                        cmd.Parameters.AddWithValue("@states", states);
                        cmd.Parameters.AddWithValue("@seatEmpty", seatEmpty);
                        cmd.Parameters.AddWithValue("@rid", rid);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Showtime đã được thêm thành công!");
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
        public static void CreateNewRoom(string rid, string rname, string rtid, string cid)
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
                    using (SqlCommand cmd = new SqlCommand("CreateNewRoom", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@rid", rid);
                        cmd.Parameters.AddWithValue("@rname", rname);
                        cmd.Parameters.AddWithValue("@rtid", rtid);
                        cmd.Parameters.AddWithValue("@cid", cid);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Phòng chiếu đã được tạo thành công!");
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
         public static void UpdateCombo(string comboId, string comboName, decimal comboPrice, int quantity)
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
                    using (SqlCommand cmd = new SqlCommand("UpdateCombo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure
                        cmd.Parameters.AddWithValue("@comboId", comboId);
                        cmd.Parameters.AddWithValue("@comboName", comboName);
                        cmd.Parameters.AddWithValue("@comboPrice", comboPrice);
                        cmd.Parameters.AddWithValue("@quantity", quantity);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin combo thành công!");
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

        */
    }
}
