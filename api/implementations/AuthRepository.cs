using System;
using System.Threading.Tasks;
using api.data;
using api.entities;
using api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api.DAL.Implementations
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;

        public AuthRepository(DataContext context)
        {
            _context = context;
        }



        public Task<AppUser> getUserByName(string username)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AppUser> Login(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.username == username);
            if (user == null) return null;
            if (!VerifyPassWordHash(password, user.PasswordHash, user.PasswordSalt)) return null;
            return user;
        }

        public async Task<AppUser> Register(AppUser user, string password)
        {
            DateTime now = DateTime.UtcNow;
            byte[] passwordHash, passwordSalt;
            CreatePassWordHash(password, out passwordHash, out passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
          
            user.created = now;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public Task<string> updatePassword(AppUser user, string password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> UserExists(string username)
        {
             if (await _context.Users.AnyAsync(x => x.username == username)) return true;
            return false;
        }

        private void CreatePassWordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA1())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            };
        }
         private bool VerifyPassWordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA1(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < password.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i]) return false;
                }
            };
            return true;
        }
    }
}
