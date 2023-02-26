using System;

namespace EnergoStatApi.Interfaces
{
    public interface IResourceConsume
    {
        public int Id { get; set; }
        public DateTime DateOfPoint { get; set; }
        public int Value { get; set; }
        public TransitionMethodEnum TransitionMethod { get; set; }
    }

    public enum TransitionMethodEnum
    {
        Portal,
        Operator,
        LK_TES
    }
}
