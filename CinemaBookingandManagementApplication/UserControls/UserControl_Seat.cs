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
    public partial class UserControl_Seat : UserControl
    {
        Seat seat = new Seat();
        public UserControl_Seat()
        {
            InitializeComponent();
        }

        public void setNumberSeat(int number)
        {
            buttonSeat.Text = number.ToString();
        }

        private void InitializeComponent()
        {
            this.buttonSeat = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // buttonSeat
            // 
            this.buttonSeat.BorderRadius = 10;
            this.buttonSeat.BorderThickness = 1;
            this.buttonSeat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSeat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSeat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSeat.FillColor = System.Drawing.Color.White;
            this.buttonSeat.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeat.ForeColor = System.Drawing.Color.Black;
            this.buttonSeat.Location = new System.Drawing.Point(0, 0);
            this.buttonSeat.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSeat.Name = "buttonSeat";
            this.buttonSeat.Size = new System.Drawing.Size(50, 50);
            this.buttonSeat.TabIndex = 80;
            this.buttonSeat.Text = "1";
            // 
            // UserControl_Seat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonSeat);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "UserControl_Seat";
            this.Size = new System.Drawing.Size(50, 50);
            this.ResumeLayout(false);

        }
    }
}
