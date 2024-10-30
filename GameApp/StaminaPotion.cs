using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class StaminaPotion:Potion
    {
        public StaminaPotion(int s) : base(s)
        {

        }
        public override void Consume(Avatar a)
        {
            a.Stamina += a.Stamina * Size / 100;
        }
    }
}
