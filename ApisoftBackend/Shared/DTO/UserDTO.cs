using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record UserDTO
    (
        int DocumentNumU,
        string FirstName,
        string FirstSurname,
        string Direction,
        string Phone
    );
}
