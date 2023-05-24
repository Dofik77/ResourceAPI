namespace EnergoStatApi.Domain.Service
{
    using EnergoStatApi.DataAccess.Entity;
    using EnergoStatApi.DataAccess.Interfaces;
    using EnergoStatApi.Domain.Entity;
    using EnergoStatApi.Domain.Interfaces;

    public class AccountService : IAccountService
    {
        public IBaseRepository<User> _usersRepository;
        public IBaseRepository<AuthenticationUser> _authUsersRepository;

        public AccountService(IBaseRepository<User> usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public void Login(LoginModel model)
        {
            var user = _usersRepository.GetAll().FirstOrDefault(x => x.Name == model.Name);

            if (user == null || model.Password != user.Password)
               throw new Exception();

            var authUser = new AuthenticationUser
            {
                AuthenticatedUser = user,
                DateTimeAuth = DateTime.Now,
            };

            _authUsersRepository.Add(authUser);
        }

        public void Register(RegistrationModel model)
        {
            var user = _usersRepository.GetAll().FirstOrDefault(x => x.Name == model.Name);

            if (user != null)
                throw new Exception();

            user = new User 
            { 
                Name = model.Name, 
                Password = model.Password, 
                AccessToken = model.AccessToken 
            };

            _usersRepository.Add(user);
        }
    }
}
