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
    internal class VehicleRepository : RepositoryBase<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Vehicle>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }
        public async Task<Vehicle> GetByIdAsync(string id, bool trackChanges) => await FindByCondition(x => x.Plate.Equals(id), trackChanges).FirstOrDefaultAsync();

        public void CreateVehicle(Vehicle vehicle) => Create(vehicle);
        public void DeleteVehicle(Vehicle vehicle) => Delete(vehicle);
        public void UpdateVehicle(Vehicle vehicle) => Update(vehicle);

    }
}
