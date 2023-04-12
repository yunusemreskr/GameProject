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
    interface ICheckService
    {
        void CheckIfRealPlayer(Player player)
        {
            if (Convert.ToBoolean(player.BirthDate) == true)
            {
                Console.WriteLine("Verified account.");
            }
            else
            {
                Console.WriteLine("Unverified acoount!");
            }
        }
    }
}
