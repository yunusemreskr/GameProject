using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.NewFolder;
using GameProject.Concrete;
using GameProject.Entitiy;

namespace GameProject.Entitiy
{
    internal class GameCampaign : IEntitiy
    {
        public string GameCampaignName { get; set; }
        public float GameCampaignPercent { get; set; }

    }
}
