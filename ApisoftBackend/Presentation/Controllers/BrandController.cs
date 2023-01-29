//using Contracts;
//using Entities.Models;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Presentation.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class BrandController : ControllerBase
//    {
//        private IRepositoryWrapper _repository;
//        public BrandController(IRepositoryWrapper repository)
//        {
//            _repository = repository;
//        }


//        // GET: api/<BrandController>
//        [HttpGet]
//        public IEnumerable<Brand> GetBrands()
//        {
//            return _repository.Brand.GetAll(false);
//        }

//        // GET api/<BrandController>/5
//        [HttpGet("{id}")]
//        public Brand Get(int id)
//        {
//            return _repository.Brand.GetById(id, false);
            
//        }

//        // POST api/<BrandController>
//        [HttpPost]
//        public string Store([FromBody] Brand brand)
//        {
//            _repository.Brand.Create(brand);
//            _repository.Save();

//            return "Created Successfully";
//        }

//        // PUT api/<BrandController>/5
//        [HttpPut("{id}")]
//        public Brand Put(int id, [FromBody] Brand brand)
//        {
//            if (ModelState.IsValid)
//            {
//                _repository.Brand.Update(brand);
//                _repository.Save();
//            }            

//            return brand;
//        }

//        // DELETE api/<BrandController>/5
//        [HttpDelete("{id}")]
//        public string Delete(int id, Brand brand)
//        {
//            _repository.Brand.Delete(brand);

//            return "Deleted successfully";
//        }
//    }
//}
