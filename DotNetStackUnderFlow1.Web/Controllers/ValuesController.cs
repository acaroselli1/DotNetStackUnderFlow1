using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetStackUnderFlow.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DotNetStackUnderFlow1.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _um;

        //[Authorize]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string>() { "Hello", "World" };
        }

        [HttpPost]
        public Question CreateQuestion([FromBody] Question q)
        {
            try
            {
                var user = _um.GetUserAsync(HttpContext.User).Result;
                q.UserId = user.Id;
                return q;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public ValuesController(UserManager<IdentityUser> um)
        {
            _um = um;
        }
    }
}