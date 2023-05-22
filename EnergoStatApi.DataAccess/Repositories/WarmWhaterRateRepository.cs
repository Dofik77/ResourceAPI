using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergoStatApi.DataAccess.Repositories
{
    public class WarmWhaterRateRepository : IBaseRepository<WarmWhaterRate>
    {
        private readonly ApplicationContext _db;

        public WarmWhaterRateRepository(ApplicationContext db)
        {
            _db = db;
        }

        public Task Add(WarmWhaterRate entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(WarmWhaterRate entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<WarmWhaterRate> GetAll()
        {
            return _db.WarmWhaterRate;
        }
    }
}
