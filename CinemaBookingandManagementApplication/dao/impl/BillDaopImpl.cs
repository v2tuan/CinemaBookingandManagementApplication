using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.dao.impl
{
    internal class BillDaopImpl
    {
        public void CompleteBill(string bId, string cusId, List<Ticket> tickets, List<DetailCombo> combos, decimal totalPrice)
        {
            Procedure.CompleteBill(bId, cusId, tickets, combos, totalPrice);
        }
    }
}
