using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;

namespace Calculator_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("sum")]
        public IActionResult GetSum([FromQuery] int a, [FromQuery] int b)
                {
                    int result = a + b; // o: var result = a + b;
                    return Ok(new { a, b, result });
                }   
}
}
