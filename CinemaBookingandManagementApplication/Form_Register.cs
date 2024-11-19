using CinemaBookingandManagementApplication.configs;
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
using static System.Net.Mime.MediaTypeNames;

namespace CinemaBookingandManagementApplication
{
    public partial class Form_Register : Form
    {
      
        public Form_Register()
        {
            InitializeComponent();
            comboBoxType.DataSource = Function.GetListCinema();
            comboBoxType.ValueMember = "cid";
            comboBoxType.DisplayMember = "cname";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                MessageBox.Show("Các Thông Tin Nhân Viên Không Được Để Trống !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            User user = new User();
            user.username =usernametxt.Text.Trim();
            bool exist = Function.CheckUsernameExists(user.username);
            if (exist)
            {
                MessageBox.Show("Tên Đăng Nhập Này Đã Tồn Tại, Yêu Cầu Nhập Tên Đăng Nhập Mới !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            user.firstname = ftxt.Text.Trim();
            user.lastname = ltxt.Text.Trim();
            user.password = passtxt.Text.Trim();
            string confirm = confirmtxt.Text.Trim();
            if (user.password != confirm)
            {
                MessageBox.Show("Yêu cầu nhập đúng mật khẩu xác nhận.");
                return;
            }
            user.cid = comboBoxType.SelectedValue.ToString();
            string role = null;
            if (isadminradio.Checked)
            {
                user.isAdmin = true;
                role = "ADMIN";
            }else
            { 
                user.isAdmin = false;
                role = "EMPLOYEE";
            }
            bool isCreated = Function.CreateLoginUser(role, user.username, user.password);

            if (isCreated)
            {
                    Procedure.InsertUserAndCinema(user);
            }

        }
        bool verify()
        {
            if (ftxt.Text == "" ||
                ltxt.Text == "" ||
                usernametxt.Text == "" ||
            passtxt.Text == "" ||
            confirmtxt.Text == ""
                )
                return true;
            else
                return false;
        }

     
    }
}
