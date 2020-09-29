using System;
using System.Collections.Generic;
using System.Text;

namespace OperacionesBancarias.dominio
{
    class Cuenta
    {
        protected double _balance;

        public Cuenta(double balance)
        {
            this.Balance = balance;
        }
        

        public virtual bool Deposita(double deposito)
        {           
            Balance += deposito;            
            Console.WriteLine("Deposita: {0}", deposito);
            return true;                    
        }
        public virtual bool Retira(double retiro)
        {
            if (retiro < Balance)
            {
                Balance -= retiro;
                Console.WriteLine("Retira: {0}", retiro);
                return true;
            }
            else return false;            
        }

        public double Balance { get => _balance; set => _balance = value; }
    }
}
