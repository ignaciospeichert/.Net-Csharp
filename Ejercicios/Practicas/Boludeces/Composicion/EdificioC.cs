using System;
using System.Collections.Generic;
using System.Text;

namespace Boludeces.Composicion
{
    class EdificioC
    {
        private string direccion;
        private int cantDepartamentos;
        private int depRentados;

        public EdificioC(string direccion, int cantDepartamentos, int depRentados)
        {
            this.direccion = direccion;
            this.cantDepartamentos = cantDepartamentos;
            this.depRentados = depRentados;
        }

        public void muestra()
        {
            Console.WriteLine("Edificio en {0} con {1} deptos, {2} rentados", direccion, cantDepartamentos, depRentados);
        }
    }
}
