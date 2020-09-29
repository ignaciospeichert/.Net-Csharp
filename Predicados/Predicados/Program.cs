using System;
using System.Collections.Generic;

namespace Predicados
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personas> personas = new List<Personas>();

            Personas P1 = new Personas();
            Personas P2 = new Personas();
            Personas P3 = new Personas();

            P1.Nombre = "Juana";
            P1.Edad = 32;

            P2.Nombre = "Maria";
            P2.Edad = 18;

            P3.Nombre = "Raul";
            P3.Edad = 52;

            personas.AddRange(new Personas[] { P1, P2, P3 });

            Predicate<Personas> elPredicado = new Predicate<Personas>(ExisteJuan);

            bool existe = personas.Exists(ExisteJuan);

            //Console.WriteLine(existe);
            if (existe) Console.WriteLine("Hay personas llamadas Juan");
            else Console.WriteLine("No hay personas llamadas Juan");
        }

        static bool ExisteJuan(Personas persona)
        {
            if (persona.Nombre == "Juan") return true;
            else return false;       
        }
        
    }
}
