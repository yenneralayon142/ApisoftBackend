//using Contracts;
//using Entities.Models;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Presentation.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class RepairController : ControllerBase
//    {
//        private IRepositoryWrapper _repository;
//        public RepairController(IRepositoryWrapper repository)
//        {
//            _repository = repository;
//        }

//        // GET: api/<RepairController>
//        [HttpGet]
//        public IEnumerable<Repair> GetRepairs()
//        {
//            return _repository.Repair.GetAll(false);
//        }

//        // GET api/<RepairController>/5
//        [HttpGet("{id}")]
//        public Repair Get(int id)
//        {
//            return _repository.Repair.GetById(id, false);
//        }

//        // POST api/<RepairController>
//        [HttpPost]
//        public string Store([FromBody] Repair repair)
//        {
//            _repository.Repair.Create(repair);
//            _repository.Save();

//            return "Created Successfully";
//        }

//        // PUT api/<RepairController>/5
//        [HttpPut("{id}")]
//        public Repair Put(int id, [FromBody] Repair repair)
//        {
//            if (ModelState.IsValid)
//            {
//                _repository.Repair.Update(repair);
//                _repository.Save();
//            }

//            return repair;
//        }

//        // DELETE api/<RepairController>/5
//        [HttpDelete("{id}")]
//        public string Delete(int id, Repair repair)
//        {
//            _repository.Repair.Delete(repair);
//            _repository.Save();

//            return "Deleted Successfully";
//        }
//    }
//}
