using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private IServiceManager _service;
        public BrandController(IServiceManager service)
        {
            _service = service;
        }


        // GET: api/<BrandController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.BrandService.GetAll(false));
        }

        // GET api/<BrandController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.BrandService.GetById(id, false));
        }

        // POST api/<BrandController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Brand brand)
        {
            _service.BrandService.CreateBrand(brand);
            await _service.Save();

            return Ok("Creado correctamente");
        }

        // PUT api/<BrandController>/5
        [HttpPut("{id}")]
        public async Task<Brand> Put(int id, [FromBody] Brand brand)
        {
            if (ModelState.IsValid)
            {
                _service.BrandService.UpdateBrand(brand);
                await _service.Save();
            }

            return brand;
        }

        // DELETE api/<BrandController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, Brand brand)
        {
            _service.BrandService.DeleteBrand(brand);
            await _service.Save();

            return Ok("Eliminado correctamente");
        }
    }
}
