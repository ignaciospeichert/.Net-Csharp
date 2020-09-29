using System;
using System.Collections.Generic;
using System.Text;

namespace Asociaciones
{
    class Empleado
    {
        protected double _salario;
        protected string _departamento;

        public Empleado(double salario, string departamento)
        {
            Salario = salario;
            Departamento = departamento;
        }

        public double Salario { get => _salario; set => _salario = value; }
        public string Departamento { get => _departamento; set => _departamento = value; }

        public virtual void getDetalles()
        {
            Console.WriteLine("El departamento del empleado es {0} y su salario es {1}",Departamento, Salario);
        }

        public virtual void calcularSalario()
        {
            Console.WriteLine("Calculando salario de empleado");
        }



    }
}
