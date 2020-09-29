using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Entities.Herencia;
using Interfaces;

namespace Data
{
    public class DAO_Cliente : ICRUD<Cliente>
    {
        public List<Cliente> Clientes = new List<Cliente>();
        public List<Empleado> Empleados = new List<Empleado>();

        public bool Create(Cliente Entity)
        {
            try
            {
                Clientes.Add(Entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
           
        }

        public bool Delete(object ID)
        {
           foreach (Cliente c in Clientes)
           {
                if (c.DNI == ID.ToString())
                {
                    Clientes.Remove(c);
                    return true;
                }
           }
            return false;
        }

        public Cliente Read(object ID)
        {
            foreach (Cliente c in Clientes)
            {
                if (c.DNI == ID.ToString())
                {
                    return c;
                }
            }
            return null;
        }

        public List<Cliente> ReadAll()
        {
            return Clientes;
        }

        public bool Update(Cliente Entity)
        {
            foreach (Cliente c in Clientes)
            {
                //Cliente cliente = (Cliente)Entity;

                if (c.DNI == Entity.DNI)
                {
                    c.Nombre = Entity.Nombre;
                    c.Apellido = Entity.Apellido;
                    c.Direccion = Entity.Direccion;
                    c.Telefono = Entity.Telefono;
                    c.Email = Entity.Email;
                    return true;
                }
            }
            return false;
        }

        //public bool Create(object Entity)
        //{
        //    try
        //    {
        //        Clientes.Add((Cliente)Entity);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        //public bool Delete(object ID)
        //{
        //    foreach (Cliente c in Clientes)
        //    {
        //        if (c.DNI == ID.ToString())
        //        {
        //            Clientes.Remove(c);
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public object Read(object ID)
        //{
        //    foreach (Cliente c in Clientes)
        //    {
        //        if (c.DNI == ID.ToString())
        //        {
        //            return c;
        //        }
        //    }
        //    return null;
        //}

        //public ArrayList ReadAll()
        //{
        //    ArrayList c = new ArrayList();
        //    c.Add(Clientes);
        //    return c;
        //}

        //public bool Update(object Entity)
        //{
        //    foreach (Cliente c in Clientes)
        //    {
        //        Cliente cliente = (Cliente)Entity;

        //        if (c.DNI == cliente.DNI)
        //        {
        //            c.Nombre = cliente.Nombre;
        //            c.Apellido = cliente.Apellido;
        //            c.Direccion = cliente.Direccion;
        //            c.Telefono = cliente.Telefono;
        //            c.Email = cliente.Email;
        //            return true;
        //        }                
        //    }
        //    return false;         
        //}

        //public bool CreateCliente(Cliente cliente)
        //{
        //    try
        //    {
        //        Clientes.Add(cliente);
        //        return true;
        //    }
        //    catch 
        //    {
        //        return false;
        //    }
        //}

        //public List<Cliente> ReadAllCliente()
        //{
        //    return Clientes;
        //}

        //public Cliente ReadCliente(string _DNI)
        //{
        //    foreach (Cliente c in Clientes)
        //    {
        //        if (c.DNI == _DNI)
        //        {
        //            return c;
        //        }
        //    }
        //    return null;       
        //}

        //public Cliente UpdateCliente(Cliente cliente)
        //{
        //    foreach (Cliente c in Clientes)
        //    {
        //        if (c.DNI == cliente.DNI)
        //        {
        //            c.Nombre = cliente.Nombre;
        //            c.Apellido = cliente.Apellido;
        //            c.Direccion = cliente.Direccion;
        //            c.Telefono = cliente.Telefono;
        //            c.Email = cliente.Email;
        //            return c;
        //        }                
        //    }
        //    return null;            
        //}
        //public bool DeleteCliente(string _DNI)
        //{
        //    foreach (Cliente c in Clientes)
        //    {
        //        if (c.DNI == _DNI)
        //        {
        //            Clientes.Remove(c);
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }




    
   
}
