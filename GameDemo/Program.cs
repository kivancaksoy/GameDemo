using GameDemo.Abstract;
using GameDemo.Adapters;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseGamerManager gamerManager = new GamerManager(new GamerCheckManager());
            //gamerManager.Save(new Gamer { DateOfBirth = new DateTime(1994, 5, 5), FirstName = "Kıvanç", LastName = "Aksoy", NationalityId = "11111111112", NickName = "kvnc35" });

            //BaseGameManager gameManager = new GameManager();
            //gameManager.Sell(new Game { Name = "God Of War", UnitPrice = 3.99}, new Gamer { NickName = "kvnc35" });

            //BaseGameManager gameManager = new GameManager();
            //gameManager.Sell(new Game {Name = "God Of War", UnitPrice = 15}, new Gamer { NickName = "kvnc35" }, new Campaign { Name = "New Year", Discount = 10, Description = "New year %10 discount"});

            
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Kıvanç";
            gamer1.LastName = "Aksoy";
            gamer1.NickName = "kvnc123";
            gamer1.NationalityId = "11111111119";
            gamer1.DateOfBirth = new DateTime(1992, 1, 1);

            Game game1 = new Game();
            game1.Name = "God of War";
            game1.UnitPrice = 9.99;

            Campaign campaign1 = new Campaign();
            campaign1.Name = "New year";
            campaign1.Description = "New year %15 discount cmpaign";
            campaign1.Discount = 15;

            GamerCheckManager gamerCheckManager = new GamerCheckManager();
            BaseGamerManager gamerManager = new GamerManager(gamerCheckManager);

            gamerManager.Save(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            BaseGameManager gameManager = new GameManager();
            gameManager.Sell(game1, gamer1);

            BaseCampaignManager campaignManager = new CampaignManager();

            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);

            gameManager.Sell(game1, gamer1, campaign1);


        }
    }
}
