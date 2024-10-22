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
    public partial class UserControl_Combo : UserControl
    {
        public Combo combo { get; set; }
        public event EventHandler addClick = null;
        public event EventHandler minusClick = null;

        public UserControl_Combo()
        {
            InitializeComponent();
        }

        public UserControl_Combo(Combo combo)
        {
            InitializeComponent();
            this.combo = combo;
            pictureBoxCombo.Image = combo.Image;
            labelName.Text = combo.ComboName;
            labelDescription.Text = combo.Descriptions;
        }

        private void txt_quantity_IconRightClick(object sender, EventArgs e)
        {
            addClick?.Invoke(this, e);
            int quantity = int.Parse(txt_quantity.Text);
            quantity += 1;
            txt_quantity.Text = quantity.ToString();
        }

        private void txt_quantity_IconLeftClick(object sender, EventArgs e)
        {
            minusClick?.Invoke(this, e);
            int quantity = int.Parse(txt_quantity.Text);
            quantity -= 1;
            txt_quantity.Text = quantity.ToString();
        }
    }
}
