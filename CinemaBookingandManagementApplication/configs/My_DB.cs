using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaBookingandManagementApplication.Dao
{
    internal class My_DB
    {
        public My_DB()
        {
         
        }

        private string getConnectionStrFromFile(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        return line;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred: " + e.Message);
            }

            return null;
        }

        public SqlConnection getConnectionFromFile(string file_path = "")
        {
            if (file_path.Length > 0)
            {
                return new SqlConnection(getConnectionStrFromFile(file_path));
            }
            else
            {
                return new SqlConnection(getConnectionStrFromFile("ConnectionStr.txt"));
            }
        }
    }
}
