using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.NewFolder
{
    internal interface ICampaignService
    {
        void NewCampaign(GameCampaign gameCampaign);
        void UpdateCampaign(GameCampaign gameCampaign);
        void DeleteCampaign(GameCampaign gameCampaign);
    }
}
