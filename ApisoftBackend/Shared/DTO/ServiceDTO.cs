using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record ServiceDTO
    (
        int ServiceId,
        string Name,
        string Description
    );
}
