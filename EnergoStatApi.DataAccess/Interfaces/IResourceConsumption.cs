using System;

namespace EnergoStatApi.DataAccess.Interface
{
    public interface IResourceRate
    {
        public int ForeignKey { get; set; }

        public DateTime DateOfIndication { get; set; }

        public float IndicationRate { get; set; }

        public float TariffPlan { get; set; }
    }
}
