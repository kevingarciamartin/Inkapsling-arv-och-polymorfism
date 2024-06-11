using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling__arv_och_polymorfism.Arv
{
    public class Flamingo : Bird
    {
        public Flamingo(double weight, double speed, bool isWarmBlooded, bool layEggs) : 
            base(weight, speed, isWarmBlooded, layEggs)
        {
        }

        public string Family { get; } = "Phoenicopteridae";

        public override void DoSound()
        {
            Console.WriteLine("Nasal honking");
        }

        public override string Stats()
        {
            return base.Stats() + $", Family: {Family}";
        }
    }
}
