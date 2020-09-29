using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraIntermedio
{
    class Resta :IOperacion
    {
        private double r;

        public void calcular(double a, double b)
        {
            r = a - b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la resta es {0}",r);
        }
    }
}
