//using Contracts;
//using Entities.Models;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Presentation.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class StatusVehicleController : ControllerBase
//    {
//        private IRepositoryWrapper _repository;
//        public StatusVehicleController(IRepositoryWrapper repository)
//        {
//            _repository = repository;
//        }
    
//        // GET: api/<StatusVehicleController>
//        [HttpGet]
//        public IEnumerable<StatusVehicle> GetStatus()
//        {
//            return _repository.StatusVehicle.GetAll(false);
//        }

//        // GET api/<StatusVehicleController>/5
//        [HttpGet("{id}")]
//        public StatusVehicle Get(int id)
//        {
//            return _repository.StatusVehicle.GetById(id, false);
//        }

//        // POST api/<StatusVehicleController>
//        [HttpPost]
//        public string Store([FromBody] StatusVehicle status)
//        {
//            _repository.StatusVehicle.Create(status);
//            _repository.Save();

//            return "Created SUccessfully";
//        }

//        // PUT api/<StatusVehicleController>/5
//        [HttpPut("{id}")]
//        public StatusVehicle Put(int id, [FromBody] StatusVehicle status)
//        {
//            if (ModelState.IsValid)
//            {
//                _repository.StatusVehicle.Update(status);
//                _repository.Save();
//            }

//            return status;
//        }

//        // DELETE api/<StatusVehicleController>/5
//        [HttpDelete("{id}")]
//        public string Delete(int id, StatusVehicle status)
//        {
//            _repository.StatusVehicle.Delete(status);
//            _repository.Save();

//            return "Deleted Successfully";
//        }
//    }
//}
