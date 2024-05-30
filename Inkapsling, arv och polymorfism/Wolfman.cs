using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling__arv_och_polymorfism
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(double weight, double speed, bool isWarmBlooded, bool layEggs) :
            base(weight, speed, isWarmBlooded, layEggs)
            {
            }

        public void Talk()
        {
            Console.WriteLine("This is how a Wolfman talks.");
        }
    }
}
