using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesDiplomatura
{
    class Empleado
    {
        private string nombre;
        private string apellido;
        private int salario;

        public Empleado(string nombre, string apellido, int salario)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.salario = salario;
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public string CalcularSalario()
        {
            return "El salario es: " + salario;
        }

    }
       

    
}
