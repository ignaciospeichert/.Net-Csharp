using System;
using System.Collections.Generic;
using System.Text;

namespace OperacionesBancarias.dominio
{
    class CajaDeAhorro : Cuenta
    {
        private double _porcentajeIntereses;

        public double PorcentajeIntereses { get => _porcentajeIntereses; set => _porcentajeIntereses = value; }

        public CajaDeAhorro(double pbalance, double porcentajedeintereses) : base (pbalance)
        {
            this._porcentajeIntereses = porcentajedeintereses;
        }
      
        public override bool Retira(double retiro)
        {
            if (retiro < Balance)
            {
                Balance -= retiro;
                Console.WriteLine("Retira: {0}", retiro);
                return true;
            }
            else return false;
        }
    }
}
