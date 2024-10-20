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
    public partial class UserControl_CinemaShowTime : UserControl
    {
        public Cinema cinema {  get; set; } = new Cinema();
        public string CinemaID { get; set; } = string.Empty;
        public string CinemaName { get; set; } = string.Empty;
        public Movie movie { get; set; }
        public DateTime Date { get; set; }
        public UserControl_CinemaShowTime()
        {
            InitializeComponent();
        }

        private void UserControl_CinemaShowTime_Load(object sender, EventArgs e)
        {
            labelCinemaName.Text = CinemaName;
        }
    }
}
