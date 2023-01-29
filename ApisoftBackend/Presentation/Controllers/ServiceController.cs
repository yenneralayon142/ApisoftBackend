using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private IServiceManager _service;
        public ServiceController(IServiceManager service)
        {
            _service = service;
        }


        // GET: api/<ServiceController>
        [HttpGet]
        public async Task <IActionResult> Get()
        {
            return Ok(await _service.ServiceService.GetServicesDTO(false));
        }

        // GET api/<ServiceController>/5
        [HttpGet("{id}")]
        public async Task <IActionResult> GetById(int id)
        {
            return Ok(await _service.ServiceService.GetByIdDTO(id, trackChanges: false));
        }

        // POST api/<ServiceController>
        [HttpPost]
        public async Task <IActionResult> Create ( Service service)
        {
            _service.ServiceService.CreateService(service);
            await _service.Save();
            return Ok("Creado correctamente");
        }

        // PUT api/<ServiceController>/5
        [HttpPut("{id}")]
        public async Task <Service> Put(int id, [FromBody] Service service)
        {
            if (ModelState.IsValid)
            {
                _service.ServiceService.UpdateService(service);
                await _service.Save();
            }

            return service;
        }

        // DELETE api/<ServiceController>/5
        [HttpDelete("{id}")]
        public async Task <IActionResult> Delete(int id, Service service)
        {
            _service.ServiceService.DeleteService(service);
            await _service.Save();

            return Ok("Eliminado correctamente");
        }
    }
}
