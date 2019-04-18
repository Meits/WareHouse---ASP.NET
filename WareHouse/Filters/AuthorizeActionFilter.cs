using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WareHouse.Repositories.Interfaces;
using System.Security.Principal;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using WareHouse.Entities;

namespace WareHouse.Filters
{
    public class AuthorizeActionFilter : IAsyncActionFilter
    {
        private readonly IUserRepository _repository;
        public AuthorizeActionFilter(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            const string AUTHKEY = "authorization";
            var headers = context.HttpContext.Request.Headers;
            if (headers.ContainsKey(AUTHKEY))
            {
                User authorizeUser = _repository.Validate(headers[AUTHKEY]);
                
                
                if (authorizeUser == null)
                    context.Result = new UnauthorizedResult();
                else
                {

                    var claims = new[] {
                        new Claim(ClaimTypes.NameIdentifier, authorizeUser.Id.ToString()),
                        new Claim(ClaimTypes.Name, "Vasya"),
                    };
                    //var identity = new ClaimsIdentity(claims, "barer");
                    //var principal = new ClaimsPrincipal(identity);
                    //var ticket = new AuthenticationTicket(principal, "barer");

                    //AuthenticateResult.Success(ticket);

                    //context.HttpContext.User
                    var user = new GenericPrincipal(new ClaimsIdentity(claims), null);
                    context.HttpContext.User = user;

                    await next();
                }
                    
            }
            else
                context.Result = new UnauthorizedResult();
        }
    }
}