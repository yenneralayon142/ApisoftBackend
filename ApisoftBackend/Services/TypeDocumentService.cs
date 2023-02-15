using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.Extensions.Logging;
using ServiceContracts;
using Shared.DTO;


namespace Services
{
    internal sealed class TypeDocumentService : ITypeDocumentService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;
       

        public TypeDocumentService(IRepositoryWrapper repository,ILoggerManager loggerManager,IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper; 
            this._loggerManager = loggerManager;
        }


        public async Task <IEnumerable<TypeDocumentDTO>> GetTypeDocumentsDTOs(bool trackChanges)
        {
            var types = await _repository.TypeDocument.GetAllAsync(trackChanges);
            var typesDTO = _mapper.Map<IEnumerable<TypeDocumentDTO>>(types);

            return typesDTO;
        }
        public async Task <TypeDocumentDTO> GetByIdDto(string id, bool trackChanges)
        {
            var types = await _repository.TypeDocument.GetByIdAsync(id, trackChanges);
            var typesDTO = _mapper.Map<TypeDocumentDTO>(types);

            return typesDTO;
        }

        public void CreateTypeDocument(TypeDocument typeDocument)
        {
            _repository.TypeDocument.Create(typeDocument);            
        }

       public void UpdateTypeDocument(TypeDocument typeDocument)
       {
           _repository.TypeDocument.Update(typeDocument);
       }

       public void DeleteTypeDocument(TypeDocument typeDocument) 
       {
            _repository.TypeDocument.Delete(typeDocument);
       }



    }
}