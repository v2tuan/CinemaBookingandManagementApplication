using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication
{
    public partial class Form_EditCombo : Form
    {
        private Combo currentcombo;
        public Form_EditCombo(Combo combo)
        {
            InitializeComponent();
            currentcombo = combo;
            LoadComboDetail(combo);
        }
        public void LoadComboDetail(Combo combo)
        {
            textBoxComboName.Text = combo.ComboName.Trim();
            textBoxDescription.Text = combo.Descriptions.Trim();
            textBoxPrice.Text = combo.ComboPrice.ToString();
            if (combo.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    combo.Image.Save(ms, combo.Image.RawFormat);
                    pictureBoxCombo.Image = Image.FromStream(ms);
                }
            }

        }
        
        private void pictureBoxCombo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn tệp hình ảnh được chọn
                string imagePath = openFileDialog.FileName;

                // Cập nhật hình ảnh trong PictureBox
                pictureBoxCombo.ImageLocation = imagePath;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (Function.IsNumber(textBoxPrice.Text))
                {
                    ComboDaoImpl ComboDao = new ComboDaoImpl();
                    currentcombo.ComboName = textBoxComboName.Text.Trim();
                    currentcombo.Descriptions = textBoxDescription.Text.Trim();
                    currentcombo.ComboPrice = decimal.Parse(textBoxPrice.Text);

                    // Kiểm tra nếu ảnh không được chọn, thông báo cho người dùng
                    if (pictureBoxCombo.Image == null)
                    {
                        MessageBox.Show("Vui lòng chọn ảnh.");
                        return; // Dừng thực thi hàm nếu không có ảnh
                    }

                    // Nếu có ảnh, lưu ảnh vào bộ nhớ
                    MemoryStream pic = new MemoryStream();
                    pictureBoxCombo.Image.Save(pic, pictureBoxCombo.Image.RawFormat);
                    currentcombo.Image = pictureBoxCombo.Image;

                    // Cập nhật combo
                    ComboDao.update(currentcombo);
                    this.DialogResult = DialogResult.OK; // Thành công
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Yêu Cầu Nhập Đúng Dữ liệu");
                }
            }
            catch (Exception ex)
            {
                // Nếu có lỗi xảy ra trong quá trình lưu ảnh, thông báo lỗi
                MessageBox.Show("vui lòng chọn ảnh để thay đổi: " + ex.Message);
            }


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            ComboDaoImpl ComboDao = new ComboDaoImpl();
            ComboDao.delete(currentcombo);
            this.DialogResult = DialogResult.OK; // Thành công
            this.Close();
        }

        private void labelComboName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxComboName_TextChanged(object sender, EventArgs e)
        {
            labelComboName.Text = textBoxComboName.Text.Trim();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            labelDescription.Text = textBoxDescription.Text;
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            labelPrice.Text = "Giá: " + textBoxPrice.Text + " ₫";
        }
    }
}
