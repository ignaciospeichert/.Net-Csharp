using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM.Clases
{
    interface Ifunciones
    {
        int Registrar();
        bool Actualizar();
        bool Eliminar();

        DataTable Listar();

        DataTable BuscarPorCodigo(int id);
    }
}
