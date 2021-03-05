using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class WinterCampaign:ICampaignService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " " + " oyununa kampanya başarıyla uygulandı ");
        }
        public void Delete(Game game)
        {

            Console.WriteLine(game.GameName + " " + " oyunundaki kampanya başarıyla silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " " + " oyunundaki kampanya başarıyla güncellendi ");
        }
    }
}
