using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling__arv_och_polymorfism.Arv
{
    public class Bird : Animal
    {
        public Bird(double weight, double speed, bool isWarmBlooded, bool layEggs) : 
            base(weight, speed, isWarmBlooded, layEggs)
        {
        }

        public string Characteristic { get; } = "Wings";

        public override void DoSound()
        {
            Console.WriteLine("Chirp");
        }

        public override string Stats()
        {
            return $"Weight: {Weight}, " +
                $"Speed: {Speed}, " +
                $"IsWarmBlooded: {IsWarmBlooded}, " +
                $"LayEggs: {LayEggs}, " +
                $"Characteristic: {Characteristic}";
        }
    }
}
