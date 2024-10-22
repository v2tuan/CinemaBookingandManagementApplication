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
    public partial class Form_ManagerCombo : Form
    {
        public Form_ManagerCombo()
        {
            InitializeComponent();
        }

        private void btnAddCombo_Click(object sender, EventArgs e)
        {
            Form_AddCombo frm = new Form_AddCombo();
            frm.ShowDialog();
        }
    }
}
