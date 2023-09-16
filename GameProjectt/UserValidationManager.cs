using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectt
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.YearOfBirth == 1985 && gamer.Name == "Engin"  && gamer.Surname == "Demirog" && gamer.NationalId == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
