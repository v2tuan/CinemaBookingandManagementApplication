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
    public partial class UserControl_show_schedule_information : UserControl
    {
        public UserControl_show_schedule_information()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UserControl_show_schedule_information
            // 
            this.Name = "UserControl_show_schedule_information";
            this.Load += new System.EventHandler(this.UserControl_show_schedule_information_Load);
            this.ResumeLayout(false);

        }

        private void UserControl_show_schedule_information_Load(object sender, EventArgs e)
        {

        }
    }
}
