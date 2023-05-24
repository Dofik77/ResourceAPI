using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.DataAccess.Enum;
using EnergoStatApi.DataAccess.Interface;
using EnergoStatApi.DataAccess.Interfaces;
using EnergoStatApi.Domain.Entity;
using EnergoStatApi.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergoStatApi.Domain.Service
{
    public class RatePredictedService : IRatePerdictedService
    {
        public IBaseRepository<ElectricRate> _electrictRepository;
        public IBaseRepository<WarmWhaterRate> _coldWhaterRepository;
        public IBaseRepository<ColdWhaterRate> _warmWhaterRepository;


        List<int> mounthNumWinterOffsetRate = new List<int>() { 1, 2, 3, 11, 12 };
        List<int> mounthNumSummerOffsetRate = new List<int>() { 7,8 };
        float electricWinterOffset = 1.10f;
       

        public RatePredictedService(IBaseRepository<ElectricRate>? electrictRepository, IBaseRepository<WarmWhaterRate>? coldWhaterRepository, IBaseRepository<ColdWhaterRate>? warmWhaterRepository)
        {
            _electrictRepository = electrictRepository;
            _coldWhaterRepository = coldWhaterRepository;
            _warmWhaterRepository = warmWhaterRepository;
        }

        public PredictedRateModel PredictedRate(int typeResource, DateTime currentMountToCalculate)
        {
            RateResourceType resourceType = (RateResourceType)typeResource;
            IQueryable<IResourceRate> resourceRates = null;

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

            var resourceRateForLastFiveMount = resourceRates
                .Where(x => x.DateOfIndication.Month < currentMountToCalculate.Month)
                .ToList();

            var resourceRateForCurrentMount = resourceRates
                .Where(x => x.DateOfIndication.Month == currentMountToCalculate.Month)
                .FirstOrDefault();

            var rateValueForSixMounth = resourceRateForLastFiveMount
                .Select(x => x.IndicationRate)
                .ToList();

            rateValueForSixMounth.Add(resourceRateForCurrentMount.IndicationRate);

            var middelRateValue = rateValueForSixMounth.Average();

            switch (resourceType)
            {
                // Для определения итоговой суммы прогноза потребление на следующий месяц необходимо учесть, является ли следующий месяц зимним ( Ноябрь - Март )
                // И если да, то добавляем сверху 10%
                case RateResourceType.Eletric :
                case RateResourceType.WarmWhater :
                    middelRateValue = mounthNumWinterOffsetRate
                        .Where(x => x == DateTime.Now.Month)
                        .Any() ? middelRateValue * electricWinterOffset : middelRateValue;
                    break;

                // Для холодной воды потребления на июль - август тоже повышается на 10 процентов
                case RateResourceType.ColdWhater:
                    middelRateValue = mounthNumSummerOffsetRate
                         .Where(x => x == DateTime.Now.Month)
                         .Any() ? middelRateValue * electricWinterOffset : middelRateValue;
                    break;

                default:
                    throw new Exception("Неизвестный тип репозитория");
            }

            var predictModel = new PredictedRateModel()
            {
                RateLastMounth = resourceRateForLastFiveMount
                .Select(x => x.IndicationRate)
                .ToList(),

                RateCurrentMounth = resourceRateForCurrentMount.IndicationRate,

                PredictRateNextMounth = middelRateValue
            };

            return predictModel;

        }
    }
}
