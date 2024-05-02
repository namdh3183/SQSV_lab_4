using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SQSV_lab_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxCalculateController : ControllerBase
    {
        /// <summary>
        /// Calculates the tax based on income and number of dependents.
        /// </summary>
        /// <param name="income">The income.</param>
        /// <param name="dependentQty">The number of dependents.</param>
        /// <returns>The calculated tax.</returns>
        [HttpPost]
        public IActionResult CalculateTax(float income, int dependentQty)
        {
            float tax = TaxCalculate.Calculate(income, dependentQty);
            return Ok(tax);
        }
    }

}
