using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    internal class GameSellingManager : IGameSelling
    {
        public void GameSelling(Player player, Game game, GameCampaign gameCampaign)
        {
            Console.WriteLine("Player : " + player.PlayerFirstName + " Game : " + game.GameName + " use this campaign "
                + gameCampaign.GameCampaignName + " bought successfuly.");
        }
    }
}
