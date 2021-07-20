using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ServiceC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceCController : ControllerBase
    {
        private readonly ILogger<ServiceCController> _logger;

        public ServiceCController(ILogger<ServiceCController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Message from Service C";
        }
    }
}
