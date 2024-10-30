using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avatar avatar = new Avatar();
            avatar.Name = "Geralt";
            List<Item> envanter = new List<Item>();
            {
                new ManaPotion(50);
                new ManaPotion(100);
                new ManaPotion(78);

                new Item { Name = "gereksiz item 1" };

                new StaminaPotion(81);
                new StaminaPotion(89);

                new HealthPotion(92);
                new HealthPotion(46);

                new Item { Name = "gereksiz item 2" };
            }
        }
    }
}
