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
    internal sealed class StatusVehicleService : IStatusVehicleService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public StatusVehicleService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._loggerManager = loggerManager;
        }        
        public async Task<IEnumerable<StatusVehicleDTO>> GetVehiclesAsync(bool trackChanges)
        {
            var status = await _repository.StatusVehicle.GetAllAsync(trackChanges);
            var dto = _mapper.Map<IEnumerable<StatusVehicleDTO>>(status);

            return dto;
        }
        public async Task<StatusVehicleDTO> GetByIdAsync(int id, bool trackChanges)
        {
            var status = await _repository.StatusVehicle.GetByIdAsync(id, trackChanges);
            var dto = _mapper.Map<StatusVehicleDTO>(status);

            return dto;
        }
        public void CreateStatusVehicle(StatusVehicle status)
        {
            _repository.StatusVehicle.Create(status);
        }
        public void DeleteStatusVehicle(StatusVehicle status)
        {
            _repository.StatusVehicle.Delete(status);
        }
        public void UpdateStatusVehicle(StatusVehicle status)
        {
            _repository.StatusVehicle.Update(status);
        }
    }
}
