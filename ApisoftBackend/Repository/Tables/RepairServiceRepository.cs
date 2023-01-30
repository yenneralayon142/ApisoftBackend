using Contracts;
using Contracts.Repositories;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Tables
{
    public class RepairServiceRepository : RepositoryBase<RepairService>, IRepairServiceRepository
    {
        public RepairServiceRepository(AppDbContext context) : base(context)
        {
        }

        public async Task < IEnumerable<RepairService>> GetAllAsync (bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }
        public async Task  <RepairService> GetByIdAsync(int id, bool trackChanges) =>await FindByCondition(x => x.Id.Equals(id), trackChanges).FirstOrDefaultAsync();
        public void CreateRepairService(RepairService repairservice) => Create(repairservice);
        public void DeleteRepairService(RepairService repairservice) => Delete(repairservice);
        public void UpdateRepairService(RepairService repairservice) => Update(repairservice);  

    }
}
