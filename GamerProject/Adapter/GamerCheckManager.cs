using GamerProject.Entities;
using MernisServiceReferance;
using System;
using System.Collections.Generic;
using System.Text;
using static MernisServiceReferance.KPSPublicSoapClient;

namespace GamerProject.Adapter
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);

            var x = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.FirstName, gamer.LastName, gamer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;

            return x;
        }
    }
}
