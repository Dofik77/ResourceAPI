using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnergoStatApi.DataAccess.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Created(T entity);

        T Get(int id);

        Task<List<T>> Select();

        bool Delete(T entity);
    }
}
