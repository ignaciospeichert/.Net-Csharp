using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ClasesDiplomatura
{
    class Auto
    {
        private string color;
        private string marca;
        private int ruedas;
                

        public Auto(string color, string marca, int ruedas)
        {
            this.color = color;
            this.marca = marca;
            this.ruedas = ruedas;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Ruedas
        {
            get { return ruedas; }
            set { ruedas = value; }
        }

        public string Apagar()
        {
            return "El servicio que se esta utilizando es Apagar()";         
            
        }
        public string Arrancar()
        {
            return "El servicio que se esta utilizando es Arrancar()";
        }
        public string Frenar()
        {
            return "El servicio que se esta utilizando es Frenar()";   
        }
    }
}
