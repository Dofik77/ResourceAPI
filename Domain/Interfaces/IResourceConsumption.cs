using EnergoStatApi.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergoStatApi.Domain.Interface
{
    public interface IResourceConsumption
    {
        public int Id { get; set; }

        public DateTime DateOfPoint { get; set; }

        //public int value { get; set; }

        public TransitionMethod TransitionMethod { get; set; }
    }
}
