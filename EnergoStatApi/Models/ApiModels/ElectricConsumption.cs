using System;
using EnergoStatApi.Interfaces;

namespace EnergoStatApi.Models.ApiModels
{
    public class ElectricConsumption : IIdentifiable
    {
        public int Id { get; }

        public ElectricConsumption(int id, DateTime dateOfPoint, int value, TransitionMethod transitionMethod)
        {
            Id = id;
            DateOfPoint = dateOfPoint;
            Value = value;
            TransitionMethod = transitionMethod;
        }

        public DateTime DateOfPoint { get; set; }

        public int Value { get; set; }

        public TransitionMethod TransitionMethod { get; set; }

    }
}
