using Entities.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleDTO>> GetAll(bool trackChanges);
        Task<VehicleDTO> GetById(string id, bool trackChanges);
        public void CreateVehicle(Vehicle vehicle);
        public void UpdateVehicle(Vehicle vehicle);
        public void DeleteVehicle(Vehicle vehicle);
    }
}
