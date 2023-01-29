using Contracts.Repositories;
using Entities.Models;
using Repository.Configuration;
using Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DTO;
using Microsoft.EntityFrameworkCore;

namespace Repository.Tables
{
    public class TypeDocumentRepository : RepositoryBase<TypeDocument>, ITypeDocumentRepository
    {
        public TypeDocumentRepository(AppDbContext context) : base(context)
        {
        }

        public async Task < IEnumerable<TypeDocument> > GetAllAsync (bool trackChanges)
        {
            return await FindAll(trackChanges).ToListAsync();
        }

        public async Task <TypeDocument> GetByIdAsync (string id, bool trackChanges) => await FindByCondition(x => x.Type.Equals(id), trackChanges).FirstOrDefaultAsync();

        public void CreateTypeDocument(TypeDocument typedocument) => Create(typedocument);
        public void UpdateTypeDocument(TypeDocument typedocument) => Update(typedocument);
        public void DeleteTypeDocument(TypeDocument typedocument) => Delete(typedocument);
    }
}
