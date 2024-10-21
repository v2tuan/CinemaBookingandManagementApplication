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
    public partial class UserControl_show_schedule : UserControl
    {
        public MovieSchedule movieSchedule {  get; set; } = null;
        public event EventHandler buttonClick = null;
        public UserControl_show_schedule()
        {
            InitializeComponent();
        }

        private void btn_time_Click(object sender, EventArgs e)
        {
            buttonClick?.Invoke(this, e);
        }

        private void UserControl_show_schedule_Load(object sender, EventArgs e)
        {
            if (movieSchedule != null)
            {
                btn_time.Text = $"{movieSchedule.Stime.Hours}:{movieSchedule.Stime.Minutes:D2}";
            }
        }
    }
}
