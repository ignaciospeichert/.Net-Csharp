using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Helpers;
using System.ComponentModel;

namespace Datos
{
    public class Datos_Socios : Interfaces.ICRUD<Socio>
    {
        public bool Create(Socio Entidad)
        {
            try
            {
                using (SqlConnection conn = DataHelper.Connect(true))
                {
                    string proc1 = "SP_CrearSocio";

                    SqlCommand commandCreate = new SqlCommand(proc1, conn);
                    commandCreate.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramDni = new SqlParameter("@DNI", SqlDbType.NVarChar, 8);
                    SqlParameter paramNombre = new SqlParameter("@NOMBRE", SqlDbType.NVarChar, 50);
                    SqlParameter paramApellido = new SqlParameter("@APELLIDO", SqlDbType.NVarChar, 50);
                    SqlParameter paramDireccion = new SqlParameter("@DIRECCION", SqlDbType.NVarChar, 100);
                    SqlParameter paramTelefono = new SqlParameter("@TELEFONO", SqlDbType.NVarChar, 20);
                    SqlParameter paramEmail = new SqlParameter("@EMAIL", SqlDbType.NVarChar, 50);

                    paramDni.Value = Entidad.DNI;
                    paramNombre.Value = Entidad.Nombre;
                    paramApellido.Value = Entidad.Apellido;
                    paramDireccion.Value = Entidad.Direccion;
                    paramTelefono.Value = Entidad.Telefono;
                    paramEmail.Value = Entidad.Email;

                    commandCreate.Parameters.Add(paramDni);
                    commandCreate.Parameters.Add(paramNombre);
                    commandCreate.Parameters.Add(paramApellido);
                    commandCreate.Parameters.Add(paramDireccion);
                    commandCreate.Parameters.Add(paramTelefono);
                    commandCreate.Parameters.Add(paramEmail);

                    commandCreate.ExecuteNonQuery();
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }



        public bool Delete(Socio Entidad)
        {
            try
            {
                using (SqlConnection conn = DataHelper.Connect(true))
                {
                    string storedProcedure = "SP_EliminarSocios";

                    SqlCommand commandDelete = new SqlCommand(storedProcedure, conn);
                    commandDelete.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramDni = new SqlParameter("@DNI", SqlDbType.NVarChar, 8);
                    paramDni.Value = Entidad.DNI;
                    commandDelete.Parameters.Add(paramDni);


                    commandDelete.ExecuteNonQuery();
                    return true;
                }
                
            }
            catch
            {
                return false;
            }
        }

        public Socio Read(object ID)
        {
            string storedProcedure = "SP_ReadAllSocioPorDNI";

            using (SqlConnection conn = DataHelper.Connect(true))
            {
                try
                {
                    SqlCommand commandReadAll = new SqlCommand(storedProcedure, conn);
                    commandReadAll.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramDni = new SqlParameter("@DNI", SqlDbType.NVarChar, 8);
                    paramDni.Value = ID.ToString();
                    commandReadAll.Parameters.Add(paramDni);

                    SqlDataReader dr = commandReadAll.ExecuteReader();

                    dr.Read();

                    Socio socio = new Socio();

                    socio.DNI = dr[0].ToString();
                    socio.Nombre = dr[1].ToString();
                    socio.Apellido = dr[2].ToString();
                    socio.Direccion = dr[3].ToString();
                    socio.Telefono = dr[4].ToString();
                    socio.Email = dr[5].ToString();

                    return socio;
                }
                catch
                {
                    return null;
                }
            }
        }

        public DataTable ReadAll()
        {
            string storedProcedure = "SP_ReadAllSocios";

            using (SqlConnection conn = DataHelper.Connect(true))
            {
                SqlCommand commandReadAll = new SqlCommand(storedProcedure, conn);
                commandReadAll.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = commandReadAll.ExecuteReader();

                DataTable dtAux = new DataTable();

                dtAux.Load(dr);

                return dtAux;
            }
        }

        public bool Update(Socio Entidad)
        {
            try
            {
                using (SqlConnection conn = DataHelper.Connect(true))
                {
                    string storedProcedure = "SP_ActualizarSocios";

                    SqlCommand commandUpdate = new SqlCommand(storedProcedure, conn);
                    commandUpdate.CommandType = CommandType.StoredProcedure;

                    SqlParameter paramDni = new SqlParameter("@DNI", SqlDbType.NVarChar, 8);
                    SqlParameter paramNombre = new SqlParameter("@NOMBRE", SqlDbType.NVarChar, 50);
                    SqlParameter paramApellido = new SqlParameter("@APELLIDO", SqlDbType.NVarChar, 50);
                    SqlParameter paramDireccion = new SqlParameter("@DIRECCION", SqlDbType.NVarChar, 100);
                    SqlParameter paramTelefono = new SqlParameter("@TELEFONO", SqlDbType.NVarChar, 20);
                    SqlParameter paramEmail = new SqlParameter("@EMAIL", SqlDbType.NVarChar, 50);

                    paramDni.Value = Entidad.DNI;
                    paramNombre.Value = Entidad.Nombre;
                    paramApellido.Value = Entidad.Apellido;
                    paramDireccion.Value = Entidad.Direccion;
                    paramTelefono.Value = Entidad.Telefono;
                    paramEmail.Value = Entidad.Email;

                    commandUpdate.Parameters.Add(paramDni);
                    commandUpdate.Parameters.Add(paramNombre);
                    commandUpdate.Parameters.Add(paramApellido);
                    commandUpdate.Parameters.Add(paramDireccion);
                    commandUpdate.Parameters.Add(paramTelefono);
                    commandUpdate.Parameters.Add(paramEmail);

                    commandUpdate.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

