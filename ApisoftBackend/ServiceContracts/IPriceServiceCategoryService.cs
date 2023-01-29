using Entities.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IPriceServiceCategoryService
    {
        Task<IEnumerable<PriceServiceCategoryDTO>> GetPriceServiceCategoryDTO(bool trackChanges);
        Task<PriceServiceCategoryDTO>GetByIdDTO(int id, bool trackChanges);

        void CreatePriceServiceCategory(PriceServiceCategory priceServiceCategory);
        void UpdatePriceServiceCategory(PriceServiceCategory priceServiceCategory);
        void DeletePriceServiceCategory(PriceServiceCategory priceServiceCategory);
    }
}
