using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.FirstName == "MAX" && gamer.LastName == "VERSTAPPEN" && gamer.IdentityNumber == 12345) 
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
