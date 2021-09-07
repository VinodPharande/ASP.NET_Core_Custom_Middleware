using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Custom_Middleware.Controllers
{
    //[Route("api/[controller]")]
    [Route("healthcheck/api/v1/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet()]
        public string Info()
        {
            return "ASP.NET Core Using Custom Middleware PoC " + typeof(HealthCheckController).Assembly.GetName().Version;
        }
    }
}
