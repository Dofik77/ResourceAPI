using EnergoStatApi.DataAccess.Enum;
using System;

namespace EnergoStatApi.DataAccess.Interface
{
    public interface IResourceConsumption
    {
        public int Id { get; set; }

        public DateTime DateOfPoint { get; set; }

        public int Value { get; set; }

        public TransitionMethod TransitionMethod { get; set; }
    }
}
