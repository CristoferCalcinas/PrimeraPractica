using Microsoft.AspNetCore.Mvc;
using WebApplication3.Contexto;
using WebApplication3.Modelo;

namespace WebApplication3.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DocenteController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        
        public DocenteController(ILogger<DocenteController> logger, AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Docente> GET()
        {
            return _aplicacionContexto.docente.ToList();
        }

        [HttpPost]
        [Route("")]
        public IActionResult POST([FromBody] Docente newDocente)
        {
            _aplicacionContexto.docente.Add(newDocente);
            _aplicacionContexto.SaveChanges();
            return Ok(newDocente);
        }

        [HttpPut]
        [Route("")]
        public IActionResult PUT([FromBody] Docente docenteUpdate)
        {
            _aplicacionContexto.docente.Update(docenteUpdate);
            _aplicacionContexto.SaveChanges();
            return Ok(docenteUpdate);
        }

        [HttpDelete]
        [Route("")]
        public IActionResult DELETE(int idDocenteDelete)
        {
            _aplicacionContexto.docente.Remove(_aplicacionContexto.docente.ToList().Where(x=>x.idDocente == idDocenteDelete).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(idDocenteDelete);
        }
    }
}
