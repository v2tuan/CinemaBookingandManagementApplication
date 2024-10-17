using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.dao.impl;
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
    public partial class Form_AddMovie : Form
    {
        public Form_AddMovie()
        {
            InitializeComponent();
            comboBoxType.DataSource = MovieTypeDaoImpl.getListMovieType();
            comboBoxType.ValueMember = "mtid";
            comboBoxType.DisplayMember = "typename";
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxMovie_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn tệp hình ảnh được chọn
                string imagePath = openFileDialog.FileName;

                // Cập nhật hình ảnh trong PictureBox
                pictureBoxMovie.ImageLocation = imagePath;
            }
        }
    }
}
