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
        private readonly Lazy<IServiceService> _serviceService;



        private readonly IRepositoryWrapper _repositoryWrapper;
        public ServiceManager(IRepositoryWrapper repositoryManager, ILoggerManager loggerManager,IMapper mapper)
        {
            _typeDocumentService = new Lazy<ITypeDocumentService>(() => new TypeDocumentService(repositoryManager, loggerManager, mapper));
            _serviceService = new Lazy<IServiceService>(() => new ServiceService(repositoryManager, loggerManager, mapper));

            this._repositoryWrapper = repositoryManager;
        }

        public ITypeDocumentService TypeDocumentService => _typeDocumentService.Value;
        public IServiceService ServiceService => _serviceService.Value;

        public async Task Save() => await _repositoryWrapper.SaveAsync();

    }
}
