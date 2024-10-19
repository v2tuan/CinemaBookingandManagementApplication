using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.models
{
    public class Seat
    {
        public int SeatId { get; set; }
        public string Rid { get; set; }
        public int States { get; set; }
        public string Snumber { get; set; }
        public string Srow { get; set; }
    }
}
