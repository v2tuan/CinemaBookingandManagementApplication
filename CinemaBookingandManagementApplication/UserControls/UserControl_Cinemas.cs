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

namespace CinemaBookingandManagementApplication.UserControls
{
    public partial class UserControl_Cinemas : UserControl
    {
        public Cinemas cinema { get; set; } = new Cinemas();
        public event EventHandler buttonClick = null;
        public event EventHandler editClick = null;
        public UserControl_Cinemas()
        {
            InitializeComponent();
        }

        public void restart()
        {
            PictureBoxCinema.Image = cinema.Image;
            labelName.Text = cinema.Cname;
            labelAddress.Text = cinema.Caddress;
            labelHotline.Text = cinema.Hotline;
        }

        private void UserControl_Cinema_Load(object sender, EventArgs e)
        {
            
        }

        private void UserControl_Cinema_Click(object sender, EventArgs e)
        {
           
        }

        private void UserControl_Cinema_DoubleClick(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ShadowPanel1_DoubleClick(object sender, EventArgs e)
        {
            buttonClick?.Invoke(this, e);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            editClick?.Invoke(this, e);
        }
    }
}