using System;
using System.Collections.Generic;
using System.Text;

namespace Asociaciones
{
    class ReportesRecursosHumanos
    {
        private Empleado  empleado;        

        public void generarReporte(Empleado empleado)
        {        
                empleado.getDetalles();            
        }
    }
}
