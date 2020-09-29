using System;
using System.Xml.Schema;

namespace AutoEjemploCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "0";

            Auto auto = new Auto(1, "Ford", "Focus", "Rojo", 0, "1", 0);

            do

            {
                Console.WriteLine();
                Console.WriteLine("*********************************");
                Console.WriteLine("*                               *");
                Console.WriteLine("*    Seleccione una opcion:     *");
                Console.WriteLine("*                               *");
                Console.WriteLine("*    1- Encender                *");
                Console.WriteLine("*    2- Acelerar                *");
                Console.WriteLine("*    3- Frenar                  *");
                Console.WriteLine("*    4- Apagar                  *");
                Console.WriteLine("*    5- Caracteristicas         *");
                Console.WriteLine("*    0- Salir del Programa      *");
                Console.WriteLine("*                               *");
                Console.WriteLine("*********************************");
                Console.WriteLine();
                Console.Write("Opcion: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":

                        Console.Clear();
                        auto.Encender();

                        break;


                    case "2":

                        Console.Clear();
                        auto.Acelerar();

                        break;


                    case "3":

                        Console.Clear();
                        auto.Frenar();

                        break;

                    case "4":

                        Console.Clear();
                        auto.Apagar();

                        break;

                    case "5":

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("         _______       ");
                        Console.WriteLine("        //  ||\\ \\      ");
                        Console.WriteLine("  _____//___||_\\ \\___  ");
                        Console.WriteLine(" )  _          _    \\  ");
                        Console.WriteLine(" |_/ \\________/ \\___|  ");
                        Console.WriteLine("___\\_//_______\\_//______");
                        Console.WriteLine();
                        Console.WriteLine("Marca: {0} | Modelo: {1} | Color: {2}", auto.Marca, auto.Modelo, auto.Color);
                        Console.WriteLine();
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "0":

                        Console.Clear();
                        Console.WriteLine("El programa finalizara ahora, presione una tecla para continuar...");
                        Console.ReadKey();

                        break;

                    default:

                        Console.WriteLine("La opción ingresada no es correcta, intente nuevamente.");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                }



            }


            while (opcion != "0");



        }
    }
}
