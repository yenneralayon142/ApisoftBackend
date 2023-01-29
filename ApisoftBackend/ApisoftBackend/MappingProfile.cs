using AutoMapper;
using Entities.Models;
using Shared;
using Shared.DTO;

namespace ApisoftBackend
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TypeDocument, TypeDocumentDTO>();
            CreateMap<Service, ServiceDTO>();
        }
    }
}
