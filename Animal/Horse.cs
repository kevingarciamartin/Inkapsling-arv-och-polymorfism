using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling__arv_och_polymorfism.Arv
{
    public class Horse : Animal
    {
        public Horse(double weight, double speed, bool isWarmBlooded, bool layEggs) : 
            base(weight, speed, isWarmBlooded, layEggs)
        {
        }

        public string Characteristic { get; } = "FarmAnimal";

        public override void DoSound()
        {
            Console.WriteLine("Neigh");
        }

        public override string Stats()
        {
            return base.Stats() + $", Characteristic: {Characteristic}";
        }
    }
}
