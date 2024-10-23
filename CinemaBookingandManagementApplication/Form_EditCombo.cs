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
            textBoxComboName.Text = combo.ComboName;
            textBoxDescription.Text = combo.Descriptions;
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

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
