using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.DataAccess.Interfaces;

namespace EnergoStatApi.DataAccess.Repositories
{
    public class UserRepository : IBaseRepository<User>
    {
        private readonly ApplicationContext _db;

        public UserRepository(ApplicationContext db)
        {
            _db = db;
        }

        public bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll()
        {
            return _db.Users;
        }

        public async Task Add(User users)
        {
            await _db.Users.AddAsync(users);
            await _db.SaveChangesAsync();
        }
    }
}
