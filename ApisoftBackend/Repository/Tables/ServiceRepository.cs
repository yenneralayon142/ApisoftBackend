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
    public class ServiceRepository : RepositoryBase<Service>, IServiceRepository
    {
        public ServiceRepository(AppDbContext context) : base(context)
        {                
        }

        public IEnumerable<Service> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Service GetById(int id, bool trackChanges) => FindByCondition(x => x.ServiceId.Equals(id), trackChanges).FirstOrDefault();   
        public void CreateService(Service service) => Create(service);
        public void DeleteService(Service service) => Delete(service);
        public void UpdateService(Service service) => Update(service);  
    }
}
