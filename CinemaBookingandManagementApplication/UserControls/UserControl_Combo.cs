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
    public partial class UserControl_Combo : UserControl
    {
        public UserControl_Combo()
        {
            InitializeComponent();
        }

        private void txt_quantity_IconRightClick(object sender, EventArgs e)
        {
            int quantity = int.Parse(txt_quantity.Text);
            quantity += 1;
            txt_quantity.Text = quantity.ToString();
        }
    }
}
