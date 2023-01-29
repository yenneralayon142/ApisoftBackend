//using Contracts;
//using Entities.Models;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Presentation.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CategoryVehicleController : ControllerBase
//    {
//        private IRepositoryWrapper _repository;
//        public CategoryVehicleController(IRepositoryWrapper repository)
//        {
//            _repository = repository;
//        }

//        // GET: api/<CategoryVehicleController>
//        [HttpGet]
//        public IEnumerable<CategoryVehicle> GetCategories()
//        {
//            return _repository.CategoryVehicle.GetAll(false);
//        }

//        // GET api/<CategoryVehicleController>/5
//        [HttpGet("{id}")]
//        public CategoryVehicle Get(int id)
//        {
//            return _repository.CategoryVehicle.GetById(id, false);
//        }

//        // POST api/<CategoryVehicleController>
//        [HttpPost]
//        public string Store([FromBody] CategoryVehicle category)
//        {
//            _repository.CategoryVehicle.Create(category);
//            _repository.Save();

//            return "Created Successfully";
//        }

//        // PUT api/<CategoryVehicleController>/5
//        [HttpPut("{id}")]
//        public CategoryVehicle Put(int id, [FromBody] CategoryVehicle category)
//        {
//            if (ModelState.IsValid)
//            {
//                _repository.CategoryVehicle.Update(category);
//                _repository.Save();
//            }

//            return category;
//        }

//        // DELETE api/<CategoryVehicleController>/5
//        [HttpDelete("{id}")]
//        public string Delete(int id, CategoryVehicle category)
//        {
//            _repository.CategoryVehicle.Delete(category);
//            _repository.Save();

//            return "Deleted Successfully";
//        }
//    }
//}
