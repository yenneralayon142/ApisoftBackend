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
    internal class VehicleRepository : RepositoryBase<Vehicle>, IVehicleRepository
    {
        public VehicleRepository(AppDbContext context) : base(context)
        {
        }
        public IEnumerable<Vehicle> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }
        public Vehicle GetById(string id, bool trackChanges) => FindByCondition(x => x.Plate.Equals(id), trackChanges).FirstOrDefault();

        public void CreateVehicle(Vehicle vehicle) => Create(vehicle);
        public void DeleteVehicle(Vehicle vehicle) => Delete(vehicle);
        public void UpdateVehicle(Vehicle vehicle) => Update(vehicle);

    }
}
