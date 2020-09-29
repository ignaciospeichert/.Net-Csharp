using System;
using System.Collections.Generic;
using System.Text;
using OperacionesBancarias.dominio;

namespace OperacionesBancarias.reportes
{
    class ReporteCliente
    {
        public void generarReporte(Banco banco)
        {
            Banco banco = Banco.GetBanco();
            Cliente cliente;

            Console.WriteLine();
            Console.WriteLine("\t\t\tREPORTE DE CLIENTES");
            Console.WriteLine("\t\t\t====================");

            for (int indiceCliente = 0; indiceCliente < banco.NumeroDeClientes; indiceCliente++)
            {
                cliente = banco.GetCliente(indiceCliente);

                Console.WriteLine();
                Console.WriteLine("Cliente: "
                       + cliente.Apellido + ", "
                       + cliente.PrimerNombre);

                for (int indiceCuenta = 0; indiceCuenta < cliente.NumeroDeCuentas; indiceCuenta++)
                {
                    Cuenta cuenta = cliente.GetCuenta(indiceCuenta);
                    String tipoCuenta = "";

                    // Determinar el tipo de cuenta
                    if (cuenta is CajaDeAhorro)
                    {
                        tipoCuenta = "Caja de Ahorro";
                    }
                    else if (cuenta is CuentaCorriente)
                    {
                        tipoCuenta = "Cuenta Corriente";
                    }
                    else
                    {
                        tipoCuenta = "Tipo de Cuenta Desconocido";
                    }
                    // Imprimir el balance actual de la cuenta
                    Console.WriteLine("    " + tipoCuenta + ": el balance actual es "
                             + cuenta.Balance);

                }
            }
        }
    }
}
