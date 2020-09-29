using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM.Clases
{
    class UbiGeo
    {
        //Instanciar SQLCONNECTION
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs_abm"].ConnectionString);

        public DataTable ListarDepartamentos()
        {
            //Instanciar ClaseDataTable

            var tabla = new DataTable();
            try
            {
                //Creando instancia de clase sqlDataAdapter
                using (var adaptador = new SqlDataAdapter("SP_LISTAR_DEPARTAMENTOS", cn))
                {
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.Fill(tabla);
                }
            }
            catch (SqlException e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
                return tabla;
            }
            return tabla;   
        }
        public DataTable ListarProvinciasPorDepartamentoId(string departamentoId)
        {
            //Instanciar ClaseDataTable

            var tabla = new DataTable();
            try
            {
                //Creando instancia de clase sqlDataAdapter
                using (var adaptador = new SqlDataAdapter("SP_LISTAR_PROVINCIAS", cn))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@DEPARTAMENTO_ID", departamentoId);
                    adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
                    adaptador.Fill(tabla);
                }
            }
            catch (SqlException e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
                return tabla;
            }
            return tabla;
        }

       
        public DataTable ListarDistritosPorProvinciaId(string provinciaId)
        {
            //Instanciar ClaseDataTable

            var tabla = new DataTable();
            try
            {
                //Creando instancia de clase sqlDataAdapter
                using (var adaptador = new SqlDataAdapter("select * from DISTRITO inner join PROVINCIAS on DISTRITO.PROVINCIA_ID = PROVINCIAS.PROVINCIA_ID where DISTRITO.PROVINCIA_ID = @provinciaId", cn))
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@provinciaId", provinciaId);
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(tabla);
                }
            }
            catch (SqlException e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
                return tabla;
            }
            return tabla;
        }
        
    }
}
