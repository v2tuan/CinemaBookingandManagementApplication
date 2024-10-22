using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
using CinemaBookingandManagementApplication.UserControls;
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

    public partial class Form_Booking : Form
    {
        public MovieSchedule movieSchedule { get; set; }
        public string CinemaID { get; set; } = string.Empty;
        public string CinemaName { get; set; } = string.Empty;
        public Movies movie { get; set; }

        String Order = "";
        int QtySeat = 0;
        List<Seat> listSeats = new List<Seat>();

        Form activeForm = null;
        public Form_Booking()
        {
            InitializeComponent();
            // Bật chế độ WrapMode cho cột hoặc toàn bộ DataGridView
            dataGridViewOrder.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Điều chỉnh chiều cao hàng tự động để phù hợp với nội dung
            dataGridViewOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Form_Booking_Load(object sender, EventArgs e)
        {
            pic_movie.Image = movie.Image;

            //Form_ChooseChair form_ChooseChair = new Form_ChooseChair();
            //form_ChooseChair.movieSchedule = movieSchedule;
            //form_ChooseChair.setSeat();
            //openChildForm(form_ChooseChair);

            buttonScreening.Text = $"{movieSchedule.Stime.Hours}:{movieSchedule.Stime.Minutes:D2}";
            try
            {
                flowLayoutPanelSeat.Controls.Clear();
                RoomDaoImpl roomDaoImpl = new RoomDaoImpl();
                DataTable dt = roomDaoImpl.GetSeatsByRoomId(movieSchedule.Rid);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        UserControl_Seat userControl_Seat = new UserControl_Seat();
                        Seat seat = new Seat();
                        seat.SeatId = int.Parse(dr["seatid"].ToString());
                        seat.Rid = dr["rid"].ToString();
                        seat.States = int.Parse(dr["states"].ToString());
                        seat.Snumber = dr["snumber"].ToString();
                        seat.Srow = dr["srow"].ToString();
                        userControl_Seat.seat = seat;
                        //userControl_Seat.setNumberSeat(int.Parse(seat.Snumber));

                        flowLayoutPanelSeat.Controls.Add(userControl_Seat);

                        userControl_Seat.buttonClick += (ss, ee) =>
                        {
                            if (userControl_Seat.cheked)
                            {
                                QtySeat += 1;
                                listSeats.Add(userControl_Seat.seat);
                            }
                            else
                            {
                                QtySeat -= 1;
                                listSeats.Remove(userControl_Seat.seat);
                            }
                            
                            Order = QtySeat.ToString() + "x Ghế đơn Ghế:\n" + string.Join(", ", listSeats);

                            int rowIndex = 0;
                            if (rowIndex >= 0 && rowIndex < dataGridViewOrder.Rows.Count)
                            {
                                dataGridViewOrder.Rows.RemoveAt(rowIndex);
                            }
                            if (QtySeat != 0)
                            {
                                dataGridViewOrder.Rows.Add(new object[] {
                                Order,
                                string.Format("{0:#,##0} ₫", (QtySeat * 75000).ToString())
                              });
                            }
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            labelName.Text = CinemaName + " - " + movieSchedule.Rid;
            labelMovieName.Text = movie.Moviename;
            labelDate.Text = "Suất: " + $"{movieSchedule.Stime.Hours}:{movieSchedule.Stime.Minutes:D2}" + " - " + movieSchedule.Sdate.ToString("dddd, dd/MM/yyyy");
        }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                // Đảm bảo giải phóng tài nguyên trước khi đóng form
                activeForm.Dispose();
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_ChooseCombo());
        }
    }
}
