using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication
{
    public partial class Form_EditCinema : Form
    {
        private Cinemas currentCinema;
        public Form_EditCinema(Cinemas cinema)
        {
            InitializeComponent();
            currentCinema = cinema;
            LoadCinemaDetails(cinema);
        }
        private void LoadCinemaDetails(Cinemas cinema)
        {
            textBoxCinemaName.Text = cinema.Cname;
            textBoxAddress.Text = cinema.Caddress;
            TextBoxHotline.Text = cinema.Hotline;
            textBoxArea.Text = cinema.Area;

            // Hiển thị hình ảnh
            if (cinema.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    cinema.Image.Save(ms, cinema.Image.RawFormat);
                    pictureBoxCinema.Image = Image.FromStream(ms);
                }
            }
        }
        private void pictureBoxCinema_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBoxCinema.ImageLocation = imagePath;
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.buttonEdit = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxHotline = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBoxCinema = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxArea = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCinemaName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.textBoxAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCinema)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.buttonDelete);
            this.guna2Panel2.Controls.Add(this.buttonEdit);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.LightGray;
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 299);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1131, 50);
            this.guna2Panel2.TabIndex = 41;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.BorderRadius = 5;
            this.buttonDelete.BorderThickness = 1;
            this.buttonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDelete.FillColor = System.Drawing.Color.Transparent;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonDelete.Location = new System.Drawing.Point(805, 9);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(144, 32);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonEdit.BorderRadius = 5;
            this.buttonEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonEdit.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonEdit.Location = new System.Drawing.Point(957, 9);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(159, 32);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit Cinema";
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(747, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Hotline";
            // 
            // TextBoxHotline
            // 
            this.TextBoxHotline.BorderColor = System.Drawing.Color.Gray;
            this.TextBoxHotline.BorderRadius = 5;
            this.TextBoxHotline.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxHotline.DefaultText = "";
            this.TextBoxHotline.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxHotline.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxHotline.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxHotline.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxHotline.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxHotline.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxHotline.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxHotline.Location = new System.Drawing.Point(750, 106);
            this.TextBoxHotline.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxHotline.Name = "TextBoxHotline";
            this.TextBoxHotline.PasswordChar = '\0';
            this.TextBoxHotline.PlaceholderText = "Input Hotline";
            this.TextBoxHotline.SelectedText = "";
            this.TextBoxHotline.Size = new System.Drawing.Size(313, 35);
            this.TextBoxHotline.TabIndex = 37;
            // 
            // pictureBoxCinema
            // 
            this.pictureBoxCinema.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxCinema.Location = new System.Drawing.Point(21, 76);
            this.pictureBoxCinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCinema.Name = "pictureBoxCinema";
            this.pictureBoxCinema.Size = new System.Drawing.Size(320, 160);
            this.pictureBoxCinema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCinema.TabIndex = 35;
            this.pictureBoxCinema.TabStop = false;
            this.pictureBoxCinema.Click += new System.EventHandler(this.pictureBoxCinema_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(393, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Area";
            // 
            // textBoxArea
            // 
            this.textBoxArea.BorderColor = System.Drawing.Color.Gray;
            this.textBoxArea.BorderRadius = 5;
            this.textBoxArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxArea.DefaultText = "";
            this.textBoxArea.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxArea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxArea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxArea.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxArea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxArea.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArea.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxArea.Location = new System.Drawing.Point(396, 184);
            this.textBoxArea.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.PasswordChar = '\0';
            this.textBoxArea.PlaceholderText = "Input Area";
            this.textBoxArea.SelectedText = "";
            this.textBoxArea.Size = new System.Drawing.Size(293, 35);
            this.textBoxArea.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cinema name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit Cinema";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1078, 0);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(53, 40);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.guna2ControlBox1);
            this.panelHeader.CustomBorderColor = System.Drawing.Color.LightGray;
            this.panelHeader.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.White;
            this.panelHeader.ForeColor = System.Drawing.Color.LightGray;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1131, 40);
            this.panelHeader.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(747, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // textBoxCinemaName
            // 
            this.textBoxCinemaName.BorderColor = System.Drawing.Color.Gray;
            this.textBoxCinemaName.BorderRadius = 5;
            this.textBoxCinemaName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxCinemaName.DefaultText = "";
            this.textBoxCinemaName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxCinemaName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxCinemaName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCinemaName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxCinemaName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCinemaName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCinemaName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxCinemaName.Location = new System.Drawing.Point(396, 106);
            this.textBoxCinemaName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCinemaName.Name = "textBoxCinemaName";
            this.textBoxCinemaName.PasswordChar = '\0';
            this.textBoxCinemaName.PlaceholderText = "Input Cinema Name";
            this.textBoxCinemaName.SelectedText = "";
            this.textBoxCinemaName.Size = new System.Drawing.Size(293, 35);
            this.textBoxCinemaName.TabIndex = 8;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.TextBoxHotline);
            this.guna2Panel1.Controls.Add(this.pictureBoxCinema);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.textBoxArea);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.textBoxCinemaName);
            this.guna2Panel1.Controls.Add(this.textBoxAddress);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1131, 349);
            this.guna2Panel1.TabIndex = 40;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BorderColor = System.Drawing.Color.Gray;
            this.textBoxAddress.BorderRadius = 5;
            this.textBoxAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAddress.DefaultText = "";
            this.textBoxAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxAddress.Location = new System.Drawing.Point(750, 184);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.PasswordChar = '\0';
            this.textBoxAddress.PlaceholderText = "Input Address";
            this.textBoxAddress.SelectedText = "";
            this.textBoxAddress.Size = new System.Drawing.Size(313, 35);
            this.textBoxAddress.TabIndex = 9;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Form_EditCinema
            // 
            this.ClientSize = new System.Drawing.Size(1131, 349);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EditCinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCinema)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            try
            {
                CinemaDaoImpl CinemaDao = new CinemaDaoImpl();

                currentCinema.Cname = textBoxCinemaName.Text;
                currentCinema.Caddress = textBoxAddress.Text;
                currentCinema.Hotline = TextBoxHotline.Text;
                currentCinema.Area = textBoxArea.Text;

                if (pictureBoxCinema.Image != null)
                {
                    MemoryStream pic = new MemoryStream();
                    pictureBoxCinema.Image.Save(pic, pictureBoxCinema.Image.RawFormat);
                    currentCinema.Image = pictureBoxCinema.Image;
                }

                CinemaDao.update(currentCinema);
                this.DialogResult = DialogResult.OK; // Thành công
                this.Close();
            }
            catch (Exception ex)
            {
                // Nếu có lỗi xảy ra trong quá trình lưu ảnh, thông báo lỗi
                MessageBox.Show("vui lòng thay đổi ảnh : " + ex.Message);
            }
        }

        private void pictureBoxCinema_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn tệp hình ảnh được chọn
                string imagePath = openFileDialog.FileName;

                // Cập nhật hình ảnh trong PictureBox
                pictureBoxCinema.ImageLocation = imagePath;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CinemaDaoImpl CinemaDao = new CinemaDaoImpl();
            CinemaDao.delete(currentCinema);
            this.DialogResult = DialogResult.OK; // Thành công
            this.Close();
        }
    }
}
