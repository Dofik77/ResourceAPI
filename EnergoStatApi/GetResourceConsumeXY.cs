using System;
using System.Collections.Generic;
using EnergoStatApi.Interfaces;
using EnergoStatApi.Models;

namespace EnergoStatApi
{
	public class ResourceConsumeXY
	{
		public int DateTimeX;
		public int ResourceValueY;
		 
		public List<ElectroConsume> _resourceConsumer;
		public List<KeyValuePair<int, int>> pairXY;

		public ResourceConsumeXY(List<ElectroConsume> resourceConsumer)
		{
			_resourceConsumer = resourceConsumer;
        }

        public List<KeyValuePair<int, int>> GetResourceConsumeXY()
		{
            var list = new List<KeyValuePair<string, int>>();

			foreach (var item in _resourceConsumer)
			{
				var date = item.DateOfPoint;
                pairXY.Add()

            }


        }


    }
}

