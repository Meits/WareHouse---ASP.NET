using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WareHouse.Entities;
using WareHouse.Filters;
using WareHouse.Repositories.Interfaces;
using WareHouse.ViewModels;

namespace WareHouse.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public AuthController(IUserRepository repository)
        {
            _repository = repository;
        }


        // POST api/values
        [HttpPost]
        public IActionResult Login([FromBody] UserModel userModel)
        {
            User user = _repository.Authenticate(userModel.Email, userModel.Password);
            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            string token = user.Token;

            // return basic user info (without password) and token to store client side
            //response.Headers.Add("Authorization", JwtManager.GenerateToken(username));
            this.Response.Headers["Authorization"] = token;
            return Ok(new
            {
                //Id = user.Id,
                //Firstname = user.Firstname,
                //Lastname = user.Lastname,
                //Email = user.Email,
                //Token = token,
                status = "success"

            });
        }

        // GET api/values
        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<string>> User()
        {
            
            string Id  = HttpContext.User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).Select(c => c.Value).SingleOrDefault();
            User user = _repository.GetItemAsync(new Guid(Id)).Result;

            if(user == null)
            {
                return BadRequest(new { message = "Token Error" });
            }

            return Ok(user);
        }

        // GET api/values
        [Authorize]
        [HttpGet]
        public ActionResult<IEnumerable<string>> refresh()
        {

            return Ok( "success" );
        }

    }
}