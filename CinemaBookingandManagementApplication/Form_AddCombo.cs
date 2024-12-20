﻿using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
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
    public partial class Form_AddCombo : Form
    {
        public Form_AddCombo()
        {
            InitializeComponent();
        }

        private void textBoxComboName_TextChanged(object sender, EventArgs e)
        {
            labelComboName.Text = textBoxComboName.Text.Trim();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            labelDescription.Text = textBoxDescription.Text.Trim() ;
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            labelPrice.Text = "Giá: " +  textBoxPrice.Text + " ₫";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Function.IsNumber(textBoxPrice.Text))
            {
                Combo combo = new Combo();
                combo.ComboName = textBoxComboName.Text.Trim();
                combo.Descriptions = textBoxDescription.Text.Trim();
                combo.ComboPrice = decimal.Parse(textBoxPrice.Text);
                combo.Image = pictureBoxCombo.Image;
                ComboDaoImpl comboDaoImpl = new ComboDaoImpl();
                comboDaoImpl.CreateNewCombo(combo);
                this.DialogResult = DialogResult.OK; // Thành công
                this.Close();
            }
            else
                MessageBox.Show("Yêu Cầu Nhập Đúng Dữ liệu");
           
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
    }
}
