using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class VerificarAnimales
    {
        static void Main(string[] args)
        {
            Pez p = new Pez();
            Gato g = new Gato("Manchas");
            Animal a = new Pez();
            Animal e = new Abeja();
            IMascota g2 = new Gato();

            // Mostrar distintas implementaciones de la interfaz
            p.Jugar();
            g.Jugar();

            // Demostrar la invocación virtual de métodos
            e.Come();
            e.Caminar();

            // Demostrar el llamado de métodos de la superclase
            a.Caminar();
            g.Caminar();
            g2.Jugar();

            Console.ReadKey();
        }
    }
}
