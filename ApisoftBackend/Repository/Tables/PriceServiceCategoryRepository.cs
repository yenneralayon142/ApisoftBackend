using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Repositories;
using Entities.Models;
using Repository.Configuration;
using Repository.Contexts;

namespace Repository.Tables
{
    public class PriceServiceCategoryRepository : RepositoryBase<PriceServiceCategory>, IPriceServiceCategoryRepository
    {
        public PriceServiceCategoryRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<PriceServiceCategory> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public PriceServiceCategory GetById(int id, bool trackChanges) => FindByCondition(x => x.PriceServiceCategoryId.Equals(id), trackChanges).FirstOrDefault();


        public void CreatePriceServiceCategory(PriceServiceCategory priceservicecategory) => Create(priceservicecategory);
        

        public void DeletePriceServiceCategory(PriceServiceCategory priceservicecategory) => Delete(priceservicecategory);
     

        public void UpdatePriceServiceCategory(PriceServiceCategory priceservicecategory) => Update(priceservicecategory);
       
    }
}
