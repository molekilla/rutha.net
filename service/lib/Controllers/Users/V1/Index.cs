// Based from http://www.asp.net/vnext/overview/aspnet-vnext/create-a-web-api-with-mvc-6
using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Linq;
using Rutha.Models;

namespace Rutha.Controllers.Users
{

    [Route("api/v1/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserRepository _repository;

        public UsersController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public void CreateUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
            }
            else
            {
                _repository.Add(user);

//                string url = Url.RouteUrl("GetByIdRoute", new { id = item.Id }, Request.Scheme, Request.Host.ToUriComponent());
                Context.Response.StatusCode = 201;
                //Context.Response.Headers["Location"] = url;
            }
        }
    }
}