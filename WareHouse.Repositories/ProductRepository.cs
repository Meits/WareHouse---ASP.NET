using System;
using System.Collections.Generic;
using System.Text;
using WareHouse.AppContext;
using WareHouse.Entities;

namespace WareHouse.Repositories
{
    public class ProductRepository : DbRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
