using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.NewFolder;
using GameProject.Concrete;
using GameProject.Entitiy;


namespace GameProject.NewFolder
{
    interface IGameSelling
    {
        void GameSelling(Player player, Game game, GameCampaign gameCampaign);

    }
}
