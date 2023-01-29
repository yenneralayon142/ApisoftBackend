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
    public class CategoryVehicleRepository : RepositoryBase<CategoryVehicle>, ICategoryVehicleRepository
    {
        public CategoryVehicleRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<CategoryVehicle>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }
        public async Task<CategoryVehicle> GetByIdAsync(int id, bool trackChanges) => await FindByCondition(x => x.CategoryVehicleId.Equals(id), trackChanges).FirstOrDefaultAsync();
        public void CreateCategory(CategoryVehicle category) => Create(category);
        public void DeleteCategory(CategoryVehicle category) => Delete(category);
        public void UpdateCategory(CategoryVehicle category) => Update(category);
    }
}
