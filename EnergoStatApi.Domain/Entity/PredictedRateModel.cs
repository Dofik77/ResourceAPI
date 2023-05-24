namespace EnergoStatApi.Domain.Entity
{
    public class PredictedRateModel
    {
        public List<float> RateLastMounth { get; set; }

        public float RateCurrentMounth { get; set; }

        public float PredictRateNextMounth { get; set; }
    }
}
