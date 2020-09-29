using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM.Clases
{
    class Telefono        

    {
        //Instanciar SQLCONNECTION
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs_abm"].ConnectionString);

        public int TelefonoID { get; set; }
        public string Operador { get; set; }
        public string Numero { get; set; }
        public int EmpleadoId { get; set; }

        public Telefono(string operador, string numero, int empleadoId)
        {
            this.Operador = operador;
            this.Numero = numero;
            this.EmpleadoId = empleadoId;
        }

    }
}
