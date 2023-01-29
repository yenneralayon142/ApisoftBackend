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
    internal sealed class VehicleService : IVehicleService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;
        public VehicleService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            _repository = repository;
            _loggerManager = loggerManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<VehicleDTO>> GetAll(bool trackChanges)
        {
            var vehicles = await _repository.Vehicle.GetAllAsync(false);
            var dto = _mapper.Map<IEnumerable<VehicleDTO>>(vehicles);

            return dto;
        }

        public async Task<VehicleDTO> GetById(string id, bool trackChanges)
        {
            var vehicle = await _repository.Vehicle.GetByIdAsync(id, trackChanges);
            var dto = _mapper.Map<VehicleDTO>(vehicle);

            return dto;
        }

        public void CreateVehicle(Vehicle vehicle)
        {
            _repository.Vehicle.Create(vehicle);
        }
        public void UpdateVehicle(Vehicle vehicle)
        {
            _repository.Vehicle.Update(vehicle);
        }
        public void DeleteVehicle(Vehicle vehicle)
        {
            _repository.Vehicle.Delete(vehicle);
        }
    }
}
