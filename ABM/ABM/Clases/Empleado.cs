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
    class Empleado: Ifunciones
    { 

        //Instanciar SQLCONNECTION
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs_abm"].ConnectionString);
   
        

        //Propiedades de la clase
    
        public int EmpleadoId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Dni { get; set; }
        public string Genero { get; set; }

        public string EstadoCivil { get; set; }
        public string Direccion { get; set; }
        public string DistritoId { get; set; }

        //Constructor sin parametros
        public Empleado()
        {

        }
        //Constructor con parametros para Registrar
        public Empleado(string _apellido, string _nombre, string _dni, string _genero, string _estado_civil, string _direccion, string _distrito_id)

        {
            this.Apellido = _apellido;
            this.Nombre = _nombre;
            this.Dni = _dni;
            this.Genero = _genero;
            this.EstadoCivil = _estado_civil;
            this.Direccion = _direccion;
            this.DistritoId = _distrito_id;
             
        }
        //Constructor con parametros para Actualizar
        public Empleado(string _apellido, string _nombre, string _dni, string _genero, string _estado_civil, string _direccion, string _distrito_id, int _empleado_id)

        {
            this.Apellido = _apellido;
            this.Nombre = _nombre;
            this.Dni = _dni;
            this.Genero = _genero;
            this.EstadoCivil = _estado_civil;
            this.Direccion = _direccion;
            this.DistritoId = _distrito_id;
            this.EmpleadoId = _empleado_id;

        }
        //Constructor con parametros para Eliminar
        
        public Empleado(int _empleado_id)

        {
            this.EmpleadoId = _empleado_id;

        }

        public int Registrar()
        {
            int ultimo_id = 0;
            try
            {
                using (var cmd = new SqlCommand("SP_REGISTRAR_EMPLEADO", cn))
                {
                    cmd.Parameters.AddWithValue("@APELLIDO", this.Apellido);
                    cmd.Parameters.AddWithValue("@NOMBRE", this.Nombre);
                    cmd.Parameters.AddWithValue("@DNI", this.Dni);
                    cmd.Parameters.AddWithValue("@GENERO", this.Genero);
                    cmd.Parameters.AddWithValue("@ESTADO_CIVIL", this.EstadoCivil);
                    cmd.Parameters.AddWithValue("@DIRECCION", this.Direccion);
                    cmd.Parameters.AddWithValue("@DISTRITO_ID", this.DistritoId);
                    cmd.Parameters.Add("@ULTIMO_ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    cmd.ExecuteNonQuery();

                    ultimo_id = Convert.ToInt32(cmd.Parameters["@ULTIMO_ID"].Value.ToString());

                    cn.Close();

                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);

                return ultimo_id;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

            return ultimo_id;
        }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public DataTable Listar()
        {
            throw new NotImplementedException();
        }

        public DataTable BuscarPorCodigo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
