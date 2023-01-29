using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IStatusVehicleRepository : IRepositoryBase<StatusVehicle>
    {
        IEnumerable<StatusVehicle> GetAll(bool trackChanges);
        StatusVehicle GetById(int id, bool trackChanges);
        void CreateStatusVehicle(StatusVehicle status);
        void DeleteStatusVehicle(StatusVehicle status);
        void UpdateStatusVehicle(StatusVehicle status);
    }
}
