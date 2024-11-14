using CinemaBookingandManagementApplication.configs;
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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form_Register form_Register = new Form_Register();
            form_Register.ShowDialog();
            this.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                MessageBox.Show("Tài Khoản mật khẩu không được để trống !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            User user = new User();
            user.username = usernametxt.Text.Trim();
            user.password =passwordtxt.Text.Trim();
            Constant.uname = usernametxt.Text.Trim();
            Constant.pass = passwordtxt.Text.Trim();
            bool login = Function.CheckLogin (user.username,user.password);
            if (login == false)
            {
                MessageBox.Show("Tên Đăng Nhập Hoặc mật khẩu không đúng !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Constant.uname = null;
                Constant.pass = null;
                return;
            }
            if (Function.Login(user.username, user.password) )
            {
                
                bool isAdmin = Function.GetIsAdminByUsername(user.username);
                if (isAdmin)
                {
                    Constant.role = "admin";
                    MessageBox.Show("Đăng nhập thành công với quyền Admin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    Constant.role = "user";
                    string cid = Function.GetCidByUsername(user.username);

                    if (!string.IsNullOrEmpty(cid))
                    {
                        Constant.idcinema =cid;
                        MessageBox.Show("Đăng nhập thành công với quyền employee, và CID là: " + cid, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy CID cho người dùng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                this.Hide();
                Form_Main main = new Form_Main();
                main.ShowDialog();
                this.Show();
            }
            return;

        }
        bool verify()
        {
            if (
                usernametxt.Text == "" || passwordtxt.Text == "" 
                )
                return true;
            else
                return false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
