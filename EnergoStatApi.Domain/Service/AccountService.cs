namespace EnergoStatApi.Domain.Service
{
    using EnergoStatApi.DataAccess.Entity;
    using EnergoStatApi.DataAccess.Interfaces;
    using EnergoStatApi.Domain.Entity;
    using EnergoStatApi.Domain.Interfaces;

    public class AccountService : IAccountService
    {
        public IBaseRepository<User> _usersRepository;

        public AccountService(IBaseRepository<User> usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public void Register(RegistrationModel model)
        {
            var user = _usersRepository.GetAll().FirstOrDefault(x => x.Name == model.Name);

            if(user != null)
            {
               // return 
            }

            user = new User 
            { 
                Name = model.Name, 
                Password = model.Password, 
                AccessToken = model.AccessToken 
            };

            _usersRepository.Created(user);
        }
    }
}
