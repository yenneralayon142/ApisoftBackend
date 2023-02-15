using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record BrandDTO
        (
            int BrandId,
            string Name,
            string Description
        );
}
