using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Repositories;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using Repository.Contexts;

namespace Repository.Tables
{
    public  class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<User>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id, bool trackChanges) => await FindByCondition(x => x.DocumentNumU.Equals(id), trackChanges).FirstOrDefaultAsync();
        public void CreateUser(User user) => Create(user);
        public void DeleteUser(User user) => Delete(user);
        public void UpdateUser(User user) => Update(user);

    }

    
}
