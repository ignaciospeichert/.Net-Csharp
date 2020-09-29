using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaenNet
{
    class Mamiferos
    {

        private string nombreSerVivo;

        public Mamiferos(string nombre)
        {
            nombreSerVivo = nombre;
        }
        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento basico institivo");
        }

        public void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es:"+ nombreSerVivo);
        }
    }
}
