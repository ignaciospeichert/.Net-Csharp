using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Datos
{
    public class Data_Socios : Interfaces.ICRUD<Socio>
    {
        public bool Create(Socio Entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Socio Entidad)
        {
            throw new NotImplementedException();
        }

        public Socio Read(object ID)
        {
            using (SqlConnection conn = Helpers.DataHelper.Connect(true))
            {
                try
                {
                    SqlCommand comReadAll = new SqlCommand();
                    comReadAll.CommandText = "SP_ReadAllSocioPorDNI";
                    comReadAll.CommandType = CommandType.StoredProcedure; 
                    comReadAll.Connection = conn;                

                    DataTable dtAux = new DataTable();
                    SqlParameter paramDNI = new SqlParameter("@DNI", SqlDbType.NVarChar, 8);
                    paramDNI.Value = paramDNI.ToString();

                    comReadAll.Parameters.Add(paramDNI);

                    SqlDataReader dr = comReadAll.ExecuteReader();

                    dr.Read();

                    Entidades.Socio socio = new Entidades.Socio();

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
            using (SqlConnection conn = Helpers.DataHelper.Connect(true))
            {
                SqlCommand comReadAll = new SqlCommand();
                comReadAll.CommandText = "SP_ReadAllSocios";
                comReadAll.CommandType = CommandType.StoredProcedure;
                //Envio consulta SQL a BD 
                comReadAll.Connection = conn;
                //Objeto para manipular informacion DataReader
                SqlDataReader dr = comReadAll.ExecuteReader();

                DataTable dtAux = new DataTable();
                dtAux.Load(dr);
                return dtAux;
            }
        }

        public bool Update(Socio Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
