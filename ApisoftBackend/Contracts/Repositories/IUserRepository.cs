using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IEnumerable<User> GetAll(bool trackChanges);
        User GetById(int id, bool trackChanges);
        void CreateUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);

    }
}
