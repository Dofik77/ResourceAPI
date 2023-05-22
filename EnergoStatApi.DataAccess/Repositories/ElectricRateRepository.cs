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

        public async Task Add(ElectricRate electricRate)
        {
            await _db.ElectroRate.AddAsync(electricRate);
            await _db.SaveChangesAsync();
        }

        public bool Delete(ElectricRate entity)
        {
            throw new NotImplementedException();
        }
    }
}
