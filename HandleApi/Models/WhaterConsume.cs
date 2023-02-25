using System;
using HandleApi.Interfaces;

namespace HandleApi.Models
{
    public class WhaterConsume : IResourceConsume
    {
        public int Id { get; set; }
        public DateTime DateOfPoint { get; set; }
        public int Value { get; set; }
        public TransitionMethodEnum TransitionMethod { get; set; }
    }
}
