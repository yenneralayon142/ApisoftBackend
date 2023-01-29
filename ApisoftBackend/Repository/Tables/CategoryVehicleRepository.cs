using Contracts.Repositories;
using Entities.Models;
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
        public IEnumerable<CategoryVehicle> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }
        public CategoryVehicle GetById(int id, bool trackChanges) => FindByCondition(x => x.CategoryVehicleId.Equals(id), trackChanges).FirstOrDefault();
        public void CreateCategory(CategoryVehicle category) => Create(category);
        public void DeleteCategory(CategoryVehicle category) => Delete(category);
        public void UpdateCategory(CategoryVehicle category) => Update(category);
    }
}
