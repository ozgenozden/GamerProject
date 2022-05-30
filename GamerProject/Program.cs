using GamerProject.Adapter;
using GamerProject.Concrete;
using GamerProject.Entities;
using System;

namespace GamerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamer = new GamerManager(new GamerCheckManager());
           
            gamer.Add(new Gamer { DateOfBirth=new DateTime(1992, 06, 05), FirstName="özgen", LastName="özden", NationalityId="33940901212" });

            GameSalesManager gameSalesManager = new GameSalesManager();
            gameSalesManager.GameSales(new Gamer { DateOfBirth=new DateTime(1992, 06, 05), FirstName="özgür", LastName="özden", NationalityId="33940901212" },
                new Game { GameName="FIFA 2022", GamePrice=600 }, new Campaing { CampaingName="öğrenci İndirimi", DiscountRate=50 });



        }
    }
}
