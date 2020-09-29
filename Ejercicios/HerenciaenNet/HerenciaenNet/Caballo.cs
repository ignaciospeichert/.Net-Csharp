using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaenNet
{
    class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesyDeportes, ISaltoConPatas
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        { 

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }

        int IMamiferosTerrestres.numeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.numeroPatas()
        {
            return 2;
        }
        public string tipoDeporte()
        {
            return "Polo";
        }
        public bool esOlimpico()
        {
            return true;
        }
    }
}
