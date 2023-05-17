using EnergoStatApi.DataAccess.Entity;

namespace EnergoStatApi.DataAccess.Interfaces
{
    public interface IElectricConsumeRepository : IBaseRepository<ElectricConsumptionModel>
    {
        ElectricConsumptionModel GetByName(string name);
    }
}
