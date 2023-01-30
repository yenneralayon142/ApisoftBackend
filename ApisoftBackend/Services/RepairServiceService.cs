using AutoMapper;
using Contracts;
using ServiceContracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Services
{
    internal sealed class RepairServiceService : IRepairServiceService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager loggerManager;
        private readonly IMapper _mapper; 

        public RepairServiceService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this.loggerManager = loggerManager;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<RepairServiceDTO>> GetRepairServiceDTO(bool trackChanges)
        {
            var repair = await _repository.RepairService.GetAllAsync(trackChanges);
            var repairDTO = _mapper.Map<IEnumerable<RepairServiceDTO>>(repair);

            return repairDTO;
        }
        public async Task<RepairServiceDTO> GetByIdDTO(int id, bool tracKChanges)
        {
            var repair = await _repository.RepairService.GetByIdAsync(id, tracKChanges);
            var repairDTO = _mapper.Map<RepairServiceDTO>(repair);

            return repairDTO;

        }

        public void CreateRepairService(Entities.Models.RepairService repairservice)
        {
            _repository.RepairService.Create(repairservice);
        }
        public void UpdateRepairService(Entities.Models.RepairService repairservice)
        {
            _repository.RepairService.Update(repairservice);
        }

        public void DeleteRepairService(Entities.Models.RepairService repairservice)
        {
            _repository.RepairService.Delete(repairservice);
        }
       
    }
}
