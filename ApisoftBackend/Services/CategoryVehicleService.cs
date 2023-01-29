using AutoMapper;
using Contracts;
using Contracts.Repositories;
using Entities.Models;
using ServiceContracts;
using Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal sealed class CategoryVehicleService : ICategoryVehicleService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;
        public CategoryVehicleService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._loggerManager = loggerManager;
        }
        public async Task<IEnumerable<CategoryVehicleDTO>> GetAll(bool trackChanges)
        {
            var catefories = await _repository.CategoryVehicle.GetAllAsync(trackChanges);
            var dto = _mapper.Map<IEnumerable<CategoryVehicleDTO>>(catefories);

            return dto;
        }
        public async Task<CategoryVehicleDTO> GetById(int id, bool trackChanges)
        {
            var categories = await _repository.CategoryVehicle.GetByIdAsync(id, trackChanges);
            var dto = _mapper.Map<CategoryVehicleDTO>(categories);

            return dto;
        }
        public void UpdateCategoryVehicle(CategoryVehicle category)
        {
            _repository.CategoryVehicle.Update(category);
        }
        public void CreateCategoryVehicle(CategoryVehicle category)
        {
            _repository.CategoryVehicle.Create(category);
        }
        public void DeleteCategoryVehicle(CategoryVehicle category)
        {
            _repository.CategoryVehicle.Delete(category);   
        }
    }
}
