using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Abstract
{
    public interface IGameService
    {
        void GameSales(Gamer gamer,Game game,Campaing campaing);
    }
}
