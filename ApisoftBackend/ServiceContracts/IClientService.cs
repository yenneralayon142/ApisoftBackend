using Entities.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDTO>> GetAll(bool trackChanges);
        Task<ClientDTO>GetById(int id, bool trackChanges);
        public void CreateClient(Client client);
        public void UpdateClient(Client client);
        public void DeleteClient(Client client);
    }
}
