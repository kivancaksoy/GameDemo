using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted from DB : " + gamer.NickName);
        }

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Saved to DB : " + gamer.NickName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated in DB : " + gamer.NickName);
        }
    }
}
