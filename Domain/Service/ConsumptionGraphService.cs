using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EnergoStatApi.DataAccess.Interface;

namespace EnergoStatApi.Domain.Service
{
    public class ConsumptionGraphService
    {
        public async Task<List<KeyValuePair<int, double>>> GetConsumptionGraphService<T>(List<T> values) where T : IResourceConsumption
        {
            if (values == null)
            {
                return new List<KeyValuePair<int, double>> () { };
                //throw new InvalidOperationException("Не существует значений для построения массива координат");
            }
              
            var resourceData = new List<KeyValuePair<int, double>>();

            foreach (var item in values)
            {
                var dateTimeX = item.DateOfPoint.Month;
                var resourceValueY = item.Value;

                var dateValue = new KeyValuePair<int, double>(dateTimeX, resourceValueY);

                resourceData.Add(dateValue);
            }

            return resourceData;
        }
    }
}

