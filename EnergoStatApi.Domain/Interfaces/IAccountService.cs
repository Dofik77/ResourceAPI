using EnergoStatApi.Domain.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EnergoStatApi.Domain.Interfaces
{
    public interface IAccountService
    {
        void Register(RegistrationModel model);

        void Login(LoginModel model);

        //Task<bool> ChangePassword(ChangePasswordModel model);
    }
}
