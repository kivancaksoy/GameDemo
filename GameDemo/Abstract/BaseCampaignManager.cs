using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    public class BaseCampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " campaign has been added.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " campaign has been deleted.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " campaign has been updated.");
        }
    }
}
