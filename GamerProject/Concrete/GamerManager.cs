using GamerProject.Abstract;
using GamerProject.Adapter;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Concrete
{
    public class GamerManager :IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                Console.WriteLine(gamer.FirstName+" adlı oyuncu sisteme eklenmiştir.");
            }
            else
            {
                throw new Exception(gamer.FirstName+ " is not a valid gamer");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı oyuncu sistemden silinmiştir.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı oyuncu sistemdde güncellenmiştir.");
        }

       
    }
}
