using System;

namespace EjercicioTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche auto1 = new Coche();
            Avion avion1 = new Avion();
            avion1.conducir();
            auto1.conducir();
            Console.ReadLine();
        }
    }
}
