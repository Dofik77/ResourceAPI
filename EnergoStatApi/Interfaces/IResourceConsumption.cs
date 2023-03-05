using EnergoStatApi.Models.ApiModels;
using System;

namespace EnergoStatApi.Interfaces
{
    public interface IResourceConsumption
    {
        public int Id { get; set; }

        public DateTime DateOfPoint { get; set; }

        public int Value { get; set; }

        public TransitionMethod TransitionMethod { get; set; }
    }
}
