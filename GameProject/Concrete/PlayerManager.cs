using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using GameProject.Concrete;
using GameProject.Entitiy;
using GameProject.NewFolder;

namespace GameProject.Concrete
{
    internal class PlayerManager : IPlayerManager
    {
        private ICheckService _checkService;
        public PlayerManager(ICheckService checkService)
        {
            _checkService = checkService;
        }

        public void DeleteAccount(Player player)
        {
            Console.WriteLine("Player: " + player.PlayerFirstName + " Player Id: " + player.Id + " deleted his account.");
        }

        public void SignUp(Player player)
        {
            if (_checkService.CheckIfRealPlayer(player))
            {
                Console.WriteLine(player.PlayerFirstName + " " + player.PlayerLastName+ " account signup.");
            }
            else
            {
                Console.WriteLine("Not A Valid Person. SignUp is failed.");
            }
        }

        public void UpdateAccount(Player player)
        {
            Console.WriteLine("Player: " + player.PlayerFirstName + " updated his account successfluy.");
        }

    }
}
//Console.WriteLine("Player : " + player.PlayerFirstName + " " + player.PlayerLastName + " checked account.");