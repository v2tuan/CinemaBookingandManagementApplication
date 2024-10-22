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
    public partial class UserControl_EditCombo : UserControl
    {
        public Combo combo {  get; set; }
        public event EventHandler editClick = null;
        public UserControl_EditCombo(Combo combo)
        {
            InitializeComponent();
            this.combo = combo;
            pictureBoxCombo.Image = combo.Image;
            labelName.Text = combo.ComboName;
            labelDescription.Text = combo.Descriptions;
            labelPrice.Text = combo.ComboPrice.ToString();
        }

        public UserControl_EditCombo()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            editClick?.Invoke(this, e);
        }
    }
}
