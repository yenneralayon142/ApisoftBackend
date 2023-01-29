using AutoMapper;
using Entities.Models;
using Shared.DTO;

namespace ApisoftBackend
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TypeDocument, TypeDocumentDTO>();
            CreateMap<CategoryVehicle, CategoryVehicleDTO>();
            CreateMap<StatusVehicle, StatusVehicleDTO>();  
            CreateMap<Brand, BrandDTO>();
            CreateMap<StatusVehicle, StatusVehicleDTO>();            
            CreateMap<Repair,RepairDTO>();
            CreateMap<Service, ServiceDTO>();
            CreateMap<PriceServiceCategory,PriceServiceCategoryDTO>();

        }
    }
}
