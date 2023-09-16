using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectt
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
