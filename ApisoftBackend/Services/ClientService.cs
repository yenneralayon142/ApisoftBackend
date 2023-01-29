using AutoMapper;
using Contracts;
using Entities.Models;
using ServiceContracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal sealed class ClientService : IClientService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;
        public ClientService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            _repository = repository;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClientDTO>>GetAll(bool trackChanges)
        {
            var clients = await _repository.Client.GetAllAsync(false);
            var dto = _mapper.Map<IEnumerable<ClientDTO>>(clients);

            return dto;
        }

        public async Task<ClientDTO>GetById(int id, bool trackChanges)
        {
            var client = await _repository.Client.GetByIdAsync(id, trackChanges);
            var dto = _mapper.Map<ClientDTO>(client);  

            return dto;
        }
        public void CreateClient(Client client)
        {
            _repository.Client.Create(client);
        }
        public void UpdateClient(Client client)
        {
            _repository.Client.Update(client);
        }
        public void DeleteClient(Client client)
        {
            _repository.Client.Delete(client);  
        }
    }
}
