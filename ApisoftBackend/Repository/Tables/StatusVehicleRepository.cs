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
    public class StatusVehicleRepository : RepositoryBase<StatusVehicle>, IStatusVehicleRepository
    {
        public StatusVehicleRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<StatusVehicle> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public StatusVehicle GetById(int id, bool trackChanges) => FindByCondition(x => x.StatusVehicleId.Equals(id), trackChanges).FirstOrDefault();
        public void CreateStatusVehicle(StatusVehicle status) => Create(status);
        public void DeleteStatusVehicle(StatusVehicle status) => Delete(status);
        public void UpdateStatusVehicle(StatusVehicle status) => Update(status);
    }
}
