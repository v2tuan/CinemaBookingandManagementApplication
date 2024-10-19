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
            public TimeSpan Stime { get; set; }
            public TimeSpan Etime { get; set; }
            public int States { get; set; }
            public int SeatEmpty { get; set; }
            public string Rid { get; set; }

      
    }
}
