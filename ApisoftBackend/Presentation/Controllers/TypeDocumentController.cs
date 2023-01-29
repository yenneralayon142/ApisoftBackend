using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeDocumentController : ControllerBase
    {
        private IServiceManager _service;
        public TypeDocumentController(IServiceManager service)
        {
            _service= service;
        }

        // GET: api/<TypeDocumentController>
        [HttpGet]
        public async Task < IActionResult> Get()
        {
            return  Ok(await _service.TypeDocumentService.GetTypeDocumentsDTOs(false));
        }

        // GET api/<TypeDocumentController>/5
        [HttpGet("{id}")]
        public async Task <IActionResult> GetById(string id)
        {
            var type = await _service.TypeDocumentService.GetByIdDto(id, trackChanges:false);
            return Ok(type);
        }

        // POST api/<TypeDocumentController>

        [HttpPost]
        public async Task <IActionResult> Create( TypeDocument typedocument)
        {
            _service.TypeDocumentService.CreateTypeDocument(typedocument);
            await _service.Save();
            return Ok("Creado correctamente"); //Revisar retorno
        }


        // PUT api/<TypeDocumentController>/5

        [HttpPut("{id}")]
        public async Task <TypeDocument> Put(string id, [FromBody] TypeDocument typedocument)
        {
            if (ModelState.IsValid)
            {

                _service.TypeDocumentService.UpdateTypeDocument(typedocument);
               
                await _service.Save();
            }

            return typedocument;
        }

        // DELETE api/<TypeDocumentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id, TypeDocument typedocument)
        {
            _service.TypeDocumentService.DeleteTypeDocument(typedocument);
            await _service.Save();

            return Ok("Eliminado correctamente");
        }
    }
}
