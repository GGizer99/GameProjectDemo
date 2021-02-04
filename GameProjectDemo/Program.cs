using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());

            gamerManager.Add(new Gamer { FirstName = "Gizer", LastName = "Doğan", BirthYear = 1999, NationalityId = "1234567890" });

            CampainManager campainManager = new CampainManager();
            campainManager.Add(new Campain { CampainName = "Muhteşem Şubat İndirimi", CampainId = 4 });

            OrderManager orderManager = new OrderManager();

            orderManager.Order(new Gamer { FirstName = "Gizer", LastName = "Doğan" }, new Campain { CampainName = "Muhteşem Şubat İndirimi" },
                new Game { GameName = "GTA ", GamePrice = 300 });
        }
    }
}
