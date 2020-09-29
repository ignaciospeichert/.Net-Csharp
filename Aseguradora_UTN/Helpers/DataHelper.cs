using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Helpers
{
    public class DataHelper
    {
        public static SqlConnection Connect(bool Estado)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ReadConnString();

            if (Estado)
            {
                conn.Open();
            }
            return conn;
        }
        private static string ReadConnString()
        {
            System.IO.StreamReader read = new System.IO.StreamReader(@"C:\Conn\conn.txt");
            return read.ReadToEnd();
        }
    }
}
