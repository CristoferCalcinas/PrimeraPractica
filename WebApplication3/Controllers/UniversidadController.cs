using Microsoft.AspNetCore.Mvc;
using WebApplication3.Contexto;
using WebApplication3.Modelo;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UniversidadController : ControllerBase
    {
        private readonly ILogger<UniversidadController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;

        public UniversidadController(ILogger<UniversidadController> logger, AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }

        [Route("")]
        [HttpGet]
        public IEnumerable<Universidad> GET()
        {
            return _aplicacionContexto.universidad.ToList();
        }

        [Route("")]
        [HttpPost]
        public IActionResult POST([FromBody] Universidad newUniversidad)
        {
            _aplicacionContexto.universidad.Add(newUniversidad);
            _aplicacionContexto.SaveChanges();
            return Ok(newUniversidad);
        }

        [Route("")]
        [HttpPut]
        public IActionResult PUT([FromBody] Universidad updateUniversidad)
        {
            _aplicacionContexto.universidad.Update(updateUniversidad);
            _aplicacionContexto.SaveChanges();
            return Ok(updateUniversidad);
        }

        [Route("")]
        [HttpDelete]
        public IActionResult DELETE(int idUniversidadDelete)
        {
            _aplicacionContexto.universidad.Remove(_aplicacionContexto.universidad.ToList().Where(x => x.idUniversidad == idUniversidadDelete).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(idUniversidadDelete);
        }
    }
}
