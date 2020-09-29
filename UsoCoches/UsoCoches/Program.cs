using System;

namespace UsoCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();
            Coche coche2 = new Coche();
            Coche coche3 = new Coche(72.35,80.05);

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());
            Console.WriteLine(coche3.getInfoCoche());
            coche3.setExtras(true, "Cuero ");
            Console.WriteLine(coche3.getExtras());

            Console.ReadLine();


        }
    }

    partial class Coche
    {



        public Coche()
        {

            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;

        }
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;

        }


    }

    partial class Coche { 
        public String getInfoCoche()
        { 
            return "Informacion del coche:\n " + "Ruedas: " + ruedas + " Largo: " + largo + " Ancho: " + ancho; 
        }
         
        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public String getExtras()
        {
            return "Extras del coche; \n" + "Tapiceria: " + tapiceria + "Climatizador:" + climatizador;
        }

        private int ruedas;
        private double largo;
        private double ancho;
        private Boolean climatizador;
        private String tapiceria;

        
    } 


}
