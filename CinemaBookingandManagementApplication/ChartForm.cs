using System;
using CinemaBookingandManagementApplication.configs;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CinemaBookingandManagementApplication
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu doanh thu (Giả sử bạn đã có các phương thức này)
            decimal doanhThuThangTruoc2 = Function.TinhDoanhThuBaoGomComboVaVe("Cineplex", 2023, 9); // Tháng trước 2
            decimal doanhThuThangTruoc = Function.TinhDoanhThuBaoGomComboVaVe("Cineplex", 2023, 10); // Tháng trước
            decimal doanhThuThangHienTai = Function.TinhDoanhThuBaoGomComboVaVe("Cineplex", 2023, 11); // Tháng hiện tại
            decimal doanhThuThangDuDoan = Function.GetDuDoanDoanhThuThangTiepTheo("Cineplex", 2023, 12); // Tháng dự đoán

            // Xóa các series cũ nếu có
            chart1.Series.Clear();

            // Tạo Series mới cho biểu đồ
            var series = new Series("Doanh Thu")
            {
                ChartType = SeriesChartType.Column, // Chọn loại biểu đồ là Cột
                BorderWidth = 1,
                IsValueShownAsLabel = true // Hiển thị giá trị trên mỗi cột
            };

            // Thêm dữ liệu vào các cột của biểu đồ
            series.Points.AddXY("Tháng trước 2", doanhThuThangTruoc2); // Cột 1
            series.Points.AddXY("Tháng trước", doanhThuThangTruoc); // Cột 2
            series.Points.AddXY("Tháng hiện tại", doanhThuThangHienTai); // Cột 3
            series.Points.AddXY("Tháng dự đoán", doanhThuThangDuDoan); // Cột 4

            // Thêm series vào biểu đồ
            chart1.Series.Add(series);

            // Cấu hình các tùy chọn cho biểu đồ
            chart1.ChartAreas[0].AxisX.Title = "Các tháng";
            chart1.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maRap = textBox1.ToString(); // Hoặc comboBox
            int nam = guna2DateTimePicker1.Value.Year;
            int thang = guna2DateTimePicker1.Value.Month;

            // Gọi hàm vẽ biểu đồ
            VẽBiểuĐồDoanhThu(maRap, nam, thang);
        }
        private void VẽBiểuĐồDoanhThu(string maRap, int nam, int thang)
        {
            // Lấy doanh thu của 2 tháng trước
            decimal doanhThuThangTruoc1 = Function.TinhDoanhThuBaoGomComboVaVe(maRap, nam, thang - 1);
            decimal doanhThuThangTruoc2 = Function.TinhDoanhThuBaoGomComboVaVe(maRap, nam, thang - 2);

            // Lấy doanh thu của tháng hiện tại
            decimal doanhThuThangHienTai = Function.TinhDoanhThuBaoGomComboVaVe(maRap, nam, thang);

            // Dự đoán doanh thu tháng tiếp theo
            decimal duDoanDoanhThu = Function.GetDuDoanDoanhThuThangTiepTheo(maRap, nam, thang);

            // Cấu hình biểu đồ
            chart1.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh Thu");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series.Add(series);

            // Thêm dữ liệu vào biểu đồ
            series.Points.AddXY("Tháng " + (thang - 2), doanhThuThangTruoc2); // Doanh thu tháng trước 2
            series.Points.AddXY("Tháng " + (thang - 1), doanhThuThangTruoc1); // Doanh thu tháng trước 1
            series.Points.AddXY("Tháng " + thang, doanhThuThangHienTai);      // Doanh thu tháng hiện tại
            series.Points.AddXY("Dự đoán", duDoanDoanhThu);                    // Doanh thu dự đoán

            // Tùy chỉnh biểu đồ (như tiêu đề, trục, v.v.)
            chart1.Titles.Clear();
            chart1.Titles.Add("Biểu đồ doanh thu");
            chart1.ChartAreas[0].AxisX.Title = "Tháng";
            chart1.ChartAreas[0].AxisY.Title = "Doanh thu";
        }

    }
}
