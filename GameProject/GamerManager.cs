using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
     class GamerManager : IGamerServices
    {
        IUserValidationService _userValidationService;//Herhangi bir doğrulama sistemi çeşidini almıyor
        //direkt interface aldığı için kullanıcı hangi doğrulama sistemini seçerse buraya o geliyor

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer) == true)
            {
                Console.WriteLine(gamer.Name+" isimli oyuncu doğrulandı.");
                Console.WriteLine(gamer.Name + " adlı oyuncu sistem eklendi");
            }
            else
            {
                Console.WriteLine(gamer.Name+" isimli oyuncu doğrulanamadı. Kayıt başarısız");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " adlı oyuncu sistemden silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " adlı oyuncu güncellendi");
        }
    }
}
