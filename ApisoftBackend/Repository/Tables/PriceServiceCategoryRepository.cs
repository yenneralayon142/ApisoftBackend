using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Repositories;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using Repository.Contexts;

namespace Repository.Tables
{
    public class PriceServiceCategoryRepository : RepositoryBase<PriceServiceCategory>, IPriceServiceCategoryRepository
    {
        public PriceServiceCategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task <IEnumerable<PriceServiceCategory>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task <PriceServiceCategory> GetByIdAsync(int id, bool trackChanges) => await  FindByCondition(x => x.PriceServiceCategoryId.Equals(id), trackChanges).FirstOrDefaultAsync();


        public void CreatePriceServiceCategory(PriceServiceCategory priceservicecategory) => Create(priceservicecategory);
        

        public void DeletePriceServiceCategory(PriceServiceCategory priceservicecategory) => Delete(priceservicecategory);
     

        public void UpdatePriceServiceCategory(PriceServiceCategory priceservicecategory) => Update(priceservicecategory);

       
    }
}
