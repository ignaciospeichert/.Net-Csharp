using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace OperacionesBancarias.dominio
{
    class Banco
    {
        private static Banco instanciaBanco = new Banco();
        private int MAX_CLIENTES = 10;
        private const double PORCENTAJES_CAJA_AHORRO = 3.5;
        private int _numeroDeClientes;
        private Cliente[] clientes;

        public Banco()
        {
            clientes = new Cliente[MAX_CLIENTES];
            _numeroDeClientes = 0;
        }

        public static Banco GetBanco()
        {
            return instanciaBanco;
        }

        public int NumeroDeClientes { get => _numeroDeClientes; }

        public void AgregaCliente(string nombre, string apellido)
        {
            clientes[_numeroDeClientes] = new Cliente(nombre, apellido);
            _numeroDeClientes++;
        }
        public Cliente GetCliente (int n)
        {
            return clientes[n];
        }
    }
}
