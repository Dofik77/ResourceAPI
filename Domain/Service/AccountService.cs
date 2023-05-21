using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.DataAccess.Interfaces;
using EnergoStatApi.Domain.Entity;
using EnergoStatApi.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EnergoStatApi.Domain.Service
{
    public class AccountService : IAccountService
    {
        public IBaseRepository<User> _usersRepository;

        public AccountService(IBaseRepository<User> usersRepository)
        {
            _usersRepository = usersRepository;
        }




        public Task<ClaimsIdentity> Register(RegistrationModel model)
        {
            var user = _usersRepository.GetAll().FirstOrDefault(x => x.Name == model.Name);

            if(user != null)
            {
                //???
            }

            user = new User 
            { 
                Name = model.Name, 
                Password = model.Password, 
                AccessToken = model.AccessToken 
            };



        }
    }
}
