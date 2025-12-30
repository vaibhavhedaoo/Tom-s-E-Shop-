using AuthService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthService.Domain.Interfaces
{
    public interface IUserRepository
    {
        bool RegisterUser(User user, string role);
        User GetUserByEmail(string email);
    }
}
