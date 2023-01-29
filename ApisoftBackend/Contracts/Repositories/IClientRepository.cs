using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IClientRepository : IRepositoryBase<Client>
    {
        Task<IEnumerable<Client>> GetAllAsync(bool trackChanges);
        Task<Client> GetByIdAsync(int id, bool trackChanges);
        void CreateClient(Client client);
        void DeleteClient(Client client);
        void UpdateClient(Client client);
    }
}
