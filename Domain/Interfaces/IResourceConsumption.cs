using EnergoStatApi.Domain.Enum;
using System;

namespace EnergoStatApi.Domain.Interface
{
    public interface IResourceConsumption
    {
        public int Id { get; set; }

        public DateTime DateOfPoint { get; set; }

        public double Value { get; set; }

        public TransitionMethod TransitionMethod { get; set; }
    }
}
