using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record StatusVehicleDTO
    (
       int StatusVehicleId,
       string Name,
       string Description
    );
}
