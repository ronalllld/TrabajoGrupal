using empresa1.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace titulo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TituloController : ControllerBase
    {
        private readonly ILogger<TituloController> _logger;
        private readonly Aplication_Context _aplicacionContexto;
        public TituloController(
            ILogger<TituloController> logger,
            Aplication_Context aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Titulo titulo)
        {
            _aplicacionContexto.titulo.Add(titulo);
            _aplicacionContexto.SaveChanges();
            return Ok(titulo);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<Titulo> Get()
        {
            return _aplicacionContexto.titulo.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Titulo titulo)
        {
            _aplicacionContexto.titulo.Update(titulo);
            _aplicacionContexto.SaveChanges();
            return Ok(titulo);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int tituloID)
        {
            _aplicacionContexto.titulo.Remove(
                _aplicacionContexto.titulo.ToList()
                .Where(x => x.idtitulo == tituloID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(tituloID);
        }
    }
}
