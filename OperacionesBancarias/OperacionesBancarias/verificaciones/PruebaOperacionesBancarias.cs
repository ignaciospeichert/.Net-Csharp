using System;
using OperacionesBancarias.dominio;

namespace OperacionesBancarias.verificaciones
{
    class PruebaOperacionesBancarias
    {
        static void Main(string[] args)
        {

            Cuenta micuenta = new Cuenta(500.00);
            Console.WriteLine("Creando una cuenta con 500.00 de balance");

            micuenta.Retira(150.00);

            micuenta.Deposita(22.50);

            micuenta.Retira(47.62);

            Console.WriteLine("La cuenta tiene un balance de {0}", micuenta.Balance);

            Cliente juan = new Cliente("Juan", "Perez");

            juan.Cuenta = micuenta;
            Console.WriteLine("El cliente: {0} {1}, tiene un balance de {2}", juan.PrimerNombre, juan.Apellido, juan.Cuenta.Balance);


            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------");

            Banco banco = new Banco();
            Cliente cliente;

            banco.AgregaCliente("Juan", "Perez");
            banco.AgregaCliente("Pedro", "Garcia");
            banco.AgregaCliente("Oscar", "Toma");
            banco.AgregaCliente("Maria", "Soley");

            for (int i = 0; i < banco.NumeroDeClientes; i++)
            {
                cliente = banco.GetCliente(i);
                Console.WriteLine("Cliente: [{0}] es {1} {2}",i,cliente.PrimerNombre,cliente.Apellido);
            }

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("------------------------------------------------------------");

            Banco banco1 = new Banco();
            Cliente cliente1;

            banco1.AgregaCliente("Juan", "Perez");
            cliente1 = banco1.GetCliente(0);

        }
    }
}
