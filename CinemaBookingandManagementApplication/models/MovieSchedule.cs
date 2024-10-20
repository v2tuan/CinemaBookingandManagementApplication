using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.models
{
    public class MovieSchedule
    {
            public string Shid { get; set; }
            public string Mid { get; set; }
            public DateTime Sdate { get; set; }
            public DateTime Stime { get; set; }
            public DateTime Etime { get; set; }
            public int SeatEmpty { get; set; }
            public string Rid { get; set; }
      
    }
}
