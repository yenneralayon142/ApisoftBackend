using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private IServiceManager _service;
        public VehicleController(IServiceManager service)
        {
            _service = service;
        }

        // GET: api/<VehicleController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.VehicleService.GetAll(false));
        }

        // GET api/<VehicleController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _service.VehicleService.GetById(id, false));
        }

        // POST api/<VehicleController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Vehicle vehicle)
        {
            _service.VehicleService.CreateVehicle(vehicle);
            await _service.Save();

            return Ok("Created Successfully");
        }

        // PUT api/<VehicleController>/5
        [HttpPut("{id}")]
        public async Task<Vehicle> Put(string id, [FromBody] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _service.VehicleService.UpdateVehicle(vehicle);
                await _service.Save();
            }

            return vehicle;
        }

        // DELETE api/<VehicleController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id, Vehicle vehicle)
        {
            _service.VehicleService.DeleteVehicle(vehicle);
            await _service.Save();

            return Ok("Deleted Succesfully");
        }
    }
}
