using CinemaBookingandManagementApplication.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CinemaBookingandManagementApplication.Dao
{
    internal class My_DB
    {
        public My_DB()
        {
         
        }
        
        public string getConnectionStrFromFile(string filePath)
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

        public SqlConnection getConnection()
        {
            return new SqlConnection(getConnectionStrFromFile("ConnectionStr.txt")+ "Integrated Security=True;");
             
        }
        public SqlConnection getConnectionFromFile()
        {
            string uname = Constant.uname;
            string pass = Constant.pass;
            //string connectionString = $"Data Source=LAPTOP-O6UI28NM;Initial Catalog=rapchieuphim6;TrustServerCertificate=True;User Id={Constant.uname};Password={Constant.pass};";
            return new SqlConnection(getConnectionStrFromFile("ConnectionStr.txt") + "User Id =" + Constant.uname + "; Password =" + Constant.pass + ";"); 
        }
    }
}
