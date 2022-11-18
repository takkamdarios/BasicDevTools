using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTools.ADO.Repositories
{
    internal interface IBaseRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        T Get(int id);
        ICollection<T> GetAll();

    }
}
