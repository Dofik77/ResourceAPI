using System;
using System.ComponentModel.DataAnnotations.Schema;
using EnergoStatApi.Domain.Enum;
using EnergoStatApi.Domain.Interface;

namespace EnergoStatApi.Domain.Entity
{
    public class ElectricConsumptionModel : IResourceConsumption
    {
        public int Id { get; set; }

        public DateTime DateOfPoint { get; set; }
       
        public int Value { get; set; }

        public TransitionMethod TransitionMethod { get; set; }
    }
}
