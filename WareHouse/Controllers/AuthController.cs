using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WareHouse.Entities;

namespace WareHouse.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public void Login([FromBody] User user)
        {

        }

    }
}