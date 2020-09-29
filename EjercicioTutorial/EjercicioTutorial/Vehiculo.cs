using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioTutorial
{
    class Vehiculo
    {
        public void arrancarMotor()
        {
            Console.WriteLine("Arranca el motor");
        }

        public void pararMotor()
        {
            Console.WriteLine("El motor se paro") ;
        }
        public virtual void conducir()
        {
            Console.WriteLine("Conduciendo");
        }
    }
}
