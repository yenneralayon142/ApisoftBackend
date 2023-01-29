using Entities.Models;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IUserService 
    {
        Task<IEnumerable<UserDTO>> GetAll(bool trackChanges);
        Task<UserDTO> GetById(int id, bool trackChanges);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
