using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Concrete
{
    public class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName +" adlı kampanya eklenmiştir.");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName +" adlı kampanya kaldırılmıştır.");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName +" adlı kampanya güncellenmiştir.");
        }
    }
}
