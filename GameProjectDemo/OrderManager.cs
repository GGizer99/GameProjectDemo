using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class OrderManager : IOrderService
    {
        public void Order(Gamer gamer, Campain campain, Game game)
        {
            Console.WriteLine("Sayin " + gamer.FirstName + " " + gamer.LastName + " " + game.GameName + " İsimli Oyunu" + " " + campain.CampainName +
                " Kampanyasından Yararlanarak" + " Siparişiniz Onaylanmıştır");
        }
    }
}
