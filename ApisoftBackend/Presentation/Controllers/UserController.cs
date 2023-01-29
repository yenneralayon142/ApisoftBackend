//using System.Collections;
//using Contracts;
//using Entities.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace Presentation.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UserController : ControllerBase
//    {
//        private IRepositoryWrapper _repository;

//        public UserController(IRepositoryWrapper repository)
//        {
//            _repository = repository;
//        }

//        // GET: api/<UserController>
//        [HttpGet]
//        public IEnumerable<User> GetUser()
//        {
//            return _repository.User.GetAll(false);
//        }

//        //GET: api/<UserController>
//        [HttpGet("{id}")]
//        public User GetById(int id)
//        {
//            return _repository.User.GetById(id, false);
//        }

//        //POST api/<UserController>
//        [HttpPost]
//        public string Store([FromBody] User user)
//        {
//            _repository.User.Create(user);
//            _repository.Save();

//            return "Created Successfully";
//        }

//        //PUT api/<UserController>
//        [HttpPut("{id}")]
//        public User Put(string id, [FromBody] User user)
//        {
//            if (ModelState.IsValid)
//            {
//                _repository.User.Update(user);
//                _repository.Save();
//            }

//            return user;
//        }

//        //DELETE api/<UserController>
//        [HttpDelete("{id}")]
//        public string Delete(string id, User user)
//        {
//            _repository.User.Delete(user);
//            _repository.Save();

//            return "Deleted Successfully";
//        }


//    }
//}
