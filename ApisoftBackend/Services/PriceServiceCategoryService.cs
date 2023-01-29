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
    internal sealed class PriceServiceCategoryService : IPriceServiceCategoryService
    {
        private readonly IRepositoryWrapper _repository;
        private readonly ILoggerManager _loggerManager;
        private readonly IMapper _mapper;

        public PriceServiceCategoryService(IRepositoryWrapper repository, ILoggerManager loggerManager, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;
            this._loggerManager = loggerManager;
        }

        public async Task<IEnumerable<PriceServiceCategoryDTO>> GetPriceServiceCategoryDTO(bool trackChanges)
        {
            var price = await _repository.PriceServiceCategory.GetAllAsync(trackChanges);
            var priceDTO = _mapper.Map<IEnumerable<PriceServiceCategoryDTO>>(price);

            return priceDTO;
        }

        public async Task<PriceServiceCategoryDTO> GetByIdDTO(int id, bool trackChanges)
        {
            var price = await _repository.PriceServiceCategory.GetByIdAsync(id, trackChanges);
            var priceDTO = _mapper.Map<PriceServiceCategoryDTO>(price);

            return priceDTO;
        }
        public void CreatePriceServiceCategory(PriceServiceCategory priceServiceCategory)
        {
            _repository.PriceServiceCategory.Create(priceServiceCategory);
        }

        public void UpdatePriceServiceCategory(PriceServiceCategory priceServiceCategory)
        {
            _repository.PriceServiceCategory.Update(priceServiceCategory);
        }

        public void DeletePriceServiceCategory(PriceServiceCategory priceServiceCategory)
        {
            _repository.PriceServiceCategory.Delete(priceServiceCategory);
        }

      

       

       
    }
}
