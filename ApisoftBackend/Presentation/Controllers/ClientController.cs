//using Contracts;
//using Entities.Models;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Presentation.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ClientController : ControllerBase
//    {
//        private IRepositoryWrapper _repository;
//        public ClientController(IRepositoryWrapper repository)
//        {
//            _repository = repository;
//        }


//        // GET: api/<ClientController>
//        [HttpGet]
//        public IEnumerable<Client> GetClients()
//        {
//            return _repository.Client.GetAll(false);
//        }

//        // GET api/<ClientController>/5
//        [HttpGet("{id}")]
//        public Client GetClientById(int id)
//        {
//            return _repository.Client.GetById(id, false);
//        }

//        // POST api/<ClientController>
//        [HttpPost]
//        public string StoreClients([FromBody] Client client)
//        {
//            _repository.Client.Create(client);
//            _repository.Save();

//            return "Created Successfully...";
//        }

//        // PUT api/<ClientController>/5
//        [HttpPut("{id}")]
//        public Client Put(int id, [FromBody] Client client)
//        {
//            if (ModelState.IsValid)
//            {
//                _repository.Client.Update(client);
//                _repository.Save();                
//            }

//            return client;

//        }

//        // DELETE api/<ClientController>/5
//        [HttpDelete("{id}")]
//        public string Delete(int id, Client client)
//        {
//            _repository.Client.Delete(client);
//            _repository.Save();

//            return "Delete Successfully";
//        }
//    }
//}
