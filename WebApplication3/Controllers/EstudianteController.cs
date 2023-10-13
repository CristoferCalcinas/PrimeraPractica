using Microsoft.AspNetCore.Mvc;
using WebApplication3.Contexto;
using WebApplication3.Modelo;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudianteController : ControllerBase
    {
        private readonly ILogger<EstudianteController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;

        public EstudianteController(ILogger<EstudianteController> logger, AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
            [Route("")]
            [HttpGet]
        public IEnumerable<Estudiante> GET()
        {
            return _aplicacionContexto.estudiante.ToList();
        }

        [Route("")]
        [HttpPost]
        public IActionResult POST([FromBody] Estudiante newEstudiante)
        {
            _aplicacionContexto.estudiante.Add(newEstudiante);
            _aplicacionContexto.SaveChanges();
            return Ok(newEstudiante);
        }

        [Route("")]
        [HttpPut]
        public IActionResult PUT([FromBody] Estudiante updateEstudiante)
        {
            _aplicacionContexto.estudiante.Update(updateEstudiante);
            _aplicacionContexto.SaveChanges();
            return Ok(updateEstudiante);
        }

        [Route("")]
        [HttpDelete]
        public IActionResult DELETE(int idEstudianteDelete)
        {
            _aplicacionContexto.estudiante.Remove(_aplicacionContexto.estudiante.ToList().Where(x => x.idEstudiante == idEstudianteDelete).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(idEstudianteDelete);
        }
    }
}
