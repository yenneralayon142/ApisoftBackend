using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusVehicleController : ControllerBase
    {
        private IServiceManager _service;
        public StatusVehicleController(IServiceManager service)
        {
            _service = service;
        }

        // GET: api/<StatusVehicleController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.StatusVehicleService.GetVehiclesAsync(false));
        }

        // GET api/<StatusVehicleController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {            
            return Ok(await _service.StatusVehicleService.GetByIdAsync(id, false));
        }

        // POST api/<StatusVehicleController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] StatusVehicle status)
        {
            _service.StatusVehicleService.CreateStatusVehicle(status);
            await _service.Save();

            return Ok("Created SUccessfully");
        }

        // PUT api/<StatusVehicleController>/5
        [HttpPut("{id}")]
        public async Task<StatusVehicle> Put(int id, [FromBody] StatusVehicle status)
        {
            if (ModelState.IsValid)
            {
                _service.StatusVehicleService.UpdateStatusVehicle(status);
                await _service.Save();
            }

            return status;
        }

        // DELETE api/<StatusVehicleController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, StatusVehicle status)
        {
            _service.StatusVehicleService.DeleteStatusVehicle(status);
            await _service.Save();

            return Ok("Deleted Successfully");
        }
    }
}
