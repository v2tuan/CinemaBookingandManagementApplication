using CinemaBookingandManagementApplication.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            Form_ShowMovie form_ShowMovie = new Form_ShowMovie();
            openChildForm(form_ShowMovie);
            form_ShowMovie.buttonBuyClick += (ss, ee) =>
            {
                Form_detailMovie frm = new Form_detailMovie();
                openChildForm(frm);
            };

            Form_ShowMovie form_ShowMovie2 = new Form_ShowMovie();
            openChildForm(form_ShowMovie2);
            form_ShowMovie2.buttonBuyClick += (ss, ee) =>
            {
                Form_detailMovie frm = new Form_detailMovie();
                openChildForm(frm);
            };
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
            Form_Cinema frm = new Form_Cinema();
            openChildForm(frm);
        }
    }
}
