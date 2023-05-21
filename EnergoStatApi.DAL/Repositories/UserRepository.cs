using EnergoStatApi.DataAccess.Entity;
using EnergoStatApi.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EnergoStatApi.DataAccess.Repositories
{
    internal class UserRepository : IBaseRepository<User>
    {
        private readonly ApplicationContext _db;

        public UserRepository(ApplicationContext db)
        {
            _db = db;
        }

        public bool Created(User entity)
        {
            throw new NotImplementedException();
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
