using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Concrete
{
    public class GameSalesManager : IGameService
    {
        
        public void GameSales(Gamer gamer, Game game,Campaing campaing)
        {
            Console.WriteLine(game.GameName+" adlı oyun "+gamer.FirstName+ "adlı kullanıcıya "+campaing.CampaingName+
                " adlı kampanyadan yararlanarak %"+campaing.DiscountRate+" indirim oranı kullanılarak "+
                (game.GamePrice-(game.GamePrice*campaing.DiscountRate/100)) +" fiyatına satılmıştır."
                
                );
        }


    }
}
