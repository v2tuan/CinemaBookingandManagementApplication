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
    public partial class Form_Booking : Form
    {
        Form activeForm = null;
        public Form_Booking()
        {
            InitializeComponent();
        }

        private void Form_Booking_Load(object sender, EventArgs e)
        {
            openChildForm(new Form_ChooseChair());
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

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ChooseCombo());
        }
    }
}
