using System;
using System.Collections.Generic;
using System.Text;

namespace Boludeces
{
    class Propietario
    {
        private string nombre;
        private Edificio propiedad = null;

        public Propietario(string nombre)
        {
            this.nombre = nombre;          
        }

        public void mostrarPropiedad()
        { 
            if (propiedad != null)
            {
                Console.WriteLine("{0} tiene ",nombre);
                propiedad.muestra();
            }
            else
            {
                Console.WriteLine("{0} aun no tiene propiedades", nombre);
            }
        }
        public void adicionaPropiedad(Edificio edificio)
        {
            if (edificio != null)
                propiedad = edificio;
        }
        
    }
   
}
