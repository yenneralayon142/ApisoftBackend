using Contracts.Repositories;
using Entities.Models;
using Repository.Configuration;
using Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Tables
{
    public class BrandRepository : RepositoryBase<Brand>, IBrandRepository
    {
        public BrandRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<Brand> GetAll(bool trackChanges)
        {
            return FindAll(trackChanges).ToList();
        }

        public Brand GetById(int id, bool trackChanges) => FindByCondition(x => x.BrandId.Equals(id), trackChanges).FirstOrDefault();

        public void CreateBrand(Brand brand) => Create(brand);
        public void UpdateBrand(Brand brand) => Update(brand);
        public void DeleteBrand(Brand brand) => Delete(brand);
    }
}
