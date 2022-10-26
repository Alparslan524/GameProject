using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderServices
    {
        IUserValidationService _userValidationService;//Herhangi bir doğrulama sistemi çeşidini almıyor
        //direkt interface aldığı için kullanıcı hangi doğrulama sistemini seçerse buraya o geliyor

        public OrderManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void GameBuy(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer) == true)
            {
                Console.WriteLine(gamer.Name + " isimli oyuncu doğrulandı.");
                Console.WriteLine(gamer.Name + " isimli oyuncu oyun aldı");
            }
            else
            {
                Console.WriteLine(gamer.Name + " isimli oyuncu doğrulanamadı. Satın alım başarısız");
            }
        }

        public void GameSell(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer) == true)
            {
                Console.WriteLine(gamer.Name + " isimli oyuncu doğrulandı.");
                Console.WriteLine(gamer.Name + " isimli oyuncu oyun sattı");
            }
            else
            {
                Console.WriteLine(gamer.Name + " isimli oyuncu doğrulanamadı. Satım işlemi başarısız");
            }
        }
    }
}
