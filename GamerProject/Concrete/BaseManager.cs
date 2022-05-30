using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Concrete
{
    public abstract class BaseManager<T> 
     where T : Gamer,new()
    {
        public void Add(T entity)
        {
           
        }
    }
}
