using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ICRUD<T>
    {
        bool Create(T Entity);
        List<T> ReadAll();
        T Read(object ID);
        bool Update(T Entity);
        bool Delete(object ID);
    }
}
