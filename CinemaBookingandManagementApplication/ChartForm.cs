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
