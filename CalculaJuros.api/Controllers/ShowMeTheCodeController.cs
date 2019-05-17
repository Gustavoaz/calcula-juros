﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJuros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet()]
        public ActionResult<string> Get()
        {            
            return Ok("https://github.com/Gustavoaz/calcula-juros");
        }
    }
}