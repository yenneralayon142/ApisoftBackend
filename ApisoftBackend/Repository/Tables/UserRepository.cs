using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.Repositories;
using Entities.Models;
using Repository.Configuration;
using Repository.Contexts;

namespace Repository.Tables
{
    public  class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<User> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public User GetById(int id, bool trackChanges) => FindByCondition(x => x.DocumentNumU.Equals(id), trackChanges).FirstOrDefault();


        public void CreateUser(User user) => Create(user);

        public void DeleteUser(User user) => Delete(user);

        public void UpdateUser(User user) => Update(user);

    }

    
}
