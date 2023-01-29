using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IBrandRepository : IRepositoryBase<Brand>
    {
        Task<IEnumerable<Brand>> GetAllAsync(bool trackChanges);
        Task<Brand> GetByIdAsync(int id, bool trackChanges);
        void CreateBrand(Brand brand);
        void DeleteBrand(Brand brand);
        void UpdateBrand(Brand brand);
    }
}
