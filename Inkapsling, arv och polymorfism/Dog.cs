﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling__arv_och_polymorfism
{
    internal class Dog : Animal
    {
        public Dog(double weight, double speed, bool isWarmBlooded, bool layEggs) : 
            base(weight, speed, isWarmBlooded, layEggs)
        {
        }

        public string Characteristic { get; } = "Pet";

        public override void DoSound()
        {
            Console.WriteLine("Woff");
        }

        public override string Stats()
        {
            return $"Weight: {Weight}, " +
                $"Speed: {Speed}, " +
                $"IsWarmBlooded: {IsWarmBlooded}, " +
                $"LayEggs: {LayEggs}, " +
                $"Characteristic: {Characteristic}";
        }

        public string PetDog()
        {
            return "*Petting the dog*";
        }
    }
}
