﻿using CinemaBookingandManagementApplication.configs;
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
    public partial class Form_BaoCaoNam : Form
    {
        public Form_BaoCaoNam()
        {
            InitializeComponent();
        }

        private void Form_BaoCaoNam_Load(object sender, EventArgs e)
        {
            int year = 2024;
            DataTable businessReport = Function.GetBusinessReportOfYear(year);
            baocaodata.DataSource = businessReport;
            baocaodata.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            baocaodata.EnableHeadersVisualStyles = false;
            baocaodata.AllowUserToResizeColumns = false;
            baocaodata.AllowUserToResizeRows = false;
            baocaodata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            baocaodata.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Đặt màu nền cho Header
            baocaodata.ColumnHeadersDefaultCellStyle.BackColor = Color.LightCoral; // Đỏ nhạt
            baocaodata.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Màu chữ trắng
            baocaodata.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold); // Phông chữ đậm

            // Đặt màu nền cho body của DataGridView
            baocaodata.DefaultCellStyle.BackColor = Color.White; // Màu nền trắng cho các hàng
            baocaodata.DefaultCellStyle.ForeColor = Color.Black; // Màu chữ đen
            baocaodata.DefaultCellStyle.Font = new Font("Arial", 9); // Phông chữ chính cho body

            // Tùy chọn: Đặt màu xen kẽ giữa các hàng
            baocaodata.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // Màu xám nhạt cho các hàng xen kẽ

            // Tùy chỉnh độ cao của header và các hàng
            baocaodata.ColumnHeadersHeight = 50;
            baocaodata.RowTemplate.Height = 35;

            // Tùy chọn: Ẩn đường viền ô để giao diện gọn gàng hơn
            baocaodata.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Tùy chọn: Đặt căn giữa cho các ô trong cột header
            baocaodata.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tùy chọn: Căn lề cho dữ liệu trong các ô của DataGridView (trái, phải, hoặc giữa)
            baocaodata.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = int.Parse(comboBoxType.SelectedItem.ToString().Trim());
             DataTable businessReport = Function.GetBusinessReportOfYear(year);
            baocaodata.DataSource = null;
            baocaodata.DataSource = businessReport;
            baocaodata.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}