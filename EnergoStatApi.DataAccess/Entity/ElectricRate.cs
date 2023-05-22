using System;
using EnergoStatApi.DataAccess.Enum;
using EnergoStatApi.DataAccess.Interface;

namespace EnergoStatApi.DataAccess.Entity
{
    public class ElectricRate : IResourceRate
    {
        public int ForeignKey { get; set; }

        public DateTime DateOfIndication { get; set; }

        public float IndicationRate { get; set; }

        public float TariffPlan { get; set; }
    }
}
