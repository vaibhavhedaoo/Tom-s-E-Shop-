using AuthService.Domain.Entities;
using AuthService.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AuthService.Infrastructure.Presistance.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AuthServiceContext _context;
        public UserRepository(AuthServiceContext context)
        {
            _context = context;
        }
        public User GetUserByEmail(string email)
        {
           return _context.Users.Include(u=>u.Roles).Where(u =>u.Email == email).FirstOrDefault();
        }

        public bool RegisterUser(User user, string role)
        {
            Role UserRole = _context.Roles.Where(r=>r.Name == role).FirstOrDefault();
            if(UserRole != null)
            {
                user.Roles.Add(UserRole);
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
