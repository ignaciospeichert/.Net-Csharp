using Entities.Herencia;
using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Data
{
    public class DAO_Empleado : ICRUD<Empleado>
    {
        List<Empleado> Empleados = new List<Empleado>();

        public bool Create(Empleado Entity)
        {
            try
            {
                Empleados.Add(Entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(object ID)
        {
            foreach (Empleado e in Empleados)
            {
                if (e.DNI == ID.ToString())
                {
                    Empleados.Remove(e);
                    return true;
                }               
            }
            return false;
        }

        public Empleado Read(object ID)
        {
            foreach (Empleado e in Empleados)
            {
                if (e.DNI == ID.ToString())
                {
                    return e;
                }                
            }
            return null;
        }

        public List<Empleado> ReadAll()
        {
            return Empleados;
        }

        public bool Update(Empleado Entity)
        {
            foreach  (Empleado e in Empleados)
            {
                if (e.DNI == Entity.DNI)
                {
                    e.Nombre = Entity.Nombre;
                    e.Apellido = Entity.Apellido;
                    e.Direccion = Entity.Direccion;
                    e.Telefono = Entity.Telefono;
                    e.Email = Entity.Email;
                    return true;
                }               
            }
            return false;
        }
    }
}
