using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.models
{
    public class Ticket
    {
        public string Tid { get; set; }
        public decimal Price { get; set; }
        public DateTime Tdate { get; set; }
        public string BId { get; set; }
        public string Shid { get; set; }
        public int SeatId { get; set; }
    }
}
