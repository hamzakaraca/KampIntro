﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.FirstName == "HAMZA"
                && gamer.LastName == "KARACA" && gamer.IdentityNumber == 60406214340)
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
