using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Asociaciones
{
    class Gerente : Empleado
    {
        private int _cantidadPersonal;

        public Gerente(double salario, string departamento, int cantidadPersonal) : base(salario, departamento)
        {
            Departamento = departamento;
            Salario = salario;
            CantidadPersonal = cantidadPersonal;
        }

        public int CantidadPersonal { get => _cantidadPersonal; set => _cantidadPersonal = value; }

        public override void getDetalles()
        {
            Console.WriteLine("El gerente tiene {0} cantidad de personal",CantidadPersonal);
        }
        public override void calcularSalario()
        {
            Console.WriteLine("Calculando salario de gerente");
        }
    }
}
