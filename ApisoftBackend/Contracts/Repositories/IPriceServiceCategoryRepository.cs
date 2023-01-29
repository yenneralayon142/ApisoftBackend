using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts.Repositories
{
    public interface IPriceServiceCategoryRepository : IRepositoryBase<PriceServiceCategory>
    {
        Task <IEnumerable<PriceServiceCategory>> GetAllAsync (bool trackChanges);
        Task <PriceServiceCategory> GetByIdAsync(int id, bool trackChanges);
        void CreatePriceServiceCategory(PriceServiceCategory priceservicecategory);
        void DeletePriceServiceCategory(PriceServiceCategory priceservicecategory);
        void UpdatePriceServiceCategory(PriceServiceCategory priceservicecategory);
    }
}
