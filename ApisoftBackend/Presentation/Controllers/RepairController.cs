using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepairController : ControllerBase
    {
        private IServiceManager _service;
        public RepairController(IServiceManager service)
        {
            _service = service;
        }

        // GET: api/<RepairController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.RepairService.GetRepairsDTO(false));
        }

        // GET api/<RepairController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.RepairService.GetByIdDTO(id,trackChanges: false));
        }

        // POST api/<RepairController>
        [HttpPost]
        public async Task <IActionResult> Create (Repair repair)
        {
            _service.RepairService.CreateRepair(repair);
            await _service.Save();
            return Ok("Creado Correctamente");
          
        }

        // PUT api/<RepairController>/5
        [HttpPut("{id}")]
        public async Task<Repair>Put(int id, [FromBody] Repair repair) 
        {
            if (ModelState.IsValid)
            {
                _service.RepairService.UpdateRepair(repair);
                await _service.Save();
            }

            return repair;
        }

        // DELETE api/<RepairController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, Repair repair)
        {
            _service.RepairService.DeleteRepair(repair);
            await _service.Save();

            return Ok("Eliminado correctamente");
        }
    }
}
