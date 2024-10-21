using CinemaBookingandManagementApplication.UserControls;
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
    public partial class Form_ChooseChair : Form
    {
        public Form_ChooseChair()
        {
            InitializeComponent();
        }

        private void Form_ChooseChair_Load(object sender, EventArgs e)
        {
            flowLayoutPanelSeat.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    UserControl_Seat userControl_Seat = new UserControl_Seat();
                    userControl_Seat.setNumberSeat(j + 1);
                    flowLayoutPanelSeat.Controls.Add(userControl_Seat);
                }
            }
        }
    }
}
