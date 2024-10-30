using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class Entity
    {
        public static long Id {  get; set; }
        public long ID { get; private set; }
        public Entity() 
        {
            ID = ++ID;
        }
    }
}
