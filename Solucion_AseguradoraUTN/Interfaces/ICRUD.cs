using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICRUD<T>
    {
        bool Create(T Entidad);

        T Read(Object ID);

        DataTable ReadAll();

        bool Update(T Entidad);

        bool Delete(T Entidad);
    }
}
