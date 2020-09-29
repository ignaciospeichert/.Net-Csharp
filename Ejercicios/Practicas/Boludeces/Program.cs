using Boludeces.Composicion;
using System;
using System.Dynamic;

namespace Boludeces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Empleado empleado1 = new Empleado("Ignacio", 1500.500);
            //Console.WriteLine(empleado1.Sueldo);
            //Console.WriteLine(empleado1.Nombre);

            //Edificio edif1 = new Edificio("San martin 264", 18, 16);

            //Propietario Ignacio = new Propietario("Ignacio");

            //Ignacio.adicionaPropiedad(edif1);
            //Ignacio.mostrarPropiedad();


            //edif1.muestra();


            //Auto a = new Auto("fiat", "toro", "1997");
            //Persona p = new Persona("Ignacio", "Jose", "Speichert", "35324738");
            //p.usaAuto(a);
            //Console.ReadKey();

            PropietarioC Ignacio = new PropietarioC("Ignacio");

            Ignacio.mostrarPropiedad();
            Console.ReadLine();


        }
    }
}
