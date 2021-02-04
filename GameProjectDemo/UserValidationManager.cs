using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.BirthYear == 1999 && gamer.FirstName == "Gizer" && gamer.LastName == "Doğan" && gamer.NationalityId == "1234567890")
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
