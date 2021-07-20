using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ServiceA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceAController : ControllerBase
    {
        private readonly ILogger<ServiceAController> _logger;

        public ServiceAController(ILogger<ServiceAController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Message from Service A";
        }
    }
}
