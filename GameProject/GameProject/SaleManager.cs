using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager
    {
        IPaymentValidationService _paymentValidationService;

        public SaleManager(IPaymentValidationService paymentValidationService)
        {
            _paymentValidationService = paymentValidationService;
        }
        public void sell(Game game)
        {
            if (_paymentValidationService.PayValidate(game) == true)
            {
                Console.WriteLine("Oyun satışı başarıyla yapıldı");
            }
            else
                Console.WriteLine("Oyun satışı başarısız");
        }


    }
}
