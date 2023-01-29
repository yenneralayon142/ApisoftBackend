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
            CreateMap<CategoryVehicle, CategoryVehicleDTO>();
<<<<<<< HEAD
            CreateMap<StatusVehicle, StatusVehicleDTO>();  
            CreateMap<Brand, BrandDTO>();
=======
            CreateMap<StatusVehicle, StatusVehicleDTO>();            
            CreateMap<Repair,RepairDTO>();
            CreateMap<Service, ServiceDTO>();
<<<<<<< HEAD

=======
>>>>>>> feature/YennerEdition
>>>>>>> 54c53f4303667e15c0ff86de0eaa07638efd654b
>>>>>>> ecb72ab75b6a63c6a32abbfe3178bc12de986aea
        }
    }
}
