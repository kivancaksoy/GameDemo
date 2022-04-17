using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public abstract class BaseGameManager : IGameService
    {

        public virtual void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.NickName + " bought the " + game.Name + " for $" + game.UnitPrice);
        }

        public void Sell(Game game, Gamer gamer, Campaign campaign)
        {
            game.UnitPrice = game.UnitPrice * (100 - campaign.Discount) / 100;
            Console.WriteLine(gamer.NickName + " bought the " + game.Name + " for $" + game.UnitPrice + " with " + campaign.Name + " campaign.");
        }
    }
}
