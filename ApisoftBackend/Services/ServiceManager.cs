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
<<<<<<< HEAD
        private readonly Lazy<IBrandService> _brandService;
=======
=======
        private readonly Lazy<IServiceService> _serviceService;
>>>>>>> feature/YennerEdition
>>>>>>> 54c53f4303667e15c0ff86de0eaa07638efd654b



        private readonly IRepositoryWrapper _repositoryWrapper;
        public ServiceManager(IRepositoryWrapper repositoryManager, ILoggerManager loggerManager,IMapper mapper)
        {
            _typeDocumentService = new Lazy<ITypeDocumentService>(() => new TypeDocumentService(repositoryManager, loggerManager, mapper));
<<<<<<< HEAD
            _categoryVehicleService = new Lazy<ICategoryVehicleService>(() => new CategoryVehicleService(repositoryManager, loggerManager, mapper));
            _statusVehicleService = new Lazy<IStatusVehicleService>(() => new StatusVehicleService(repositoryManager, loggerManager, mapper));
<<<<<<< HEAD
            _brandService = new Lazy<IBrandService>(() => new BrandService(repositoryManager,loggerManager, mapper));
=======
=======
            _serviceService = new Lazy<IServiceService>(() => new ServiceService(repositoryManager, loggerManager, mapper));
>>>>>>> feature/YennerEdition
>>>>>>> 54c53f4303667e15c0ff86de0eaa07638efd654b

            this._repositoryWrapper = repositoryManager;
        }

        public ITypeDocumentService TypeDocumentService => _typeDocumentService.Value;
<<<<<<< HEAD
        public ICategoryVehicleService CategoryVehicleService => _categoryVehicleService.Value;
        public IStatusVehicleService StatusVehicleService => _statusVehicleService.Value;
<<<<<<< HEAD
        public IBrandService BrandService => _brandService.Value;
=======
=======
        public IServiceService ServiceService => _serviceService.Value;
>>>>>>> feature/YennerEdition
>>>>>>> 54c53f4303667e15c0ff86de0eaa07638efd654b

        public async Task Save() => await _repositoryWrapper.SaveAsync();

    }
}
