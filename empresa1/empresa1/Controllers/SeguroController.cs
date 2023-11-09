using empresa1.Models;
using Empresa1.Context;
using Microsoft.AspNetCore.Mvc;

namespace empresa1.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class SeguroController : ControllerBase
    {

        private readonly ILogger<SeguroController> _logger;

        private readonly Empresa1.Context.Aplication_Context _aplication_context;
        public SeguroController(
            ILogger<SeguroController> logger,


            Aplication_Context aplication_context)
        {
            _logger = logger;


            _aplication_context = aplication_context;

        }
        /*Crear*/
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Seguro seguro)
        {
            _aplication_context.seguro.Add(seguro);

            _aplication_context.SaveChanges();
            return Ok(seguro);

        }
        /*Obtener lista*/
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplication_context.seguro.ToList());

        }
        /*Modificar*/
        [Route("{id}")]

        [HttpPut]
        public IActionResult Put(
            [FromBody] Seguro seguro)
        {
            _aplication_context.seguro.Update(seguro);
            _aplication_context.SaveChanges();

            return Ok(seguro);
        }
        /*Eliminar*/
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int id_seguro)
        {
            _aplication_context.seguro.Remove(
                _aplication_context.seguro.ToList()
                .Where(x => x.idseguro == id_seguro)

                .FirstOrDefault());
            _aplication_context.SaveChanges();

            return Ok(id_seguro);
        }
    }
}
