using empresa1.Models;
using Empresa1.Context;
using Microsoft.AspNetCore.Mvc;

namespace empresa1.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class SalarioController : ControllerBase
    {

        private readonly ILogger<SalarioController> _logger;

        private readonly Empresa1.Context.Aplication_Context _aplication_context;
        public SalarioController(
            ILogger<SalarioController> logger,


            Aplication_Context aplication_context)
        {
            _logger = logger;


            _aplication_context = aplication_context;

        }
        /*Crear*/
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Salario salario)
        {
            _aplication_context.salario.Add(salario);

            _aplication_context.SaveChanges();
            return Ok(salario);

        }
        /*Obtener lista*/
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplication_context.salario.ToList());

        }
        /*Modificar*/
        [Route("{id}")]

        [HttpPut]
        public IActionResult Put(
            [FromBody] Salario salario)
        {
            _aplication_context.salario.Update(salario);
            _aplication_context.SaveChanges();

            return Ok(salario);
        }
        /*Eliminar*/
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int id_salario)
        {
            _aplication_context.salario.Remove(
                _aplication_context.salario.ToList()
                .Where(x => x.idsalario == id_salario)

                .FirstOrDefault());
            _aplication_context.SaveChanges();

            return Ok(id_salario);
        }
    }
}
