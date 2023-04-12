using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entitiy;

namespace GameProject.NewFolder
{
    internal interface IPlayerManager
    {
        void SignUp(Player player);
        void UpdateAccount(Player player);
        void DeleteAccount(Player player);

    }
}
