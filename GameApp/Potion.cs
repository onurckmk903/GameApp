using GameApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    public class Potion:Item,IConsumable
    {
        public int Size { get; set; }
        public Potion(int s)
        {
            s=Size;
            
        }
        public virtual void Consume(Avatar a )
        {
            Console.WriteLine($"{Name} isimli iksir {a.Name}isimli karakter üstünde kullanıldı"  );
            
        }
    }
}
