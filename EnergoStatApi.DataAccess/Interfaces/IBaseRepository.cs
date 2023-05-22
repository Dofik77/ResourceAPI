using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnergoStatApi.DataAccess.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task Add(T entity);

        IQueryable<T> GetAll();

        bool Delete(T entity);
    }
}
