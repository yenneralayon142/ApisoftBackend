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
    public class RepairRepository : RepositoryBase<Repair>, IRepairRepository
    {
        public RepairRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<Repair> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Repair GetById(int id, bool trackChanges) => FindByCondition(x => x.RepairId.Equals(id), trackChanges).FirstOrDefault();

        public void CreateRepair(Repair repair) => Create(repair);
        public void DeleteRepair(Repair repair) => Delete(repair);
        public void UpdateRepair(Repair repair) => Update(repair);
    }
}
