using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EnergoStatApi.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Created(T entity);

        T Get(int id);

        Task<List<T>> Select();

        bool Delete(T entity);
    }
}
