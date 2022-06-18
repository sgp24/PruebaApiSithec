using Microsoft.AspNetCore.Mvc;
using PruebaAPISithec.Models;
namespace PruebaAPISithec.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(Calculo calculo)
        {
            if (ModelState.IsValid)
            {
                //Se valida el tipo de operacion
                if (calculo.TipoOperacion.ToLower() == "suma")
                {
                    return Ok(calculo.PrimerValor + calculo.SegundoValor);
                }
                else if (calculo.TipoOperacion.ToLower() == "resta")
                {
                    return Ok(calculo.PrimerValor - calculo.SegundoValor);
                }
                else if (calculo.TipoOperacion.ToLower() == "division")
                {
                    return Ok((float)calculo.PrimerValor / (float)calculo.SegundoValor);
                }
                else if (calculo.TipoOperacion.ToLower() == "multiplicacion")
                {
                    return Ok(calculo.PrimerValor * calculo.SegundoValor);
                }
                else
                {
                    return BadRequest("No se especifico una operacion correcta");
                }
            }
            return BadRequest(calculo);
        }
        [HttpGet("{TipoOperacion}/{PrimerValor}/{SegundoValor}")]
        public IActionResult Get(string TipoOperacion, int PrimerValor, int SegundoValor)
        {
            if (ModelState.IsValid)
            {
                //Se valida el tipo de operacion
                if (TipoOperacion.ToLower() == "suma")
                {
                    return Ok(PrimerValor + SegundoValor);
                }
                else if (TipoOperacion.ToLower() == "resta")
                {
                    return Ok(PrimerValor - SegundoValor);
                }
                else if (TipoOperacion.ToLower() == "division")
                {
                    return Ok((float)PrimerValor / (float)SegundoValor);
                }
                else if (TipoOperacion.ToLower() == "multiplicacion")
                {
                    return Ok(PrimerValor * SegundoValor);
                }
                else
                {
                    return BadRequest("No se especifico una operacion correcta");
                }
            }
            return BadRequest("Un valor asignado no es correcto");
        }
    }
}
