//using Contracts;
//using Entities.Models;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Presentation.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class VehicleController : ControllerBase
//    {
//        private IRepositoryWrapper _repository;
//        public VehicleController(IRepositoryWrapper repository)
//        {
//            _repository = repository;
//        }
            
//        // GET: api/<VehicleController>
//        [HttpGet]
//        public IEnumerable<Vehicle> Get()
//        {
//            return _repository.Vehicle.GetAll(false);
//        }

//        // GET api/<VehicleController>/5
//        [HttpGet("{id}")]
//        public Vehicle Get(string id)
//        {
//            return _repository.Vehicle.GetById(id, false);
//        }

//        // POST api/<VehicleController>
//        [HttpPost]
//        public string Store([FromBody] Vehicle vehicle)
//        {
//            _repository.Vehicle.Create(vehicle);
//            _repository.Save();

//            return "Created Successfully";
//        }

//        // PUT api/<VehicleController>/5
//        [HttpPut("{id}")]
//        public Vehicle Put(string id, [FromBody] Vehicle vehicle)
//        {
//            if (ModelState.IsValid)
//            {
//                _repository.Vehicle.Update(vehicle);
//                _repository.Save();
//            }

//            return vehicle; 
//        }

//        // DELETE api/<VehicleController>/5
//        [HttpDelete("{id}")]
//        public string Delete(string id, Vehicle vehicle)
//        {
//            _repository.Vehicle.Delete(vehicle);
//            _repository.Save();

//            return "Deleted Succesfully";
//        }
//    }
//}
