using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void DeleteCampaign(GameCampaign gameCampaign)
        {
            Console.WriteLine("Campaign deleted.");
        }

        public void NewCampaign(GameCampaign gameCampaign)
        {
            Console.WriteLine("New Campaign created.");
        }

        public void UpdateCampaign(GameCampaign gameCampaign)
        {
            Console.WriteLine("Campaign updated.");
        }
    }
}
