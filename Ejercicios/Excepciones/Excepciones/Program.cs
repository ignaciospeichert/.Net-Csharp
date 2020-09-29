using System;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ManejaVector();
        }
        public void ManejaVector()
        {
            int i = 0;
            int j = 0;

            String[] mensajes = { "Hola Mundo de Excepciones!", "No, no se rompio", "Aca tampoco!!" };

            while (i < 4)
            {
                try
                {
                    Console.WriteLine(mensajes[i]);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    Console.WriteLine("Reiniciando el valor del indice");
                    i = -1;
                }
                finally
                {
                    Console.WriteLine("Esto se imprime siempre");
                }
                i++;
                j++;
                if (j == 20)
                {
                    Console.WriteLine("Forzando la finalizacion del ciclo");
                    i = 4;
                }
              
            }
        }
    }
}
