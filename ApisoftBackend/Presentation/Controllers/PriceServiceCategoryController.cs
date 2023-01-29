using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceServiceCategoryController : ControllerBase
    {
        private IServiceManager _service;
        public PriceServiceCategoryController(IServiceManager service)
        {
            _service = service;
        }

        //GET: api/<ClientController>
        [HttpGet]
        public async Task <IActionResult> Get()
        {
            return Ok(await _service.PriceServiceCategoryService.GetPriceServiceCategoryDTO(false));
        }
        //GET: api/<ClientController>
        [HttpGet("{id}")]
        public async Task <IActionResult> GetById(int id)
        {
            return Ok(await _service.PriceServiceCategoryService.GetByIdDTO(id,trackChanges:false));
        }

        //POST: api/<ClientController>
        [HttpPost]
        public async Task <IActionResult> Create(PriceServiceCategory priceServiceCategory)
        {
            _service.PriceServiceCategoryService.CreatePriceServiceCategory(priceServiceCategory);
            await _service.Save();
            return Ok("Creado correctamente");
        }

        //PUT: api/<ClientController>
        [HttpPut("{id}")]
        public async Task < PriceServiceCategory> Put(int id, [FromBody] PriceServiceCategory priceservicecategory)
        {
            if (ModelState.IsValid)
            {
                _service.PriceServiceCategoryService.UpdatePriceServiceCategory(priceservicecategory);
                await _service.Save();
            }

            return priceservicecategory;
        }

        //DELETE: api/<ClientController>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete (int id, PriceServiceCategory priceServiceCategory)
        {
            _service.PriceServiceCategoryService.DeletePriceServiceCategory(priceServiceCategory);
            await _service.Save();

            return Ok("Eliminado correctamente");
        }

    }
}
