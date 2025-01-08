using MCFiveToSevenEndpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace MCFiveToSevenEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;

        public OddOrEvenController(OddOrEvenServices oddOrEvenServices)
        {
            _oddOrEvenServices = oddOrEvenServices;
        }

        [HttpGet]
        [Route("OddOrEven/{input}")]
        public string oddOrEven(string input)
        {
            return _oddOrEvenServices.oddOrEven(input);
        }
    }
}