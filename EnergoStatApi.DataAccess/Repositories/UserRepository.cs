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

        public bool Created(User entity)
        {
            if (entity == null)
                return false;

            _db.Add(entity);
            return true;
        }

        public bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll()
        {
            return _db.Users;
        }
    }
}
