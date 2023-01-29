using Entities.Models;
using Shared.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IServiceService
    {
        Task<IEnumerable<ServiceDTO>> GetServicesDTO(bool trackChanges);
        Task<ServiceDTO> GetByIdDTO(int id, bool trackChanges);

        void CreateService(Service service);
        void UpdateService(Service service);
        void DeleteService(Service service);
    }
}
