using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.DTO;

namespace Contracts.Repositories
{
    public interface ITypeDocumentRepository : IRepositoryBase<TypeDocument>
    {
        Task <IEnumerable<TypeDocument>> GetAllAsync (bool trackChanges);
        Task <TypeDocument> GetByIdAsync (string id, bool trackChanges);
        void CreateTypeDocument(TypeDocument typedocument);
        void DeleteTypeDocument(TypeDocument typedocument);
        void UpdateTypeDocument(TypeDocument typedocument);
    }
}
