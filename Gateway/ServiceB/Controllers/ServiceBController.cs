﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ServiceB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceBController : ControllerBase
    {
        private readonly ILogger<ServiceBController> _logger;

        public ServiceBController(ILogger<ServiceBController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Message from Service B";
        }
    }
}
