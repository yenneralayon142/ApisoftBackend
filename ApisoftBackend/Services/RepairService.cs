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
    internal sealed class RepairService : IRepairService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public RepairService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._loggerManager = loggerManager;
        }

        public async Task<IEnumerable<RepairDTO>> GetRepairsDTO(bool trackChanges)
        {
            var repairs = await _repository.Repair.GetAllAsync(trackChanges);
            var repairsDTO = _mapper.Map<IEnumerable<RepairDTO>>(repairs);

            return repairsDTO;
        }

        public async Task <RepairDTO> GetByIdDTO(int id, bool trackChanges)
        {
            var repairs = await _repository.Repair.GetByIdAsync(id, trackChanges);
            var repairsDTO = _mapper.Map<RepairDTO>(repairs);

            return repairsDTO;
        }

        public void CreateRepair(Repair repair)
        {
            _repository.Repair.Create(repair);
        }
       
        public void UpdateRepair(Repair repair)
        {
            _repository.Repair.Update(repair);
        }
        public void DeleteRepair(Repair repair)
        {
            _repository.Repair.Delete(repair);
        }
    }
}
