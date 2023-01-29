using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IServiceRepository : IRepositoryBase<Service>
    {
       Task <IEnumerable<Service>> GetAllAsync(bool trackChanges);
       Task <Service> GetByIdAsync(int id, bool trackChanges);
        void CreateService(Service service);
        void DeleteService(Service service);
        void UpdateService(Service service);
    }
}
