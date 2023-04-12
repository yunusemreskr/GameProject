using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Concrete;
using GameProject.Entitiy;
using GameProject.NewFolder;

namespace GameProject.Concrete
{
    internal class PlayerManager : IPlayerManager, ICheckService
    {
        public void DeleteAccount(Player player)
        {
            Console.WriteLine("Player: " + player.PlayerFirstName + " Player Id: "+ player.Id + " deleted his account.");
        }

        public void SignUp(Player player)
        {
            Console.WriteLine("Player: " + player.PlayerFirstName + " signup.");
        }

        public void UpdateAccount(Player player)
        {
            Console.WriteLine("Player: " + player.PlayerFirstName + " updated his account successfluy.");
        }
        public void CheckIfRealPlayer(Player player)
        {
            Console.WriteLine("Player : " + player.PlayerFirstName + " " + player.PlayerLastName + " checked account.");
        }
    }
}
