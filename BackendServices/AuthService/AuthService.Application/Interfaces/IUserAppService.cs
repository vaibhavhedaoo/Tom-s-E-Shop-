using AuthService.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuthService.Application.Interfaces
{
    public interface IUserAppService
    {
        UserDTO LoginUser(LoginDTO loginDTO);
        bool SignUpUser(SignUpDTO signUpDTO, string roles);
    }
}
