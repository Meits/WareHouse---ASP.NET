using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WareHouse.Entities;
using WareHouse.Filters;
using WareHouse.Repositories;

namespace WareHouse.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStockRepository _repository;

        public StocksController(IStockRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Stocks
        [HttpGet]
        public IEnumerable<Stock> Get()
        {
            //return new string[] { "value1", "value2" };
            return _repository.FindAll();
        }

        // GET: api/Stocks/5
        [HttpGet("{id}", Name = "StocksGet")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Stocks
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Stocks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
