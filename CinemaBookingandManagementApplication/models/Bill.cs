using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.models
{
    public class Bill
    {
        public string BId { get; set; }
        public decimal Price { get; set; }
        public int States { get; set; }
        public string CusId { get; set; }
    }
}
