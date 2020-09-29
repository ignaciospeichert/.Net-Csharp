using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesDiplomatura
{
    class CuentaBancaria
    {
        private int numero;
        private int saldo; 
        private string titular;

        public CuentaBancaria(int numero, int saldo, string titular)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.titular = titular;
        }

        public int Numero 
        {
            get { return numero; }
            set { numero = value; }
        }

        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
    }
}
