using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YenallarRezervasyon
{
    public interface IGenericRepository<T>
    {
        void Create(T entity);
        void Insert(T entity);
        void Remove(T entity);
        void Update(T entity);
        List<T> GetListAll();
        T GetById(int id);

    }
}
