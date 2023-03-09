using EnergoStatApi.DAL.Interfaces;
using EnergoStatApi.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergoStatApi.DAL.Repositories
{
    public class ElectricConsumptionRepository : IElectricConsumeRepository
    {
        private readonly ApplicationContext _db;

        public ElectricConsumptionRepository(ApplicationContext db)
        {
            _db = db;
        }

        public bool Created(ElectricConsumptionModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ElectricConsumptionModel entity)
        {
            throw new NotImplementedException();
        }

        public ElectricConsumptionModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public ElectricConsumptionModel GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ElectricConsumptionModel>> Select()
        {
            return await _db.ElectroConsume.ToListAsync();
        }
    }
}
