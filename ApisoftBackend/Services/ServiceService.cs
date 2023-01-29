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
    internal sealed class ServiceService : IServiceService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager loggerManager;
        private readonly IMapper _mapper;

        public ServiceService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            _repository = repository;
            this.loggerManager = loggerManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ServiceDTO>> GetServicesDTO(bool trackChanges)
        {
            var services = await _repository.Service.GetAllAsync(trackChanges);
            var servicesDTO = _mapper.Map<IEnumerable<ServiceDTO>>(services);

            return servicesDTO;
        }

        public async Task<ServiceDTO> GetByIdDTO(int id, bool trackChanges)
        {
            var services = await _repository.Service.GetByIdAsync(id,trackChanges);
            var servicesDTO = _mapper.Map<ServiceDTO>(services);

            return servicesDTO;
        }
        public void CreateService(Service service)
        {
            _repository.Service.Create(service);
        }

      
        public void UpdateService(Service service)
        {
            _repository.Service.Update(service);
        }

        public void DeleteService(Service service)
        {
            _repository.Service.Delete(service);
        }
    }
}
