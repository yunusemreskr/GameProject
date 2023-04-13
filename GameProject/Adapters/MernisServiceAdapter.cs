using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entitiy;
using GameProject.NewFolder;
using GameProject.NewFolder;
using GameProject.Concrete;
using GameProject.Entitiy;

namespace GameProject.Adapters
{
    internal class MernisServiceAdapter : ICheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(player.TcNo, player.PlayerFirstName, player.PlayerLastName, player.DateOfBirth.Year);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
