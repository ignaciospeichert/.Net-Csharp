using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Abeja : Animal
    {
        public Abeja() : base (6)
        {

        }
        public override void Come()
        {
            Console.WriteLine("La abeja come");
        }
        public override void Caminar()
        {
            Console.WriteLine("Las abejas vuelvan, NO caminan");
            base.Caminar();
        }
        
    }
}
