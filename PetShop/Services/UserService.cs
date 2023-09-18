using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using PetShopAPI.Data;
using PetShopAPI.Entities;
using PetShopAPI.Exceptions;
using PetShopAPI.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PetShopAPI.Services
{
    public interface IUserService
    {
        void Register(RegisterUserDto dto);
        string GenerateToken(LogInDto dto);
    }
    public class UserService : IUserService
    {
        private readonly PetShopDbContext _dbContext;
        private readonly IPasswordHasher<User> _passwordhasher;
        private readonly Authentication _authentication;

        public UserService(PetShopDbContext dbContext, IPasswordHasher<User> passwordHasher, Authentication authentication)
        {
            _dbContext = dbContext;
            _passwordhasher = passwordHasher;
            _authentication = authentication;
        }

        public string GenerateToken(LogInDto dto)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Email == dto.Email);

            if(user is null)
            {
                throw new BadRequestException("Invalid username or password");
            }

            var result = _passwordhasher.VerifyHashedPassword(user, user.PasswordHash, dto.Password);

            if(result == PasswordVerificationResult.Failed)
            {
                throw new BadRequestException("Invalid username or password");
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_authentication.JwtKey));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(_authentication.JwtExpireDays);

            var token = new JwtSecurityToken(_authentication.JwtIssuer,
                _authentication.JwtIssuer,
                claims,
                expires: expires,
                signingCredentials: cred);

            var tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }

        public void Register(RegisterUserDto dto)
        {
            var user = new User()
            {
                Email = dto.Email,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Nationality = dto.Nationality,
            };

            var hasheedPassword = _passwordhasher.HashPassword(user, dto.Password);

            user.PasswordHash = hasheedPassword;
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }
    }
}
