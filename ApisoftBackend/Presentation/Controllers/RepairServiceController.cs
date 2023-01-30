using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairServiceController : ControllerBase
    {
        private IServiceManager _service;
        public RepairServiceController(IServiceManager service)
        {
            _service = service;
        }

        // GET: api/<RepairServiceController>
        [HttpGet]
        public async Task <IActionResult>Get()
        {
            return Ok(await _service.RepairServiceService.GetRepairServiceDTO(false));
        }

        // GET api/<RepairServiceController>/5
        [HttpGet("{id}")]
        public async Task <IActionResult> GetById(int id)
        {
            return Ok(await _service.RepairServiceService.GetByIdDTO(id,trackChanges:false));
        }

        // POST api/<RepairServiceController>
        [HttpPost]
        public async Task <IActionResult> Create (RepairService repairService)
        {
            _service.RepairServiceService.CreateRepairService(repairService);
            await _service.Save();
            return Ok("Creado Correctamente");
        }

        // PUT api/<RepairServiceController>/5
        [HttpPut("{id}")]
        public async Task <RepairService> Put(int id, [FromBody] RepairService repairservice)
        {
            if (ModelState.IsValid)
            {
                _service.RepairServiceService.UpdateRepairService(repairservice);
                await _service.Save();
            }

            return repairservice;
        }

        // DELETE api/<RepairServiceController>/5
        [HttpDelete("{id}")]
        public async Task <IActionResult> Delete(int id, RepairService repairservice)
        {
            _service.RepairServiceService.DeleteRepairService(repairservice);
            await _service.Save();

            return Ok("Eliminado Correctamente");
        }
    }
}
