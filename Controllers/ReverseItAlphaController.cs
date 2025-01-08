using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCFiveToSevenEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCFiveToSevenEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItAlphaController : ControllerBase
    {
        private readonly ReverseItAlphaServices _reverseItAlphaServices;

        public ReverseItAlphaController(ReverseItAlphaServices reverseItAlphaServices)
        {
            _reverseItAlphaServices = reverseItAlphaServices;
        }

        [HttpGet]
        [Route("ReverseAlpha/{input}")]
        public string reverseAlpha(string input)
        {
            return _reverseItAlphaServices.reverseAlpha(input);
        }
    }
}