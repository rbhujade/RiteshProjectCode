using JWT_Authentication_Authorization.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWT_Authentication_Authorization.Services
{
    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;
        private readonly OurHeroDbContext _db;

        public UserService(IOptions<AppSettings> appSettings, OurHeroDbContext db) 
        {
            _appSettings = appSettings.Value;
            _db = db;
        }

        public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest model)
        {
            var user = await _db.Users.SingleOrDefaultAsync(s=> s.Username == model.Username && s.Password == model.Password);

            if (user == null) 
            {
                return null;
            }

            var token = await generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        private async Task<string> generateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = await Task.Run(() => {
                var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                return tokenHandler.CreateToken(tokenDescriptor);
            });

            return tokenHandler.WriteToken(token);
        }
    }
}
