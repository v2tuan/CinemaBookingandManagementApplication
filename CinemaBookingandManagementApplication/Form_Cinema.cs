using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
using CinemaBookingandManagementApplication.UserControls;
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

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                flowLayoutPanelRoom.Controls.Clear();
                RoomDaoImpl roomDaoImpl = new RoomDaoImpl();
                DataTable dt = roomDaoImpl.GetRoomsByCinemaId(cinema.Cid);

                
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        
                        Room room = new Room();
                        room.Rid = dr["rid"].ToString();
                        room.Rname = dr["rname"].ToString();
                        room.Cid = dr["cid"].ToString();

                        UserControl_Room userControl_Room = new UserControl_Room(room);
                        flowLayoutPanelRoom.Controls.Add(userControl_Room);

                        userControl_Room.buttonClick += (ss, ee) =>
                        {
                            Form_EditRoom editRoom = new Form_EditRoom(room);
                            editRoom.ShowDialog();
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
