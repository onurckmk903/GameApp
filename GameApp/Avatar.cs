using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class Avatar:Entity
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Stamina { get; set; }
        public int MaxHealth { get; private set; }
        public int MaxMana { get; private set; }
        public int MaxStamina { get; private set; }
        public void BilgiYazdir()
        {
            Console.WriteLine($"{Name}isimli avatar:"      );
            Console.WriteLine($"Health:{Health},Mana:{ Mana},stamina:{Stamina}");
        }
    }
}
