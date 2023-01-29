using Contracts;
using Contracts.Repositories;
using Repository.Contexts;
using Repository.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using System.Runtime.CompilerServices;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private AppDbContext _context;
        private IClientRepository _clientRepository;
        private ITypeDocumentRepository _typeDocumentRepository;
        private IUserRepository _userRepository;
        private IBrandRepository _brandRepository;
        private IPriceServiceCategoryRepository _priceServiceCategoryRepository;
        private ICategoryVehicleRepository _categoryVehicleRepository;
        private IRepairRepository _repairRepository;
        private IServiceRepository _serviceRepository;
        private IStatusVehicleRepository _statusVehicleRepository;
        private IVehicleRepository _vehicleRepository;
        private IRepairServiceRepository _repairServiceRepository;


        public RepositoryWrapper(AppDbContext context) => _context = context;

        public IClientRepository Client
        {
            get
            {
                if (_clientRepository == null)
                {
                    _clientRepository = new ClientRepository(_context);
                }

                return _clientRepository;
            }
        }

        public ITypeDocumentRepository TypeDocument
        {
            get
            {
                if (_typeDocumentRepository == null)
                {
                    _typeDocumentRepository = new TypeDocumentRepository(_context);
                }

                return _typeDocumentRepository;
            }
        }

        public IUserRepository User
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_context);

                }

                return _userRepository;

            }
        }

        public IBrandRepository Brand
        {
            get
            {
                if (_brandRepository == null)
                {
                    _brandRepository = new BrandRepository(_context);
                }


                return _brandRepository;
            }
        }

        public IPriceServiceCategoryRepository PriceServiceCategory
        {
            get
            {
                if (_priceServiceCategoryRepository == null)
                {
                    _priceServiceCategoryRepository = new PriceServiceCategoryRepository(_context);


                }

                return _priceServiceCategoryRepository;

            }
        }

        public ICategoryVehicleRepository CategoryVehicle
        {
            get
            {
                if (_categoryVehicleRepository == null)
                {
                    _categoryVehicleRepository = new CategoryVehicleRepository(_context);
                }

                return _categoryVehicleRepository;
            }
        }

        public IRepairRepository Repair
        {
            get
            {
                if(_repairRepository == null)
                {
                    _repairRepository = new RepairRepository(_context);
                }

                return _repairRepository;
            }
        }

        public IServiceRepository Service
        {
            get
            {
                if(_serviceRepository == null)
                {
                    _serviceRepository = new ServiceRepository(_context);
                }

                return _serviceRepository;
            }
        }
        
        public IStatusVehicleRepository StatusVehicle
        {
            get
            {
                if (_statusVehicleRepository == null)
                {
                    _statusVehicleRepository = new StatusVehicleRepository(_context);
                }

                return _statusVehicleRepository;
            }
        }
        
        public IVehicleRepository Vehicle
        {
            get
            {
                if(_vehicleRepository == null)
                {
                    _vehicleRepository = new VehicleRepository(_context);
                }

                return _vehicleRepository;
            }
        }

        public IRepairServiceRepository RepairService
        {
            get
            {
                if(_repairServiceRepository == null)
                {
                    _repairServiceRepository = new RepairServiceRepository(_context);
                }

                return _repairServiceRepository;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
