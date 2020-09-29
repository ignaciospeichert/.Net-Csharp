using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades
{
    public class Actividad_Socio : Interfaces.ICRUD<Socio>
    {
        Datos.Datos_Socios datos_socios = new Datos.Datos_Socios();
        public bool Create(Socio Entidad)
        {
            return datos_socios.Create(Entidad);
        }

        public bool Delete(Socio Entidad)
        {
            return datos_socios.Delete(Entidad);
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
            return datos_socios.Update(Entidad);
        }
    }
}
