using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling__arv_och_polymorfism
{
    abstract class Animal
    {
        public Animal(double weight, double speed, bool isWarmBlooded, bool layEggs)
        {
            Weight = weight;
            Speed = speed;
            IsWarmBlooded = isWarmBlooded;
            LayEggs = layEggs;
        }

        public double Weight { get; set; }
        public double Speed { get; set; }
        public bool IsWarmBlooded { get; set; }
        public bool LayEggs { get; set; }

        public abstract void DoSound();
    }
}
