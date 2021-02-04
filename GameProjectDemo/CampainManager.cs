using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo
{
    class CampainManager : ICampainService
    {
        public void Add(Campain campain)
        {
            Console.WriteLine(campain.CampainName + " Kampanyası Eklendi");
        }

        public void Delete(Campain campain)
        {
            Console.WriteLine(campain.CampainName + " Kampanyası Silindi");
        }

        public void Update(Campain campain)
        {
            Console.WriteLine(campain.CampainName + " Kampanyası Güncellendi");
        }
    }
}
