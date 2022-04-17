using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    public class GamerManager : BaseGamerManager
    {
        IPersonCheckService _personCheckService;

        public GamerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Gamer gamer)
        {
            if (_personCheckService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                //throw new Exception("Not a valid person.");
                Console.WriteLine("Not a valid person.");
            }
            
        }
    }
}
