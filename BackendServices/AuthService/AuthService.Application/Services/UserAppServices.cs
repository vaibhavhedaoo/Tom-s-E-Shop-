using System;
using System.Collections.Generic;
using System.Linq;
using AuthService.Application.DTOs;
using AuthService.Application.Interfaces;
using AuthService.Domain.Entities;
using AuthService.Domain.Interfaces;
using MapsterMapper;
using BC =BCrypt.Net.BCrypt;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace AuthService.Application.Services
{
    public class UserAppServices : IUserAppService
    {
        private readonly IConfiguration configuration;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;



        public UserAppServices(IUserRepository userRepository, IMapper mapper, IConfiguration configuration)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public UserDTO LoginUser(LoginDTO loginDTO)
        {
            User user = _userRepository.GetUserByEmail(loginDTO.Email);
            if (user != null)
            {
                bool isPasswordValid = BC.Verify(loginDTO.Password, user.Password);
                if (isPasswordValid)
                {
                    UserDTO data = _mapper.Map<UserDTO>(user);
                    //UserDTO userDTO = new UserDTO
                    //{
                    //    UserId = user.Id,
                    //    Name = user.Name,
                    //    Email = user.Email,
                    //    PhoneNumber = user.PhoneNumber,
                    //    Roles = user.Roles.Select(r => r.Name).ToArray(),
                    //    Token = "GeneratedJWTToken" // Placeholder for actual token generation logic
                    //};  
                    //return userDTO;
                    data.Token = GenerateJwtToken(data); // Placeholder for actual token generation logic
                    return data;
                }
            }
            return null;
        }

        public bool SignUpUser(SignUpDTO signUpDTO, string roles)
        {
            User existingUser = _userRepository.GetUserByEmail(signUpDTO.Email);
            if (existingUser == null)
            {
                User newUser = _mapper.Map<User>(signUpDTO);
                //User newUser = new User
                //{
                //    Name = signUpDTO.Name,
                //    Email = signUpDTO.Email,
                //    Password = BC.HashPassword(signUpDTO.Password),
                //    PhoneNumber = signUpDTO.PhoneNumber,
                //    EmailConfirmed = false,
                //    CreatedDate = DateTime.UtcNow
                //};
                return _userRepository.RegisterUser(newUser, roles);

            }
            return false;
        }

        private string GenerateJwtToken(UserDTO user)
        {
            // Implement JWT token generation logic here
            var key = configuration["Jwt:Key"];
            if (string.IsNullOrWhiteSpace(key))
                throw new InvalidOperationException("JWT signing key is not configured. Set 'Jwt:Key' in configuration.");

            var securityKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            if (!int.TryParse(configuration["Jwt:ExpireMinutes"], out var expireMinutes) || expireMinutes <= 0)
                expireMinutes = 60; // reasonable default

            var roles = user?.Roles ?? Array.Empty<string>();

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user?.Name ?? string.Empty),
                new Claim(JwtRegisteredClaimNames.Email, user?.Email ?? string.Empty),
                new Claim("Roles", string.Join(",", roles)),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            // Add individual role claims
            foreach (var role in roles.Where(r => !string.IsNullOrWhiteSpace(r)))
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(expireMinutes),
                signingCredentials: credentials
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
