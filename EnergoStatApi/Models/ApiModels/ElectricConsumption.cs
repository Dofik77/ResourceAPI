using System;
using EnergoStatApi.Interfaces;

namespace EnergoStatApi.Models.ApiModels
{
    public class ElectricConsumption : IResourceConsumption
    {
        public int Id { get; set; }

        public DateTime DateOfPoint { get; set; }

        public int Value { get; set; }

        public TransitionMethod TransitionMethod { get; set; }
      
    }

    public enum TransitionMethod
    {
        Portal,
        Operator,
        LK_TES
    }

}
