using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;
using WareHouse.AppContext;
using WareHouse.Entities;
using WareHouse.Repositories.Interfaces;

namespace WareHouse.Repositories
{
    public class UserRepository : DbRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {

        }
        public User Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            //var user = Context.Users.SingleOrDefault(x => x.Username == username);
            var user = this.FindByCondition(x => x.Email == username);
            

            // check if username exists
            if (user == null)
                return null;

            if (!VerifyPasswordHash(password, user.Password, user.Salt))
                return null;

            // authentication successful
            return user;
        }

       

        public User Validate(string stringValues)
        {
            var strings = stringValues.Split(" ");
            if (strings[0] == "Bearer" && strings[1] != "")
            {
                User user = this.FindByCondition(x => x.Token == strings[1]);
                // check if username exists
                if (user == null)
                    return null;

                return user;
            }
            else
            {
                return null;
            }

        }

        private  bool VerifyPasswordHash(string password, string storedHash, string storedSalt)
        {
            if (password == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
  
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: Convert.FromBase64String(storedSalt),
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8));

            if(hashed == storedHash)
            {
                return true;
            }

            return false;
        }
    }
}
