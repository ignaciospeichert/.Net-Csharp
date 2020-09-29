using System;

namespace HerenciaenNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Babieca");

            Humano Juan = new Humano("Juan");

            Gorila Copito = new Gorila("Copito");

            IMamiferosTerrestres IBabieca = Babieca;
            ISaltoConPatas IBabieca2 = Babieca;

            //Mamiferos[] arrayMamiferos = new Mamiferos[3];

            //arrayMamiferos[1] = Babieca;
            //arrayMamiferos[2] = Juan;
            //arrayMamiferos[3] = Copito;


            //arrayMamiferos[1].getNombre();

            Console.WriteLine(IBabieca.numeroPatas());
            Console.WriteLine(IBabieca2.numeroPatas());

            Console.ReadLine();

            
        }
    }

}
