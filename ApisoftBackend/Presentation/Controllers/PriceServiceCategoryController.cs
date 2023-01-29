//using Contracts;
//using Entities.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace Presentation.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class PriceServiceCategoryController : ControllerBase
//    {
//        private IRepositoryWrapper _repository;

//        public PriceServiceCategoryController(IRepositoryWrapper repository)
//        {
//            _repository = repository;
//        }

//        //GET: api/<ClientController>
//        [HttpGet]
//        public IEnumerable<PriceServiceCategory> GetPriceServiceCategory()
//        {
//            return _repository.PriceServiceCategory.GetAll(false);
//        }
//        //GET: api/<ClientController>
//        [HttpGet("{id}")]
//        public PriceServiceCategory GetById(int id)
//        {
//            return _repository.PriceServiceCategory.GetById(id, false);
//        }

//        //POST: api/<ClientController>
//        [HttpPost]
//        public string Store([FromBody] PriceServiceCategory priceservicecategory)
//        {
//            _repository.PriceServiceCategory.Create(priceservicecategory);
//            _repository.Save();

//            return "Created Successfully";
//        }

//        //PUT: api/<ClientController>
//        [HttpPut("{id}")]
//        public PriceServiceCategory Put(string id, [FromBody] PriceServiceCategory priceservicecategory)
//        {
//            if (ModelState.IsValid)
//            {
//                _repository.PriceServiceCategory.Update(priceservicecategory);
//                _repository.Save();
//            }

//            return priceservicecategory;
//        }

//        //DELETE: api/<ClientController>
//        [HttpDelete("{id}")]
//        public string Delete(string id, PriceServiceCategory priceservicecategory)
//        {
//            _repository.PriceServiceCategory.Delete(priceservicecategory);
//            _repository.Save();

//            return "Deleted Successfully";
//        }

//    }
//}
