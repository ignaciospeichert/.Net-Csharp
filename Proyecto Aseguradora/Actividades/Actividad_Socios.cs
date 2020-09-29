using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades
{
    public class Actividad_Socios : Interfaces.ICRUD<Socio>
    {
        Datos.Data_Socios datos_socios = new Datos.Data_Socios();

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
            return datos_socios.Read(ID);
        }

        public DataTable ReadAll()
        {
            return datos_socios.ReadAll();
        }

        public bool Update(Socio Entidad)
        {
            throw new NotImplementedException();
        }
    }
}
