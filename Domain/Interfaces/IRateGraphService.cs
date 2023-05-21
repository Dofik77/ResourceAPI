using EnergoStatApi.DataAccess.Enum;
using EnergoStatApi.DataAccess.Interface;
using EnergoStatApi.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EnergoStatApi.Domain.Interfaces
{
    public interface IRateGraphService
    {
        public Task<List<RateGraphModel>> GetRateGraph(int numberResourceType);
    }
}
