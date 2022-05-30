using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Entities
{
    public class Campaing:IEntity
    {
        public int Id { get; set; }
        public string  CampaingName { get; set; }
        public int DiscountRate { get; set; }
    }
}
