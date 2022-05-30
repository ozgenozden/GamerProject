using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Adapter
{
    public class OutSourceGamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealGamer(Gamer gamer)
        {
            return true;
        }
    }
}
