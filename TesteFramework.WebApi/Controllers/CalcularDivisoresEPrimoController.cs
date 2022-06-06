using Microsoft.AspNetCore.Mvc;
using TesteFramework.Core;

namespace TesteFramework.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumeroController : ControllerBase
    {

        public NumeroController() { }

        [HttpGet("/CalcularDivisoresEPrimos/{numero}")]
        public IActionResult CalcularDivisoresEPrimos(int numero)
        {
            var result = Functions.RetornarDivisoresEPrimos(numero);

            return Ok(result);
        }
    }
}
