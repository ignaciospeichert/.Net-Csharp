using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AutoEjemploCurso
{
    class Auto
    {
        private int idauto = 0;
        private string marca = "";
        private string modelo = "";
        private string color = "";
        private double velocidad = 0;
        private string transmision = "";
        private int estado = 0;

        public Auto(int idauto, string marca, string modelo, string color, double velocidad, string transmision, int estado)
        {
            this.idauto = idauto;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.velocidad = velocidad;
            this.transmision = transmision;
            this.estado = estado;
        }

        public int Idauto { get => idauto; set => idauto = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public double Velocidad { get => velocidad; set => velocidad = value; }
        public string Transmision { get => transmision; set => transmision = value; }
        public int Estado { get => estado; set => estado = value; }


        public void Encender()
        {
            if (this.estado == 1)
            {
                Console.WriteLine();
                Console.Write("&%·$&%·&·%$&·%   ");
                Console.WriteLine("El auto ya esta encendido");
            }
            else
            {
                this.estado = 1;
                Console.WriteLine();
                Console.WriteLine("El auto se encendio");
            }
        }
        public void Apagar()
        {
            if (this.estado == 1)
            {
                if (this.velocidad == 0)
                {
                    this.estado = 0;
                    Console.WriteLine();
                    Console.WriteLine("El auto se apago.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Debe detener el Auto.");
                }
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("El auto ya se encuentra apagado.");
            }
        }

        public void Acelerar()
        { 
            this.velocidad += 10;
            Console.WriteLine();
            Console.WriteLine("La velocidad actual es {0}", velocidad);
        }

        public void Frenar()
        {
            if (this.velocidad < 10) 
            {
                Console.WriteLine();
                Console.WriteLine("El auto esta detenido");
            }
            else
            {
                this.velocidad -= 10;

                Console.WriteLine();
                Console.WriteLine("La velocidad actual es {0}", Velocidad);

            }
        }

            


        
            
        
	}
    
}
