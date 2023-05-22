using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
namespace EnergoStatApi.Domain.Service
{
    using EnergoStatApi.DataAccess.Entity;
    using EnergoStatApi.DataAccess.Enum;
    using EnergoStatApi.DataAccess.Interface;
    using EnergoStatApi.DataAccess.Interfaces;
    using EnergoStatApi.Domain.Entity;
    using EnergoStatApi.Domain.Interfaces;

    public class RateGraphService : IRateGraphService
    {
        public IBaseRepository<ElectricRate> _electrictRepository;
        public IBaseRepository<WarmWhaterRate> _coldWhaterRepository;
        public IBaseRepository<ColdWhaterRate> _warmWhaterRepository;

        public RateGraphService(IBaseRepository<ElectricRate> electrictRepository, IBaseRepository<WarmWhaterRate> coldWhaterRepository, IBaseRepository<ColdWhaterRate> warmWhaterRepository)
        {
            _electrictRepository = electrictRepository;
            _coldWhaterRepository = coldWhaterRepository;
            _warmWhaterRepository = warmWhaterRepository;
        }

        public async Task<List<RateGraphModel>> GetRateGraph(int numberResourceType, DateTime dateOfIndication, DateTime dateEndRateResource)
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
                    resourceRates = _coldWhaterRepository.GetAll();
                    break;

                case RateResourceType.WarmWhater:
                    resourceRates = _warmWhaterRepository.GetAll();
                    break;

                 default:
                    throw new Exception("Неизвестный тип репозитория");
            }

            if (!resourceRates.Any())
               throw new Exception("Репозиторий пуст, необходимо обратится к владельцу сервера для выяснения причин");

            var resourceRatesOnDate = resourceRates
                .Where(x => x.DateOfIndication >= dateOfIndication && x.DateOfIndication <= dateEndRateResource)
                .ToList();

            if (!resourceRatesOnDate.Any())
                throw new Exception($"На заданные даты с {dateOfIndication} по {dateEndRateResource} нету данных о потреблении энергии");

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

