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
<<<<<<< HEAD
        private readonly Lazy<ICategoryVehicleService> _categoryVehicleService;
        private readonly Lazy<IStatusVehicleService> _statusVehicleService;
=======
        private readonly Lazy<IServiceService> _serviceService;
>>>>>>> feature/YennerEdition



        private readonly IRepositoryWrapper _repositoryWrapper;
        public ServiceManager(IRepositoryWrapper repositoryManager, ILoggerManager loggerManager,IMapper mapper)
        {
            _typeDocumentService = new Lazy<ITypeDocumentService>(() => new TypeDocumentService(repositoryManager, loggerManager, mapper));
<<<<<<< HEAD
            _categoryVehicleService = new Lazy<ICategoryVehicleService>(() => new CategoryVehicleService(repositoryManager, loggerManager, mapper));
            _statusVehicleService = new Lazy<IStatusVehicleService>(() => new StatusVehicleService(repositoryManager, loggerManager, mapper));
=======
            _serviceService = new Lazy<IServiceService>(() => new ServiceService(repositoryManager, loggerManager, mapper));
>>>>>>> feature/YennerEdition

            this._repositoryWrapper = repositoryManager;
        }

        public ITypeDocumentService TypeDocumentService => _typeDocumentService.Value;
<<<<<<< HEAD
        public ICategoryVehicleService CategoryVehicleService => _categoryVehicleService.Value;
        public IStatusVehicleService StatusVehicleService => _statusVehicleService.Value;
=======
        public IServiceService ServiceService => _serviceService.Value;
>>>>>>> feature/YennerEdition

        public async Task Save() => await _repositoryWrapper.SaveAsync();

    }
}
