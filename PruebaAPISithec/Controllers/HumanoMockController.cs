using Microsoft.AspNetCore.Mvc;
using PruebaAPISithec.Models;
namespace PruebaAPISithec.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumanoMockController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            List<Humano> ListaHumanos = new List<Humano>();
            ListaHumanos.Add(new Humano{ Id = 1, Nombre = "sergio gonzalez", Sexo = "Masculino", Edad = "26", Estatura = "178", Peso = "90"});
            ListaHumanos.Add(new Humano { Id = 2, Nombre = "Ana Perez", Sexo = "Femenino", Edad = "34", Estatura = "165", Peso = "59" });
            ListaHumanos.Add(new Humano { Id = 3, Nombre = "Pedro Fernandez", Sexo = "Masculino", Edad = "19", Estatura = "170", Peso = "70" });
            ListaHumanos.Add(new Humano { Id = 4, Nombre = "Fernanda Martinez", Sexo = "Femenino", Edad = "24", Estatura = "160", Peso = "60" });
            return Ok(ListaHumanos);
        }
        
    }
}
