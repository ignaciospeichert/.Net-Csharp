using System;
using System.Collections.Generic;
using System.Text;

namespace Boludeces.Composicion
{
    class PropietarioC
    {
        private string nombre;
        private EdificioC propiedad = null;

        public PropietarioC(string nombre)
        {
            this.nombre = nombre;
            propiedad = new EdificioC("San Martin 264", 18, 16);
        }

        public void mostrarPropiedad()
        {
            if (propiedad != null)
            {
                Console.WriteLine("{0} tiene ", nombre);
                propiedad.muestra();
            }
            else
            {
                Console.WriteLine("{0} aun no tiene propiedades", nombre);
            }
        }
        //public void adicionaPropiedad(Edificio edificio)
        //{
        //    if (edificio != null)
        //        propiedad = edificio;
        //}
    }
}
