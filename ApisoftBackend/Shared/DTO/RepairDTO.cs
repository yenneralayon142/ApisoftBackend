using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record class RepairDTO
    (
        string Plate,
        decimal Subtotal,
        decimal Total,
        int DocumentNumU
    );
    
}
