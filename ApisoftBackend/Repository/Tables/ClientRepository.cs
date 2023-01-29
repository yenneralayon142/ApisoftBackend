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
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(AppDbContext context) : base (context)
        {
        }

        public async Task<IEnumerable<Client>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }
        public async Task<Client> GetByIdAsync(int id, bool trackChanges) => await FindByCondition(x => x.DocumentNum.Equals(id), trackChanges).FirstOrDefaultAsync();

        public void CreateClient(Client client) => Create(client);
        public void UpdateClient(Client client) => Update(client);
        public void DeleteClient(Client client) => Delete(client);
    }
}
