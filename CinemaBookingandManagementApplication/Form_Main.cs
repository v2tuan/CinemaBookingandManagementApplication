﻿using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.Dao;
using CinemaBookingandManagementApplication.models;
using CinemaBookingandManagementApplication.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication
{
    public partial class Form_Main : Form
    {
        Form activeForm = null;
        public Form_Main()
        {
            InitializeComponent();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            if(Constant.role !="admin")
            {
                buttonfigures.Visible = false;
                buttonCinema.Visible = false;
                buttonCombo.Visible = false;
                buttonManagerMovie.Visible = false;
            }
            My_DB db = new My_DB();

            Form_ShowMovie form_ShowMovie = new Form_ShowMovie();
            openChildForm(form_ShowMovie);
            form_ShowMovie.buttonBuyClick += (ss, ee) =>
            {
                Form_detailMovie frm = new Form_detailMovie();
                openChildForm(frm);
            };

            if(User_Static.Role != 1)
            {
                buttonCinema.Hide();
                buttonfigures.Hide();
            }
        }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                // Đảm bảo giải phóng tài nguyên trước khi đóng form
                activeForm.Dispose();
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            object s = new object();
            EventArgs ee = new EventArgs();
            Form_Main_Load(s, ee);
        }

        private void buttonfigures_Click(object sender, EventArgs e)
        {
            Form_HomeManager frm = new Form_HomeManager();
            openChildForm(frm);
            //using(Form_HomeManager frm = new Form_HomeManager())
            //{
            //    openChildForm(frm);
            //}
        }

        private void buttonCinema_Click(object sender, EventArgs e)
        {
            Form_ShowCinema frm = new Form_ShowCinema();
            openChildForm(frm);
        }

        private void buttonManagerMovie_Click(object sender, EventArgs e)
        {
            Form_ManagerMovie frm = new Form_ManagerMovie();
            openChildForm(frm);
        }

        private void buttonCombo_Click(object sender, EventArgs e)
        {
            Form_ManagerCombo frm = new Form_ManagerCombo();
            openChildForm(frm);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            //Constant.idcinema = null;
           // Constant.uname = null;
           /// Constant.pass = null;
          //  Constant.role = null;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            
            // Constant.idcinema = null;
            //  Constant.uname = null;
            ///  Constant.pass = null;
            // Constant.role = null;
        }
    }
}
