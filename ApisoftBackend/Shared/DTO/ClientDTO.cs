using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record ClientDTO
    (
        int DocumentNum,
        string FirstName,
        string FirstSurname,
        string Direction,
        string Phone
    );
}
