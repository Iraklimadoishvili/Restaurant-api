using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Restaurant_api.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;

namespace Restaurant_api.Data
{

    public class AuthRepository : IAuthRepository
    {

        private readonly RestaurantDbContext _db;
        private readonly IConfiguration _configuration;
        private readonly AppSettings _appSettings;
        public AuthRepository(RestaurantDbContext db, IConfiguration configuration ,IOptions<AppSettings> appSettings)
        {
            _db = db;
            _configuration = configuration;
            _appSettings = appSettings.Value;
            
        }
        //login user
        public async Task<ServiceResponse<string>> Login(string username, string password)
        {
            var response = new ServiceResponse<string>();
            var user = await _db.Users.FirstOrDefaultAsync(x => x.Email.ToLower() == username.ToLower());

            if (user == null)
            {
                response.Success = false;
                response.Message = "User not found";
            }
            else if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                response.Success = false;
                response.Message = "Wrong password";
            }
            else
            {
                response.Data = GenerateToken(user);
            }

            return response;
        }


        //registering user
        public async Task<ServiceResponse<int>> Register(User user, string password,string confirmPassword)
        {

            var response = new ServiceResponse<int>();


            if(await UserExsits(user.Email))
            {
                response.Success = false;
                response.Message = "User already exsits";
                return response;
            }

            if(password != confirmPassword)
            {
                response.Success = false;
                response.Message = "Password and confirm password do not match";
                return response;
            }
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

             await _db.Users.AddAsync(user);
             await _db.SaveChangesAsync();
            response.Data= user.Id;
            return response;
        }


        //check if user exsts by email
        public  async Task<bool> UserExsits(string username)
        {
            if (await _db.Users.AnyAsync(x => x.Email.ToLower() == username.ToLower()))
            {
                return true;
            }
            return false;
                
    }

   
        private void CreatePasswordHash(string password,out byte[] passwordHash, out byte[] passwordSalt) { 
        
        using(var hmac = new System.Security.Cryptography.HMACSHA512()) {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash,byte[] passwordSalt) {
        
         using(var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computeHash.SequenceEqual(passwordHash);
            }

        }

        private string GenerateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.Username)
            };

            var tokenKey = _appSettings.Token;
            Console.WriteLine($"Token key length: {tokenKey.Length}");

            if (tokenKey.Length < 64)
            {
                throw new InvalidOperationException("Token key is too short. It must be at least 64 characters long.");
            }

            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = credentials
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

    
    }
}
