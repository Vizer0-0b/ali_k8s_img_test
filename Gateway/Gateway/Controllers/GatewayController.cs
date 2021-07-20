using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GatewayController : ControllerBase
    {
        private static readonly string[] Services = new[]
        {
            "Service1", "Service2", "Service3", "Service4", "Service5", "Service6", "Service7", "Service8", "Service9", "Service10"
        };

        private readonly ILogger<GatewayController> _logger;

        public GatewayController(ILogger<GatewayController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<dynamic> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new 
            {
                Date = DateTime.Now.AddDays(index),
                ServiceReturn = rng.Next(-20, 55),
                Service = Services[rng.Next(Services.Length)]
            })
            .ToArray();
        }
    }
}
