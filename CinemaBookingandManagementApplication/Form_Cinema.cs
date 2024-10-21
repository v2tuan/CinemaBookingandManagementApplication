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
    public partial class Form_Cinema : Form
    {
        public Cinemas cinema {  get; set; }
        public Form_Cinema()
        {
            InitializeComponent();
        }

        private void Form_Cinema_Load(object sender, EventArgs e)
        {
            PictureBoxCinema.Image = cinema.Image;
            labelName.Text = cinema.Cname;
            labelAddress.Text = cinema.Caddress;
            labelHotline.Text = cinema.Hotline;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            Form_AddRoom form_AddRoom = new Form_AddRoom();
            form_AddRoom.CinemaID = cinema.Cid;
            form_AddRoom.ShowDialog();
        }
    }
}
