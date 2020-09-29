using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int minumero = 101;

            int intentos = 0;

            Console.WriteLine("Ingresa un numero 0 y 100");


            while (minumero != aleatorio)

            {
                intentos++;

                minumero = int.Parse(Console.ReadLine());

                if (minumero > aleatorio) Console.WriteLine("El numero es menor");

                if (minumero < aleatorio) Console.WriteLine("El numero es mayor");

            }

            Console.WriteLine($"Excelente, lo acertaste en {intentos} intentos");
            Console.ReadKey();


        }


    }

}

