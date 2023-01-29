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
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(AppDbContext context) : base (context)
        {
        }

        public IEnumerable<Client> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Client GetById(int id, bool trackChanges) => FindByCondition(x => x.DocumentNum.Equals(id), trackChanges).FirstOrDefault();

        public void CreateClient(Client client) => Create(client);
        public void UpdateClient(Client client) => Update(client);
        public void DeleteClient(Client client) => Delete(client);
    }
}
