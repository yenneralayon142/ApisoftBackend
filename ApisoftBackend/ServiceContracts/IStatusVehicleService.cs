using Entities.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IStatusVehicleService
    {
        Task<IEnumerable<StatusVehicleDTO>> GetVehiclesAsync(bool trackChanges);
        Task<StatusVehicleDTO>GetByIdAsync(int id, bool trackChanges);
        void CreateStatusVehicle(StatusVehicle status);
        void UpdateStatusVehicle(StatusVehicle status);
        void DeleteStatusVehicle(StatusVehicle status);
    }
}
