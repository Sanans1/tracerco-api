using Microsoft.AspNetCore.Mvc;
using tracerco_api.Interfaces;

namespace tracerco_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly ISimpleCalculator _simpleCalculator;

        public CalculatorController(ILogger<CalculatorController> logger, ISimpleCalculator simpleCalculator)
        {
            _logger = logger;
            _simpleCalculator = simpleCalculator;
        }

        [HttpPost]
        [Route("Add")]
        public int Add(int start, int amount)
        {
            return _simpleCalculator.Add(start, amount);
        }

        [HttpPost]
        [Route("Divide")]
        public int Divide(int start, int by)
        {
            return _simpleCalculator.Divide(start, by);
        }

        [HttpPost]
        [Route("Multiply")]
        public int Multiply(int start, int by)
        {
            return _simpleCalculator.Multiply(start, by);
        }

        [HttpPost]
        [Route("Subtract")]
        public int Subtract(int start, int amount)
        {
            return _simpleCalculator.Subtract(start, amount);
        }
    }
}
