using System;
using EnergoStatApi.Domain.Enum;
using EnergoStatApi.Domain.Interface;

namespace EnergoStatApi.Domain.Entity
{
    public class WhaterConsumptionModel : IResourceConsumption
    {
        public int Id { get; set; }

        public DateTime DateOfPoint { get; set; }

        public double Value { get; set; }

        public TransitionMethod TransitionMethod { get; set; }
    }
}
