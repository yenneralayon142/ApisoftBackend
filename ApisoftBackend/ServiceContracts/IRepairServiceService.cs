using Entities.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IRepairServiceService
    {
        Task<IEnumerable<RepairServiceDTO>> GetRepairServiceDTO(bool trackChanges);
        Task<RepairServiceDTO> GetByIdDTO(int id, bool trackChanges);

        void CreateRepairService(RepairService repairservice);
        void UpdateRepairService(RepairService repairservice);
        void DeleteRepairService(RepairService repairservice);
    }
}
