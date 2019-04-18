using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Primitives;
using WareHouse.Abstractions;
using WareHouse.Entities;

namespace WareHouse.Repositories.Interfaces
{
    public interface IUserRepository : IDbRepository<User>
    {
        User Authenticate(string username, string password);
        User Validate(string stringValues);
    }
}
