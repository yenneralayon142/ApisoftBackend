using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IRepairRepository : IRepositoryBase<Repair>
    {
        Task <IEnumerable<Repair>> GetAllAsync(bool trackChanges);
        Task <Repair> GetByIdAsync(int id, bool trackChanges);
        void CreateRepair(Repair repair);
        void DeleteRepair(Repair repair);
        void UpdateRepair(Repair repair);
    }
}
