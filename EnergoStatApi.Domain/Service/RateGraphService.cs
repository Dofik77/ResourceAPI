using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.DataAccess.Enum;
using EnergoStatApi.DataAccess.Interface;
using EnergoStatApi.DataAccess.Interfaces;
using EnergoStatApi.DataAccess.Repositories;
using EnergoStatApi.Domain.Entity;
using EnergoStatApi.Domain.Interfaces;

namespace EnergoStatApi.Domain.Service
{
    public class RateGraphService : IRateGraphService
    {
        public IBaseRepository<ElectricRate> _electrictRepository;

        public RateGraphService(IBaseRepository<ElectricRate> electrictRepository)
        {
            _electrictRepository = electrictRepository;
        }

        public async Task<List<RateGraphModel>> GetRateGraph(int numberResourceType)
        {
            RateResourceType resourceType = (RateResourceType)numberResourceType;
            IQueryable<IResourceRate> resourceRates = null;

            var graphData = new List<RateGraphModel>();

            switch (resourceType)
            {
                case RateResourceType.Eletric:
                    resourceRates = _electrictRepository.GetAll();
                    break;
                     
                case RateResourceType.ColdWhater:
                    
                    break;

                case RateResourceType.WarmWhater:
                    break;

                 default:
                    
                    break;
            }

            if (!resourceRates.Any())
               throw new Exception("");

            foreach (var item in resourceRates)
            {
                var dateTimeX = item.DateOfIndication.Month;
                var resourceValueY = item.IndicationRate;

                var dateValue = new RateGraphModel(dateTimeX, resourceValueY);

                graphData.Add(dateValue);
            }

            return graphData;
        }
    }
}

