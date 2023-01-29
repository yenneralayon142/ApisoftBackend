using Contracts.Repositories;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Tables
{
    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        public BrandRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Brand>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task<Brand> GetByIdAsync(int id, bool trackChanges) => await FindByCondition(x => x.BrandId.Equals(id), trackChanges).FirstOrDefaultAsync();

        public void CreateBrand(Brand brand) => Create(brand);
        public void UpdateBrand(Brand brand) => Update(brand);
        public void DeleteBrand(Brand brand) => Delete(brand);
    }
}
