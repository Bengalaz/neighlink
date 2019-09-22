using System;
using System.Collections.Generic;

namespace Business
{
    public interface ICrudService<T>
    {
        bool Insert(T t);
        bool Update(T t);
        bool Delete(int? id);
        List<T> FindAll();
        T FindById(int? id);
    }
}
