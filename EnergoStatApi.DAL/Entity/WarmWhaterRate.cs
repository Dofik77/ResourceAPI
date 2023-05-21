using EnergoStatApi.DataAccess.Enum;
using EnergoStatApi.DataAccess.Interface;
using System;

namespace EnergoStatApi.DataAccess.Entity
{
    public class WarmWhaterRate : IResourceRate
    {
        public int ForeignKey { get; set; }

        public DateTime DateOfIndication { get; set; }

        public float IndicationRate { get; set; }

        public float TariffPlan { get; set; }
    }
}
