using System;
using EnergoStatApi.Interfaces;

namespace EnergoStatApi.Models
{
    public class WhaterConsume : IResourceConsume
    {
        public int Id { get; set; }
        public DateTime DateOfPoint { get; set; }
        public int Value { get; set; }
        public TransitionMethodEnum TransitionMethod { get; set; }
    }
}
