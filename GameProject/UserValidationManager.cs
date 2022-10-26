using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            if (gamer.TcNo == 123456)//Mernis ile kontrol sağlandı gibi düşünebiliriz
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
