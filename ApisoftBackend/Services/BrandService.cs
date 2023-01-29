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
    internal sealed class BrandService : IBrandService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;
        public BrandService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._loggerManager = loggerManager;
        }      
        public async Task<IEnumerable<BrandDTO>> GetAll(bool trackChanges)
        {
            var brands = await _repository.Brand.GetAllAsync(false);
            var dto = _mapper.Map<IEnumerable<BrandDTO>>(brands);

            return dto;
        }

        public async Task<BrandDTO> GetById(int id, bool trackChanges)
        {
            var brands = await _repository.Brand.GetByIdAsync(id, trackChanges);
            var dto = _mapper.Map<BrandDTO>(brands);

            return dto;
        }

        public void UpdateBrand(Brand brand)
        {
            _repository.Brand.Update(brand);
        }
        public void CreateBrand(Brand brand)
        {
            _repository.Brand.Create(brand);
        }
        public void DeleteBrand(Brand brand)
        {
            _repository.Brand.Delete(brand);
        }
    }
}
