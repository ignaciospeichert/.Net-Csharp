using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Pez : Animal, IMascota
    {
        private string nombre;
        public Pez() : base(0)
        {

        }
        public override void Come()
        {
            Console.WriteLine("Los peces comen algas");
        }
        public override void Caminar()
        {
            Console.WriteLine("Los peces no caminan");
            base.Caminar();
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void Jugar()
        {
            Console.WriteLine("Los peces juegan re locos");
        }
    }
}
