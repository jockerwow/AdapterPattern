using Microsoft.AspNetCore.Mvc;
using PayrollSystem.Core;

namespace PayrollSystem.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PayrollCalculatorController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public ActionResult<decimal> Calculate(Employee employee)
        {
            var calculator = new PayrollCalculator();
            return Ok(calculator.Calculate(employee));

        }
    }
}
