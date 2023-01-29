using Contracts;
using Contracts.Repositories;
using Entities.Models;
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

        public IEnumerable<RepairService> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }
        public RepairService GetById(int id, bool trackChanges) => FindByCondition(x => x.Id.Equals(id), trackChanges).FirstOrDefault();

        public void CreateRepairService(RepairService repairservice) => Create(repairservice);
        public void DeleteRepairService(RepairService repairservice) => Delete(repairservice);
        public void UpdateRepairService(RepairService repairservice) => Update(repairservice);  

    }
}
