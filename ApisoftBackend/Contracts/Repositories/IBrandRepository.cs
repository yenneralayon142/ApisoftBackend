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
        IEnumerable<Brand> GetAll(bool trackChanges);
        Brand GetById(int id, bool trackChanges);
        void CreateBrand(Brand brand);
        void DeleteBrand(Brand brand);
        void UpdateBrand(Brand brand);
    }
}
