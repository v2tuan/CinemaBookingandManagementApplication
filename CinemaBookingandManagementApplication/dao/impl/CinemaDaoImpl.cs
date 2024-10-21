﻿using CinemaBookingandManagementApplication.configs;
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
    internal class CinemaDaoImpl
    {
        public DataTable GetMovieSchedulesByCinema(string cinemaId, string movieId, DateTime showDate)
        {
            return Function.GetMovieSchedulesByCinema(cinemaId, movieId, showDate);
        }
        public DataTable GetCinemasWithMovieSchedules(string movieId, DateTime showDate)
        {
            return Function.GetCinemasWithMovieSchedules(movieId, showDate);
        }

        public DataTable GetRoomsByCinemaId(string cinemaId)
        {
            return Function.GetRoomsByCinemaId(cinemaId);
        }

        public void insert(Cinemas cinema)
        {
            string cid = cinema.Cid;
            string cname = cinema.Cname;
            string caddress = cinema.Caddress;
            string hotline = cinema.Hotline;
            string area = cinema.Area;

            MemoryStream pic = new MemoryStream();
            cinema.Image.Save(pic, cinema.Image.RawFormat);
            Procedure.CreateNewCinema(cid, cname, caddress, hotline, area, pic);
        }

        public String IDNext()
        {
            try
            {
                int count = 0;
                count++;
                string nextID = "C" + count.ToString("D6");

                while (checkID(nextID))
                {
                    count++;
                    nextID = "C" + count.ToString("D6");
                }
                return nextID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Cinema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public bool checkID(string id)
        {
            return Function.checkCinemaID(id);
        }

        public DataTable GetListCinema()
        {
            return Function.GetListCinema();
        }
    }
}
