using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraIntermedio
{
    class Division: IOperacion
    {
        private double r;

        public void calcular(double a, double b)
        {
            r = a / b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la division es {0}",r);
        }
    }
}
