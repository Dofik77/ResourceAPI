using System;
using EnergoStatApi.DataAccess.Enum;
using EnergoStatApi.DataAccess.Interface;

namespace EnergoStatApi.DataAccess.Entity
{
    public class ElectricConsumptionModel : IResourceConsumption
    {
        public int Id { get; set; }

        public DateTime DateOfPoint { get; set; }
       
        public int Value { get; set; }

        public TransitionMethod TransitionMethod { get; set; }
    }
}
