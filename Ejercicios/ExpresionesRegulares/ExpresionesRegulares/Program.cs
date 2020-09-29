using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Mi nombre es Juan y mi telefono es 1165083753 y mi codigo postal es juarez";
            string patron = @"\d";

            Regex miRegex = new Regex(patron);
            
            MatchCollection Match = miRegex.Matches(frase);

            if (Match.Count > 0) Console.WriteLine("Se ha encontrado una letra J");
            else Console.WriteLine("No se ha encontra la letra J");

            Console.ReadLine();

        }
    }
}
