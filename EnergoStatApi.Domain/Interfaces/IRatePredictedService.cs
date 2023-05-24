namespace EnergoStatApi.Domain.Interfaces
{
    using EnergoStatApi.Domain.Entity;

    public interface IRatePerdictedService
    {
        public PredictedRateModel PredictedRate(int typeResource, DateTime currentMountToCalculate);
    }
}
