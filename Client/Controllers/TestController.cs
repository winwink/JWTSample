using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet,Route("TestAuth")]
        [Authorize]
        public async Task<string> Get()
        {
            return DateTime.Now.ToShortTimeString();
        }

        [HttpGet,Route("TestNoAuth")]
        public async Task<string> GetNoAuth()
        {
            return "NoAuth" + DateTime.Now.ToShortTimeString();
        }
    }
}