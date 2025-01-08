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
        [Route("ReverseNum/{input}")]
        public string reverseNum(string input)
        {
            return _reverseItNumServices.reverseNum(input);
        }
    }
}