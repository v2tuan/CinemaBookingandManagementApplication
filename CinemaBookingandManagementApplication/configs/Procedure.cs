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
using CinemaBookingandManagementApplication.models;
using Newtonsoft.Json;

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

                        if (images != null)
                        {
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = images.ToArray();
                        }
                        else
                        {
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = DBNull.Value;
                        }

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
        public static void CreateNewCinema(string cid, string cname, string caddress, string hotline, string area, MemoryStream images)
        {
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("CreateNewCinema", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@cid", cid);
                        cmd.Parameters.AddWithValue("@cname", cname);
                        cmd.Parameters.AddWithValue("@caddress", caddress);
                        cmd.Parameters.AddWithValue("@hotline", hotline);
                        cmd.Parameters.AddWithValue("@area", area);

                        // Kiểm tra hình ảnh, nếu null thì truyền DBNull.Value
                        if (images != null)
                        {
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = images.ToArray();
                        }
                        else
                        {
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = DBNull.Value;
                        }

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
                finally
                {
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
        public static void CreateNewCombo(string comboName, decimal comboPrice, string descriptions, MemoryStream images)
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

                        cmd.Parameters.AddWithValue("@comboName", comboName);
                        cmd.Parameters.AddWithValue("@comboPrice", comboPrice);
                        cmd.Parameters.AddWithValue("@descriptions", descriptions);
                        if (images != null)
                        {
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = images.ToArray();
                        }
                        else
                        {
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = DBNull.Value;
                        }

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

                        if (images != null)
                        {
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = images.ToArray();
                        }
                        else
                        {
                            MessageBox.Show("không có ảnh");
                            cmd.Parameters.Add("@images", SqlDbType.VarBinary).Value = DBNull.Value;
                        }

                        cmd.Parameters.AddWithValue("@descriptions", descriptions);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();

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
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa combo này không?", "Xác Nhận Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
                        using (SqlCommand cmd = new SqlCommand("DELETE_MOVIE", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Thêm tham số cho stored procedure
                            cmd.Parameters.AddWithValue("@MID", movieId);

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
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        // hàm thủ tục
        public static void DeleteRoom(string roomId)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này không?", "Xác Nhận Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
                        using (SqlCommand cmd = new SqlCommand("DELETE_ROOM", conn))
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
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }


        // hàm xóa seat 
        public static void DeleteSeat(int seatId)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa ghế này không?", "Xác Nhận Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
                        using (SqlCommand cmd = new SqlCommand(" DELETE_SEAT", conn))
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
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        // delete customer
        public static void DeleteCustomer(string customerId)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác Nhận Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
                        using (SqlCommand cmd = new SqlCommand(" DELETE_CUSTOMER", conn))
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
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }


        // ham xoa combo
        public static void DeleteCombo(string comboId)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa combo này không?", "Xác Nhận Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
                        using (SqlCommand cmd = new SqlCommand("DELETE_COMBO", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Thêm tham số cho stored procedure
                            cmd.Parameters.AddWithValue("@COMBOID", comboId);

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
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }



        // ham delete cinema
        public static void DeleteCinema(string cinemaId)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Cinema này không?", "Xác Nhận Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
                        using (SqlCommand cmd = new SqlCommand("DELETE_CINEMA", conn))
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
            else if (dialogResult == DialogResult.No)
            {

                return;

            }
        }

        // hàm xóa lịch chiếu
        public static void DeleteShowtime(string showtimeId)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa Lịch chiếu này không?", "Xác Nhận Xóa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
                        using (SqlCommand cmd = new SqlCommand("DELETE_SHOWTIME", conn))
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
            else if (dialogResult == DialogResult.No)
            {
                return;
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
                    using (SqlCommand cmd = new SqlCommand(" UPDATE_MOVIE_REVENUE", conn))
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

        public static void UpdateMovie(string mid, string moviename, int ageRestriction, decimal revenue, string mtid,
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
                    using (SqlCommand cmd = new SqlCommand("UpdateMovie", conn))
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
        //hàm hoàn thành bill
        public static void CompleteBill(string bId, string cusId, List<Ticket> tickets, List<DetailCombo> combos, decimal totalPrice)
        {
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("CompleteBill", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add basic parameters
                        cmd.Parameters.AddWithValue("@bId", bId);
                        if (cusId == null)
                        {
                            cmd.Parameters.AddWithValue("@cusId", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@cusId", cusId);
                        }
                        cmd.Parameters.AddWithValue("@totalPrice", totalPrice);

                        // Serialize tickets to JSON
                        string ticketJson = JsonConvert.SerializeObject(tickets);

                        // Add ticket JSON parameter
                        cmd.Parameters.AddWithValue("@ticketJson", ticketJson);

                        // Tạo chuỗi JSON cho DetailCombo
                        string comboJson = JsonConvert.SerializeObject(combos);

                        // Add combo JSON parameter
                        cmd.Parameters.AddWithValue("@comboJson", comboJson);

                        // Execute stored procedure
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
        //chức nang mới của Huy
        public static DataTable GenerateTop5MoviesReport()
        {
            // Tạo DataTable để lưu kết quả trả về từ stored procedure
            DataTable dataTable = new DataTable();

            // Sử dụng kết nối từ file
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                // Thêm sự kiện thông báo từ SQL Server
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };

                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi stored procedure GenerateTop5MoviesReport
                    using (SqlCommand cmd = new SqlCommand("GenerateTop5MoviesReport", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số vào nếu có (nếu stored procedure yêu cầu tham số, hiện tại không có)
                        // cmd.Parameters.AddWithValue("@paramName", value); // nếu cần

                        // Sử dụng SqlDataAdapter để lấy dữ liệu trả về từ stored procedure
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            // Điền dữ liệu vào DataTable
                            adapter.Fill(dataTable);
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

            // Trả về DataTable chứa kết quả
            return dataTable;
        }



        // proc them acount
        public static void InsertUserAndCinema(User user)
        {
            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = myDB.getConnection())
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
                    using (SqlCommand cmd = new SqlCommand("InsertUserAndCinema", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Thêm các tham số cho stored procedure từ model user
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@fname", user.firstname);
                        cmd.Parameters.AddWithValue("@lname", user.lastname);
                        cmd.Parameters.AddWithValue("@isadmin", user.isAdmin);
                        cmd.Parameters.AddWithValue("@pass", user.password);
                        cmd.Parameters.AddWithValue("@cid", user.cid);

                        // Thực thi stored procedure
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("Error occurred: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        public static void CompleteBillAndSendMail(string bId, string cusId, List<Ticket> tickets, List<DetailCombo> combos, decimal totalPrice, string customerName, string email)
        {
            using (SqlConnection conn = myDB.getConnectionFromFile())
            {
                conn.InfoMessage += (sender, e) =>
                {
                    // Hiển thị thông báo từ SQL Server qua MessageBox
                    MessageBox.Show("SQL Server Message: " + e.Message, "Thông báo từ SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("[CompleteBillAndSendMail]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add basic parameters
                        cmd.Parameters.AddWithValue("@bId", bId);
                        if (cusId == null)
                        {
                            cmd.Parameters.AddWithValue("@cusId", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@cusId", cusId);
                        }
                        cmd.Parameters.AddWithValue("@totalPrice", totalPrice);

                        // Serialize tickets to JSON
                        string ticketJson = JsonConvert.SerializeObject(tickets);

                        // Add ticket JSON parameter
                        cmd.Parameters.AddWithValue("@ticketJson", ticketJson);

                        // Tạo chuỗi JSON cho DetailCombo
                        string comboJson = JsonConvert.SerializeObject(combos);

                        // Add combo JSON parameter
                        cmd.Parameters.AddWithValue("@comboJson", comboJson);

                        // Add combo JSON parameter
                        cmd.Parameters.AddWithValue("@CustomerName", customerName);

                        // Add combo JSON parameter
                        cmd.Parameters.AddWithValue("@Email", email);

                        // Execute stored procedure
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
        //hàm hoàn thành bill và gửi mail
        
    }

