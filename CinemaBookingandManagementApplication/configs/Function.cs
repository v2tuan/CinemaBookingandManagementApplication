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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace CinemaBookingandManagementApplication.configs
{
    static class Function
    {
        public static SqlConnection conn2 = new My_DB().getConnection();
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
                    if (result == 1)
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
            using (SqlConnection conn = new My_DB().getConnection())
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

                    if (result == 1)
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

                    if ( result == 1)
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
                    if (  result == 1)
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

        public static string GetCinemaAreaById(string cinemaId)
        {
            string cinemaArea = string.Empty;

            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi function SQL
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.GET_CINEMA_AREA_BY_ID(@CinemaId)", conn))
                    {
                        // Thêm tham số cinemaId vào lệnh
                        cmd.Parameters.AddWithValue("@CinemaId", cinemaId);

                        // Thực thi lệnh và lấy kết quả
                        cinemaArea = (string)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return cinemaArea; // Trả về tên rạp phim
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
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM GET_MOVIES_BY_DATE(@ShowDate)", conn))
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

        // func lấy rạp có lịch chiếu phim

        public static DataTable GetCinemasWithMovieSchedules(string movieId, DateTime showDate)
        {
            DataTable cinemasTable = new DataTable();

            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi function SQL
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM GET_CINEMAS_WITH_MOVIE_SCHEDULES(@MovieId, @ShowDate)", conn))
                    {
                        // Thêm tham số vào lệnh
                        cmd.Parameters.AddWithValue("@MovieId", movieId);
                        cmd.Parameters.AddWithValue("@ShowDate", showDate);

                        // Thực thi lệnh và lấy kết quả vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(cinemasTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return cinemasTable; // Trả về danh sách rạp có lịch chiếu
        }


        // func hàm tìm lịch chiếu theo cid, mid, date
        public static DataTable GetMovieSchedulesByCinema(string cinemaId, string movieId, DateTime showDate)
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
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM GET_MOVIE_SCHEDULES_BY_CID_MID_DATE(@CinemaId, @MovieId, @ShowDate)", conn))
                    {
                        // Thêm tham số vào lệnh
                        cmd.Parameters.AddWithValue("@CinemaId", cinemaId);
                        cmd.Parameters.AddWithValue("@MovieId", movieId);
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

            return schedulesTable; // Trả về danh sách lịch chiếu của phim
        }

        public static DataTable GetMovieByCinemaAndTime(string cinemaId, DateTime showDate)
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
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM GET_MOVIE_SCHEDULES_BY_CID_DATE(@CinemaId, @ShowDate)", conn))
                    {
                        // Thêm tham số vào lệnh
                        cmd.Parameters.AddWithValue("@CinemaId", cinemaId);
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

            return schedulesTable; // Trả về danh sách lịch chiếu của phim
        }

        //Hàm list ghế theo id room
        public static DataTable GetSeatsByRoomId(string roomId)
        {
            DataTable seatsTable = new DataTable();

            // Sử dụng kết nối từ file thay vì chuỗi kết nối trực tiếp
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo lệnh để gọi function SQL
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.GetSeatsByRoomId(@RoomId)", conn))
                    {
                        // Thêm tham số vào lệnh
                        cmd.Parameters.AddWithValue("@RoomId", roomId);

                        // Thực thi lệnh và lấy kết quả vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(seatsTable);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return seatsTable; // Trả về danh sách ghế của phòng
        }

        //hàm list combo
        public static DataTable GetComboList()
        {
            DataTable combos = new DataTable();
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM LIST_COMBO()", conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(combos);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return combos;
        }
        //Hàm check ID của bill
        public static bool checkBillID(string billID)
        {
            bool exists = false;
            try
            {
                conn.Open();
                int result;
                // Gọi hàm SQL
                using (SqlCommand command = new SqlCommand("SELECT dbo.CHECK_Bill(@BILLID)", conn))
                {
                    command.Parameters.AddWithValue("@BILLID", billID);
                    result = (Int32)command.ExecuteScalar();
                    if (result == 1)
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


        // hàm check nhập liệu là só

        public static  bool IsNumber(string input)
        {
            // Kiểm tra nếu input có thể chuyển đổi thành số
            return int.TryParse(input, out _);
        }

        // hàm check nhập liệu là chữ
        public static bool IsAllLetters(string input)
        {
            // Kiểm tra chuỗi không trống và tất cả ký tự là chữ
            return !string.IsNullOrEmpty(input) && input.All(char.IsLetter);
        }


        //hàm sắp xếp Phim theo doang thu trên từng Rạp
        public static DataTable GetMoviesSortedByRevenue(string cinemaId)
        {
            DataTable movies = new DataTable();
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM GetMoviesSortedByRevenue(@CinemaId)", conn))
                    {
                        // Thêm tham số @CinemaId cho câu lệnh SQL
                        command.Parameters.AddWithValue("@CinemaId", cinemaId);

                        // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(movies);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return movies;
        }
        //hàm lấy danh sách bill theo id cinema
        public static DataTable GetBillsByCinemaId(string cinemaId)
        {
            DataTable bills = new DataTable();

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();

                    // SQL command to call the GetBillsByCinemaId function
                    using (SqlCommand command = new SqlCommand(
                        "SELECT * FROM dbo.GetBillsByCinemaId(@cinemaId)", conn))
                    {
                        // Add the cinema ID parameter to the command
                        command.Parameters.AddWithValue("@cinemaId", cinemaId);

                        // Use SqlDataAdapter to execute the command and fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(bills);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Display error message if an exception occurs
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return bills;
        }

        //hàm lấy doanh thu, số lượng nhân viên, số lượng movie, số lượng phòng theo id Cinema
        public static DataTable GetCinemaStatistics(string cinemaId)
        {
            DataTable cinemaStats = new DataTable();
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM GetCinemaStatistics(@cid)", conn))
                    {
                        // Thêm tham số @cid cho câu lệnh SQL
                        command.Parameters.AddWithValue("@cid", cinemaId);

                        // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(cinemaStats);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return cinemaStats;
        }
        //hàm search movie theo movie name va cinema name
        public static DataTable SearchMoviesWithCinema(string movieName, string cinemaName)
        {
            DataTable movies = new DataTable();

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();

                    // Tạo câu lệnh SQL để gọi hàm table-valued
                    using (SqlCommand command = new SqlCommand(
                        "SELECT * FROM dbo.SearchMoviesWithCinema(@movieName, @cinemaName)", conn))
                    {
                        // Thêm các tham số cho câu lệnh SQL
                        command.Parameters.AddWithValue("@movieName", movieName);
                        command.Parameters.AddWithValue("@cinemaName", cinemaName);

                        // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(movies);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return movies;
        }
        //hàm search movie theo movie name
        public static DataTable SearchMoviesByName(string movieName)
        {
            DataTable movies = new DataTable();

            // Assuming My_DB().getConnectionFromFile() gives a valid SQL connection.
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();

                    // Create a SQL command to call the SearchMoviesByName function
                    using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.SearchMoviesByName(@movieName)", conn))
                    {
                        // Add the movie name parameter to the command
                        command.Parameters.AddWithValue("@movieName", movieName);

                        // Use SqlDataAdapter to execute the command and fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(movies);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during database access
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return movies;
        }
        //hàm search combo theo combo name
        public static DataTable SearchComboByName(string comboName)
        {
            DataTable combos = new DataTable();

            // Assuming My_DB().getConnectionFromFile() gives a valid SQL connection.
            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();

                    // Create a SQL command to call the SearchComboByName function
                    using (SqlCommand command = new SqlCommand(
                        "SELECT * FROM dbo.SearchComboByName(@comboName)", conn))
                    {
                        // Add the combo name parameter to the command
                        command.Parameters.AddWithValue("@comboName", comboName);

                        // Use SqlDataAdapter to execute the command and fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(combos);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during database access
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return combos;
        }
        //hàm search cinema theo cinema name
        public static DataTable SearchCinemaByName(string cinemaName)
        {
            DataTable cinemas = new DataTable();

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();

                    // Create a SQL command to call the SearchCinemaByName function
                    using (SqlCommand command = new SqlCommand(
                        "SELECT * FROM dbo.SearchCinemaByName(@cinemaName)", conn))
                    {
                        // Add the cinema name parameter to the command
                        command.Parameters.AddWithValue("@cinemaName", cinemaName);

                        // Use SqlDataAdapter to execute the command and fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(cinemas);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Display an error message if an exception occurs
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return cinemas;
        }
        //hàm sắp xếp doanh thu phim theo cinema id
        public static DataTable GetMoviesByRevenueDesc(string cinemaId)
        {
            DataTable movies = new DataTable();

            using (SqlConnection conn = new My_DB().getConnectionFromFile())
            {
                try
                {
                    conn.Open();

                    // SQL command to call the GetMoviesByRevenueDesc function
                    using (SqlCommand command = new SqlCommand(
                        "SELECT * FROM dbo.GetMoviesByRevenueDesc(@cinemaId)", conn))
                    {
                        // Add the cinema ID parameter to the command
                        command.Parameters.AddWithValue("@cinemaId", cinemaId);

                        // Use SqlDataAdapter to execute the command and fill the DataTable
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(movies);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Display error message if an exception occurs
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return movies;
        }

        public static bool CheckUsernameExists(string username)
        {
            bool exists = false;
            try
            {
                conn2.Open();
                int result;

                // Gọi hàm SQL CheckUsernameExists
                using (SqlCommand command = new SqlCommand("SELECT dbo.CheckUsernameExists(@username)", conn2))
                {
                    command.Parameters.AddWithValue("@username", username);
                    // command.Parameters.AddWithValue("@password", password);
                    result = (int)command.ExecuteScalar();

                    if (result == 1)
                    {
                        exists = true; // Username tồn tại
                    }
                    else
                    {
                        exists = false; // Username không tồn tại
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
                if (conn2.State == ConnectionState.Open)
                {
                    conn2.Close();
                }
            }
            return exists;
        }

        public static bool CheckLogin(string username,string pass)
        {
            bool exists = false;
            try
            {
                conn2.Open();
                int result;

                // Gọi hàm SQL CheckUsernameExists
                using (SqlCommand command = new SqlCommand("SELECT dbo.CheckLogin(@username,@pass)", conn2))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@pass", pass);
                    // command.Parameters.AddWithValue("@password", password);
                    result = (int)command.ExecuteScalar();

                    if (result == 1)
                    {
                        exists = true; // Username tồn tại
                    }
                    else
                    {
                        exists = false; // Username không tồn tại
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
                if (conn2.State == ConnectionState.Open)
                {
                    conn2.Close();
                }
            }
            return exists;
        }
        public static bool CreateLoginUser(string roleName, string loginName, string password)
        {
            bool isSuccess = false;

            try
            {
                // Mở kết nối
                conn2.Open();

                // Tạo SqlCommand để gọi stored procedure
                using (SqlCommand cmd = new SqlCommand("USP_CREATE_LOGIN_USER", conn2))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số vào stored procedure
                    cmd.Parameters.AddWithValue("@Role_Name", roleName);
                    cmd.Parameters.AddWithValue("@Login_Name", loginName);
                    cmd.Parameters.AddWithValue("@Password_Login", password);

                    // Thực thi stored procedure
                    cmd.ExecuteNonQuery();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo login và user: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đảm bảo đóng kết nối
                if (conn2.State == ConnectionState.Open)
                {
                    conn2.Close();
                }
            }
            return isSuccess;
        }

        // func login 
        public static bool Login(string username, string password)
        {
            My_DB my_DB = new My_DB();
            // Chuỗi kết nối với các thông tin đăng nhập từ người dùng
            string connectionString = my_DB.getConnectionStrFromFile("ConnectionStr.txt") + "User Id =" + username + "; Password =" + password + ";";

            bool isLoggedIn = false;

            // Tạo kết nối với chuỗi kết nối trên
             using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    isLoggedIn = true;
                    
                }
                catch (SqlException ex)
                {   
                    MessageBox.Show("Lỗi đăng nhập : " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isLoggedIn = false;
                }
            }

            return isLoggedIn;
        }


        // get is admin 
        public static bool GetIsAdminByUsername(string username)
        {
            bool isAdmin = false;
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT dbo.GetIsAdminByUsername(@username)", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        isAdmin = Convert.ToBoolean(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred : " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return isAdmin;
        }


        // get cid từ user name
        public static string GetCidByUsername(string username)
        {
            string cid = string.Empty;
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT dbo.GetCidByUsername(@username);", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        cid = result.ToString();
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
            return cid;
        }
        public static DataTable getListArea()
        {
            DataTable area = new DataTable();
            try
            {
                conn.Open();

                // Gọi hàm SQL
                using (SqlCommand command = new SqlCommand("SELECT * FROM LIST_AREA()", conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(area);
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
            return area;
        }
        public static DataTable getListCinemaByArea(string area)
        {
            DataTable cinema = new DataTable();
            try
            {
                conn.Open();

                // Gọi hàm SQL
                using (SqlCommand command = new SqlCommand("SELECT * FROM GetCinemasByArea(@area)", conn))
                {
                    command.Parameters.AddWithValue("@area", area);
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
            finally
            {
                // Đảm bảo kết nối được đóng lại
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return cinema;
        }


        // chưa fix còn lỗi 
        public static bool checkDuplicateSeatAndShid(int seatid, string shid)
        {
            bool exists = false;
            try
            {
                conn.Open();
                int result;
                using (SqlCommand command = new SqlCommand("SELECT dbo.CheckDuplicateSeatAndShid(@SEATID, @SHID)", conn))
                {
                    command.Parameters.AddWithValue("@SEATID", seatid);
                    command.Parameters.AddWithValue("@SHID", shid);
                    result = (int)command.ExecuteScalar();
                    //result = 1;
                    if (result == 1)
                    {
                        exists = true; 
                    }
                    else
                    {
                        exists = false; 
                    }
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi nếu có
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
        
        //hàm dự đoán doanh thu tháng tiếp theo 
        public static decimal GetDuDoanDoanhThuThangTiepTheo(string maRap, int namHienTai, int thangHienTai)
        {
            decimal doanhThuTrungBinh = 0;

            //using (SqlConnection conn = new My_DB().getConnectionFromFile())
            using (SqlConnection conn = new My_DB().getConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.DuDoanDoanhThuThangTiepTheo(@maRap, @namHienTai, @thangHienTai)", conn))
                    {
                        // Thêm các tham số đầu vào cho hàm SQL
                        command.Parameters.AddWithValue("@maRap", maRap);
                        command.Parameters.AddWithValue("@namHienTai", namHienTai);
                        command.Parameters.AddWithValue("@thangHienTai", thangHienTai);

                        // Thực thi câu lệnh và lấy kết quả
                        object result = command.ExecuteScalar();

                        // Kiểm tra kết quả trả về
                        if (result != null && result != DBNull.Value)
                        {
                            doanhThuTrungBinh = Convert.ToDecimal(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return doanhThuTrungBinh;
        }
        //hàm doanh thu theo tháng dựa vào cinema id
        public static decimal TinhDoanhThuBaoGomComboVaVe(string maRap, int nam, int thang)
        {
            decimal doanhThuThang = 0;

            // using (SqlConnection conn = new My_DB().getConnectionFromFile())
            using (SqlConnection conn = new My_DB().getConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand("SELECT dbo.TinhDoanhThuBaoGomComboVaVe(@maRap, @nam, @thang)", conn))
                    {
                        // Thêm các tham số đầu vào cho hàm SQL
                        command.Parameters.AddWithValue("@maRap", maRap);
                        command.Parameters.AddWithValue("@nam", nam);
                        command.Parameters.AddWithValue("@thang", thang);

                        // Thực thi câu lệnh và lấy kết quả
                        object result = command.ExecuteScalar();

                        // Kiểm tra kết quả trả về
                        if (result != null && result != DBNull.Value)
                        {
                            doanhThuThang = Convert.ToDecimal(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return doanhThuThang;
        }
        public static DataTable GetBusinessReportOfYear(int year)
        {
            DataTable report = new DataTable();
            using (SqlConnection conn = new My_DB().getConnection()) // Kết nối đến cơ sở dữ liệu
            {
                try
                {
                    conn.Open();
                    // Gọi hàm GetBusinessReportOfYear với tham số năm
                    using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.GetBusinessReportOfYear(@Year)", conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@Year", year);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Điền dữ liệu vào DataTable
                            adapter.Fill(report);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi nếu có
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            return report; // Trả về bảng kết quả
        }
    }
}
