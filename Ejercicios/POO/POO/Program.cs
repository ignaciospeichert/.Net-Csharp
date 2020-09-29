using System;

namespace POO
{
    class Program
    { 

        static void Main(string[] args)
        {
            realizarTarea();
        }

        static void realizarTarea() {

            Punto origen = new Punto();
            Punto destino = new Punto(128,80);
            double distancia = origen.DistanciaHasta(destino); 

        }
    }
}
