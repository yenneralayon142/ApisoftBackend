using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IRepairServiceRepository : IRepositoryBase<RepairService>
    {
        IEnumerable<RepairService> GetAll(bool trackChanges);
        RepairService GetById(int id, bool trackChanges);
        void CreateRepairService(RepairService repairservice);
        void DeleteRepairService(RepairService repairservice);
        void UpdateRepairService(RepairService repairservice);
    }
}
