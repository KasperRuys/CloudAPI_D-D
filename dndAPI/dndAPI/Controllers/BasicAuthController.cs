using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicAuthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Login([FromHeader]string authorization)
        {
            var credentials = authorization;
            if (!string.IsNullOrEmpty(credentials))
            {
                return Ok("Logged on");
            }
            Response.Headers.Add("WWW-Authenticate", "Basic");

            return Unauthorized();
        }

        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            return Unauthorized("Logged out");
        }
    }
}