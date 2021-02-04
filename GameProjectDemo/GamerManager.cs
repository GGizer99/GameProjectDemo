using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class GamerManager : IGameService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validation(gamer) == true)
            {
                Console.WriteLine("Oyuncu Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }


        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Kaydı Silindi");

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Kaydı Güncellendi");

        }

    }
}
