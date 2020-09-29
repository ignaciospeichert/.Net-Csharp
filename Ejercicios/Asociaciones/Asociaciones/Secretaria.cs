using System;
using System.Collections.Generic;
using System.Text;

namespace Asociaciones
{
    class Secretaria : Empleado
    {
        public Secretaria(double salario, string departamento) : base (salario, departamento)
        {
            Salario = salario;
            Departamento = departamento;
        }
        public override void getDetalles()
        {
            Console.WriteLine("Obteniendo detalles de Secretaria");
        }
        public override void calcularSalario()
        {
            Console.WriteLine("Calculando salario de secretaria");
        }

    }
}
