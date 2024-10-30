using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class HealthPotion:Potion
    {
        public HealthPotion(int s) : base(s)
        {

        }
        public override void Consume(Avatar a)
        {
            a.Health += a.Health * Size / 100;
        }
    }
}
