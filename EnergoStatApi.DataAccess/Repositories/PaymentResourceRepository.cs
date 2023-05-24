using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergoStatApi.DataAccess.Repositories
{
    public class PaymentResourceRepository : IBaseRepository<PaymentResource>
    {
        private readonly ApplicationContext _db;

        public PaymentResourceRepository(ApplicationContext db)
        {
            _db = db;
        }

        public async Task Add(PaymentResource payment)
        {
            await _db.PaymentData.AddAsync(payment);
            await _db.SaveChangesAsync();
        }

        public bool Delete(PaymentResource entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<PaymentResource> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
