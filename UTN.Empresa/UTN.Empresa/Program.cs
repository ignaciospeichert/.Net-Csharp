using System;
using System.Security.Cryptography.X509Certificates;

namespace UTN.Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] miArray = { 2, 6, 8, 22 };

            //for (int i = 0; i < miArray.Length; i++)
            //{
            //    Console.WriteLine(miArray[i]);
            //}

            ////Resize al Array. Le digo que tiene solamente 3 elementos.
            //Array.Resize(ref miArray, 3);

            //for (int i = 0; i < miArray.Length; i++)
            //{
            //    Console.WriteLine(miArray[i]);
            //}

            int[] vector1 = { 2, 3, 5, 7, 11, 17, 19 };

            ImprimeVector(vector1);

            int[] vector2 = vector1;

            vector2[0] = 0;
            vector2[1] = 1;
            vector2[2] = 2;
            vector2[3] = 3;
            vector2[4] = 4;
            vector2[5] = 5;
            vector2[6] = 6;
            

            ImprimeVector(vector1);

        }
        public static void ImprimeVector(int[] vector)
        {
            Console.Write('<');
            for (int i = 0; i < vector.Length; i++)
            {
                //Imprimir un elemento
                Console.WriteLine(vector[i]);
                //Imprimir una coma para delimitar si no es el ultimo elemento
                if ((i + 1) < vector.Length)
                {
                    Console.Write(", ");
                }
            }
            Console.Write('>');
            Console.WriteLine();
        }
    }
}
