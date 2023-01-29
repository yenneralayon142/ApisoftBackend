using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IVehicleRepository : IRepositoryBase<Vehicle>
    {
        Task<IEnumerable<Vehicle>> GetAllAsync(bool trackChanges);
        Task<Vehicle> GetByIdAsync(string id, bool trackChanges);
        void CreateVehicle(Vehicle vehicle);
        void DeleteVehicle(Vehicle vehicle);
        void UpdateVehicle(Vehicle vehicle);
    }
}
