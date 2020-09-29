using System;

namespace Asociaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReportesRecursosHumanos reporte = new ReportesRecursosHumanos();

            //Gerente gerente1 = new Gerente(5);

            //Empleado emp1 = new Empleado(60000, "Sistemas");

            //Ingeniero ing1 = new Ingeniero();

            //Secretaria sec1 = new Secretaria();

            //reporte.generarReporte(emp1);
            //reporte.generarReporte(gerente1);
            //reporte.generarReporte(ing1);
            //reporte.generarReporte(sec1);

            ReportesRecursosHumanos reporte = new ReportesRecursosHumanos();

            Empleado emp1 = new Secretaria(60000, "Sistemas");
            Empleado emp2 = new Gerente(90000, "IT", 15);
            Empleado emp3 = new Ingeniero(80000, "Comercial");
            

            reporte.generarReporte(emp1);
            reporte.generarReporte(emp2);
            reporte.generarReporte(emp3);


            
        }
    }
}
