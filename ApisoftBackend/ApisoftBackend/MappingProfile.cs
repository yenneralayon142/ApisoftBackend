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
<<<<<<< HEAD
            CreateMap<CategoryVehicle, CategoryVehicleDTO>();
            CreateMap<StatusVehicle, StatusVehicleDTO>();            
=======
            CreateMap<Service, ServiceDTO>();
>>>>>>> feature/YennerEdition
        }
    }
}
