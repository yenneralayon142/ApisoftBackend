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
        IEnumerable<Service> GetAll(bool trackChanges);
        Service GetById(int id, bool trackChanges);
        void CreateService(Service service);
        void DeleteService(Service service);
        void UpdateService(Service service);
    }
}
