﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    public interface IServiceManager
    {
        ITypeDocumentService TypeDocumentService { get; }
        ICategoryVehicleService CategoryVehicleService { get; }
        IStatusVehicleService StatusVehicleService { get; }
        IBrandService BrandService { get; }

        IServiceService ServiceService { get; }

        Task Save();
    }
}
