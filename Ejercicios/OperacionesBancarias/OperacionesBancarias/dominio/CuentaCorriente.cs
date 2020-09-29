using System;
using System.Collections.Generic;
using System.Text;

namespace OperacionesBancarias.dominio
{
    class CuentaCorriente : Cuenta
    {
        private double SIN_PROTECTION = -1.0;
        private double _proteccionSobregiro;

        public double ProteccionSobregiro { get => _proteccionSobregiro; }

        public CuentaCorriente(double balance, double proteccion) : base(balance)
        {
            this._proteccionSobregiro = proteccion;
        }

        public CuentaCorriente (double balance) : base (balance)
        {
            this._balance = balance;
        }

        
        public override bool Retira(double retiro)
        {
            bool resultado = true;

            if (retiro > Balance)
            {
                // No hay suficiente saldo para el retiro solicitado
                // Verificar que en caso que exista haya suficiente protección de sobregiro
                double sobregiroNecesario = retiro - Balance;
                if ((ProteccionSobregiro == SIN_PROTECTION) || (ProteccionSobregiro < sobregiroNecesario))
                {
                    // No hay suficiente protección de giro para la cantidad solicitada
                    resultado = false;
                }
                else
                {
                    // Hay suficiente protección de giro para la cantidad solicitada y cubre
                    Balance = 0.0;
                    _proteccionSobregiro -= sobregiroNecesario;
                }
            }
            else
            {
                // Hay suficiente  para la cantidad solicitada
                // Proceder normalmente
                Balance -= retiro;
            }
            return resultado;
        }
    }
}
