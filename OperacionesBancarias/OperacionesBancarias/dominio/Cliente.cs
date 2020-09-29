using System;
using System.Collections.Generic;
using System.Text;

namespace OperacionesBancarias.dominio
{
    public class Cliente
    {
        private string _primerNombre;
        private string _apellido;

        private Cuenta [] cuentas = new Cuenta[5];
        private int numeroDeCuentas = 0;

        public Cliente(string primerNombre, string apellido)
        {
            PrimerNombre = primerNombre;
            Apellido = apellido;            
        }

        public void AgregaCuenta(Cuenta cta)
        {
            int i = numeroDeCuentas++;
            cuentas[i] = cta;
        }
        public Cuenta GetCuenta(int indiceCuenta)
        {
            return cuentas[indiceCuenta];
        }

        public string PrimerNombre { get => _primerNombre; set => _primerNombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int NumeroDeCuentas { get => numeroDeCuentas; set => numeroDeCuentas = value; }
    }

}
