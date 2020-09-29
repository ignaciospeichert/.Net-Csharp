using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraIntermedio
{
    class CSuma : IOperacion
    {
        private double r;
        ArrayList resultados = new ArrayList();

        public void calcular(double a, double b)
        {
            r = a + b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la suma es {0}",r);
            resultados.Add(r);
        }

        public void mostrarResultado()
        {
            foreach (double r in resultados)
                Console.WriteLine(r);
        }
    }
}
