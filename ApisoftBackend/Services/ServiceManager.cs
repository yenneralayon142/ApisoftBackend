using AutoMapper;
using Contracts;
using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ITypeDocumentService> _typeDocumentService;
        private readonly Lazy<ICategoryVehicleService> _categoryVehicleService;
        private readonly Lazy<IStatusVehicleService> _statusVehicleService;
        private readonly Lazy<IServiceService> _serviceService;
        private readonly Lazy<IRepairService> _repairService;




        private readonly IRepositoryWrapper _repositoryWrapper;
        public ServiceManager(IRepositoryWrapper repositoryManager, ILoggerManager loggerManager,IMapper mapper)
        {
            _typeDocumentService = new Lazy<ITypeDocumentService>(() => new TypeDocumentService(repositoryManager, loggerManager, mapper));
            _categoryVehicleService = new Lazy<ICategoryVehicleService>(() => new CategoryVehicleService(repositoryManager, loggerManager, mapper));
            _statusVehicleService = new Lazy<IStatusVehicleService>(() => new StatusVehicleService(repositoryManager, loggerManager, mapper));
            _serviceService = new Lazy<IServiceService>(() => new ServiceService(repositoryManager, loggerManager, mapper));
            _repairService = new Lazy<IRepairService>(()=> new RepairService(repositoryManager,loggerManager, mapper));

            this._repositoryWrapper = repositoryManager;
        }

        public ITypeDocumentService TypeDocumentService => _typeDocumentService.Value;

        public ICategoryVehicleService CategoryVehicleService => _categoryVehicleService.Value;
        public IStatusVehicleService StatusVehicleService => _statusVehicleService.Value;

        public IServiceService ServiceService => _serviceService.Value;

        public IRepairService RepairService => _repairService.Value;


        public async Task Save() => await _repositoryWrapper.SaveAsync();

    }
}
