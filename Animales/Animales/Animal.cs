using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    public abstract class Animal
    {
        protected int patas;

        public Animal(int cantPatas)
        {
            patas = cantPatas;
        }
        public abstract void Come();

        public virtual void Caminar()
        {
            Console.WriteLine("El animal camina con {0} patas",patas);
        }

    }
}
