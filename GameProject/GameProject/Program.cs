using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2000,
                FirstName = "HAMZA",
                LastName = "KARACA",
                IdentityNumber = 60406214340
            });

            SaleManager saleManager = new SaleManager(new PaymentValidation());
            saleManager.sell(new Game
            {
                GameName = "Pubg",
                GameId = 1,
                Price = 50,
                ReleaseDate = 2018

            });
            Game game = new Game();
            WinterCampaign winterCanpaign = new WinterCampaign();
            winterCanpaign.Add(game);
        }
    }
}
