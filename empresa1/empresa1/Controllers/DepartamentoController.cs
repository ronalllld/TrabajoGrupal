using empresa1.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace departamento.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartamentoController : ControllerBase
    {
        private readonly ILogger<DepartamentoController> _logger;
        private readonly Aplication_Context _aplicacionContexto;
        public DepartamentoController(
            ILogger<DepartamentoController> logger,
            Aplication_Context aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Departamento departamento)
        {
            _aplicacionContexto.departamento.Add(departamento);
            _aplicacionContexto.SaveChanges();
            return Ok(departamento);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]

        public IEnumerable<Departamento> Get()
        {
            return _aplicacionContexto.departamento.ToList();
        }

        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Departamento departamento)
        {
            _aplicacionContexto.departamento.Update(departamento);
            _aplicacionContexto.SaveChanges();
            return Ok(departamento);

        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int departamentoID)
        {
            _aplicacionContexto.departamento.Remove(
                _aplicacionContexto.departamento.ToList()
                .Where(x => x.iddepartamento == departamentoID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(departamentoID);
        }
    }
}
