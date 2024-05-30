using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2Polymorphism
{
    internal class WhiteSpaceInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use white space as your only input. This fired an error!";
        }
    }
}
