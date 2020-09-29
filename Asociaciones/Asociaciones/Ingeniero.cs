using System;
using System.Collections.Generic;
using System.Text;

namespace Asociaciones
{
    class Ingeniero : Empleado
    {
        public Ingeniero(double salario, string departamento) : base (salario, departamento)
        {
            Salario = salario;
            Departamento = departamento;
        }
        public override void getDetalles()
        {
            Console.WriteLine("Detalles de ingeniero");
        }
        public override void calcularSalario()
        {
            Console.WriteLine("Calculando salario de ingeniero");
        }

    }
}
