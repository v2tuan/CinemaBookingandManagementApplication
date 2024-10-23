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
    public partial class UserControl_Room : UserControl
    {
        public Room Room { get; set; }
        public event EventHandler buttonClick = null;
        public UserControl_Room(Room Room)
        {
            InitializeComponent();
            this.Room = Room;
            buttonRoom.Text = Room.Rname;
        }

        public UserControl_Room()
        {
            InitializeComponent();
        }

        private void UserControl_Room_Load(object sender, EventArgs e)
        {

        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            buttonClick?.Invoke(this, e);
        }
    }
}
