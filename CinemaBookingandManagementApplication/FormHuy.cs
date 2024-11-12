using CinemaBookingandManagementApplication.configs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CinemaBookingandManagementApplication
{
    public partial class FormHuy : Form
    {
        public FormHuy()
        {
            InitializeComponent();
        }
        private void DisplayMovieRevenueView()
        {
            try
            {
                // Lấy dữ liệu từ view MovieRevenueView
                DataTable movieRevenueData = Views.GetMovieRevenueView();

                // Đưa dữ liệu vào DataGridView
                dataGridView1.DataSource = movieRevenueData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        // Hàm để hiển thị top 5 phim doanh thu cao nhất
        private void DisplayTop5MoviesReport()
        {
            try
            {
                // Lấy dữ liệu từ stored procedure GenerateTop5MoviesReport
                DataTable top5MoviesData = Procedure.GenerateTop5MoviesReport();

                // Đưa dữ liệu vào DataGridView
                dataGridView1.DataSource = top5MoviesData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayTop5MoviesReport();
        }

        private void FormHuy_Load(object sender, EventArgs e)
        {
            DisplayMovieRevenueView();
        }
    }
}
