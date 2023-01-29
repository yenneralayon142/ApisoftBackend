using Entities.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IRepairService
    {
        Task<IEnumerable<RepairDTO>> GetRepairsDTO(bool trackChanges);
        Task<RepairDTO> GetByIdDTO(int id,bool trackChanges);

        void CreateRepair(Repair repair);
        void UpdateRepair(Repair repair);
        void DeleteRepair(Repair repair);
    
    }
}
