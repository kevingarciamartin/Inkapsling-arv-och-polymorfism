using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling__arv_och_polymorfism.Arv
{
    public class Wolf : Animal
    {
        public Wolf(double weight, double speed, bool isWarmBlooded, bool layEggs) : 
            base(weight, speed, isWarmBlooded, layEggs)
        {
        }

        public string Characteristic { get; } = "Feral";

        public override void DoSound()
        {
            Console.WriteLine("Howl");
        }

        public override string Stats()
        {
            return base.Stats() + $", Characteristic: {Characteristic}";
        }
    }
}
