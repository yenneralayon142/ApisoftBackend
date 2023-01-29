using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record VehicleDTO
    (
        string Plate,
        string Color,
        string Mileage,
        string ModelYear
    );    
}
