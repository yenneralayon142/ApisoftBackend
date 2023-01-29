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
            CreateMap<StatusVehicle, StatusVehicleDTO>();            
            CreateMap<Repair,RepairDTO>();
            CreateMap<Service, ServiceDTO>();

        }
    }
}
