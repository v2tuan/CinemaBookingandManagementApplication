using CinemaBookingandManagementApplication.dao.impl;
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

namespace CinemaBookingandManagementApplication
{
    public partial class Form_InformationCustomer : Form
    {
        public List<Ticket> listTicket { get; set; }
        public List<DetailCombo> listDetailCombo { get; set; }
        public decimal totalPrice { get; set; }
        public Form_InformationCustomer()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                BillDaopImpl billDaopImpl = new BillDaopImpl();
                string bId = billDaopImpl.IDNext();
                string cusId = null;
                string customerName = textBoxCustomerName.Text;
                string email = textBoxEmail.Text;
                billDaopImpl.CompleteBillAndSendMail(bId, cusId, listTicket, listDetailCombo, totalPrice, customerName, email);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
