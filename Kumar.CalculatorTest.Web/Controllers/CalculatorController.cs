using Kumar.CalculatorTest.Web.Model;
using Kumar.CalculatorTest.Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Kumar.CalculatorTest.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : Controller
    {
        private readonly ICalculatorRepository _calculatorRepository;
        public CalculatorController(ICalculatorRepository calculatorRepository)
        {
            _calculatorRepository = calculatorRepository;
        }

        [HttpPost("add")]
        public ActionResult<int> Add([FromBody] CalculationRequestModel model)
        {
            int result = _calculatorRepository.Add(model.Number1, model.Number2);
            if (result < 0) return new BadRequestObjectResult("Addition resulted in negative number.");
            return Ok(result);
        }

        [HttpPost("subtract")]
        public ActionResult<int> Subtract([FromBody] CalculationRequestModel model)
        {

            int result = _calculatorRepository.Subtract(model.Number1, model.Number2);
            return Ok(result);
        }

    }
}
