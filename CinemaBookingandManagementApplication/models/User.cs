using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.models
{
    internal class User
    {
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string password { get; set; }

        public string cid { get; set; }
        public bool isAdmin { get; set; }
    }
}
