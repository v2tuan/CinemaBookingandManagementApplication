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
    public partial class UserControl_EditMovie : UserControl
    {
        public Movies movie { get; set; } = new Movies();

        public event EventHandler buttonClick = null;
        public UserControl_EditMovie()
        {
            InitializeComponent();
            //btn_edit.Visible = false;
            //pic_cover.Visible = false;
            //btn_edit.Visible = false;
        }
        private void pic_movie_MouseEnter(object sender, EventArgs e)
        {
           // btn_edit.Visible = true;
            //pic_cover.Visible = true;
        }

        private void pic_movie_MouseLeave(object sender, EventArgs e)
        {
            //pic_cover.Visible = false;
            //btn_edit.Visible = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            buttonClick?.Invoke(this, e);
        }

        private void btn_edit_MouseEnter(object sender, EventArgs e)
        {
          //  btn_edit.Visible = true;
            //pic_cover.Visible = true;
        }

        public void restart()
        {
            pic_movie.Image = movie.Image;
            labelName.Text = movie.Moviename;
           
        }

        private void pic_movie_Click(object sender, EventArgs e)
        {

        }
    }
}
