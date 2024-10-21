using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication.dao.impl
{
    internal class ShowTimeDaoImpl
    {

        public void AddShowtime(MovieSchedule showTime)
        {
            string shid = showTime.Shid;
            string mid = showTime.Mid;
            DateTime sdate = showTime.Sdate;
            DateTime stime = DateTime.Parse(showTime.Stime.ToString());
            DateTime etime = DateTime.Parse(showTime.Etime.ToString());
            int seatEmpty = showTime.SeatEmpty;
            string rid = showTime.Rid;
            Procedure.AddShowtime(shid, mid, sdate, stime, etime, seatEmpty, rid);
        }

        public String IDNext()
        {
            try
            {
                int count = 0;
                count++;
                string nextID = "Sh" + count.ToString("D6");

                while (checkID(nextID))
                {
                    count++;
                    nextID = "Sh" + count.ToString("D6");
                }
                return nextID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Movies Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public bool checkID(string id)
        {
            return Function.CheckIDShowtime(id);
        }
    }
}
