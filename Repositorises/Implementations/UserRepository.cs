using CLASSEM_MVC_PRO.Context;
using CLASSEM_MVC_PRO.Models.Entities;
using CLASSEM_MVC_PRO.Repositorises.Interfaces;

namespace CLASSEM_MVC_PRO.Repositorises
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }
        public User Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public void Delete(User user)
        {           
           _context.Users.Remove(user);
           _context.SaveChanges();
        }

        public User GetById(string userId)
        {
            var user = _context.Users.SingleOrDefault(x => x.UserId == userId);
            return user;
        }

        public User Login(string email, string password)
        {
            var user = _context.Users.SingleOrDefault(w => w.Email == email && w.Password == password);
            return user;
        }

        public User UpdatePassword(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user;
        }
    }
}