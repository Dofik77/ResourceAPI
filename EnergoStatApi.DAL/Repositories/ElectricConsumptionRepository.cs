﻿using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EnergoStatApi.DataAccess.Repositories
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
            if (entity == null)
                return false;

            _db.Add(entity);
            return true;
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
