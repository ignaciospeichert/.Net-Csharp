using System;
using System.Collections.Generic;
using System.Text;

namespace Boludeces
{
    class Auto
    {
        private string marca;
        private string modelo;
        private string anio;

        public Auto(string marca, string modelo, string anio)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Anio = anio;
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Anio { get => anio; set => anio = value; }

    }

}
