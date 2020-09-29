using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    interface IMascota
    {
        void SetNombre(string nombre);
        string GetNombre();
        void Jugar();
    }
}
