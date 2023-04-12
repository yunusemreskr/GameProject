using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class PlayerManager : IPlayerManager, ICheckService
    {
        public void DeleteAccount(Player player)
        {
            Console.WriteLine("Player: " + player.Id+ player.PlayerFirstName + " deleted his account." );
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
            Console.WriteLine("Player : " + player.PlayerFirstName+ player.PlayerLastName + " checked account.");
        }
    }
}
