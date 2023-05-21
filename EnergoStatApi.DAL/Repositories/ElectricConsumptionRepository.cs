using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EnergoStatApi.DataAccess.Repositories
{
    public class ElectricRateRepository : IBaseRepository<ElectricRate>
    {
        private readonly ApplicationContext _db;
         
        public ElectricRateRepository(ApplicationContext db)
        {
            _db = db;
        }

        public IQueryable<ElectricRate> GetAll()
        {
            return _db.ElectroRate;
        }

        public bool Created(ElectricRate entity)
        {
            if (entity == null)
                return false;

            _db.Add(entity);
            return true;
        }

        public ElectricRate Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ElectricRate entity)
        {
            throw new NotImplementedException();
        }
    }
}
