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
        [Route("OddOrEven/{num}")]
        public string oddOrEven(int num)
        {
            return _oddOrEvenServices.oddOrEven(num);
        }
    }
}