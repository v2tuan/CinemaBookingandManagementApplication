using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingandManagementApplication.dao.impl
{
    internal class ShowTimeDaoImpl
    {
        public void AddShowtime(MovieSchedule showTime)
        {
            string shid = showTime.Shid;
            string mid = showTime.Mid;
            DateTime sdate = showTime.Sdate;
            DateTime stime = showTime.Stime;
            DateTime etime = showTime.Etime;
            int seatEmpty = showTime.SeatEmpty;
            string rid = showTime.Rid;
            Procedure.AddShowtime(shid, mid, sdate, stime, etime, seatEmpty, rid);
        }
    }
}
