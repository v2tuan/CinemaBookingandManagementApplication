using CinemaBookingandManagementApplication.Dao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.configs
{
    internal class Procedure
    {
        private My_DB myDB = new My_DB();  // Sử dụng lớp My_DB để lấy kết nối

        public void AddNewMovie(string mid, string moviename, int ageRestriction, decimal revenue,
                    string mtid, DateTime releaseDate, int duration, string descriptions, byte[] images)
        {
            using (SqlConnection conn = myDB.getConnectionFromFile())  // Lấy kết nối từ My_DB
            {
                using (SqlCommand cmd = new SqlCommand("AddNewMovie", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số
                    cmd.Parameters.AddWithValue("@mid", mid);
                    cmd.Parameters.AddWithValue("@moviename", moviename);
                    cmd.Parameters.AddWithValue("@ageRestriction", ageRestriction);
                    cmd.Parameters.AddWithValue("@revenue", revenue);
                    cmd.Parameters.AddWithValue("@mtid", mtid);
                    cmd.Parameters.AddWithValue("@releaseDate", releaseDate); // Thay đổi tên tham số
                    cmd.Parameters.AddWithValue("@duration", duration); // Thay đổi tên tham số
                    cmd.Parameters.AddWithValue("@descriptions", descriptions); // Thay đổi tên tham số
                    cmd.Parameters.AddWithValue("@images", images); // Thay đổi tên tham số

                    // Mở kết nối và thực thi stored procedure
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
