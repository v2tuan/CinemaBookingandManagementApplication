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
    public partial class Form_AddCombo : Form
    {
        public Form_AddCombo()
        {
            InitializeComponent();
        }

        private void textBoxComboName_TextChanged(object sender, EventArgs e)
        {
            labelComboName.Text = textBoxComboName.Text;
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            labelDescription.Text = textBoxDescription.Text;
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            labelPrice.Text = "Giá: " +  textBoxPrice.Text + " ₫";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
