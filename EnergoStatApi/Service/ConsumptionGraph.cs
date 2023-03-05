using System;
using System.Collections.Generic;
using EnergoStatApi.Interfaces;
using EnergoStatApi.Models.ApiModels;

namespace EnergoStatApi.Service
{
    public class ConsumptionGraphService
    {
        public List<KeyValuePair<int, int>> GetConsumptionGraph(List<IResourceConsumption> values)
        {
            var resourceData = new List<KeyValuePair<int, int>>();

            foreach (var item in values)
            {
                var dateTimeX = item.DateOfPoint.Month;
                var resourceValueY = item.Value;

                var dateValue = new KeyValuePair<int, int>(dateTimeX, resourceValueY);

                resourceData.Add(dateValue);
            }

            return resourceData;
        }
    }
}

