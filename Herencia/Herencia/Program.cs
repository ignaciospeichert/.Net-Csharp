using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");
            Humano Juan = new Humano("Juan");
            Gorila Kingkong = new Gorila("Kingkong");

            Kingkong.pensar();
            Console.ReadKey();
        

            
            
        }
    }
        class Mamiferos
        {
             private String nombreSerVivo;

             public Mamiferos(string nombre)
               {
                    nombreSerVivo = nombre;
               }
         

            public void respirar()
            {
                Console.WriteLine("soy capaz de respirar");
            }
            public void pensar()
            {
            Console.WriteLine("Pensamiento basico institivo");
            }

            public void cuidarCrias()
            {
                Console.WriteLine("Cuido de mis crias");
            }
            public void getNombre()
            {
                Console.WriteLine("El nombre del ser vivo es: "+ nombreSerVivo);
            }
        }

        class Caballo : Mamiferos
        {
            public Caballo(String nombreCaballo) : base(nombreCaballo)
            {

            }
            public void galopar()
            {
                Console.WriteLine("Soy capaz de galopar");
            }
        }

        class Humano : Mamiferos
        {
            public Humano(String nombreHumano) : base(nombreHumano)
            {
            
            }   
            public void pensar()
            {
                    Console.WriteLine("Soy capaz de pensar");
            }
        }
        
        class Gorila: Mamiferos
        {
            public Gorila(String nombreGorila) : base(nombreGorila)
            {
            }
            
            public void trepar()
            {
            Console.WriteLine("Soy capaz de trepar");
            }
        public void pensar()
            {
            Console.WriteLine("Pensamiento institivo avanzado");
            }

        }   
    
}
