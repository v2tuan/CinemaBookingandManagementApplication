using CinemaBookingandManagementApplication.dao.impl;
using CinemaBookingandManagementApplication.models;
using CinemaBookingandManagementApplication.UserControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
        ArrayList listCombo = new ArrayList();
        // Khởi tạo một Dictionary
        Dictionary<Combo, int> listChooseCombo = new Dictionary<Combo, int>();


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
                                dataGridViewOrder.Rows.Add(new object[] { Order, string.Format("{0:#,##0} ₫", (QtySeat * 75000).ToString()) });
                            }
                            caculateTotal();
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
            string Order = "";

            if (listSeats.Count > 0 && !buttonChooseCombo.Checked)
            {
                buttonChooseCombo.Checked = true;
                Form_ChooseCombo form_ChooseCombo = new Form_ChooseCombo();
                openChildForm(form_ChooseCombo);

                form_ChooseCombo.addClick += (ss, ee, chosecombo) =>
                {
                    int count = 0;
                    if (listChooseCombo.ContainsKey(chosecombo))
                    {
                        count = listChooseCombo[chosecombo];
                        Order = (count).ToString() + "x " + chosecombo.ComboName.Trim();
                        foreach (DataGridViewRow item in dataGridViewOrder.Rows)
                        {

                            // Thêm ràng buộc tên Combo không được giống nhau//
                            ///////////////////////////////////////////////////
                            if (item.Cells[0].Value.ToString() == Order)
                            {
                                item.Cells[0].Value = (count + 1).ToString() + "x " + chosecombo.ComboName.Trim();
                                item.Cells[1].Value = string.Format("{0:#,##0} ₫", ((count + 1) * chosecombo.ComboPrice).ToString());
                            }
                        }
                        listChooseCombo[chosecombo]++;
                    }
                    else
                    {
                        listChooseCombo.Add(chosecombo, 1);
                        count = listChooseCombo[chosecombo];
                        Order = count.ToString() + "x " + chosecombo.ComboName.Trim();
                        dataGridViewOrder.Rows.Add(new object[] { Order, string.Format("{0:#,##0} ₫", (count * chosecombo.ComboPrice).ToString()) });
                    }
                    caculateTotal();

                };
                form_ChooseCombo.minusClick += (ss, ee, chosecombo) =>
                {
                    if (listChooseCombo.ContainsKey(chosecombo))
                    {
                        int count = listChooseCombo[chosecombo];

                        if (count > 0)
                        {
                            Order = (count).ToString() + "x " + chosecombo.ComboName.Trim();
                            foreach (DataGridViewRow item in dataGridViewOrder.Rows)
                            {
                                if (item.Cells[0].Value.ToString() == Order)
                                {
                                    item.Cells[0].Value = (count - 1).ToString() + "x " + chosecombo.ComboName.Trim();
                                    item.Cells[1].Value = string.Format("{0:#,##0} ₫", ((count - 1) * chosecombo.ComboPrice).ToString());
                                }
                            }
                        }
                        listChooseCombo[chosecombo]--;
                    }
                    caculateTotal();
                };
            }
            else if (listSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế");
            }
            else if (buttonChooseCombo.Checked && !buttonPayment.Checked)
            {
                buttonPayment.Checked = true;
                Form_Pay Pay_Form = new Form_Pay();
                openChildForm(Pay_Form);
                btn_Continue.Text = "Complete";
            }
            else if (btn_Continue.Text == "Complete")
            {

                List<Ticket> listTicket = new List<Ticket>();
                List<DetailCombo> listDetailCombo = new List<DetailCombo>();


                foreach (var seat in listSeats)
                {
                    Ticket ticket = new Ticket();
                    ticket.Price = decimal.Parse("75000");
                    ticket.Tdate = DateTime.Now;
                    ticket.Shid = movieSchedule.Shid;
                    ticket.SeatId = seat.SeatId;
                    listTicket.Add(ticket);
                }

                foreach (var keyValue in listChooseCombo)
                {
                    DetailCombo detailCombo = new DetailCombo();
                    detailCombo.ComboId = keyValue.Key.ComboId;
                    detailCombo.Quantity = keyValue.Value;
                    listDetailCombo.Add(detailCombo);
                }

                decimal totalPrice = decimal.Parse(labelTotal.Text.Replace(",", "").Replace(" ₫", ""));

                Form_InformationCustomer form_InformationCustomer = new Form_InformationCustomer();
                form_InformationCustomer.listTicket = listTicket;
                form_InformationCustomer.listDetailCombo = listDetailCombo;
                form_InformationCustomer.totalPrice = totalPrice;
                form_InformationCustomer.ShowDialog();

                //BillDaopImpl billDaopImpl = new BillDaopImpl();
                //string bId = billDaopImpl.IDNext();
                //string cusId = null;
                //decimal totalPrice = decimal.Parse(labelTotal.Text.Replace(",", "").Replace(" ₫", ""));
                //billDaopImpl.CompleteBill(bId, cusId, listTicket, listDetailCombo, totalPrice);
            }
        }

        public void caculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow item in dataGridViewOrder.Rows)
            {
                total += decimal.Parse(item.Cells[1].Value.ToString().Replace(",", "").Replace(" ₫", ""));
            }

            labelTotal.Text = string.Format("{0:#,##0} ₫", total);
        }
    }
}
