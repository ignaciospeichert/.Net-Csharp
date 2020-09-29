using System;
using System.Runtime.CompilerServices;

namespace CalculadoraIntermedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string valor = "";
            double vala = 0.0;
            double valb = 0.0;

            IOperacion operacion = new CSuma();

            while(opcion != 5)
            {
                Console.WriteLine("1-Suma, 2-Resta, 3-Multiplicacion, 4-Division, 5-Salir");
                Console.WriteLine("Que desea realizar?");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                Console.WriteLine("Dame el valor de a");
                valor = Console.ReadLine();
                vala = Convert.ToDouble(valor);

                Console.WriteLine("Dame el valor de b");
                valor = Console.ReadLine();
                valb = Convert.ToDouble(valor);

                if (opcion == 1)
                {
                    operacion = new CSuma();
                }
                if (opcion == 2)
                {
                    operacion = new Resta();
                }
                if (opcion == 3)
                {
                    operacion = new Multiplicacion();
                }
                if (opcion == 4)
                {
                    operacion = new Division();
                }
                else
                {
                    Console.WriteLine("El programa ha finalizado");
                    Console.Clear();
                }
                

                operacion.calcular(vala, valb);
                operacion.mostrar();
            }          
                 
        }
    
    }
}
