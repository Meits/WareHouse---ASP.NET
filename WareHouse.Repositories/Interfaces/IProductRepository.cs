using System;
using System.Collections.Generic;
using System.Text;
using WareHouse.Abstractions;
using WareHouse.Entities;

namespace WareHouse.Repositories
{
    public interface IProductRepository : IDbRepository<Product>
    {
    }
}
