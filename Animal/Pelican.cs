﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling__arv_och_polymorfism.Arv
{
    public class Pelican : Bird
    {
        public Pelican(double weight, double speed, bool isWarmBlooded, bool layEggs) : 
            base(weight, speed, isWarmBlooded, layEggs)
        {
        }

        public string Family { get; } = "Pelecanidae";

        public override void DoSound()
        {
            Console.WriteLine("Squawk");
        }

        public override string Stats()
        {
            return base.Stats() + $", Family: {Family}";
        }
    }
}
