using Entities.Models;
using Shared.DTO;

namespace ServiceContracts
{
    public interface ITypeDocumentService
    {
        Task <IEnumerable<TypeDocumentDTO>> GetTypeDocumentsDTOs(bool trackChanges);
        Task <TypeDocumentDTO> GetByIdDto(string id, bool trackChanges);

        void CreateTypeDocument(TypeDocument typeDocument);
        void UpdateTypeDocument(TypeDocument typeDocument);
        void DeleteTypeDocument(TypeDocument typeDocument);
    }
}