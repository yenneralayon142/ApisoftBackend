using Entities.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface ICategoryVehicleService
    {
        Task<IEnumerable<CategoryVehicleDTO>> GetAll(bool trackChanges);
        Task<CategoryVehicleDTO>GetById(int id, bool trackChanges);
        void CreateCategoryVehicle(CategoryVehicle category);
        void UpdateCategoryVehicle(CategoryVehicle category);
        void DeleteCategoryVehicle(CategoryVehicle category);
    }
}
