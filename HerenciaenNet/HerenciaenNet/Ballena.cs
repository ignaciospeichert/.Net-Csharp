using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaenNet
{
    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }
        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
    }
}
