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
    public class ReverseItNumController : ControllerBase
    {
        private readonly ReverseItNumServices _reverseItNumServices;

        public ReverseItNumController(ReverseItNumServices reverseItNumServices)
        {
            _reverseItNumServices = reverseItNumServices;
        }

        [HttpGet]
        [Route("ReverseNum/")]
        public string ReverseNum(string input)
        {
            return _reverseItNumServices.ReverseNum(input);
        }
    }
}