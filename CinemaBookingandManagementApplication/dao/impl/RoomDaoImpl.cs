using CinemaBookingandManagementApplication.configs;
using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication.dao.impl
{
    internal class RoomDaoImpl
    {
        public int GetTotalSeatsByRoomId(string roomId)
        {
            return Function.GetTotalSeatsByRoomId(roomId);
        }
        public DataTable GetRoomsByCinemaId(string cinemaId)
        {
            return Function.GetRoomsByCinemaId(cinemaId);
        }
        public void insert(Room room)
        {
            string rid = room.Rid;
            string cid = room.Cid;
            string name = room.Rname;
            Procedure.CreateNewRoom(rid, name, cid);
        }
        public String IDNext()
        {
            try
            {
                int count = 0;
                count++;
                string nextID = "R" + count.ToString("D6");

                while (checkID(nextID))
                {
                    count++;
                    nextID = "R" + count.ToString("D6");
                }
                return nextID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public bool checkID(string id)
        {
            return Function.checkRoomID(id);
        }
    }
}
