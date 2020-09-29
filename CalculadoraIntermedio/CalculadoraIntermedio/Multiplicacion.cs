using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraIntermedio
{
    class Multiplicacion : IOperacion
    {
        private double r;

        public void calcular(double a, double b)
        {
            r = a * b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la multiplicacion es {0}",r);
        }
    }
}
