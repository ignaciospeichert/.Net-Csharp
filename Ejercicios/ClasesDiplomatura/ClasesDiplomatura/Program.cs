using System;
using System.Dynamic;

namespace ClasesDiplomatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("rojo", "fiat", 4);                       
            Console.WriteLine(auto1.Arrancar());
            Console.ReadLine();

            Persona persona1 = new Persona("ignacio", "speichert", 29);
            Console.WriteLine(persona1.Caminar());
            Console.ReadLine();

            Empleado empleado1 = new Empleado("ignacio", "speich", 50000);
            Console.WriteLine(empleado1.CalcularSalario());
            Console.ReadLine();

            Libro libro1 = new Libro("Borges", 2, "Marzo", true);
            Console.WriteLine(libro1.IsLeido());
            Console.ReadKey();
        }
    }
}
