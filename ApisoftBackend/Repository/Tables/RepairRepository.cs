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
    public class RepairRepository : RepositoryBase<Repair>, IRepairRepository
    {
        public RepairRepository(AppDbContext context) : base(context)
        {
        }

        public async Task <IEnumerable<Repair>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task <Repair> GetByIdAsync(int id, bool trackChanges) => await FindByCondition(x => x.RepairId.Equals(id), trackChanges).FirstOrDefaultAsync();

        public void CreateRepair(Repair repair) => Create(repair);
        public void DeleteRepair(Repair repair) => Delete(repair);
        public void UpdateRepair(Repair repair) => Update(repair);
    }
}
