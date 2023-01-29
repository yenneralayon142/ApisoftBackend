//using Contracts;
//using Entities.Models;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Presentation.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ServiceController : ControllerBase
//    {
//        private IRepositoryWrapper _repository;
//        public ServiceController(IRepositoryWrapper repository)
//        {
//            _repository = repository;
//        }

//        // GET: api/<ServiceController>
//        [HttpGet]
//        public IEnumerable<Service> GetServices()
//        {
//            return _repository.Service.GetAll(false);
//        }

//        // GET api/<ServiceController>/5
//        [HttpGet("{id}")]
//        public Service Get(int id)
//        {
//            return _repository.Service.GetById(id, false);
//        }

//        // POST api/<ServiceController>
//        [HttpPost]
//        public string Store([FromBody] Service service)
//        {
//            _repository.Service.Create(service);
//            _repository.Save();

//            return "Created Successfully";
//        }

//        // PUT api/<ServiceController>/5
//        [HttpPut("{id}")]
//        public Service Put(int id, [FromBody] Service service)
//        {
//            if (ModelState.IsValid)
//            {
//                _repository.Service.Update(service);
//                _repository.Save();
//            }

//            return service;
//        }

//        // DELETE api/<ServiceController>/5
//        [HttpDelete("{id}")]
//        public string Delete(int id, Service service)
//        {
//            _repository.Service.Delete(service);
//            _repository.Save();

//            return "Deleted Successfully";
//        }
//    }
//}
