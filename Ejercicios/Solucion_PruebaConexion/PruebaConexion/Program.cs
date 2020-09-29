using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaConexion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        
    }

    class Conexion
    {

        public DataTable ReadAll()
        {

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = @"data source=DESKTOP-3A92C6E;
                                          Initial Catalog=Aseguradora;
                                          Integrated Security=true;";

                conn.Open();

                //Opcion1
                //string query = "Select * from Socios";
                //SqlCommand command = new SqlCommand(query, conn);

                //Opcion2
                SqlCommand command = new SqlCommand();
                command.CommandText = "Select * from Socios";
                command.Connection = conn;
                
            }


        }
    }
}
