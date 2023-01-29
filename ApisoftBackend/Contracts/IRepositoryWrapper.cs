using Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IClientRepository Client { get; }
        ITypeDocumentRepository TypeDocument { get; }
        IUserRepository User { get; }
        IBrandRepository Brand { get; }
        ICategoryVehicleRepository CategoryVehicle { get; }
        IRepairRepository Repair { get; }
        IPriceServiceCategoryRepository PriceServiceCategory { get; }
        IServiceRepository Service { get; }
        IStatusVehicleRepository StatusVehicle { get; }
        IVehicleRepository Vehicle { get; }
        IRepairServiceRepository RepairService { get; }

        Task SaveAsync();
    }
}
