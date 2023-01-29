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

        IServiceService ServiceService { get; }

        Task Save();
    }
}
