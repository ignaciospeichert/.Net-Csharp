using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Gato : Animal, IMascota
    {
        private string nombre;

        public Gato(string nombreGato) : base(4)
        {
            this.nombre = nombreGato;
        }
        public Gato() : this("")
        {
            
        }
        public override void Come()
        {
            Console.WriteLine("El gato come");
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void Jugar()
        {
            Console.WriteLine("El gato juega");
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;            
        }
        public override void Caminar()
        {

            base.Caminar();
        }
    }
}
