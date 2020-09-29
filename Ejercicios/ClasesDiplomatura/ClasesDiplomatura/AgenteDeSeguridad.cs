using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesDiplomatura
{
    class AgenteDeSeguridad
    {
        private string nombre;
        private int presupuesto;
        private int salario;
        private bool guardia;

        public AgenteDeSeguridad (string nombre, int presupuesto, int salario, bool guardia)
        {
            this.nombre = nombre;
            this.presupuesto = presupuesto;
            this.salario = salario;
            this.guardia = guardia;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Presupuesto
        {
            get { return presupuesto; }
            set { presupuesto = value; }
        }
        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public bool Guarda
        {
            get { return guardia; }
            set { guardia = value; }
        }
        public bool IsDeGuardia()
        {
            return guardia;
        }
    }
}
