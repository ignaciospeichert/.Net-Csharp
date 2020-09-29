using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesDiplomatura
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

       public string Apeliido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Caminar()
        {
            return "El servicio que se esta utilizando es Caminar()";
        }
        public string Comer()
        {
            return "El servicio que se esta utilizando es Comer()";
        }
    }
}
