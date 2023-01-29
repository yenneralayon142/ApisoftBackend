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
    public class ServiceRepository : RepositoryBase<Service>, IServiceRepository
    {
        public ServiceRepository(AppDbContext context) : base(context)
        {                
        }

        public async Task <IEnumerable<Service>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task <Service> GetByIdAsync(int id, bool trackChanges) =>await FindByCondition(x => x.ServiceId.Equals(id), trackChanges).FirstOrDefaultAsync();   
        public void CreateService(Service service) => Create(service);
        public void DeleteService(Service service) => Delete(service);
        public void UpdateService(Service service) => Update(service);  
    }
}
