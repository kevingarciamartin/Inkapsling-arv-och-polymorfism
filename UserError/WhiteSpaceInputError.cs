using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling__arv_och_polymorfism.Polymorfism
{
    public class WhiteSpaceInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use white space as your only input. This fired an error!";
        }
    }
}
