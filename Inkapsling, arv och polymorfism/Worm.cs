using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling__arv_och_polymorfism
{
    internal class Worm : Animal
    {
        public Worm(double weight, double speed, bool isWarmBlooded, bool layEggs) : 
            base(weight, speed, isWarmBlooded, layEggs)
        {
        }

        public string Characteristic { get; } = "Wiggley";

        public override void DoSound()
        {
            Console.WriteLine("Rssprssp");
        }
    }
}
