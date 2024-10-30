using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class ManaPotion : Potion
    {
        public ManaPotion(int s) : base(s)
        {

        }
        
            
        
    public override void Consume(Avatar a)
    {
        a.Mana += a.Mana * Size / 100;
    }

}
}
