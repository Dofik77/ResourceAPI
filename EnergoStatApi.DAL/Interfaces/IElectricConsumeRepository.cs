using EnergoStatApi.Domain.Entity;

namespace EnergoStatApi.DAL.Interfaces
{
    public interface IElectricConsumeRepository : IBaseRepository<ElectricConsumptionModel>
    {
        ElectricConsumptionModel GetByName(string name);
    }
}
