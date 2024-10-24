using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication.dao.impl
{
    internal class BillDaopImpl
    {
        public void CompleteBill(string bId, string cusId, List<Ticket> tickets, List<DetailCombo> combos, decimal totalPrice)
        {
            Procedure.CompleteBill(bId, cusId, tickets, combos, totalPrice);
        }

        public String IDNext()
        {
            try
            {
                int count = 0;
                count++;
                string nextID = "B" + count.ToString("D6");

                while (checkID(nextID))
                {
                    count++;
                    nextID = "B" + count.ToString("D6");
                }
                return nextID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Bills", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public bool checkID(string billID)
        {
            return Function.checkBillID(billID);
        }

        public System.Data.DataTable GetListMovie()
        {
            return Function.GetListMovie();
        }
    }
}
