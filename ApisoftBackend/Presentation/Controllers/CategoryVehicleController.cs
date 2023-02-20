using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryVehicleController : ControllerBase
    {
        private IServiceManager _service;
        public CategoryVehicleController(IServiceManager service)
        {
            _service = service;
        }

        // GET: api/<CategoryVehicleController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {            
            return Ok(await _service.CategoryVehicleService.GetAll(false));
        }

        // GET api/<CategoryVehicleController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {            
            return Ok(await _service.CategoryVehicleService.GetById(id, false));
        }

        // POST api/<CategoryVehicleController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CategoryVehicle category)
        {
            _service.CategoryVehicleService.CreateCategoryVehicle(category);
            await _service.Save();

            return Ok("Creado correctamente");
        }

        // PUT api/<CategoryVehicleController>/5
        [HttpPut("{id}")]
        public async Task<CategoryVehicle> Put(int id, [FromBody] CategoryVehicle category)
        {
            if (ModelState.IsValid)
            {
                _service.CategoryVehicleService.UpdateCategoryVehicle(category);
                await _service.Save();
            }

            return category;
        }

        // DELETE api/<CategoryVehicleController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, CategoryVehicle category)
        {
            _service.CategoryVehicleService.DeleteCategoryVehicle(category);
            await _service.Save();

            return Ok("Eliminado correctamente");
        }
    }
}
