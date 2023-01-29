using System.Collections;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceContracts;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IServiceManager _service;

        public UserController(IServiceManager service)
        {
            _service = service;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.UserService.GetAll(false));
        }

        //GET: api/<UserController>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _service.UserService.GetById(id, false));
        }

        //POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            _service.UserService.CreateUser(user);
            await _service.Save();

            return Ok("Created Successfully");
        }

        //PUT api/<UserController>
        [HttpPut("{id}")]
        public async Task<User> Put(string id, [FromBody] User user)
        {
            if (ModelState.IsValid)
            {
                _service.UserService.UpdateUser(user);
                await _service.Save();
            }

            return user;
        }

        //DELETE api/<UserController>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id, User user)
        {
            _service.UserService.DeleteUser(user);
            await _service.Save();

            return Ok("Deleted Successfully");
        }
    }
}
