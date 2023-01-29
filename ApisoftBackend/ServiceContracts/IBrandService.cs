using Entities.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IBrandService
    {
        Task<IEnumerable<BrandDTO>> GetAll(bool trackChanges);
        Task<BrandDTO> GetById(int id, bool trackChanges);
        void CreateBrand(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);

    }
}
