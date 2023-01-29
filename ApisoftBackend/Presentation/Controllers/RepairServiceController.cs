//using Contracts;
//using Entities.Models;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Presentation.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class RepairServiceController : ControllerBase
//    {
//        private IRepositoryWrapper _repository;
//        public RepairServiceController(IRepositoryWrapper repository)
//        {
//            _repository = repository;
//        }

//        // GET: api/<RepairServiceController>
//        [HttpGet]
//        public IEnumerable<RepairService> GetRepairsServices()
//        {
//            return _repository.RepairService.GetAll(false);
//        }

//        // GET api/<RepairServiceController>/5
//        [HttpGet("{id}")]
//        public RepairService Get(int id)
//        {
//            return _repository.RepairService.GetById(id, false);
//        }

//        // POST api/<RepairServiceController>
//        [HttpPost]
//        public string Post([FromBody] RepairService repairservice)
//        {
//            _repository.RepairService.Create(repairservice);
//            _repository.Save();

//            return "Created Successfully";
//        }

//        // PUT api/<RepairServiceController>/5
//        [HttpPut("{id}")]
//        public RepairService Put(int id, [FromBody] RepairService repairservice)
//        {
//            if (ModelState.IsValid)
//            {
//                _repository.RepairService.Update(repairservice);
//                _repository.Save();
//            }

//            return repairservice;
//        }

//        // DELETE api/<RepairServiceController>/5
//        [HttpDelete("{id}")]
//        public string Delete(int id, RepairService repairservice)
//        {
//            _repository.RepairService.Delete(repairservice);
//            _repository.Save();

//            return "Deleted Succesfully";
//        }
//    }
//}
