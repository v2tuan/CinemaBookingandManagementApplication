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

        // hàm get movie by date
        public static DataTable GetMoviesByDate(DateTime showDate)
        {
            DataTable moviesTable = new DataTable();

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM GET_MOVIES_BY_DATE", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure; // Đặt loại lệnh là stored procedure

                        // Thêm tham số cho hàm
                        command.Parameters.AddWithValue("@showDate", showDate);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(moviesTable); // Điền dữ liệu vào DataTable
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return moviesTable; // Trả về DataTable chứa danh sách phim
        }


        // hàm tính số ghế đã đăt cho một suất chiếu
        public static int CountBookedSeats(string showtimeId)
        {
            int totalBookedSeats = 0; // Biến để lưu tổng số ghế đã đặt

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT COUNT_BOOKED_SEATS(@shid)", conn))
                    {
                        // Thêm tham số cho hàm
                        command.Parameters.AddWithValue("@shid", showtimeId);

                        // Thực thi câu lệnh và lấy giá trị trả về
                        totalBookedSeats = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return totalBookedSeats; // Trả về tổng số ghế đã đặt
        }



        // hàm lấy ra top suất chiếu có lượt bán cao nhất
        public static DataTable GetMostPopularShowtimes(int top)
        {
            DataTable popularShowtimes = new DataTable(); // Khởi tạo DataTable để lưu kết quả

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GET_MOST_POPULAR_SHOWTIME(@top)", conn))
                    {
                        // Thêm tham số cho hàm
                        command.Parameters.AddWithValue("@top", top);

                        // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(popularShowtimes);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return popularShowtimes; // Trả về DataTable chứa danh sách suất chiếu phổ biến
        }


        // hàm trả về top phim có lượt bán vé cao nhất
        public static DataTable GetMostPopularMovies(int top)
        {
            DataTable popularMovies = new DataTable(); // Khởi tạo DataTable để lưu kết quả

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GET_MOST_POPULAR_MOVIES(@top)", conn))
                    {
                        // Thêm tham số cho hàm
                        command.Parameters.AddWithValue("@top", top);

                        // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(popularMovies);
                        }
                    }
                }
                catch (Exception ex)
                {
                   MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return popularMovies; // Trả về DataTable chứa danh sách phim phổ biến
        }


        // tính tổng doanh thu của một phim 

        public static decimal CalculateTotalRevenueByMovie(string movieId)
        {
            decimal totalRevenue = 0; // Khởi tạo biến để lưu tổng doanh thu

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.CALCULATE_TOTAL_REVENUE_BY_MOVIE(@mid)", conn))
                    {
                        // Thêm tham số cho hàm
                        command.Parameters.AddWithValue("@mid", movieId);

                        // Thực thi hàm và lấy giá trị trả về
                        totalRevenue = (decimal)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return totalRevenue; // Trả về tổng doanh thu
        }


        // tính tổng doanh thu theo ngày 
        public static decimal CalculateDailyRevenue(DateTime date)
        {
            decimal totalRevenue = 0; // Khởi tạo biến để lưu tổng doanh thu

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.CALCULATE_DAILY_REVENUE(@date)", conn))
                    {
                        // Thêm tham số cho hàm
                        command.Parameters.AddWithValue("@date", date);

                        // Thực thi hàm và lấy giá trị trả về
                        totalRevenue = (decimal)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return totalRevenue; // Trả về tổng doanh thu
        }
        //tổng doanh thu  từ việc bán vé và các sản phẩm như đồ ăn/uống.
        public static decimal CalculateTotalRevenue()
        {
            decimal totalRevenue = 0;

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.CALCULATE_TOTAL_REVENUE()", conn))
                    {
                        // Thực thi lệnh và lấy giá trị trả về
                        totalRevenue = (decimal)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return totalRevenue; // Trả về tổng doanh thu
        }
        //hàm liệt kê doanh thu của từng bộ phim
        public static DataTable CalculateRevenueByMovie()
        {
            DataTable revenueData = new DataTable(); // Khởi tạo DataTable để lưu kết quả

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.CALCULATE_REVENUE_BY_MOVIE()", conn))
                    {
                        // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(revenueData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return revenueData; // Trả về DataTable chứa doanh thu theo từng bộ phim
        }
        //Tính tổng số vé bán trong một bộ phim cụ thể
        public static int CountTicketsSoldByMovie(string movieId)
        {
            int totalTickets = 0; // Khởi tạo biến để lưu tổng số vé đã bán

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.COUNT_TICKETS_SOLD_BY_MOVIE(@mid)", conn))
                    {
                        // Thêm tham số cho hàm
                        command.Parameters.AddWithValue("@mid", movieId);

                        // Thực thi hàm và lấy giá trị trả về
                        totalTickets = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return totalTickets; // Trả về tổng số vé đã bán
        }
        //Tính số lượng vé bán trong một ngày cụ thể.
        public static int CountTicketsSoldByDate(DateTime date)
        {
            int totalTickets = 0; // Khởi tạo biến để lưu tổng số vé đã bán

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.COUNT_TICKETS_SOLD_BY_DATE(@date)", conn))
                    {
                        // Thêm tham số cho hàm
                        command.Parameters.AddWithValue("@date", date);

                        // Thực thi hàm và lấy giá trị trả về
                        totalTickets = (int)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return totalTickets; // Trả về tổng số vé đã bán
        }
        //Kiểm tra trạng thái của một ghế trong phòng chiếu.
        public static string CheckSeatAvailability(int seatId)
        {
            string seatStatus = string.Empty; // Biến để lưu trữ trạng thái ghế

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.CHECK_SEAT_AVAILABILITY(@seatId)", conn))
                    {
                        // Thêm tham số cho hàm
                        command.Parameters.AddWithValue("@seatId", seatId);

                        // Thực thi câu lệnh và lấy giá trị trả về
                        seatStatus = (string)command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return seatStatus; // Trả về trạng thái ghế
        }
        //hàm check id rroom
        public static bool checkRoomID(string roomID)
        {
            bool exists = false;
            try
            {
                conn.Open();
                int result;

                // Gọi hàm SQL
                using (SqlCommand command = new SqlCommand("SELECT dbo.COUNT_ROOM(@ROOMID)", conn))
                {
                    command.Parameters.AddWithValue("@ROOMID", roomID);
                    result = (int)command.ExecuteScalar(); // Chuyển đổi kết quả thành kiểu int

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
        //hàm list phong 
        public static DataTable GetRoomList()
        {
            DataTable rooms = new DataTable();
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM GetRoomList()", conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(rooms);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return rooms;
        }

        //hàm list room theo ID cinema
        public static DataTable GetRoomsByCinemaId(string cinemaId)
        {
            DataTable rooms = new DataTable();

            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi hàm SQL
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetRoomsByCinemaId(@cinemaId)", conn))
                    {
                        cmd.Parameters.AddWithValue("@cinemaId", cinemaId);

                        // Sử dụng SqlDataAdapter để lấy dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(rooms); // Đổ dữ liệu vào DataTable
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return rooms;
        }
        //hàm đếm số ghế trong phòng theo idroom
        public static int GetTotalSeatsByRoomId(string roomId)
        {
            int totalSeats = 0;

            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi function SQL
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.GetTotalSeatsByRoomId(@roomId)", conn))
                    {
                        // Thêm tham số roomId vào lệnh
                        cmd.Parameters.AddWithValue("@roomId", roomId);

                        // Thực thi lệnh và lấy kết quả
                        totalSeats = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return totalSeats;
        }
        //hàm list các ghế chưa đặt theo IDRoom
        public static DataTable GetAvailableSeatsByRoomId(string roomId)
        {
            DataTable availableSeats = new DataTable();

            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi hàm từ SQL Server
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetAvailableSeatsByRoomId(@roomId)", conn))
                    {
                        // Thêm tham số cho hàm
                        cmd.Parameters.AddWithValue("@roomId", roomId);

                        // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(availableSeats);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
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

            // Trả về DataTable chứa danh sách ghế trống
            return availableSeats;
        }
        //hàm check ID showtime 
        public static bool CheckIDShowtime(string showtimeId)
        {
            bool exists = false;
            try
            {
                // Mở kết nối với cơ sở dữ liệu
                conn.Open();
                int result;

                // Tạo lệnh SQL để gọi hàm kiểm tra IDShowtime
                using (SqlCommand command = new SqlCommand("SELECT dbo.CountIDShowtime(@showtimeId)", conn))
                {
                    // Thêm tham số IDShowtime vào câu lệnh SQL
                    command.Parameters.AddWithValue("@showtimeId", showtimeId);

                    // Thực thi lệnh và lấy kết quả trả về từ hàm SQL
                    result = (Int32)command.ExecuteScalar();

                    // Kiểm tra kết quả, nếu là 1 thì IDShowtime tồn tại
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
                // Hiển thị thông báo lỗi nếu có
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Đảm bảo kết nối được đóng
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return exists;
        }

        // hàm lấy tên rạp từ id
        public static string GetCinemaNameById(string cinemaId)
        {
            string cinemaName = string.Empty;

            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi function SQL
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.GET_CINEMA_NAME_BY_ID(@CinemaId)", conn))
                    {
                        // Thêm tham số cinemaId vào lệnh
                        cmd.Parameters.AddWithValue("@CinemaId", cinemaId);

                        // Thực thi lệnh và lấy kết quả
                        cinemaName = (string)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return cinemaName; // Trả về tên rạp phim
        }

        // hàm lấy lịch chiếu từ id của movie


        public static DataTable GetMovieSchedulesByMovieId(string movieId)
        {
            DataTable schedulesTable = new DataTable();

            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi function SQL
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM GET_MOVIE_SCHEDULES_BY_MOVIE_ID(@MovieId)", conn))
                    {
                        // Thêm tham số movieId vào lệnh
                        cmd.Parameters.AddWithValue("@MovieId", movieId);

                        // Thực thi lệnh và lấy kết quả vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(schedulesTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return schedulesTable; // Trả về danh sách lịch chiếu
        }


        // hàm lấy lịch chiếu dựa vào ngày chiếu
        public static DataTable GetMovieSchedulesByDate(DateTime showDate)
        {
            DataTable schedulesTable = new DataTable();

            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi function SQL
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM GET_MOVIE_SCHEDULES_BY_DATE(@ShowDate)", conn))
                    {
                        // Thêm tham số showDate vào lệnh
                        cmd.Parameters.AddWithValue("@ShowDate", showDate);

                        // Thực thi lệnh và lấy kết quả vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(schedulesTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return schedulesTable; // Trả về danh sách lịch chiếu
        }


        // hàm lấy lịch chiếu theo cụm rạp
        public static DataTable GetMovieSchedulesByCinemaId(string cinemaId)
        {
            DataTable schedulesTable = new DataTable();

            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi function SQL
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM GET_MOVIE_SCHEDULES_BY_CINEMA_ID(@CinemaId)", conn))
                    {
                        // Thêm tham số cinemaId vào lệnh
                        cmd.Parameters.AddWithValue("@CinemaId", cinemaId);

                        // Thực thi lệnh và lấy kết quả vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(schedulesTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return schedulesTable; // Trả về danh sách lịch chiếu
        }

    }
}
