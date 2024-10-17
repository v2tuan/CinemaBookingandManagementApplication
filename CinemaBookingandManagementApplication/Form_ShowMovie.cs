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
    public partial class Form_ShowMovie : Form
    {
        public event EventHandler buttonBuyClick = null;
        public Form_ShowMovie()
        {
            InitializeComponent();
        }

        private void Form_ShowMovie_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                UserControl_Movie userControl = new UserControl_Movie();
                fpanel_show_movie.Controls.Add(userControl);
                userControl.buttonClick += (ss, ee) =>
                {
                    buttonBuyClick?.Invoke(this, e);
                };
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            using(Form_AddMovie frm = new Form_AddMovie())
            {
                frm.ShowDialog();
            }
        }
    }
}
