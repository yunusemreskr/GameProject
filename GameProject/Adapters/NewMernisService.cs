using GameProject.Entitiy;
using GameProject.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    internal class NewMernisService : ICheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            return true;
        }
    }
}
