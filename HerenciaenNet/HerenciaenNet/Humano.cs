using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HerenciaenNet
{
    class Humano : Mamiferos
    {           
        
        public Humano(string nombreHumano) : base (nombreHumano)
        {

        }
        

        public void pensar()
        {
            Console.WriteLine("Soy capaz de pensar");
        }

     


    }
    
}
