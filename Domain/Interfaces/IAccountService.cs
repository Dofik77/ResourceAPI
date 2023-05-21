using EnergoStatApi.Domain.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EnergoStatApi.Domain.Interfaces
{
    public interface IAccountService
    {
        Task<ClaimsIdentity> Register(RegistrationModel model);

        //Task<ClaimsIdentity> Login(LoginModel model);

        //Task<bool> ChangePassword(ChangePasswordModel model);
    }
}
