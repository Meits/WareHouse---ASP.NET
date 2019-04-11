using System;
using System.Collections.Generic;
using System.Text;
using WareHouse.Abstractions;
using WareHouse.AppContext;
using WareHouse.Entities;

namespace WareHouse.Repositories
{
    public class StockRepository : DbRepository<Stock>, IStockRepository
    {
        public StockRepository(AppDbContext context) : base(context)
        {
        }
    }
}
