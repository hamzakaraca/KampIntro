using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PaymentValidation:IPaymentValidationService
    {
        public bool PayValidate(Game game)
        {
            if (game.GameName == "Pubg" && game.GameId == 1 && game.Price == 50 && game.ReleaseDate == 2018)
            {
                return true;
            }
            else
                return false;
        }
    }
}
