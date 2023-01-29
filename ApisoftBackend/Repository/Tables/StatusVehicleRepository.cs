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
    public class StatusVehicleRepository : RepositoryBase<StatusVehicle>, IStatusVehicleRepository
    {
        public StatusVehicleRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<StatusVehicle>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task<StatusVehicle> GetByIdAsync(int id, bool trackChanges) => await FindByCondition(x => x.StatusVehicleId.Equals(id), trackChanges).FirstOrDefaultAsync();
        public void CreateStatusVehicle(StatusVehicle status) => Create(status);
        public void DeleteStatusVehicle(StatusVehicle status) => Delete(status);
        public void UpdateStatusVehicle(StatusVehicle status) => Update(status);
    }
}
