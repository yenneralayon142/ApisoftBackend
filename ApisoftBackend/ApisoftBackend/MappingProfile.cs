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
<<<<<<< HEAD
            CreateMap<StatusVehicle, StatusVehicleDTO>();  
            CreateMap<Brand, BrandDTO>();
=======
            CreateMap<StatusVehicle, StatusVehicleDTO>();            
=======
            CreateMap<Service, ServiceDTO>();
>>>>>>> feature/YennerEdition
>>>>>>> 54c53f4303667e15c0ff86de0eaa07638efd654b
        }
    }
}
