using Microsoft.AspNetCore.Mvc;
using PruebaAPISithec.Models;
namespace PruebaAPISithec.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumanoController : ControllerBase
    {
        private readonly HumanDataContext context;
        public HumanoController(HumanDataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var humanosRegistrados = from it in context.Humano orderby it.Id select it;
            return Ok(humanosRegistrados);
        }
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            var resultado = context.Humano.Find(id);
            if(resultado != null)
                return Ok(resultado);
            else
                return BadRequest("No se encontro ese registro.");
        }
        [HttpPost]
        public IActionResult Post(Humano humano)
        {
            if (ModelState.IsValid)
            {
                context.Add(humano);
                context.SaveChanges();
                return Ok(humano);
            }
            else
                return BadRequest("Fallo el insertado.");            
        }
        [HttpPut("id")]
        public IActionResult Put(int id, Humano humano)
        {
            if(ModelState.IsValid)
            {
                var resultado = context.Humano.First(x => x.Id == id);
                resultado.Nombre = humano.Nombre;
                resultado.Sexo = humano.Sexo;
                resultado.Edad = humano.Edad;
                resultado.Estatura = humano.Estatura;
                resultado.Peso = humano.Peso;
                context.SaveChanges();
                return Ok(humano);
            }
            else
            {
                return BadRequest("No se envio el formato correcto");
            }                       
        }
        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            var resultado = context.Humano.Find(id);
            if (resultado != null)
            {
                context.Remove(context.Humano.Single(x => x.Id == id));
                context.SaveChanges();
                return Ok("Se elimino el elemento con el indice: " + id + " exitosamente!");
            }
            return BadRequest("No existe el elemento que quiere eliminar");            
        }
    }
}
