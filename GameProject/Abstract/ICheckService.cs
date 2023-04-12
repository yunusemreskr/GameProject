using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
