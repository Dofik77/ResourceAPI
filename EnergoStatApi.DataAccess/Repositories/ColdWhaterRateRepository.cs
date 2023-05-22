using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergoStatApi.DataAccess.Repositories
{
    public class ColdWhaterRateRepository : IBaseRepository<ColdWhaterRate>
    {
        private readonly ApplicationContext _db;

        public ColdWhaterRateRepository(ApplicationContext db)
        {
            _db = db;
        }

        public Task Add(ColdWhaterRate entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ColdWhaterRate entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ColdWhaterRate> GetAll()
        {
            return _db.ColdWhaterRate;
        }
    }
}
