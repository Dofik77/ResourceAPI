namespace EnergoStatApi.DataAccess.Repositories
{
    using EnergoStatApi.DataAccess.Entity;
    using EnergoStatApi.DataAccess.Interfaces;

    public class AuthenticationUserRepository : IBaseRepository<AuthenticationUser>
    {
        private readonly ApplicationContext _db;

        public AuthenticationUserRepository(ApplicationContext db)
        {
            _db = db;
        }

        public async Task Add(AuthenticationUser entity)
        {
            await _db.AuthUsers.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public bool Delete(AuthenticationUser entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<AuthenticationUser> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
