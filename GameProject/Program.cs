using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Name = "Alp";
            gamer.LastName = "Aydoğan";
            gamer.TcNo = 123456;
            gamer.DogumTarihi = "2002";

            UserValidationManager userValidationManager = new UserValidationManager();
            GamerManager gamerManager = new GamerManager(userValidationManager);//Sisteme Başka doğrulama sistemi ekleyip burda onu da yazabilirdik
            gamerManager.Add(gamer);


            Gamer gamer2 = new Gamer();
            gamer2.Name = "Alp";
            gamer2.LastName = "Aydoğan";
            gamer2.TcNo = 12345;
            gamer2.DogumTarihi = "2002";

            Validation2Manager validation2Manager = new Validation2Manager();
            OrderManager orderManager = new OrderManager(validation2Manager);//Yeni validasyon sistemi ekledik ve mevcut kodlarımız değişmedi
            orderManager.GameBuy(gamer2);


        }
    }
}
