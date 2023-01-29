using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface ICategoryVehicleRepository : IRepositoryBase<CategoryVehicle>
    {
        Task<IEnumerable<CategoryVehicle>> GetAllAsync(bool trackChanges);
        Task<CategoryVehicle> GetByIdAsync(int id, bool trackChanges);
        void CreateCategory(CategoryVehicle category);
        void DeleteCategory(CategoryVehicle category);
        void UpdateCategory(CategoryVehicle category);
    }
}
