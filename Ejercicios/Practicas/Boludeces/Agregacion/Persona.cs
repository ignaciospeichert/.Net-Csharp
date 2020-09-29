using System;
using System.Collections.Generic;
using System.Text;

namespace Boludeces
{
    class Persona
    {
        private string primerNombre;
        private string segundoNombre;
        private string apellido;
        private string documento;

        public Persona(string primerNombre, string segundoNombre, string apellido, string documento)
        {
            this.PrimerNombre = primerNombre;
            this.SegundoNombre = segundoNombre;
            this.Apellido = apellido;
            this.Documento = documento;
        }

        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Documento { get => documento; set => documento = value; }

        public void usaAuto(Auto a)
        {         
            Console.WriteLine("La persona {0} esta usando un {1} modelo {2} del año {3}",primerNombre,a.Marca,a.Modelo,a.Anio);
        }
    }
}
