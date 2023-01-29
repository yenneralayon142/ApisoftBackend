using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private IServiceManager _service;
        public ClientController(IServiceManager service)
        {
            _service = service;
        }


        // GET: api/<ClientController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.ClientService.GetAll(false));
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.ClientService.GetById(id, false));
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Client client)
        {
            _service.ClientService.CreateClient(client);
            await _service.Save();

            return Ok("Created Successfully");
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task<Client> Put(int id, [FromBody] Client client)
        {
            if (ModelState.IsValid)
            {
                _service.ClientService.UpdateClient(client);
                await _service.Save();
            }

            return client;

        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id, Client client)
        {
            _service.ClientService.DeleteClient(client);
            await _service.Save();

            return Ok("Delete Successfully");
        }
    }
}
